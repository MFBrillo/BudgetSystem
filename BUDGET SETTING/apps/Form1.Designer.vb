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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MenuController = New System.Windows.Forms.Panel()
        Me.Timelbl = New System.Windows.Forms.Label()
        Me.Closebtn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Verifybtn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Officebtn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Settingbtn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Chartbtn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Datelbl = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Statuslbl = New System.Windows.Forms.Label()
        Me.Userlbl = New System.Windows.Forms.Label()
        Me.PCNamelbl = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MainPanel = New System.Windows.Forms.DataGridView()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuController.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.MainPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuController
        '
        Me.MenuController.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MenuController.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.MenuController.Controls.Add(Me.Closebtn)
        Me.MenuController.Controls.Add(Me.Panel2)
        Me.MenuController.Controls.Add(Me.Panel1)
        Me.MenuController.Location = New System.Drawing.Point(0, -1)
        Me.MenuController.Name = "MenuController"
        Me.MenuController.Size = New System.Drawing.Size(207, 850)
        Me.MenuController.TabIndex = 7
        '
        'Timelbl
        '
        Me.Timelbl.AutoSize = True
        Me.Timelbl.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Timelbl.ForeColor = System.Drawing.Color.White
        Me.Timelbl.Location = New System.Drawing.Point(18, 277)
        Me.Timelbl.Name = "Timelbl"
        Me.Timelbl.Size = New System.Drawing.Size(92, 33)
        Me.Timelbl.TabIndex = 94
        Me.Timelbl.Text = "Label5"
        '
        'Closebtn
        '
        Me.Closebtn.ActiveBorderThickness = 1
        Me.Closebtn.ActiveCornerRadius = 5
        Me.Closebtn.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.Closebtn.ActiveForecolor = System.Drawing.Color.Black
        Me.Closebtn.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.Closebtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Closebtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Closebtn.BackgroundImage = CType(resources.GetObject("Closebtn.BackgroundImage"), System.Drawing.Image)
        Me.Closebtn.ButtonText = "Close"
        Me.Closebtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Closebtn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Closebtn.ForeColor = System.Drawing.Color.SeaGreen
        Me.Closebtn.IdleBorderThickness = 1
        Me.Closebtn.IdleCornerRadius = 1
        Me.Closebtn.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Closebtn.IdleForecolor = System.Drawing.Color.White
        Me.Closebtn.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Closebtn.Location = New System.Drawing.Point(0, 803)
        Me.Closebtn.Margin = New System.Windows.Forms.Padding(5)
        Me.Closebtn.Name = "Closebtn"
        Me.Closebtn.Size = New System.Drawing.Size(207, 47)
        Me.Closebtn.TabIndex = 125
        Me.Closebtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Verifybtn)
        Me.Panel2.Controls.Add(Me.Officebtn)
        Me.Panel2.Controls.Add(Me.Settingbtn)
        Me.Panel2.Controls.Add(Me.Chartbtn)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 342)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(207, 204)
        Me.Panel2.TabIndex = 79
        '
        'Verifybtn
        '
        Me.Verifybtn.ActiveBorderThickness = 1
        Me.Verifybtn.ActiveCornerRadius = 5
        Me.Verifybtn.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.Verifybtn.ActiveForecolor = System.Drawing.Color.Black
        Me.Verifybtn.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.Verifybtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Verifybtn.BackgroundImage = CType(resources.GetObject("Verifybtn.BackgroundImage"), System.Drawing.Image)
        Me.Verifybtn.ButtonText = "Verify"
        Me.Verifybtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Verifybtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.Verifybtn.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Verifybtn.ForeColor = System.Drawing.Color.Black
        Me.Verifybtn.IdleBorderThickness = 1
        Me.Verifybtn.IdleCornerRadius = 1
        Me.Verifybtn.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.Verifybtn.IdleForecolor = System.Drawing.Color.White
        Me.Verifybtn.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.Verifybtn.Location = New System.Drawing.Point(0, 150)
        Me.Verifybtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Verifybtn.Name = "Verifybtn"
        Me.Verifybtn.Size = New System.Drawing.Size(207, 50)
        Me.Verifybtn.TabIndex = 9
        Me.Verifybtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Officebtn
        '
        Me.Officebtn.ActiveBorderThickness = 1
        Me.Officebtn.ActiveCornerRadius = 5
        Me.Officebtn.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.Officebtn.ActiveForecolor = System.Drawing.Color.Black
        Me.Officebtn.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.Officebtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Officebtn.BackgroundImage = CType(resources.GetObject("Officebtn.BackgroundImage"), System.Drawing.Image)
        Me.Officebtn.ButtonText = "Office"
        Me.Officebtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Officebtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.Officebtn.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Officebtn.ForeColor = System.Drawing.Color.Black
        Me.Officebtn.IdleBorderThickness = 1
        Me.Officebtn.IdleCornerRadius = 1
        Me.Officebtn.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.Officebtn.IdleForecolor = System.Drawing.Color.White
        Me.Officebtn.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.Officebtn.Location = New System.Drawing.Point(0, 100)
        Me.Officebtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Officebtn.Name = "Officebtn"
        Me.Officebtn.Size = New System.Drawing.Size(207, 50)
        Me.Officebtn.TabIndex = 7
        Me.Officebtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Settingbtn
        '
        Me.Settingbtn.ActiveBorderThickness = 1
        Me.Settingbtn.ActiveCornerRadius = 5
        Me.Settingbtn.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.Settingbtn.ActiveForecolor = System.Drawing.Color.Black
        Me.Settingbtn.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.Settingbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Settingbtn.BackgroundImage = CType(resources.GetObject("Settingbtn.BackgroundImage"), System.Drawing.Image)
        Me.Settingbtn.ButtonText = "Setting"
        Me.Settingbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Settingbtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.Settingbtn.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Settingbtn.ForeColor = System.Drawing.Color.Black
        Me.Settingbtn.IdleBorderThickness = 1
        Me.Settingbtn.IdleCornerRadius = 1
        Me.Settingbtn.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.Settingbtn.IdleForecolor = System.Drawing.Color.White
        Me.Settingbtn.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.Settingbtn.Location = New System.Drawing.Point(0, 50)
        Me.Settingbtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Settingbtn.Name = "Settingbtn"
        Me.Settingbtn.Size = New System.Drawing.Size(207, 50)
        Me.Settingbtn.TabIndex = 3
        Me.Settingbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Chartbtn
        '
        Me.Chartbtn.ActiveBorderThickness = 1
        Me.Chartbtn.ActiveCornerRadius = 5
        Me.Chartbtn.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.Chartbtn.ActiveForecolor = System.Drawing.Color.Black
        Me.Chartbtn.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.Chartbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Chartbtn.BackgroundImage = CType(resources.GetObject("Chartbtn.BackgroundImage"), System.Drawing.Image)
        Me.Chartbtn.ButtonText = "Chart of Account"
        Me.Chartbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Chartbtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.Chartbtn.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chartbtn.ForeColor = System.Drawing.Color.Black
        Me.Chartbtn.IdleBorderThickness = 1
        Me.Chartbtn.IdleCornerRadius = 1
        Me.Chartbtn.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.Chartbtn.IdleForecolor = System.Drawing.Color.White
        Me.Chartbtn.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.Chartbtn.Location = New System.Drawing.Point(0, 0)
        Me.Chartbtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Chartbtn.Name = "Chartbtn"
        Me.Chartbtn.Size = New System.Drawing.Size(207, 50)
        Me.Chartbtn.TabIndex = 8
        Me.Chartbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Timelbl)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Datelbl)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Statuslbl)
        Me.Panel1.Controls.Add(Me.Userlbl)
        Me.Panel1.Controls.Add(Me.PCNamelbl)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(207, 342)
        Me.Panel1.TabIndex = 78
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(21, 211)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 13)
        Me.Label5.TabIndex = 93
        Me.Label5.Text = "Date"
        '
        'Datelbl
        '
        Me.Datelbl.AutoSize = True
        Me.Datelbl.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Datelbl.ForeColor = System.Drawing.Color.White
        Me.Datelbl.Location = New System.Drawing.Point(21, 226)
        Me.Datelbl.Name = "Datelbl"
        Me.Datelbl.Size = New System.Drawing.Size(55, 19)
        Me.Datelbl.TabIndex = 92
        Me.Datelbl.Text = "Label5"
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(28, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 19)
        Me.Label1.TabIndex = 91
        Me.Label1.Text = "DASHBOARD"
        '
        'Statuslbl
        '
        Me.Statuslbl.AutoSize = True
        Me.Statuslbl.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Statuslbl.ForeColor = System.Drawing.Color.White
        Me.Statuslbl.Location = New System.Drawing.Point(20, 180)
        Me.Statuslbl.Name = "Statuslbl"
        Me.Statuslbl.Size = New System.Drawing.Size(56, 19)
        Me.Statuslbl.TabIndex = 5
        Me.Statuslbl.Text = "Offline"
        Me.Statuslbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Userlbl
        '
        Me.Userlbl.AutoSize = True
        Me.Userlbl.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Userlbl.ForeColor = System.Drawing.Color.White
        Me.Userlbl.Location = New System.Drawing.Point(20, 129)
        Me.Userlbl.Name = "Userlbl"
        Me.Userlbl.Size = New System.Drawing.Size(55, 19)
        Me.Userlbl.TabIndex = 4
        Me.Userlbl.Text = "Label6"
        Me.Userlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PCNamelbl
        '
        Me.PCNamelbl.AutoSize = True
        Me.PCNamelbl.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PCNamelbl.ForeColor = System.Drawing.Color.White
        Me.PCNamelbl.Location = New System.Drawing.Point(20, 75)
        Me.PCNamelbl.Name = "PCNamelbl"
        Me.PCNamelbl.Size = New System.Drawing.Size(55, 19)
        Me.PCNamelbl.TabIndex = 3
        Me.PCNamelbl.Text = "Label5"
        Me.PCNamelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(21, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Status"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(21, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "User"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(21, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "PC Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MainPanel
        '
        Me.MainPanel.AllowUserToAddRows = False
        Me.MainPanel.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray
        Me.MainPanel.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.MainPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MainPanel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.MainPanel.BackgroundColor = System.Drawing.Color.White
        Me.MainPanel.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.MainPanel.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.MainPanel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MainPanel.Location = New System.Drawing.Point(213, -1)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.ReadOnly = True
        Me.MainPanel.RowTemplate.Height = 35
        Me.MainPanel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MainPanel.Size = New System.Drawing.Size(1129, 850)
        Me.MainPanel.TabIndex = 90
        '
        'Timer1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1341, 849)
        Me.Controls.Add(Me.MainPanel)
        Me.Controls.Add(Me.MenuController)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Maintenance"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuController.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.MainPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MenuController As Panel
    Friend WithEvents MainPanel As DataGridView
    Friend WithEvents Officebtn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Settingbtn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Chartbtn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Verifybtn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Statuslbl As Label
    Friend WithEvents Userlbl As Label
    Friend WithEvents PCNamelbl As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Closebtn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Datelbl As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Timelbl As Label
    Friend WithEvents Timer1 As Timer
End Class
