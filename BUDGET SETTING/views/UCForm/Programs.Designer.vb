<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Programs
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.sectoridtxt = New System.Windows.Forms.Label()
        Me.officeidtxt = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Officetxt = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Subsectoridcbb = New System.Windows.Forms.ComboBox()
        Me.Sectoridcbb = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Programdescriptiontxt = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Programnametxt = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Programcodetxt = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Progidtxt = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Programidtxt = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Descriptionbtn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Searchtxt = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.AccountIDtxt = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Subsectoridtxt = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1319, 50)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "PROGRAM"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 50)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(457, 810)
        Me.Panel2.TabIndex = 75
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Panel5.Controls.Add(Me.Subsectoridtxt)
        Me.Panel5.Controls.Add(Me.sectoridtxt)
        Me.Panel5.Controls.Add(Me.officeidtxt)
        Me.Panel5.Controls.Add(Me.DataGridView2)
        Me.Panel5.Controls.Add(Me.Officetxt)
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.Controls.Add(Me.Subsectoridcbb)
        Me.Panel5.Controls.Add(Me.Sectoridcbb)
        Me.Panel5.Controls.Add(Me.Button1)
        Me.Panel5.Controls.Add(Me.Label7)
        Me.Panel5.Controls.Add(Me.Programdescriptiontxt)
        Me.Panel5.Controls.Add(Me.Label8)
        Me.Panel5.Controls.Add(Me.Programnametxt)
        Me.Panel5.Controls.Add(Me.Label10)
        Me.Panel5.Controls.Add(Me.Programcodetxt)
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(Me.Progidtxt)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Controls.Add(Me.Label15)
        Me.Panel5.Controls.Add(Me.Programidtxt)
        Me.Panel5.Location = New System.Drawing.Point(18, 14)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(420, 770)
        Me.Panel5.TabIndex = 74
        '
        'sectoridtxt
        '
        Me.sectoridtxt.AutoSize = True
        Me.sectoridtxt.Location = New System.Drawing.Point(40, 626)
        Me.sectoridtxt.Name = "sectoridtxt"
        Me.sectoridtxt.Size = New System.Drawing.Size(46, 13)
        Me.sectoridtxt.TabIndex = 153
        Me.sectoridtxt.Text = "Sectorid"
        '
        'officeidtxt
        '
        Me.officeidtxt.AutoSize = True
        Me.officeidtxt.Location = New System.Drawing.Point(40, 602)
        Me.officeidtxt.Name = "officeidtxt"
        Me.officeidtxt.Size = New System.Drawing.Size(43, 13)
        Me.officeidtxt.TabIndex = 152
        Me.officeidtxt.Text = "Officeid"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToResizeColumns = False
        Me.DataGridView2.AllowUserToResizeRows = False
        Me.DataGridView2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.ColumnHeadersVisible = False
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(56, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Coral
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView2.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView2.EnableHeadersVisualStyles = False
        Me.DataGridView2.Location = New System.Drawing.Point(110, 74)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(56, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView2.RowHeadersVisible = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(56, Byte), Integer))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.DataGridView2.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(359, 351)
        Me.DataGridView2.TabIndex = 75
        Me.DataGridView2.Visible = False
        '
        'Officetxt
        '
        Me.Officetxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Officetxt.BorderColorFocused = System.Drawing.Color.White
        Me.Officetxt.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Officetxt.BorderColorMouseHover = System.Drawing.Color.White
        Me.Officetxt.BorderThickness = 1
        Me.Officetxt.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.Officetxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Officetxt.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Officetxt.ForeColor = System.Drawing.Color.Gainsboro
        Me.Officetxt.isPassword = False
        Me.Officetxt.Location = New System.Drawing.Point(33, 39)
        Me.Officetxt.Margin = New System.Windows.Forms.Padding(4)
        Me.Officetxt.MaxLength = 32767
        Me.Officetxt.Name = "Officetxt"
        Me.Officetxt.Size = New System.Drawing.Size(369, 28)
        Me.Officetxt.TabIndex = 151
        Me.Officetxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(31, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 16)
        Me.Label6.TabIndex = 150
        Me.Label6.Text = "Office"
        '
        'Subsectoridcbb
        '
        Me.Subsectoridcbb.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Subsectoridcbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Subsectoridcbb.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Subsectoridcbb.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Subsectoridcbb.ForeColor = System.Drawing.Color.White
        Me.Subsectoridcbb.FormattingEnabled = True
        Me.Subsectoridcbb.Location = New System.Drawing.Point(33, 297)
        Me.Subsectoridcbb.Name = "Subsectoridcbb"
        Me.Subsectoridcbb.Size = New System.Drawing.Size(359, 22)
        Me.Subsectoridcbb.TabIndex = 148
        '
        'Sectoridcbb
        '
        Me.Sectoridcbb.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Sectoridcbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Sectoridcbb.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Sectoridcbb.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sectoridcbb.ForeColor = System.Drawing.Color.White
        Me.Sectoridcbb.FormattingEnabled = True
        Me.Sectoridcbb.Location = New System.Drawing.Point(34, 237)
        Me.Sectoridcbb.Name = "Sectoridcbb"
        Me.Sectoridcbb.Size = New System.Drawing.Size(359, 22)
        Me.Sectoridcbb.TabIndex = 117
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(31, 525)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(357, 30)
        Me.Button1.TabIndex = 147
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(32, 457)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(119, 16)
        Me.Label7.TabIndex = 143
        Me.Label7.Text = "programdescription"
        '
        'Programdescriptiontxt
        '
        Me.Programdescriptiontxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Programdescriptiontxt.BorderColorFocused = System.Drawing.Color.White
        Me.Programdescriptiontxt.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Programdescriptiontxt.BorderColorMouseHover = System.Drawing.Color.White
        Me.Programdescriptiontxt.BorderThickness = 1
        Me.Programdescriptiontxt.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.Programdescriptiontxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Programdescriptiontxt.Enabled = False
        Me.Programdescriptiontxt.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Programdescriptiontxt.ForeColor = System.Drawing.Color.Gainsboro
        Me.Programdescriptiontxt.isPassword = False
        Me.Programdescriptiontxt.Location = New System.Drawing.Point(33, 479)
        Me.Programdescriptiontxt.Margin = New System.Windows.Forms.Padding(4)
        Me.Programdescriptiontxt.MaxLength = 32767
        Me.Programdescriptiontxt.Name = "Programdescriptiontxt"
        Me.Programdescriptiontxt.Size = New System.Drawing.Size(361, 28)
        Me.Programdescriptiontxt.TabIndex = 144
        Me.Programdescriptiontxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(30, 395)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 16)
        Me.Label8.TabIndex = 141
        Me.Label8.Text = "programname"
        '
        'Programnametxt
        '
        Me.Programnametxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Programnametxt.BorderColorFocused = System.Drawing.Color.White
        Me.Programnametxt.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Programnametxt.BorderColorMouseHover = System.Drawing.Color.White
        Me.Programnametxt.BorderThickness = 1
        Me.Programnametxt.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.Programnametxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Programnametxt.Enabled = False
        Me.Programnametxt.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Programnametxt.ForeColor = System.Drawing.Color.Gainsboro
        Me.Programnametxt.isPassword = False
        Me.Programnametxt.Location = New System.Drawing.Point(32, 417)
        Me.Programnametxt.Margin = New System.Windows.Forms.Padding(4)
        Me.Programnametxt.MaxLength = 32767
        Me.Programnametxt.Name = "Programnametxt"
        Me.Programnametxt.Size = New System.Drawing.Size(361, 28)
        Me.Programnametxt.TabIndex = 142
        Me.Programnametxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(29, 334)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 16)
        Me.Label10.TabIndex = 137
        Me.Label10.Text = "programcode"
        '
        'Programcodetxt
        '
        Me.Programcodetxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Programcodetxt.BorderColorFocused = System.Drawing.Color.White
        Me.Programcodetxt.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Programcodetxt.BorderColorMouseHover = System.Drawing.Color.White
        Me.Programcodetxt.BorderThickness = 1
        Me.Programcodetxt.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.Programcodetxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Programcodetxt.Enabled = False
        Me.Programcodetxt.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Programcodetxt.ForeColor = System.Drawing.Color.Gainsboro
        Me.Programcodetxt.isPassword = False
        Me.Programcodetxt.Location = New System.Drawing.Point(34, 354)
        Me.Programcodetxt.Margin = New System.Windows.Forms.Padding(4)
        Me.Programcodetxt.MaxLength = 32767
        Me.Programcodetxt.Name = "Programcodetxt"
        Me.Programcodetxt.Size = New System.Drawing.Size(361, 28)
        Me.Programcodetxt.TabIndex = 138
        Me.Programcodetxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(31, 270)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 16)
        Me.Label5.TabIndex = 131
        Me.Label5.Text = "subsectorid"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(33, 209)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 16)
        Me.Label4.TabIndex = 129
        Me.Label4.Text = "sectorid"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label3.ForeColor = System.Drawing.Color.DarkRed
        Me.Label3.Location = New System.Drawing.Point(32, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 16)
        Me.Label3.TabIndex = 127
        Me.Label3.Text = "progid"
        '
        'Progidtxt
        '
        Me.Progidtxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Progidtxt.BorderColorFocused = System.Drawing.Color.White
        Me.Progidtxt.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Progidtxt.BorderColorMouseHover = System.Drawing.Color.White
        Me.Progidtxt.BorderThickness = 1
        Me.Progidtxt.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.Progidtxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Progidtxt.Enabled = False
        Me.Progidtxt.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Progidtxt.ForeColor = System.Drawing.Color.Gainsboro
        Me.Progidtxt.isPassword = False
        Me.Progidtxt.Location = New System.Drawing.Point(33, 172)
        Me.Progidtxt.Margin = New System.Windows.Forms.Padding(4)
        Me.Progidtxt.MaxLength = 32767
        Me.Progidtxt.Name = "Progidtxt"
        Me.Progidtxt.Size = New System.Drawing.Size(361, 28)
        Me.Progidtxt.TabIndex = 128
        Me.Progidtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(189, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 19)
        Me.Label2.TabIndex = 126
        Me.Label2.Text = "ADD"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label15.ForeColor = System.Drawing.Color.DarkRed
        Me.Label15.Location = New System.Drawing.Point(32, 79)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(67, 16)
        Me.Label15.TabIndex = 65
        Me.Label15.Text = "programid"
        '
        'Programidtxt
        '
        Me.Programidtxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Programidtxt.BorderColorFocused = System.Drawing.Color.White
        Me.Programidtxt.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Programidtxt.BorderColorMouseHover = System.Drawing.Color.White
        Me.Programidtxt.BorderThickness = 1
        Me.Programidtxt.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.Programidtxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Programidtxt.Enabled = False
        Me.Programidtxt.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Programidtxt.ForeColor = System.Drawing.Color.Gainsboro
        Me.Programidtxt.isPassword = False
        Me.Programidtxt.Location = New System.Drawing.Point(33, 103)
        Me.Programidtxt.Margin = New System.Windows.Forms.Padding(4)
        Me.Programidtxt.MaxLength = 32767
        Me.Programidtxt.Name = "Programidtxt"
        Me.Programidtxt.Size = New System.Drawing.Size(361, 28)
        Me.Programidtxt.TabIndex = 68
        Me.Programidtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Panel3.Controls.Add(Me.DataGridView1)
        Me.Panel3.Controls.Add(Me.Panel1)
        Me.Panel3.Controls.Add(Me.AccountIDtxt)
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(457, 50)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(862, 810)
        Me.Panel3.TabIndex = 76
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
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(56, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Coral
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(11, 66)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(56, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(56, Byte), Integer))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(840, 744)
        Me.DataGridView1.TabIndex = 74
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Descriptionbtn)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Searchtxt)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(862, 46)
        Me.Panel1.TabIndex = 73
        '
        'Descriptionbtn
        '
        Me.Descriptionbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.Descriptionbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Descriptionbtn.ForeColor = System.Drawing.Color.White
        Me.Descriptionbtn.Location = New System.Drawing.Point(524, 10)
        Me.Descriptionbtn.Name = "Descriptionbtn"
        Me.Descriptionbtn.Size = New System.Drawing.Size(113, 30)
        Me.Descriptionbtn.TabIndex = 126
        Me.Descriptionbtn.Text = "Add Description"
        Me.Descriptionbtn.UseVisualStyleBackColor = False
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
        Me.Searchtxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Searchtxt.BorderColorFocused = System.Drawing.Color.White
        Me.Searchtxt.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Searchtxt.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Searchtxt.BorderThickness = 1
        Me.Searchtxt.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.Searchtxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Searchtxt.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Searchtxt.ForeColor = System.Drawing.Color.White
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
        'Subsectoridtxt
        '
        Me.Subsectoridtxt.AutoSize = True
        Me.Subsectoridtxt.Location = New System.Drawing.Point(40, 652)
        Me.Subsectoridtxt.Name = "Subsectoridtxt"
        Me.Subsectoridtxt.Size = New System.Drawing.Size(63, 13)
        Me.Subsectoridtxt.TabIndex = 154
        Me.Subsectoridtxt.Text = "Subsectorid"
        '
        'Programs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.Coral
        Me.Name = "Programs"
        Me.Size = New System.Drawing.Size(1319, 860)
        Me.Panel2.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Programidtxt As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Searchtxt As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents AccountIDtxt As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Programdescriptiontxt As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label8 As Label
    Friend WithEvents Programnametxt As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label10 As Label
    Friend WithEvents Programcodetxt As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Progidtxt As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Button1 As Button
    Friend WithEvents Descriptionbtn As Button
    Friend WithEvents Subsectoridcbb As ComboBox
    Friend WithEvents Sectoridcbb As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Officetxt As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents officeidtxt As Label
    Friend WithEvents sectoridtxt As Label
    Friend WithEvents Subsectoridtxt As Label
End Class
