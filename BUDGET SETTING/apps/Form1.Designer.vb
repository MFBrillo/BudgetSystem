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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuController = New System.Windows.Forms.Panel()
        Me.TitleBar = New System.Windows.Forms.Label()
        Me.Closebtn = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Officebtn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Chartbtn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Settingbtn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.isLoginPanel = New System.Windows.Forms.Panel()
        Me.MenuController.SuspendLayout()
        CType(Me.Closebtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.isLoginPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuController
        '
        Me.MenuController.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MenuController.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.MenuController.Controls.Add(Me.TitleBar)
        Me.MenuController.Controls.Add(Me.Closebtn)
        Me.MenuController.Location = New System.Drawing.Point(0, 0)
        Me.MenuController.Name = "MenuController"
        Me.MenuController.Size = New System.Drawing.Size(1324, 57)
        Me.MenuController.TabIndex = 7
        '
        'TitleBar
        '
        Me.TitleBar.BackColor = System.Drawing.Color.Transparent
        Me.TitleBar.Font = New System.Drawing.Font("Tahoma", 20.0!)
        Me.TitleBar.ForeColor = System.Drawing.Color.White
        Me.TitleBar.Location = New System.Drawing.Point(5, 1)
        Me.TitleBar.Name = "TitleBar"
        Me.TitleBar.Size = New System.Drawing.Size(224, 49)
        Me.TitleBar.TabIndex = 91
        Me.TitleBar.Text = "Budget Setting"
        Me.TitleBar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Closebtn
        '
        Me.Closebtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Closebtn.BackColor = System.Drawing.Color.Transparent
        Me.Closebtn.Image = CType(resources.GetObject("Closebtn.Image"), System.Drawing.Image)
        Me.Closebtn.ImageActive = Nothing
        Me.Closebtn.Location = New System.Drawing.Point(1281, 12)
        Me.Closebtn.Name = "Closebtn"
        Me.Closebtn.Size = New System.Drawing.Size(30, 29)
        Me.Closebtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Closebtn.TabIndex = 126
        Me.Closebtn.TabStop = False
        Me.Closebtn.Zoom = 10
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
        Me.Officebtn.Location = New System.Drawing.Point(384, 3)
        Me.Officebtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Officebtn.Name = "Officebtn"
        Me.Officebtn.Size = New System.Drawing.Size(160, 47)
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
        Me.Chartbtn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
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
        Me.Chartbtn.Location = New System.Drawing.Point(24, 3)
        Me.Chartbtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Chartbtn.Name = "Chartbtn"
        Me.Chartbtn.Size = New System.Drawing.Size(160, 47)
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
        Me.Settingbtn.ButtonText = "Account Settings"
        Me.Settingbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Settingbtn.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Settingbtn.ForeColor = System.Drawing.Color.Black
        Me.Settingbtn.IdleBorderThickness = 1
        Me.Settingbtn.IdleCornerRadius = 1
        Me.Settingbtn.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Settingbtn.IdleForecolor = System.Drawing.Color.White
        Me.Settingbtn.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Settingbtn.Location = New System.Drawing.Point(204, 3)
        Me.Settingbtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Settingbtn.Name = "Settingbtn"
        Me.Settingbtn.Size = New System.Drawing.Size(160, 47)
        Me.Settingbtn.TabIndex = 3
        Me.Settingbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MainPanel
        '
        Me.MainPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MainPanel.BackColor = System.Drawing.Color.White
        Me.MainPanel.Location = New System.Drawing.Point(1, 65)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(1323, 636)
        Me.MainPanel.TabIndex = 79
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Settingbtn)
        Me.Panel1.Controls.Add(Me.Chartbtn)
        Me.Panel1.Controls.Add(Me.Officebtn)
        Me.Panel1.Location = New System.Drawing.Point(1, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1689, 50)
        Me.Panel1.TabIndex = 80
        '
        'isLoginPanel
        '
        Me.isLoginPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.isLoginPanel.Controls.Add(Me.MainPanel)
        Me.isLoginPanel.Controls.Add(Me.Panel1)
        Me.isLoginPanel.Enabled = False
        Me.isLoginPanel.Location = New System.Drawing.Point(0, 63)
        Me.isLoginPanel.Name = "isLoginPanel"
        Me.isLoginPanel.Size = New System.Drawing.Size(1324, 701)
        Me.isLoginPanel.TabIndex = 81
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1323, 764)
        Me.Controls.Add(Me.isLoginPanel)
        Me.Controls.Add(Me.MenuController)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "l"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuController.ResumeLayout(False)
        CType(Me.Closebtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.isLoginPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MenuController As Panel
    Friend WithEvents Officebtn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Settingbtn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Chartbtn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Closebtn As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents TitleBar As Label
    Friend WithEvents MainPanel As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents isLoginPanel As Panel
End Class
