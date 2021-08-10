Imports System.Net

Public Class Form1

    Public ServerStatus As String = "Server status: Indeterminate"
    Public Shared ServerRetryCount As Integer = 0
    Public Shared CanUseServer As Boolean = True

    ' Basically just a macro for the writeline function
    Private Sub DebugPrint(ByVal Message)
        Try
            System.Diagnostics.Debug.WriteLine("[Debug]: " & Message)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("[Debug]: Failed to write line to console. Exception: " & ex.Message)
        End Try
    End Sub

    Private Shared Function GetServerStatus(ByVal URL As String) As Boolean
        If (CanUseServer) Then
            If (ServerRetryCount > +10) Then
                MsgBox("Master server is unavailable after multiple attempts, disabling server usage.")
                CanUseServer = False
            End If
            Try
                Dim req As WebRequest = WebRequest.Create(URL)
                req.Timeout = 100
                req.Headers.Add(HttpRequestHeader.UserAgent, "Sapphire S21 Toolbox")
                Dim res As WebResponse = req.GetResponse()
            Catch ex As Exception
                System.Diagnostics.Debug.WriteLine(ex.Message)
                ServerRetryCount += 1
                Return False
            End Try
            ServerRetryCount = 0
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Check server connection to get the latest tool versions

        Me.Show()

        Dim WaitingForVisibleCount = 0
        Dim MaximumWaitTime = 100

        While (Me.Visible = False)
            Threading.Thread.Sleep(1)
            If (WaitingForVisibleCount >= MaximumWaitTime) Then
                MsgBox("Error, something has prevented the program from starting correctly. Aborting.", MsgBoxStyle.Critical)
                Application.Exit()
            End If
            WaitingForVisibleCount += 1
        End While
        If (WaitingForVisibleCount > 0) Then
            DebugPrint("Count for form to be visible: " & WaitingForVisibleCount)
        Else
            DebugPrint("Loaded form without issue.")
        End If


    End Sub

    Private Sub GenericWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles GenericWorker.DoWork
        If (GetServerStatus("https://splitsecond.site")) Then
            ServerStatus = "Server status: Online"
        Else
            ServerStatus = "Server status: Offline"
        End If
    End Sub

    Private Sub CycleTimer_Tick(sender As Object, e As EventArgs) Handles CycleTimer.Tick
        ' Update UI stuff from the background worker
        GenericWorker.RunWorkerAsync()
        ServerStatusLabel.Text = ServerStatus
    End Sub

    Private Sub LicensesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LicensesToolStripMenuItem.Click
        LicenseForm.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutForm.Show()
    End Sub
End Class
