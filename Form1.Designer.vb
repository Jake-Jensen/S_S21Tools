<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ServerStatusLabel = New System.Windows.Forms.Label()
        Me.GenericWorker = New System.ComponentModel.BackgroundWorker()
        Me.CycleTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.LicensesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DonateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripDropDownButton2 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.CheckServerStatusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckForUpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateAllBinariesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateSoftwareListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.ServerStatusLabel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 433)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(842, 25)
        Me.Panel1.TabIndex = 0
        '
        'ServerStatusLabel
        '
        Me.ServerStatusLabel.Dock = System.Windows.Forms.DockStyle.Left
        Me.ServerStatusLabel.Location = New System.Drawing.Point(0, 0)
        Me.ServerStatusLabel.Name = "ServerStatusLabel"
        Me.ServerStatusLabel.Size = New System.Drawing.Size(285, 21)
        Me.ServerStatusLabel.TabIndex = 0
        Me.ServerStatusLabel.Text = "Server status: "
        Me.ServerStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GenericWorker
        '
        Me.GenericWorker.WorkerReportsProgress = True
        Me.GenericWorker.WorkerSupportsCancellation = True
        '
        'CycleTimer
        '
        Me.CycleTimer.Enabled = True
        Me.CycleTimer.Interval = 2000
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton1, Me.ToolStripDropDownButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(842, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.BackColor = System.Drawing.Color.White
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LicensesToolStripMenuItem, Me.AboutToolStripMenuItem, Me.DonateToolStripMenuItem})
        Me.ToolStripDropDownButton1.ForeColor = System.Drawing.Color.Black
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(45, 22)
        Me.ToolStripDropDownButton1.Text = "Help"
        '
        'LicensesToolStripMenuItem
        '
        Me.LicensesToolStripMenuItem.Name = "LicensesToolStripMenuItem"
        Me.LicensesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.LicensesToolStripMenuItem.Text = "Licenses"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'DonateToolStripMenuItem
        '
        Me.DonateToolStripMenuItem.Name = "DonateToolStripMenuItem"
        Me.DonateToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DonateToolStripMenuItem.Text = "Donate"
        '
        'ToolStripDropDownButton2
        '
        Me.ToolStripDropDownButton2.BackColor = System.Drawing.Color.White
        Me.ToolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButton2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CheckServerStatusToolStripMenuItem, Me.CheckForUpdateToolStripMenuItem, Me.UpdateAllBinariesToolStripMenuItem, Me.UpdateSoftwareListToolStripMenuItem})
        Me.ToolStripDropDownButton2.ForeColor = System.Drawing.Color.Black
        Me.ToolStripDropDownButton2.Image = CType(resources.GetObject("ToolStripDropDownButton2.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton2.Name = "ToolStripDropDownButton2"
        Me.ToolStripDropDownButton2.Size = New System.Drawing.Size(52, 22)
        Me.ToolStripDropDownButton2.Text = "Server"
        Me.ToolStripDropDownButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'CheckServerStatusToolStripMenuItem
        '
        Me.CheckServerStatusToolStripMenuItem.Name = "CheckServerStatusToolStripMenuItem"
        Me.CheckServerStatusToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.CheckServerStatusToolStripMenuItem.Text = "Check server status"
        '
        'CheckForUpdateToolStripMenuItem
        '
        Me.CheckForUpdateToolStripMenuItem.Name = "CheckForUpdateToolStripMenuItem"
        Me.CheckForUpdateToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.CheckForUpdateToolStripMenuItem.Text = "Check for update"
        '
        'UpdateAllBinariesToolStripMenuItem
        '
        Me.UpdateAllBinariesToolStripMenuItem.Name = "UpdateAllBinariesToolStripMenuItem"
        Me.UpdateAllBinariesToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.UpdateAllBinariesToolStripMenuItem.Text = "Update all binaries"
        '
        'UpdateSoftwareListToolStripMenuItem
        '
        Me.UpdateSoftwareListToolStripMenuItem.Name = "UpdateSoftwareListToolStripMenuItem"
        Me.UpdateSoftwareListToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.UpdateSoftwareListToolStripMenuItem.Text = "Update software list"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(842, 458)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(858, 497)
        Me.MinimumSize = New System.Drawing.Size(858, 497)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sapphire's S21 Toolbox"
        Me.Panel1.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents ServerStatusLabel As Label
    Friend WithEvents GenericWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents CycleTimer As Timer
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents LicensesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DonateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripDropDownButton2 As ToolStripDropDownButton
    Friend WithEvents CheckServerStatusToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckForUpdateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateAllBinariesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateSoftwareListToolStripMenuItem As ToolStripMenuItem
End Class
