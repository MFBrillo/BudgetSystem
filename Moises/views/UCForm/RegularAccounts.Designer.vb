<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegularAccounts
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegularAccounts))
        Me.Decriptiontxt = New System.Windows.Forms.TextBox()
        Me.AccountCodetxt = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Subcategorytxt = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.CategoryIDtxt = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.AccountIDtxt = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Accountnametxt = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Savebtn = New System.Windows.Forms.Button()
        Me.AssetIDTxt = New System.Windows.Forms.ComboBox()
        Me.RegistrycodeTxt = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.TitleBar = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Editbtn = New System.Windows.Forms.Button()
        Me.Addbtn = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.BunifuGradientPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Decriptiontxt
        '
        Me.Decriptiontxt.Location = New System.Drawing.Point(21, 456)
        Me.Decriptiontxt.Multiline = True
        Me.Decriptiontxt.Name = "Decriptiontxt"
        Me.Decriptiontxt.Size = New System.Drawing.Size(321, 91)
        Me.Decriptiontxt.TabIndex = 70
        '
        'AccountCodetxt
        '
        Me.AccountCodetxt.BackColor = System.Drawing.Color.White
        Me.AccountCodetxt.BorderColorFocused = System.Drawing.Color.Black
        Me.AccountCodetxt.BorderColorIdle = System.Drawing.Color.White
        Me.AccountCodetxt.BorderColorMouseHover = System.Drawing.Color.Black
        Me.AccountCodetxt.BorderThickness = 1
        Me.AccountCodetxt.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.AccountCodetxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.AccountCodetxt.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccountCodetxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.AccountCodetxt.isPassword = False
        Me.AccountCodetxt.Location = New System.Drawing.Point(22, 329)
        Me.AccountCodetxt.Margin = New System.Windows.Forms.Padding(4)
        Me.AccountCodetxt.MaxLength = 32767
        Me.AccountCodetxt.Name = "AccountCodetxt"
        Me.AccountCodetxt.Size = New System.Drawing.Size(320, 28)
        Me.AccountCodetxt.TabIndex = 68
        Me.AccountCodetxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label15.Location = New System.Drawing.Point(21, 309)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(86, 16)
        Me.Label15.TabIndex = 65
        Me.Label15.Text = "Account Code"
        '
        'Subcategorytxt
        '
        Me.Subcategorytxt.BackColor = System.Drawing.Color.White
        Me.Subcategorytxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Subcategorytxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Subcategorytxt.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Subcategorytxt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Subcategorytxt.FormattingEnabled = True
        Me.Subcategorytxt.Location = New System.Drawing.Point(22, 216)
        Me.Subcategorytxt.Name = "Subcategorytxt"
        Me.Subcategorytxt.Size = New System.Drawing.Size(320, 24)
        Me.Subcategorytxt.TabIndex = 64
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label13.Location = New System.Drawing.Point(19, 197)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(85, 16)
        Me.Label13.TabIndex = 63
        Me.Label13.Text = "Sub Category"
        '
        'CategoryIDtxt
        '
        Me.CategoryIDtxt.BackColor = System.Drawing.Color.White
        Me.CategoryIDtxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CategoryIDtxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CategoryIDtxt.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.CategoryIDtxt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CategoryIDtxt.FormattingEnabled = True
        Me.CategoryIDtxt.Location = New System.Drawing.Point(21, 160)
        Me.CategoryIDtxt.Name = "CategoryIDtxt"
        Me.CategoryIDtxt.Size = New System.Drawing.Size(320, 24)
        Me.CategoryIDtxt.TabIndex = 62
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label12.Location = New System.Drawing.Point(20, 142)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 16)
        Me.Label12.TabIndex = 61
        Me.Label12.Text = "Category ID"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(4, 41)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 35
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(814, 688)
        Me.DataGridView1.TabIndex = 0
        '
        'AccountIDtxt
        '
        Me.AccountIDtxt.BackColor = System.Drawing.Color.White
        Me.AccountIDtxt.BorderColorFocused = System.Drawing.Color.Black
        Me.AccountIDtxt.BorderColorIdle = System.Drawing.Color.White
        Me.AccountIDtxt.BorderColorMouseHover = System.Drawing.Color.Black
        Me.AccountIDtxt.BorderThickness = 1
        Me.AccountIDtxt.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.AccountIDtxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.AccountIDtxt.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccountIDtxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.AccountIDtxt.isPassword = False
        Me.AccountIDtxt.Location = New System.Drawing.Point(21, 274)
        Me.AccountIDtxt.Margin = New System.Windows.Forms.Padding(4)
        Me.AccountIDtxt.MaxLength = 32767
        Me.AccountIDtxt.Name = "AccountIDtxt"
        Me.AccountIDtxt.Size = New System.Drawing.Size(320, 28)
        Me.AccountIDtxt.TabIndex = 57
        Me.AccountIDtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Accountnametxt
        '
        Me.Accountnametxt.BackColor = System.Drawing.Color.White
        Me.Accountnametxt.BorderColorFocused = System.Drawing.Color.Black
        Me.Accountnametxt.BorderColorIdle = System.Drawing.Color.White
        Me.Accountnametxt.BorderColorMouseHover = System.Drawing.Color.Black
        Me.Accountnametxt.BorderThickness = 1
        Me.Accountnametxt.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.Accountnametxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Accountnametxt.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Accountnametxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Accountnametxt.isPassword = False
        Me.Accountnametxt.Location = New System.Drawing.Point(21, 381)
        Me.Accountnametxt.Margin = New System.Windows.Forms.Padding(4)
        Me.Accountnametxt.MaxLength = 32767
        Me.Accountnametxt.Name = "Accountnametxt"
        Me.Accountnametxt.Size = New System.Drawing.Size(320, 31)
        Me.Accountnametxt.TabIndex = 56
        Me.Accountnametxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1244, 50)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "REGULAR ACCOUNTS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Savebtn
        '
        Me.Savebtn.BackColor = System.Drawing.Color.Crimson
        Me.Savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Savebtn.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Savebtn.ForeColor = System.Drawing.Color.White
        Me.Savebtn.Location = New System.Drawing.Point(21, 659)
        Me.Savebtn.Name = "Savebtn"
        Me.Savebtn.Size = New System.Drawing.Size(320, 40)
        Me.Savebtn.TabIndex = 42
        Me.Savebtn.Text = "SAVE"
        Me.Savebtn.UseVisualStyleBackColor = False
        '
        'AssetIDTxt
        '
        Me.AssetIDTxt.BackColor = System.Drawing.Color.White
        Me.AssetIDTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AssetIDTxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AssetIDTxt.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.AssetIDTxt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.AssetIDTxt.FormattingEnabled = True
        Me.AssetIDTxt.Location = New System.Drawing.Point(21, 59)
        Me.AssetIDTxt.Name = "AssetIDTxt"
        Me.AssetIDTxt.Size = New System.Drawing.Size(320, 24)
        Me.AssetIDTxt.TabIndex = 47
        '
        'RegistrycodeTxt
        '
        Me.RegistrycodeTxt.BackColor = System.Drawing.Color.White
        Me.RegistrycodeTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.RegistrycodeTxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RegistrycodeTxt.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.RegistrycodeTxt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.RegistrycodeTxt.FormattingEnabled = True
        Me.RegistrycodeTxt.Location = New System.Drawing.Point(23, 105)
        Me.RegistrycodeTxt.Name = "RegistrycodeTxt"
        Me.RegistrycodeTxt.Size = New System.Drawing.Size(320, 24)
        Me.RegistrycodeTxt.TabIndex = 43
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label10.Location = New System.Drawing.Point(18, 86)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(87, 16)
        Me.Label10.TabIndex = 39
        Me.Label10.Text = "Registry Code"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Location = New System.Drawing.Point(18, 39)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(55, 16)
        Me.Label11.TabIndex = 40
        Me.Label11.Text = "Asset ID"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label14.Location = New System.Drawing.Point(18, 255)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(69, 16)
        Me.Label14.TabIndex = 43
        Me.Label14.Text = "Account ID"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label16.Location = New System.Drawing.Point(21, 361)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(90, 16)
        Me.Label16.TabIndex = 45
        Me.Label16.Text = "Account Name"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label17.Location = New System.Drawing.Point(20, 427)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(71, 16)
        Me.Label17.TabIndex = 46
        Me.Label17.Text = "Description"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 50)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1244, 888)
        Me.Panel1.TabIndex = 71
        '
        'Panel3
        '
        Me.Panel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel3.Controls.Add(Me.DataGridView1)
        Me.Panel3.Controls.Add(Me.BunifuGradientPanel1)
        Me.Panel3.Location = New System.Drawing.Point(409, 42)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(821, 729)
        Me.Panel3.TabIndex = 73
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Me.TitleBar)
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(3, 3)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(815, 38)
        Me.BunifuGradientPanel1.TabIndex = 72
        '
        'TitleBar
        '
        Me.TitleBar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TitleBar.BackColor = System.Drawing.Color.Transparent
        Me.TitleBar.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleBar.ForeColor = System.Drawing.Color.White
        Me.TitleBar.Location = New System.Drawing.Point(3, 2)
        Me.TitleBar.Name = "TitleBar"
        Me.TitleBar.Size = New System.Drawing.Size(809, 30)
        Me.TitleBar.TabIndex = 1
        Me.TitleBar.Text = "Regular Account Table"
        Me.TitleBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Editbtn)
        Me.Panel2.Controls.Add(Me.Addbtn)
        Me.Panel2.Controls.Add(Me.Savebtn)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.Decriptiontxt)
        Me.Panel2.Controls.Add(Me.CategoryIDtxt)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.AccountCodetxt)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.AssetIDTxt)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Accountnametxt)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.RegistrycodeTxt)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.Subcategorytxt)
        Me.Panel2.Controls.Add(Me.AccountIDtxt)
        Me.Panel2.Location = New System.Drawing.Point(34, 44)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(369, 727)
        Me.Panel2.TabIndex = 71
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(183, 427)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 74
        Me.Label2.Text = "Label2asdad"
        '
        'Editbtn
        '
        Me.Editbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Editbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Editbtn.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Editbtn.ForeColor = System.Drawing.Color.White
        Me.Editbtn.Location = New System.Drawing.Point(21, 567)
        Me.Editbtn.Name = "Editbtn"
        Me.Editbtn.Size = New System.Drawing.Size(320, 40)
        Me.Editbtn.TabIndex = 72
        Me.Editbtn.Text = "EDIT"
        Me.Editbtn.UseVisualStyleBackColor = False
        '
        'Addbtn
        '
        Me.Addbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Addbtn.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Addbtn.ForeColor = System.Drawing.Color.White
        Me.Addbtn.Location = New System.Drawing.Point(21, 613)
        Me.Addbtn.Name = "Addbtn"
        Me.Addbtn.Size = New System.Drawing.Size(320, 40)
        Me.Addbtn.TabIndex = 71
        Me.Addbtn.Text = "ADD"
        Me.Addbtn.UseVisualStyleBackColor = False
        '
        'RegularAccounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "RegularAccounts"
        Me.Size = New System.Drawing.Size(1244, 938)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Decriptiontxt As TextBox
    Friend WithEvents AccountCodetxt As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label15 As Label
    Friend WithEvents Subcategorytxt As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents CategoryIDtxt As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents AccountIDtxt As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Accountnametxt As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label1 As Label
    Friend WithEvents Savebtn As Button
    Friend WithEvents AssetIDTxt As ComboBox
    Friend WithEvents RegistrycodeTxt As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents TitleBar As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Addbtn As Button
    Friend WithEvents Editbtn As Button
    Friend WithEvents Label2 As Label
End Class
