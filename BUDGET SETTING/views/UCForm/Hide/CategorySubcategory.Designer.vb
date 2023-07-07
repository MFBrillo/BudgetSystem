<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CategorySubcategory
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.AssetIDCBB = New System.Windows.Forms.ComboBox()
        Me.RegistryIDcbb = New System.Windows.Forms.ComboBox()
        Me.CategoryDestxt = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Categorycodetxt = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Categorynametxt = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CategoryIDtxt = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.AddCategorybtn = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Assettxt = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AssetAddbtn = New System.Windows.Forms.Button()
        Me.BunifuMetroTextbox4 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.BunifuMetroTextbox5 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BunifuMetroTextbox6 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.BunifuMetroTextbox7 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.BunifuMetroTextbox8 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1596, 50)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "CATEGORY AND SUBGATEGORY"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray
        Me.DataGridView2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGridView2.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 9.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(592, 496)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowTemplate.Height = 35
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(982, 409)
        Me.DataGridView2.TabIndex = 64
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGray
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 9.0!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(592, 67)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 35
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(982, 407)
        Me.DataGridView1.TabIndex = 63
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.AssetIDCBB)
        Me.Panel1.Controls.Add(Me.RegistryIDcbb)
        Me.Panel1.Controls.Add(Me.CategoryDestxt)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Categorycodetxt)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Categorynametxt)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.CategoryIDtxt)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.AddCategorybtn)
        Me.Panel1.Location = New System.Drawing.Point(6, 67)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(580, 407)
        Me.Panel1.TabIndex = 62
        '
        'AssetIDCBB
        '
        Me.AssetIDCBB.BackColor = System.Drawing.Color.White
        Me.AssetIDCBB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AssetIDCBB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AssetIDCBB.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.AssetIDCBB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.AssetIDCBB.FormattingEnabled = True
        Me.AssetIDCBB.Location = New System.Drawing.Point(299, 97)
        Me.AssetIDCBB.Name = "AssetIDCBB"
        Me.AssetIDCBB.Size = New System.Drawing.Size(257, 24)
        Me.AssetIDCBB.TabIndex = 88
        '
        'RegistryIDcbb
        '
        Me.RegistryIDcbb.BackColor = System.Drawing.Color.White
        Me.RegistryIDcbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.RegistryIDcbb.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RegistryIDcbb.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.RegistryIDcbb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.RegistryIDcbb.FormattingEnabled = True
        Me.RegistryIDcbb.Location = New System.Drawing.Point(23, 97)
        Me.RegistryIDcbb.Name = "RegistryIDcbb"
        Me.RegistryIDcbb.Size = New System.Drawing.Size(257, 24)
        Me.RegistryIDcbb.TabIndex = 87
        '
        'CategoryDestxt
        '
        Me.CategoryDestxt.BackColor = System.Drawing.Color.White
        Me.CategoryDestxt.BorderColorFocused = System.Drawing.Color.Black
        Me.CategoryDestxt.BorderColorIdle = System.Drawing.Color.White
        Me.CategoryDestxt.BorderColorMouseHover = System.Drawing.Color.Black
        Me.CategoryDestxt.BorderThickness = 1
        Me.CategoryDestxt.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.CategoryDestxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CategoryDestxt.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.CategoryDestxt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CategoryDestxt.isPassword = False
        Me.CategoryDestxt.Location = New System.Drawing.Point(302, 244)
        Me.CategoryDestxt.Margin = New System.Windows.Forms.Padding(4)
        Me.CategoryDestxt.MaxLength = 32767
        Me.CategoryDestxt.Name = "CategoryDestxt"
        Me.CategoryDestxt.Size = New System.Drawing.Size(254, 30)
        Me.CategoryDestxt.TabIndex = 84
        Me.CategoryDestxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(302, 78)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 16)
        Me.Label6.TabIndex = 79
        Me.Label6.Text = "Asset ID"
        '
        'Categorycodetxt
        '
        Me.Categorycodetxt.BackColor = System.Drawing.Color.White
        Me.Categorycodetxt.BorderColorFocused = System.Drawing.Color.Black
        Me.Categorycodetxt.BorderColorIdle = System.Drawing.Color.White
        Me.Categorycodetxt.BorderColorMouseHover = System.Drawing.Color.Black
        Me.Categorycodetxt.BorderThickness = 1
        Me.Categorycodetxt.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.Categorycodetxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Categorycodetxt.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Categorycodetxt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Categorycodetxt.isPassword = False
        Me.Categorycodetxt.Location = New System.Drawing.Point(302, 169)
        Me.Categorycodetxt.Margin = New System.Windows.Forms.Padding(4)
        Me.Categorycodetxt.MaxLength = 32767
        Me.Categorycodetxt.Name = "Categorycodetxt"
        Me.Categorycodetxt.Size = New System.Drawing.Size(254, 30)
        Me.Categorycodetxt.TabIndex = 81
        Me.Categorycodetxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(299, 148)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 16)
        Me.Label9.TabIndex = 80
        Me.Label9.Text = "Category Code"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label10.Location = New System.Drawing.Point(299, 223)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(126, 16)
        Me.Label10.TabIndex = 83
        Me.Label10.Text = "Category Description"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(224, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(119, 24)
        Me.Label7.TabIndex = 77
        Me.Label7.Text = "CATEGORY"
        '
        'Categorynametxt
        '
        Me.Categorynametxt.BackColor = System.Drawing.Color.White
        Me.Categorynametxt.BorderColorFocused = System.Drawing.Color.Black
        Me.Categorynametxt.BorderColorIdle = System.Drawing.Color.White
        Me.Categorynametxt.BorderColorMouseHover = System.Drawing.Color.Black
        Me.Categorynametxt.BorderThickness = 1
        Me.Categorynametxt.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.Categorynametxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Categorynametxt.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Categorynametxt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Categorynametxt.isPassword = False
        Me.Categorynametxt.Location = New System.Drawing.Point(23, 244)
        Me.Categorynametxt.Margin = New System.Windows.Forms.Padding(4)
        Me.Categorynametxt.MaxLength = 32767
        Me.Categorynametxt.Name = "Categorynametxt"
        Me.Categorynametxt.Size = New System.Drawing.Size(254, 30)
        Me.Categorynametxt.TabIndex = 68
        Me.Categorynametxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(23, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 16)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "Registry ID"
        '
        'CategoryIDtxt
        '
        Me.CategoryIDtxt.BackColor = System.Drawing.Color.White
        Me.CategoryIDtxt.BorderColorFocused = System.Drawing.Color.Black
        Me.CategoryIDtxt.BorderColorIdle = System.Drawing.Color.White
        Me.CategoryIDtxt.BorderColorMouseHover = System.Drawing.Color.Black
        Me.CategoryIDtxt.BorderThickness = 1
        Me.CategoryIDtxt.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.CategoryIDtxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CategoryIDtxt.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.CategoryIDtxt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CategoryIDtxt.isPassword = False
        Me.CategoryIDtxt.Location = New System.Drawing.Point(23, 169)
        Me.CategoryIDtxt.Margin = New System.Windows.Forms.Padding(4)
        Me.CategoryIDtxt.MaxLength = 32767
        Me.CategoryIDtxt.Name = "CategoryIDtxt"
        Me.CategoryIDtxt.Size = New System.Drawing.Size(254, 30)
        Me.CategoryIDtxt.TabIndex = 65
        Me.CategoryIDtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label18.Location = New System.Drawing.Point(20, 148)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(75, 16)
        Me.Label18.TabIndex = 64
        Me.Label18.Text = "Category ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(20, 223)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 16)
        Me.Label4.TabIndex = 67
        Me.Label4.Text = "Category Name"
        '
        'AddCategorybtn
        '
        Me.AddCategorybtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.AddCategorybtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddCategorybtn.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.AddCategorybtn.ForeColor = System.Drawing.Color.White
        Me.AddCategorybtn.Location = New System.Drawing.Point(302, 345)
        Me.AddCategorybtn.Name = "AddCategorybtn"
        Me.AddCategorybtn.Size = New System.Drawing.Size(252, 30)
        Me.AddCategorybtn.TabIndex = 63
        Me.AddCategorybtn.Text = "Add"
        Me.AddCategorybtn.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(202, 42)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(161, 24)
        Me.Label8.TabIndex = 78
        Me.Label8.Text = "SUBCATEGORY"
        '
        'Assettxt
        '
        Me.Assettxt.BackColor = System.Drawing.Color.White
        Me.Assettxt.BorderColorFocused = System.Drawing.Color.Black
        Me.Assettxt.BorderColorIdle = System.Drawing.Color.White
        Me.Assettxt.BorderColorMouseHover = System.Drawing.Color.Black
        Me.Assettxt.BorderThickness = 1
        Me.Assettxt.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.Assettxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Assettxt.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Assettxt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Assettxt.isPassword = False
        Me.Assettxt.Location = New System.Drawing.Point(24, 111)
        Me.Assettxt.Margin = New System.Windows.Forms.Padding(4)
        Me.Assettxt.MaxLength = 32767
        Me.Assettxt.Name = "Assettxt"
        Me.Assettxt.Size = New System.Drawing.Size(256, 30)
        Me.Assettxt.TabIndex = 73
        Me.Assettxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(23, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 16)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "Asset"
        '
        'AssetAddbtn
        '
        Me.AssetAddbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.AssetAddbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AssetAddbtn.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.AssetAddbtn.ForeColor = System.Drawing.Color.White
        Me.AssetAddbtn.Location = New System.Drawing.Point(300, 329)
        Me.AssetAddbtn.Name = "AssetAddbtn"
        Me.AssetAddbtn.Size = New System.Drawing.Size(252, 30)
        Me.AssetAddbtn.TabIndex = 70
        Me.AssetAddbtn.Text = "Add"
        Me.AssetAddbtn.UseVisualStyleBackColor = False
        '
        'BunifuMetroTextbox4
        '
        Me.BunifuMetroTextbox4.BackColor = System.Drawing.Color.White
        Me.BunifuMetroTextbox4.BorderColorFocused = System.Drawing.Color.Black
        Me.BunifuMetroTextbox4.BorderColorIdle = System.Drawing.Color.White
        Me.BunifuMetroTextbox4.BorderColorMouseHover = System.Drawing.Color.Black
        Me.BunifuMetroTextbox4.BorderThickness = 1
        Me.BunifuMetroTextbox4.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.BunifuMetroTextbox4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMetroTextbox4.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.BunifuMetroTextbox4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BunifuMetroTextbox4.isPassword = False
        Me.BunifuMetroTextbox4.Location = New System.Drawing.Point(300, 111)
        Me.BunifuMetroTextbox4.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMetroTextbox4.MaxLength = 32767
        Me.BunifuMetroTextbox4.Name = "BunifuMetroTextbox4"
        Me.BunifuMetroTextbox4.Size = New System.Drawing.Size(256, 30)
        Me.BunifuMetroTextbox4.TabIndex = 86
        Me.BunifuMetroTextbox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Location = New System.Drawing.Point(299, 91)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(39, 16)
        Me.Label11.TabIndex = 85
        Me.Label11.Text = "Asset"
        '
        'BunifuMetroTextbox5
        '
        Me.BunifuMetroTextbox5.BackColor = System.Drawing.Color.White
        Me.BunifuMetroTextbox5.BorderColorFocused = System.Drawing.Color.Black
        Me.BunifuMetroTextbox5.BorderColorIdle = System.Drawing.Color.White
        Me.BunifuMetroTextbox5.BorderColorMouseHover = System.Drawing.Color.Black
        Me.BunifuMetroTextbox5.BorderThickness = 1
        Me.BunifuMetroTextbox5.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.BunifuMetroTextbox5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMetroTextbox5.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.BunifuMetroTextbox5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BunifuMetroTextbox5.isPassword = False
        Me.BunifuMetroTextbox5.Location = New System.Drawing.Point(300, 178)
        Me.BunifuMetroTextbox5.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMetroTextbox5.MaxLength = 32767
        Me.BunifuMetroTextbox5.Name = "BunifuMetroTextbox5"
        Me.BunifuMetroTextbox5.Size = New System.Drawing.Size(256, 30)
        Me.BunifuMetroTextbox5.TabIndex = 90
        Me.BunifuMetroTextbox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(299, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 16)
        Me.Label3.TabIndex = 89
        Me.Label3.Text = "Asset"
        '
        'BunifuMetroTextbox6
        '
        Me.BunifuMetroTextbox6.BackColor = System.Drawing.Color.White
        Me.BunifuMetroTextbox6.BorderColorFocused = System.Drawing.Color.Black
        Me.BunifuMetroTextbox6.BorderColorIdle = System.Drawing.Color.White
        Me.BunifuMetroTextbox6.BorderColorMouseHover = System.Drawing.Color.Black
        Me.BunifuMetroTextbox6.BorderThickness = 1
        Me.BunifuMetroTextbox6.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.BunifuMetroTextbox6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMetroTextbox6.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.BunifuMetroTextbox6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BunifuMetroTextbox6.isPassword = False
        Me.BunifuMetroTextbox6.Location = New System.Drawing.Point(24, 178)
        Me.BunifuMetroTextbox6.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMetroTextbox6.MaxLength = 32767
        Me.BunifuMetroTextbox6.Name = "BunifuMetroTextbox6"
        Me.BunifuMetroTextbox6.Size = New System.Drawing.Size(256, 30)
        Me.BunifuMetroTextbox6.TabIndex = 88
        Me.BunifuMetroTextbox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label12.Location = New System.Drawing.Point(23, 158)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(39, 16)
        Me.Label12.TabIndex = 87
        Me.Label12.Text = "Asset"
        '
        'BunifuMetroTextbox7
        '
        Me.BunifuMetroTextbox7.BackColor = System.Drawing.Color.White
        Me.BunifuMetroTextbox7.BorderColorFocused = System.Drawing.Color.Black
        Me.BunifuMetroTextbox7.BorderColorIdle = System.Drawing.Color.White
        Me.BunifuMetroTextbox7.BorderColorMouseHover = System.Drawing.Color.Black
        Me.BunifuMetroTextbox7.BorderThickness = 1
        Me.BunifuMetroTextbox7.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.BunifuMetroTextbox7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMetroTextbox7.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.BunifuMetroTextbox7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BunifuMetroTextbox7.isPassword = False
        Me.BunifuMetroTextbox7.Location = New System.Drawing.Point(300, 246)
        Me.BunifuMetroTextbox7.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMetroTextbox7.MaxLength = 32767
        Me.BunifuMetroTextbox7.Name = "BunifuMetroTextbox7"
        Me.BunifuMetroTextbox7.Size = New System.Drawing.Size(256, 30)
        Me.BunifuMetroTextbox7.TabIndex = 94
        Me.BunifuMetroTextbox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label13.Location = New System.Drawing.Point(299, 226)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(39, 16)
        Me.Label13.TabIndex = 93
        Me.Label13.Text = "Asset"
        '
        'BunifuMetroTextbox8
        '
        Me.BunifuMetroTextbox8.BackColor = System.Drawing.Color.White
        Me.BunifuMetroTextbox8.BorderColorFocused = System.Drawing.Color.Black
        Me.BunifuMetroTextbox8.BorderColorIdle = System.Drawing.Color.White
        Me.BunifuMetroTextbox8.BorderColorMouseHover = System.Drawing.Color.Black
        Me.BunifuMetroTextbox8.BorderThickness = 1
        Me.BunifuMetroTextbox8.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.BunifuMetroTextbox8.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMetroTextbox8.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.BunifuMetroTextbox8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BunifuMetroTextbox8.isPassword = False
        Me.BunifuMetroTextbox8.Location = New System.Drawing.Point(24, 246)
        Me.BunifuMetroTextbox8.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMetroTextbox8.MaxLength = 32767
        Me.BunifuMetroTextbox8.Name = "BunifuMetroTextbox8"
        Me.BunifuMetroTextbox8.Size = New System.Drawing.Size(256, 30)
        Me.BunifuMetroTextbox8.TabIndex = 92
        Me.BunifuMetroTextbox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label14.Location = New System.Drawing.Point(23, 226)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(39, 16)
        Me.Label14.TabIndex = 91
        Me.Label14.Text = "Asset"
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.BunifuMetroTextbox7)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.AssetAddbtn)
        Me.Panel2.Controls.Add(Me.BunifuMetroTextbox8)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.Assettxt)
        Me.Panel2.Controls.Add(Me.BunifuMetroTextbox5)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.BunifuMetroTextbox4)
        Me.Panel2.Controls.Add(Me.BunifuMetroTextbox6)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Location = New System.Drawing.Point(6, 496)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(580, 409)
        Me.Panel2.TabIndex = 65
        '
        'CategorySubcategory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CategorySubcategory"
        Me.Size = New System.Drawing.Size(1596, 961)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Categorynametxt As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Assettxt As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents CategoryIDtxt As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label18 As Label
    Friend WithEvents AssetAddbtn As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents AddCategorybtn As Button
    Friend WithEvents BunifuMetroTextbox7 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label13 As Label
    Friend WithEvents BunifuMetroTextbox8 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label14 As Label
    Friend WithEvents BunifuMetroTextbox5 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label3 As Label
    Friend WithEvents BunifuMetroTextbox6 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label12 As Label
    Friend WithEvents BunifuMetroTextbox4 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label11 As Label
    Friend WithEvents CategoryDestxt As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label6 As Label
    Friend WithEvents Categorycodetxt As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents AssetIDCBB As ComboBox
    Friend WithEvents RegistryIDcbb As ComboBox
End Class
