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
        Me.MenuController = New System.Windows.Forms.Panel()
        Me.TitleBar = New System.Windows.Forms.Label()
        Me.Officebtn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Chartbtn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Settingbtn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Closebtn = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Statuslbl = New System.Windows.Forms.Label()
        Me.Userlbl = New System.Windows.Forms.Label()
        Me.PCNamelbl = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timelbl = New System.Windows.Forms.Label()
        Me.Datelbl = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Main1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Dash1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.MenuController.SuspendLayout()
        CType(Me.Closebtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuController
        '
        Me.MenuController.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.MenuController.Controls.Add(Me.TitleBar)
        Me.MenuController.Controls.Add(Me.Officebtn)
        Me.MenuController.Controls.Add(Me.Chartbtn)
        Me.MenuController.Controls.Add(Me.Panel1)
        Me.MenuController.Controls.Add(Me.Settingbtn)
        Me.MenuController.Location = New System.Drawing.Point(0, 0)
        Me.MenuController.Name = "MenuController"
        Me.MenuController.Size = New System.Drawing.Size(1305, 70)
        Me.MenuController.TabIndex = 7
        '
        'TitleBar
        '
        Me.TitleBar.BackColor = System.Drawing.Color.Transparent
        Me.TitleBar.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleBar.ForeColor = System.Drawing.Color.White
        Me.TitleBar.Location = New System.Drawing.Point(12, 9)
        Me.TitleBar.Name = "TitleBar"
        Me.TitleBar.Size = New System.Drawing.Size(172, 49)
        Me.TitleBar.TabIndex = 91
        Me.TitleBar.Text = "Budget Setting"
        Me.TitleBar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Officebtn
        '
        Me.Officebtn.ActiveBorderThickness = 1
        Me.Officebtn.ActiveCornerRadius = 5
        Me.Officebtn.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.Officebtn.ActiveForecolor = System.Drawing.Color.Black
        Me.Officebtn.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.Officebtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Officebtn.BackgroundImage = CType(resources.GetObject("Officebtn.BackgroundImage"), System.Drawing.Image)
        Me.Officebtn.ButtonText = "Office"
        Me.Officebtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Officebtn.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Officebtn.ForeColor = System.Drawing.Color.Black
        Me.Officebtn.IdleBorderThickness = 1
        Me.Officebtn.IdleCornerRadius = 1
        Me.Officebtn.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Officebtn.IdleForecolor = System.Drawing.Color.White
        Me.Officebtn.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Officebtn.Location = New System.Drawing.Point(528, 6)
        Me.Officebtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Officebtn.Name = "Officebtn"
        Me.Officebtn.Size = New System.Drawing.Size(160, 50)
        Me.Officebtn.TabIndex = 7
        Me.Officebtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Chartbtn
        '
        Me.Chartbtn.ActiveBorderThickness = 1
        Me.Chartbtn.ActiveCornerRadius = 5
        Me.Chartbtn.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.Chartbtn.ActiveForecolor = System.Drawing.Color.Black
        Me.Chartbtn.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.Chartbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Chartbtn.BackgroundImage = CType(resources.GetObject("Chartbtn.BackgroundImage"), System.Drawing.Image)
        Me.Chartbtn.ButtonText = "Chart of Account"
        Me.Chartbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Chartbtn.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chartbtn.ForeColor = System.Drawing.Color.Black
        Me.Chartbtn.IdleBorderThickness = 1
        Me.Chartbtn.IdleCornerRadius = 1
        Me.Chartbtn.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Chartbtn.IdleForecolor = System.Drawing.Color.White
        Me.Chartbtn.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Chartbtn.Location = New System.Drawing.Point(191, 8)
        Me.Chartbtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Chartbtn.Name = "Chartbtn"
        Me.Chartbtn.Size = New System.Drawing.Size(160, 50)
        Me.Chartbtn.TabIndex = 8
        Me.Chartbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Settingbtn
        '
        Me.Settingbtn.ActiveBorderThickness = 1
        Me.Settingbtn.ActiveCornerRadius = 5
        Me.Settingbtn.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.Settingbtn.ActiveForecolor = System.Drawing.Color.Black
        Me.Settingbtn.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.Settingbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Settingbtn.BackgroundImage = CType(resources.GetObject("Settingbtn.BackgroundImage"), System.Drawing.Image)
        Me.Settingbtn.ButtonText = "Setting"
        Me.Settingbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Settingbtn.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Settingbtn.ForeColor = System.Drawing.Color.Black
        Me.Settingbtn.IdleBorderThickness = 1
        Me.Settingbtn.IdleCornerRadius = 1
        Me.Settingbtn.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Settingbtn.IdleForecolor = System.Drawing.Color.White
        Me.Settingbtn.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Settingbtn.Location = New System.Drawing.Point(359, 6)
        Me.Settingbtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Settingbtn.Name = "Settingbtn"
        Me.Settingbtn.Size = New System.Drawing.Size(160, 50)
        Me.Settingbtn.TabIndex = 3
        Me.Settingbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Closebtn
        '
        Me.Closebtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Closebtn.BackColor = System.Drawing.Color.Transparent
        Me.Closebtn.Image = CType(resources.GetObject("Closebtn.Image"), System.Drawing.Image)
        Me.Closebtn.ImageActive = Nothing
        Me.Closebtn.Location = New System.Drawing.Point(553, 13)
        Me.Closebtn.Name = "Closebtn"
        Me.Closebtn.Size = New System.Drawing.Size(30, 29)
        Me.Closebtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Closebtn.TabIndex = 126
        Me.Closebtn.TabStop = False
        Me.Closebtn.Zoom = 10
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Timelbl)
        Me.Panel1.Controls.Add(Me.Closebtn)
        Me.Panel1.Controls.Add(Me.Statuslbl)
        Me.Panel1.Controls.Add(Me.Datelbl)
        Me.Panel1.Controls.Add(Me.Userlbl)
        Me.Panel1.Controls.Add(Me.PCNamelbl)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(706, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(596, 58)
        Me.Panel1.TabIndex = 78
        '
        'Statuslbl
        '
        Me.Statuslbl.AutoSize = True
        Me.Statuslbl.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Statuslbl.ForeColor = System.Drawing.Color.White
        Me.Statuslbl.Location = New System.Drawing.Point(251, 28)
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
        Me.Userlbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Userlbl.Location = New System.Drawing.Point(145, 28)
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
        Me.PCNamelbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.PCNamelbl.Location = New System.Drawing.Point(20, 28)
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
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(252, 10)
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
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(146, 13)
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
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(21, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "PC Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Timelbl
        '
        Me.Timelbl.AutoSize = True
        Me.Timelbl.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Timelbl.ForeColor = System.Drawing.Color.White
        Me.Timelbl.Location = New System.Drawing.Point(351, 22)
        Me.Timelbl.Name = "Timelbl"
        Me.Timelbl.Size = New System.Drawing.Size(92, 33)
        Me.Timelbl.TabIndex = 94
        Me.Timelbl.Text = "Label5"
        '
        'Datelbl
        '
        Me.Datelbl.AutoSize = True
        Me.Datelbl.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Datelbl.ForeColor = System.Drawing.Color.White
        Me.Datelbl.Location = New System.Drawing.Point(355, 5)
        Me.Datelbl.Name = "Datelbl"
        Me.Datelbl.Size = New System.Drawing.Size(49, 18)
        Me.Datelbl.TabIndex = 92
        Me.Datelbl.Text = "Label5"
        '
        'Timer1
        '
        '
        'MainPanel
        '
        Me.MainPanel.BackColor = System.Drawing.Color.White
        Me.MainPanel.Location = New System.Drawing.Point(30, 76)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(1275, 660)
        Me.MainPanel.TabIndex = 79
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 20
        Me.BunifuElipse1.TargetControl = Me
        '
        'Main1
        '
        Me.Main1.ElipseRadius = 20
        Me.Main1.TargetControl = Me.MainPanel
        '
        'Dash1
        '
        Me.Dash1.ElipseRadius = 20
        Me.Dash1.TargetControl = Me.Panel1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1323, 764)
        Me.Controls.Add(Me.MainPanel)
        Me.Controls.Add(Me.MenuController)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Maintenance"
        Me.MenuController.ResumeLayout(False)
        CType(Me.Closebtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MenuController As Panel
    Friend WithEvents Officebtn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Settingbtn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Chartbtn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Statuslbl As Label
    Friend WithEvents Userlbl As Label
    Friend WithEvents PCNamelbl As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Datelbl As Label
    Friend WithEvents Timelbl As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Closebtn As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents TitleBar As Label
    Friend WithEvents MainPanel As Panel
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Main1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Dash1 As Bunifu.Framework.UI.BunifuElipse
End Class
