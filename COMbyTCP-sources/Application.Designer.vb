<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RXDataTB = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TXDataTB = New System.Windows.Forms.TextBox()
        Me.Server = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Client = New System.Windows.Forms.Button()
        Me.ServerPort = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ServerIPAddr = New System.Windows.Forms.TextBox()
        Me.Consolle = New System.Windows.Forms.TextBox()
        Me.PortNameCB = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ParityCB = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.StopBitsCB = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.HandshakeCB = New System.Windows.Forms.ComboBox()
        Me.BaudRateTB = New System.Windows.Forms.TextBox()
        Me.DataBitsTB = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GetCOMPB = New System.Windows.Forms.Button()
        Me.MainMenu = New System.Windows.Forms.MenuStrip()
        Me.InfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainMenu_Info = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsolePB = New System.Windows.Forms.Button()
        Me.minToTray = New System.Windows.Forms.Button()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MainMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RXDataTB)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.TXDataTB)
        Me.GroupBox1.Controls.Add(Me.Server)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Client)
        Me.GroupBox1.Controls.Add(Me.ServerPort)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ServerIPAddr)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(248, 230)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Start as"
        '
        'RXDataTB
        '
        Me.RXDataTB.BackColor = System.Drawing.SystemColors.Menu
        Me.RXDataTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RXDataTB.Cursor = System.Windows.Forms.Cursors.Default
        Me.RXDataTB.ForeColor = System.Drawing.SystemColors.InfoText
        Me.RXDataTB.Location = New System.Drawing.Point(171, 194)
        Me.RXDataTB.Name = "RXDataTB"
        Me.RXDataTB.ReadOnly = True
        Me.RXDataTB.Size = New System.Drawing.Size(56, 20)
        Me.RXDataTB.TabIndex = 19
        Me.RXDataTB.TabStop = False
        Me.RXDataTB.Text = "0"
        Me.RXDataTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(92, 196)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(73, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Recived Data"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(92, 170)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Sent Data"
        '
        'TXDataTB
        '
        Me.TXDataTB.BackColor = System.Drawing.SystemColors.Menu
        Me.TXDataTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXDataTB.Cursor = System.Windows.Forms.Cursors.Default
        Me.TXDataTB.ForeColor = System.Drawing.SystemColors.InfoText
        Me.TXDataTB.Location = New System.Drawing.Point(171, 168)
        Me.TXDataTB.Name = "TXDataTB"
        Me.TXDataTB.ReadOnly = True
        Me.TXDataTB.Size = New System.Drawing.Size(56, 20)
        Me.TXDataTB.TabIndex = 15
        Me.TXDataTB.TabStop = False
        Me.TXDataTB.Text = "0"
        Me.TXDataTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Server
        '
        Me.Server.Location = New System.Drawing.Point(15, 19)
        Me.Server.Name = "Server"
        Me.Server.Size = New System.Drawing.Size(115, 29)
        Me.Server.TabIndex = 1
        Me.Server.Text = "Server"
        Me.Server.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(169, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Porta"
        '
        'Client
        '
        Me.Client.Location = New System.Drawing.Point(15, 49)
        Me.Client.Name = "Client"
        Me.Client.Size = New System.Drawing.Size(115, 29)
        Me.Client.TabIndex = 0
        Me.Client.Text = "Client"
        Me.Client.UseVisualStyleBackColor = True
        '
        'ServerPort
        '
        Me.ServerPort.Location = New System.Drawing.Point(172, 103)
        Me.ServerPort.Name = "ServerPort"
        Me.ServerPort.Size = New System.Drawing.Size(58, 20)
        Me.ServerPort.TabIndex = 13
        Me.ServerPort.Text = "8000"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Indirizzo server "
        '
        'ServerIPAddr
        '
        Me.ServerIPAddr.Location = New System.Drawing.Point(15, 103)
        Me.ServerIPAddr.Name = "ServerIPAddr"
        Me.ServerIPAddr.Size = New System.Drawing.Size(151, 20)
        Me.ServerIPAddr.TabIndex = 11
        Me.ServerIPAddr.Text = "127.0.0.1"
        '
        'Consolle
        '
        Me.Consolle.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.Consolle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Consolle.Cursor = System.Windows.Forms.Cursors.Default
        Me.Consolle.ForeColor = System.Drawing.Color.White
        Me.Consolle.Location = New System.Drawing.Point(12, 309)
        Me.Consolle.Multiline = True
        Me.Consolle.Name = "Consolle"
        Me.Consolle.ReadOnly = True
        Me.Consolle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Consolle.Size = New System.Drawing.Size(473, 399)
        Me.Consolle.TabIndex = 10
        '
        'PortNameCB
        '
        Me.PortNameCB.FormattingEnabled = True
        Me.PortNameCB.Location = New System.Drawing.Point(82, 19)
        Me.PortNameCB.Name = "PortNameCB"
        Me.PortNameCB.Size = New System.Drawing.Size(121, 21)
        Me.PortNameCB.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Port"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Baud Rate"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Parity"
        '
        'ParityCB
        '
        Me.ParityCB.FormattingEnabled = True
        Me.ParityCB.Location = New System.Drawing.Point(82, 73)
        Me.ParityCB.Name = "ParityCB"
        Me.ParityCB.Size = New System.Drawing.Size(121, 21)
        Me.ParityCB.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 127)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Stop Bits"
        '
        'StopBitsCB
        '
        Me.StopBitsCB.FormattingEnabled = True
        Me.StopBitsCB.Location = New System.Drawing.Point(82, 127)
        Me.StopBitsCB.Name = "StopBitsCB"
        Me.StopBitsCB.Size = New System.Drawing.Size(121, 21)
        Me.StopBitsCB.TabIndex = 24
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 103)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 13)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Data Bits"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(14, 157)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 13)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Handshake"
        '
        'HandshakeCB
        '
        Me.HandshakeCB.FormattingEnabled = True
        Me.HandshakeCB.Location = New System.Drawing.Point(82, 154)
        Me.HandshakeCB.Name = "HandshakeCB"
        Me.HandshakeCB.Size = New System.Drawing.Size(121, 21)
        Me.HandshakeCB.TabIndex = 26
        '
        'BaudRateTB
        '
        Me.BaudRateTB.Location = New System.Drawing.Point(82, 47)
        Me.BaudRateTB.Name = "BaudRateTB"
        Me.BaudRateTB.Size = New System.Drawing.Size(121, 20)
        Me.BaudRateTB.TabIndex = 28
        '
        'DataBitsTB
        '
        Me.DataBitsTB.Location = New System.Drawing.Point(82, 101)
        Me.DataBitsTB.Name = "DataBitsTB"
        Me.DataBitsTB.Size = New System.Drawing.Size(121, 20)
        Me.DataBitsTB.TabIndex = 29
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GetCOMPB)
        Me.GroupBox2.Controls.Add(Me.PortNameCB)
        Me.GroupBox2.Controls.Add(Me.DataBitsTB)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.BaudRateTB)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.ParityCB)
        Me.GroupBox2.Controls.Add(Me.HandshakeCB)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.StopBitsCB)
        Me.GroupBox2.Location = New System.Drawing.Point(264, 41)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(220, 230)
        Me.GroupBox2.TabIndex = 30
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "COM Properties"
        '
        'GetCOMPB
        '
        Me.GetCOMPB.Location = New System.Drawing.Point(17, 181)
        Me.GetCOMPB.Name = "GetCOMPB"
        Me.GetCOMPB.Size = New System.Drawing.Size(186, 29)
        Me.GetCOMPB.TabIndex = 2
        Me.GetCOMPB.Text = "Get COM"
        Me.GetCOMPB.UseVisualStyleBackColor = True
        '
        'MainMenu
        '
        Me.MainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InfoToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MainMenu.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu.Name = "MainMenu"
        Me.MainMenu.Size = New System.Drawing.Size(494, 24)
        Me.MainMenu.TabIndex = 32
        Me.MainMenu.Text = "MainMenu"
        '
        'InfoToolStripMenuItem
        '
        Me.InfoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.ExitToolStripMenuItem1})
        Me.InfoToolStripMenuItem.Name = "InfoToolStripMenuItem"
        Me.InfoToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.InfoToolStripMenuItem.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.ExitToolStripMenuItem.Text = "TCP &Settings..."
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(150, 22)
        Me.ExitToolStripMenuItem1.Text = "&Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MainMenu_Info})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'MainMenu_Info
        '
        Me.MainMenu_Info.Name = "MainMenu_Info"
        Me.MainMenu_Info.Size = New System.Drawing.Size(104, 22)
        Me.MainMenu_Info.Text = "&Info..."
        '
        'ConsolePB
        '
        Me.ConsolePB.Location = New System.Drawing.Point(12, 277)
        Me.ConsolePB.Name = "ConsolePB"
        Me.ConsolePB.Size = New System.Drawing.Size(132, 26)
        Me.ConsolePB.TabIndex = 33
        Me.ConsolePB.Text = "Console <<"
        Me.ConsolePB.UseVisualStyleBackColor = True
        '
        'minToTray
        '
        Me.minToTray.Location = New System.Drawing.Point(387, 277)
        Me.minToTray.Name = "minToTray"
        Me.minToTray.Size = New System.Drawing.Size(97, 26)
        Me.minToTray.TabIndex = 34
        Me.minToTray.Text = "Minimize to Tray"
        Me.minToTray.UseVisualStyleBackColor = True
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "COM by TCP"
        '
        'Form
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(494, 720)
        Me.Controls.Add(Me.minToTray)
        Me.Controls.Add(Me.ConsolePB)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Consolle)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MainMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.MainMenuStrip = Me.MainMenu
        Me.MaximizeBox = False
        Me.Name = "Form"
        Me.Text = "COM By TCP"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MainMenu.ResumeLayout(False)
        Me.MainMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Server As System.Windows.Forms.Button
    Friend WithEvents Client As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ServerPort As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ServerIPAddr As System.Windows.Forms.TextBox
    Friend WithEvents Consolle As System.Windows.Forms.TextBox
    Friend WithEvents PortNameCB As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ParityCB As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents StopBitsCB As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents HandshakeCB As System.Windows.Forms.ComboBox
    Friend WithEvents BaudRateTB As System.Windows.Forms.TextBox
    Friend WithEvents DataBitsTB As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GetCOMPB As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TXDataTB As System.Windows.Forms.TextBox
    Friend WithEvents RXDataTB As System.Windows.Forms.TextBox
    Friend WithEvents MainMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents InfoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsolePB As System.Windows.Forms.Button
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MainMenu_Info As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents minToTray As Button
    Friend WithEvents NotifyIcon1 As NotifyIcon
End Class
