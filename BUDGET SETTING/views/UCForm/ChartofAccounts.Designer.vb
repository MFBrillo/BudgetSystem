<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ChartofAccounts
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Searchtxt = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.AccountIDtxt = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Savebtn = New System.Windows.Forms.Button()
        Me.Decriptiontxt = New System.Windows.Forms.TextBox()
        Me.AddSubcategorybtn = New System.Windows.Forms.Button()
        Me.AddCategorybtn = New System.Windows.Forms.Button()
        Me.SubcategoryIDtxt = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.CategoryIDtxt = New System.Windows.Forms.ComboBox()
        Me.Accountnametxt = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.AccountCodetxt = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.AssetIDTxt = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Label1.Size = New System.Drawing.Size(1275, 50)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "CHART OF ACCOUNTS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.Panel3.Controls.Add(Me.DataGridView1)
        Me.Panel3.Controls.Add(Me.Panel1)
        Me.Panel3.Controls.Add(Me.AccountIDtxt)
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(396, 50)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(879, 610)
        Me.Panel3.TabIndex = 75
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(186, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(186, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(59, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(59, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(11, 56)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(59, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(59, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(59, Byte), Integer))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(857, 544)
        Me.DataGridView1.TabIndex = 74
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Searchtxt)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(879, 46)
        Me.Panel1.TabIndex = 73
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Moises.My.Resources.Resources.search__1_
        Me.PictureBox1.Location = New System.Drawing.Point(469, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 30)
        Me.PictureBox1.TabIndex = 125
        Me.PictureBox1.TabStop = False
        '
        'Searchtxt
        '
        Me.Searchtxt.BackColor = System.Drawing.Color.White
        Me.Searchtxt.BorderColorFocused = System.Drawing.Color.White
        Me.Searchtxt.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Searchtxt.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Searchtxt.BorderThickness = 1
        Me.Searchtxt.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.Searchtxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Searchtxt.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Searchtxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Searchtxt.isPassword = False
        Me.Searchtxt.Location = New System.Drawing.Point(11, 10)
        Me.Searchtxt.Margin = New System.Windows.Forms.Padding(4)
        Me.Searchtxt.MaxLength = 32767
        Me.Searchtxt.Name = "Searchtxt"
        Me.Searchtxt.Size = New System.Drawing.Size(451, 30)
        Me.Searchtxt.TabIndex = 121
        Me.Searchtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'AccountIDtxt
        '
        Me.AccountIDtxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.AccountIDtxt.BorderColorFocused = System.Drawing.Color.White
        Me.AccountIDtxt.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.AccountIDtxt.BorderColorMouseHover = System.Drawing.Color.White
        Me.AccountIDtxt.BorderThickness = 1
        Me.AccountIDtxt.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.AccountIDtxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.AccountIDtxt.Enabled = False
        Me.AccountIDtxt.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccountIDtxt.ForeColor = System.Drawing.Color.Gainsboro
        Me.AccountIDtxt.isPassword = False
        Me.AccountIDtxt.Location = New System.Drawing.Point(-410, 342)
        Me.AccountIDtxt.Margin = New System.Windows.Forms.Padding(4)
        Me.AccountIDtxt.MaxLength = 32767
        Me.AccountIDtxt.Name = "AccountIDtxt"
        Me.AccountIDtxt.Size = New System.Drawing.Size(360, 28)
        Me.AccountIDtxt.TabIndex = 57
        Me.AccountIDtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(-412, 319)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(69, 16)
        Me.Label14.TabIndex = 43
        Me.Label14.Text = "Account ID"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 50)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(396, 610)
        Me.Panel2.TabIndex = 74
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Controls.Add(Me.Savebtn)
        Me.Panel5.Controls.Add(Me.Decriptiontxt)
        Me.Panel5.Controls.Add(Me.AddSubcategorybtn)
        Me.Panel5.Controls.Add(Me.AddCategorybtn)
        Me.Panel5.Controls.Add(Me.SubcategoryIDtxt)
        Me.Panel5.Controls.Add(Me.Button1)
        Me.Panel5.Controls.Add(Me.Label17)
        Me.Panel5.Controls.Add(Me.Label15)
        Me.Panel5.Controls.Add(Me.Label13)
        Me.Panel5.Controls.Add(Me.CategoryIDtxt)
        Me.Panel5.Controls.Add(Me.Accountnametxt)
        Me.Panel5.Controls.Add(Me.Label12)
        Me.Panel5.Controls.Add(Me.Label11)
        Me.Panel5.Controls.Add(Me.AccountCodetxt)
        Me.Panel5.Controls.Add(Me.AssetIDTxt)
        Me.Panel5.Controls.Add(Me.Label16)
        Me.Panel5.Location = New System.Drawing.Point(12, 10)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(378, 590)
        Me.Panel5.TabIndex = 74
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(128, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 19)
        Me.Label2.TabIndex = 126
        Me.Label2.Text = "ADD ACCOUNT"
        '
        'Savebtn
        '
        Me.Savebtn.BackColor = System.Drawing.Color.Crimson
        Me.Savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Savebtn.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Savebtn.ForeColor = System.Drawing.Color.White
        Me.Savebtn.Location = New System.Drawing.Point(9, 545)
        Me.Savebtn.Name = "Savebtn"
        Me.Savebtn.Size = New System.Drawing.Size(361, 35)
        Me.Savebtn.TabIndex = 42
        Me.Savebtn.Text = "SAVE"
        Me.Savebtn.UseVisualStyleBackColor = False
        '
        'Decriptiontxt
        '
        Me.Decriptiontxt.BackColor = System.Drawing.Color.White
        Me.Decriptiontxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Decriptiontxt.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Decriptiontxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Decriptiontxt.Location = New System.Drawing.Point(10, 400)
        Me.Decriptiontxt.Multiline = True
        Me.Decriptiontxt.Name = "Decriptiontxt"
        Me.Decriptiontxt.Size = New System.Drawing.Size(360, 91)
        Me.Decriptiontxt.TabIndex = 70
        '
        'AddSubcategorybtn
        '
        Me.AddSubcategorybtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.AddSubcategorybtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddSubcategorybtn.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.AddSubcategorybtn.ForeColor = System.Drawing.Color.White
        Me.AddSubcategorybtn.Location = New System.Drawing.Point(294, 202)
        Me.AddSubcategorybtn.Name = "AddSubcategorybtn"
        Me.AddSubcategorybtn.Size = New System.Drawing.Size(77, 23)
        Me.AddSubcategorybtn.TabIndex = 78
        Me.AddSubcategorybtn.Text = "Add"
        Me.AddSubcategorybtn.UseVisualStyleBackColor = False
        '
        'AddCategorybtn
        '
        Me.AddCategorybtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.AddCategorybtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddCategorybtn.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.AddCategorybtn.ForeColor = System.Drawing.Color.White
        Me.AddCategorybtn.Location = New System.Drawing.Point(294, 134)
        Me.AddCategorybtn.Name = "AddCategorybtn"
        Me.AddCategorybtn.Size = New System.Drawing.Size(77, 23)
        Me.AddCategorybtn.TabIndex = 77
        Me.AddCategorybtn.Text = "Add"
        Me.AddCategorybtn.UseVisualStyleBackColor = False
        '
        'SubcategoryIDtxt
        '
        Me.SubcategoryIDtxt.BackColor = System.Drawing.Color.White
        Me.SubcategoryIDtxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SubcategoryIDtxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SubcategoryIDtxt.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.SubcategoryIDtxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.SubcategoryIDtxt.FormattingEnabled = True
        Me.SubcategoryIDtxt.Location = New System.Drawing.Point(9, 201)
        Me.SubcategoryIDtxt.Name = "SubcategoryIDtxt"
        Me.SubcategoryIDtxt.Size = New System.Drawing.Size(281, 24)
        Me.SubcategoryIDtxt.TabIndex = 64
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(294, 71)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(77, 23)
        Me.Button1.TabIndex = 75
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(8, 379)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(71, 16)
        Me.Label17.TabIndex = 46
        Me.Label17.Text = "Description"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(10, 243)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(86, 16)
        Me.Label15.TabIndex = 65
        Me.Label15.Text = "Account Code"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(7, 179)
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
        Me.CategoryIDtxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.CategoryIDtxt.FormattingEnabled = True
        Me.CategoryIDtxt.Location = New System.Drawing.Point(9, 133)
        Me.CategoryIDtxt.Name = "CategoryIDtxt"
        Me.CategoryIDtxt.Size = New System.Drawing.Size(279, 24)
        Me.CategoryIDtxt.TabIndex = 62
        '
        'Accountnametxt
        '
        Me.Accountnametxt.BackColor = System.Drawing.Color.White
        Me.Accountnametxt.BorderColorFocused = System.Drawing.Color.White
        Me.Accountnametxt.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Accountnametxt.BorderColorMouseHover = System.Drawing.Color.White
        Me.Accountnametxt.BorderThickness = 1
        Me.Accountnametxt.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.Accountnametxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Accountnametxt.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Accountnametxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Accountnametxt.isPassword = False
        Me.Accountnametxt.Location = New System.Drawing.Point(10, 329)
        Me.Accountnametxt.Margin = New System.Windows.Forms.Padding(4)
        Me.Accountnametxt.MaxLength = 32767
        Me.Accountnametxt.Name = "Accountnametxt"
        Me.Accountnametxt.Size = New System.Drawing.Size(360, 31)
        Me.Accountnametxt.TabIndex = 56
        Me.Accountnametxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(7, 110)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 16)
        Me.Label12.TabIndex = 61
        Me.Label12.Text = "Category"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(7, 50)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(91, 16)
        Me.Label11.TabIndex = 40
        Me.Label11.Text = "Account Types"
        '
        'AccountCodetxt
        '
        Me.AccountCodetxt.BackColor = System.Drawing.Color.White
        Me.AccountCodetxt.BorderColorFocused = System.Drawing.Color.White
        Me.AccountCodetxt.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.AccountCodetxt.BorderColorMouseHover = System.Drawing.Color.White
        Me.AccountCodetxt.BorderThickness = 1
        Me.AccountCodetxt.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.AccountCodetxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.AccountCodetxt.Enabled = False
        Me.AccountCodetxt.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccountCodetxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.AccountCodetxt.isPassword = False
        Me.AccountCodetxt.Location = New System.Drawing.Point(9, 265)
        Me.AccountCodetxt.Margin = New System.Windows.Forms.Padding(4)
        Me.AccountCodetxt.MaxLength = 32767
        Me.AccountCodetxt.Name = "AccountCodetxt"
        Me.AccountCodetxt.Size = New System.Drawing.Size(361, 28)
        Me.AccountCodetxt.TabIndex = 68
        Me.AccountCodetxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'AssetIDTxt
        '
        Me.AssetIDTxt.BackColor = System.Drawing.Color.White
        Me.AssetIDTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AssetIDTxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AssetIDTxt.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.AssetIDTxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.AssetIDTxt.FormattingEnabled = True
        Me.AssetIDTxt.Location = New System.Drawing.Point(9, 70)
        Me.AssetIDTxt.Name = "AssetIDTxt"
        Me.AssetIDTxt.Size = New System.Drawing.Size(281, 24)
        Me.AssetIDTxt.TabIndex = 47
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(10, 309)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(90, 16)
        Me.Label16.TabIndex = 45
        Me.Label16.Text = "Account Name"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 10
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(-191, 45)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1656, 1)
        Me.Panel4.TabIndex = 93
        '
        'ChartofAccounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ChartofAccounts"
        Me.Size = New System.Drawing.Size(1275, 660)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Savebtn As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents Decriptiontxt As TextBox
    Friend WithEvents CategoryIDtxt As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents AccountCodetxt As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Accountnametxt As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents SubcategoryIDtxt As ComboBox
    Friend WithEvents AccountIDtxt As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Button1 As Button
    Friend WithEvents AddSubcategorybtn As Button
    Friend WithEvents AddCategorybtn As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Searchtxt As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Officetypetxt As ComboBox
    Friend WithEvents AssetIDTxt As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel4 As Panel
End Class
