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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Sectorbtn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Registrybtn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Fundsbtn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Categorybtn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.RegularBtn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.TitleBar = New System.Windows.Forms.Label()
        Me.MenuController = New System.Windows.Forms.Panel()
        Me.MainPanel = New System.Windows.Forms.DataGridView()
        Me.BunifuGradientPanel1.SuspendLayout()
        Me.MenuController.SuspendLayout()
        CType(Me.MainPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Sectorbtn
        '
        Me.Sectorbtn.ActiveBorderThickness = 1
        Me.Sectorbtn.ActiveCornerRadius = 20
        Me.Sectorbtn.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.Sectorbtn.ActiveForecolor = System.Drawing.Color.Black
        Me.Sectorbtn.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.Sectorbtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Sectorbtn.BackColor = System.Drawing.Color.White
        Me.Sectorbtn.BackgroundImage = CType(resources.GetObject("Sectorbtn.BackgroundImage"), System.Drawing.Image)
        Me.Sectorbtn.ButtonText = "Sector and Subsector"
        Me.Sectorbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Sectorbtn.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sectorbtn.ForeColor = System.Drawing.Color.Black
        Me.Sectorbtn.IdleBorderThickness = 1
        Me.Sectorbtn.IdleCornerRadius = 20
        Me.Sectorbtn.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.Sectorbtn.IdleForecolor = System.Drawing.Color.White
        Me.Sectorbtn.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.Sectorbtn.Location = New System.Drawing.Point(802, 5)
        Me.Sectorbtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Sectorbtn.Name = "Sectorbtn"
        Me.Sectorbtn.Size = New System.Drawing.Size(141, 50)
        Me.Sectorbtn.TabIndex = 6
        Me.Sectorbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Registrybtn
        '
        Me.Registrybtn.ActiveBorderThickness = 1
        Me.Registrybtn.ActiveCornerRadius = 20
        Me.Registrybtn.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.Registrybtn.ActiveForecolor = System.Drawing.Color.Black
        Me.Registrybtn.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.Registrybtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Registrybtn.BackColor = System.Drawing.Color.White
        Me.Registrybtn.BackgroundImage = CType(resources.GetObject("Registrybtn.BackgroundImage"), System.Drawing.Image)
        Me.Registrybtn.ButtonText = "Registry and Asset"
        Me.Registrybtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Registrybtn.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Registrybtn.ForeColor = System.Drawing.Color.Black
        Me.Registrybtn.IdleBorderThickness = 1
        Me.Registrybtn.IdleCornerRadius = 20
        Me.Registrybtn.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.Registrybtn.IdleForecolor = System.Drawing.Color.White
        Me.Registrybtn.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.Registrybtn.Location = New System.Drawing.Point(647, 6)
        Me.Registrybtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Registrybtn.Name = "Registrybtn"
        Me.Registrybtn.Size = New System.Drawing.Size(141, 50)
        Me.Registrybtn.TabIndex = 4
        Me.Registrybtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Fundsbtn
        '
        Me.Fundsbtn.ActiveBorderThickness = 1
        Me.Fundsbtn.ActiveCornerRadius = 20
        Me.Fundsbtn.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.Fundsbtn.ActiveForecolor = System.Drawing.Color.Black
        Me.Fundsbtn.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.Fundsbtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Fundsbtn.BackColor = System.Drawing.Color.White
        Me.Fundsbtn.BackgroundImage = CType(resources.GetObject("Fundsbtn.BackgroundImage"), System.Drawing.Image)
        Me.Fundsbtn.ButtonText = "Funds and Special Funds"
        Me.Fundsbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Fundsbtn.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fundsbtn.ForeColor = System.Drawing.Color.Black
        Me.Fundsbtn.IdleBorderThickness = 1
        Me.Fundsbtn.IdleCornerRadius = 20
        Me.Fundsbtn.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.Fundsbtn.IdleForecolor = System.Drawing.Color.White
        Me.Fundsbtn.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.Fundsbtn.Location = New System.Drawing.Point(492, 6)
        Me.Fundsbtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Fundsbtn.Name = "Fundsbtn"
        Me.Fundsbtn.Size = New System.Drawing.Size(141, 50)
        Me.Fundsbtn.TabIndex = 3
        Me.Fundsbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Categorybtn
        '
        Me.Categorybtn.ActiveBorderThickness = 1
        Me.Categorybtn.ActiveCornerRadius = 20
        Me.Categorybtn.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.Categorybtn.ActiveForecolor = System.Drawing.Color.Black
        Me.Categorybtn.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.Categorybtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Categorybtn.BackColor = System.Drawing.Color.White
        Me.Categorybtn.BackgroundImage = CType(resources.GetObject("Categorybtn.BackgroundImage"), System.Drawing.Image)
        Me.Categorybtn.ButtonText = "Category and Subcategory"
        Me.Categorybtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Categorybtn.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Categorybtn.ForeColor = System.Drawing.Color.Black
        Me.Categorybtn.IdleBorderThickness = 1
        Me.Categorybtn.IdleCornerRadius = 20
        Me.Categorybtn.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.Categorybtn.IdleForecolor = System.Drawing.Color.White
        Me.Categorybtn.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.Categorybtn.Location = New System.Drawing.Point(337, 6)
        Me.Categorybtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Categorybtn.Name = "Categorybtn"
        Me.Categorybtn.Size = New System.Drawing.Size(141, 50)
        Me.Categorybtn.TabIndex = 2
        Me.Categorybtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RegularBtn
        '
        Me.RegularBtn.ActiveBorderThickness = 1
        Me.RegularBtn.ActiveCornerRadius = 20
        Me.RegularBtn.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.RegularBtn.ActiveForecolor = System.Drawing.Color.Black
        Me.RegularBtn.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.RegularBtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RegularBtn.BackColor = System.Drawing.Color.White
        Me.RegularBtn.BackgroundImage = CType(resources.GetObject("RegularBtn.BackgroundImage"), System.Drawing.Image)
        Me.RegularBtn.ButtonText = "Regular Accounts"
        Me.RegularBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RegularBtn.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegularBtn.ForeColor = System.Drawing.Color.Black
        Me.RegularBtn.IdleBorderThickness = 1
        Me.RegularBtn.IdleCornerRadius = 20
        Me.RegularBtn.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.RegularBtn.IdleForecolor = System.Drawing.Color.White
        Me.RegularBtn.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.RegularBtn.Location = New System.Drawing.Point(182, 6)
        Me.RegularBtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RegularBtn.Name = "RegularBtn"
        Me.RegularBtn.Size = New System.Drawing.Size(141, 50)
        Me.RegularBtn.TabIndex = 1
        Me.RegularBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Me.TitleBar)
        Me.BunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(1166, 50)
        Me.BunifuGradientPanel1.TabIndex = 4
        '
        'TitleBar
        '
        Me.TitleBar.BackColor = System.Drawing.Color.Transparent
        Me.TitleBar.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleBar.ForeColor = System.Drawing.Color.White
        Me.TitleBar.Location = New System.Drawing.Point(0, 1)
        Me.TitleBar.Name = "TitleBar"
        Me.TitleBar.Size = New System.Drawing.Size(1166, 49)
        Me.TitleBar.TabIndex = 1
        Me.TitleBar.Text = "Budget Appropriation"
        Me.TitleBar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MenuController
        '
        Me.MenuController.BackColor = System.Drawing.Color.White
        Me.MenuController.Controls.Add(Me.Sectorbtn)
        Me.MenuController.Controls.Add(Me.Categorybtn)
        Me.MenuController.Controls.Add(Me.Registrybtn)
        Me.MenuController.Controls.Add(Me.RegularBtn)
        Me.MenuController.Controls.Add(Me.Fundsbtn)
        Me.MenuController.Dock = System.Windows.Forms.DockStyle.Top
        Me.MenuController.Location = New System.Drawing.Point(0, 50)
        Me.MenuController.Name = "MenuController"
        Me.MenuController.Size = New System.Drawing.Size(1166, 62)
        Me.MenuController.TabIndex = 7
        '
        'MainPanel
        '
        Me.MainPanel.AllowUserToAddRows = False
        Me.MainPanel.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray
        Me.MainPanel.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.MainPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MainPanel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.MainPanel.BackgroundColor = System.Drawing.Color.White
        Me.MainPanel.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.MainPanel.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.MainPanel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MainPanel.Location = New System.Drawing.Point(0, 115)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.ReadOnly = True
        Me.MainPanel.RowTemplate.Height = 35
        Me.MainPanel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MainPanel.Size = New System.Drawing.Size(1166, 560)
        Me.MainPanel.TabIndex = 90
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1166, 674)
        Me.Controls.Add(Me.MainPanel)
        Me.Controls.Add(Me.MenuController)
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Account Code"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.MenuController.ResumeLayout(False)
        CType(Me.MainPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Sectorbtn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Registrybtn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Fundsbtn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Categorybtn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents RegularBtn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents TitleBar As Label
    Friend WithEvents MenuController As Panel
    Friend WithEvents MainPanel As DataGridView
End Class
