Imports System.Net

Public Class Form1

#Region "Global string vars"
    ' Takes a bit more memory, but I prefer to have string tables.

    Public Const ServerURL As String = "https://splitsecond.site"
    Public Const DonationURL As String = "https://paypal.me/SapphireExOne?locale.x=en_US"

    Public Const Error_FormLoadBad = "Error, something has prevented the program from starting correctly. Aborting."
    Public Const Error_MasterServerUnavailable = "Master server is unavailable after multiple attempts, disabling server usage."
    Public Const Info_ProgName = "Sapphire S21 Toolbox"
    Public Const Info_ServerOnline = "Server status: Online"
    Public Const Info_ServerOnlineMessage = "Server is online."
    Public Const Info_ServerOffline = "Server status: Offline"
    Public Const Info_ServerOfflineMessage = "Server is offline."
#End Region

    ' Global variables
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
                MsgBox(Error_MasterServerUnavailable)
                CanUseServer = False
            End If
            Try
                Dim req As WebRequest = WebRequest.Create(URL)
                req.Timeout = 300
                req.Headers.Add(HttpRequestHeader.UserAgent, Info_ProgName)
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
                MsgBox(Error_FormLoadBad, MsgBoxStyle.Critical)
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
        If (GetServerStatus(ServerURL)) Then
            ServerStatus = Info_ServerOnline
        Else
            ServerStatus = Info_ServerOffline
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

    Private Sub DonateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DonateToolStripMenuItem.Click
        Try
            Dim URL As String = "https://paypal.me/SapphireExOne?locale.x=en_US"
            Process.Start(URL)
        Catch ex As Exception
            MessageBox.Show(
                "Click the help button below to donate.",
                "Sapphire's S21 Toolbox Donation",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                0,
                DonationURL,
                "S21Toolbox")
        End Try

    End Sub

    Private Sub CheckServerStatusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckServerStatusToolStripMenuItem.Click
        If (GetServerStatus(ServerURL)) Then
            MsgBox(Info_ServerOnlineMessage)
        Else
            MsgBox(Info_ServerOfflineMessage)
        End If
    End Sub
End Class
