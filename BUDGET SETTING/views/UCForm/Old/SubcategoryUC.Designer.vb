<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SubcategoryUC
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Searchtxt = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.AssetAddbtn = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.SubcategoryCodetxt = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.SubcategoryDestxt = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.BunifuMetroTextbox2 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuMetroTextbox1 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Subcategorynametxt = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.SubcategoryIDtxt = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(763, 791)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.Searchtxt)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(763, 63)
        Me.Panel2.TabIndex = 84
        '
        'Searchtxt
        '
        Me.Searchtxt.BackColor = System.Drawing.Color.White
        Me.Searchtxt.BorderColorFocused = System.Drawing.Color.Blue
        Me.Searchtxt.BorderColorIdle = System.Drawing.Color.Gray
        Me.Searchtxt.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.Searchtxt.BorderThickness = 1
        Me.Searchtxt.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.Searchtxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Searchtxt.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Searchtxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Searchtxt.isPassword = False
        Me.Searchtxt.Location = New System.Drawing.Point(8, 12)
        Me.Searchtxt.Margin = New System.Windows.Forms.Padding(4)
        Me.Searchtxt.MaxLength = 32767
        Me.Searchtxt.Name = "Searchtxt"
        Me.Searchtxt.Size = New System.Drawing.Size(693, 44)
        Me.Searchtxt.TabIndex = 83
        Me.Searchtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.GridColor = System.Drawing.Color.White
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 35
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(763, 791)
        Me.DataGridView1.TabIndex = 83
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(822, 519)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(338, 30)
        Me.Button4.TabIndex = 128
        Me.Button4.Text = "Edit"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(822, 638)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(340, 30)
        Me.Button5.TabIndex = 129
        Me.Button5.Text = "Cancel"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'AssetAddbtn
        '
        Me.AssetAddbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.AssetAddbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AssetAddbtn.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.AssetAddbtn.ForeColor = System.Drawing.Color.White
        Me.AssetAddbtn.Location = New System.Drawing.Point(822, 578)
        Me.AssetAddbtn.Name = "AssetAddbtn"
        Me.AssetAddbtn.Size = New System.Drawing.Size(340, 30)
        Me.AssetAddbtn.TabIndex = 127
        Me.AssetAddbtn.Text = "Save"
        Me.AssetAddbtn.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label14.Location = New System.Drawing.Point(822, 127)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(75, 16)
        Me.Label14.TabIndex = 126
        Me.Label14.Text = "Category ID"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label15.Location = New System.Drawing.Point(819, 278)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(112, 16)
        Me.Label15.TabIndex = 124
        Me.Label15.Text = "Subcategory Code"
        '
        'SubcategoryCodetxt
        '
        Me.SubcategoryCodetxt.BackColor = System.Drawing.Color.White
        Me.SubcategoryCodetxt.BorderColorFocused = System.Drawing.Color.Black
        Me.SubcategoryCodetxt.BorderColorIdle = System.Drawing.Color.White
        Me.SubcategoryCodetxt.BorderColorMouseHover = System.Drawing.Color.Black
        Me.SubcategoryCodetxt.BorderThickness = 1
        Me.SubcategoryCodetxt.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.SubcategoryCodetxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SubcategoryCodetxt.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.SubcategoryCodetxt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.SubcategoryCodetxt.isPassword = False
        Me.SubcategoryCodetxt.Location = New System.Drawing.Point(822, 298)
        Me.SubcategoryCodetxt.Margin = New System.Windows.Forms.Padding(4)
        Me.SubcategoryCodetxt.MaxLength = 32767
        Me.SubcategoryCodetxt.Name = "SubcategoryCodetxt"
        Me.SubcategoryCodetxt.Size = New System.Drawing.Size(337, 30)
        Me.SubcategoryCodetxt.TabIndex = 125
        Me.SubcategoryCodetxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'SubcategoryDestxt
        '
        Me.SubcategoryDestxt.BackColor = System.Drawing.Color.White
        Me.SubcategoryDestxt.BorderColorFocused = System.Drawing.Color.Black
        Me.SubcategoryDestxt.BorderColorIdle = System.Drawing.Color.White
        Me.SubcategoryDestxt.BorderColorMouseHover = System.Drawing.Color.Black
        Me.SubcategoryDestxt.BorderThickness = 1
        Me.SubcategoryDestxt.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.SubcategoryDestxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SubcategoryDestxt.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.SubcategoryDestxt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.SubcategoryDestxt.isPassword = False
        Me.SubcategoryDestxt.Location = New System.Drawing.Point(822, 372)
        Me.SubcategoryDestxt.Margin = New System.Windows.Forms.Padding(4)
        Me.SubcategoryDestxt.MaxLength = 32767
        Me.SubcategoryDestxt.Name = "SubcategoryDestxt"
        Me.SubcategoryDestxt.Size = New System.Drawing.Size(337, 30)
        Me.SubcategoryDestxt.TabIndex = 123
        Me.SubcategoryDestxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label16.Location = New System.Drawing.Point(822, 352)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(183, 16)
        Me.Label16.TabIndex = 122
        Me.Label16.Text = "Subcategory Name Description"
        '
        'BunifuMetroTextbox2
        '
        Me.BunifuMetroTextbox2.BackColor = System.Drawing.Color.White
        Me.BunifuMetroTextbox2.BorderColorFocused = System.Drawing.Color.Black
        Me.BunifuMetroTextbox2.BorderColorIdle = System.Drawing.Color.White
        Me.BunifuMetroTextbox2.BorderColorMouseHover = System.Drawing.Color.Black
        Me.BunifuMetroTextbox2.BorderThickness = 1
        Me.BunifuMetroTextbox2.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.BunifuMetroTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMetroTextbox2.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.BunifuMetroTextbox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BunifuMetroTextbox2.isPassword = False
        Me.BunifuMetroTextbox2.Location = New System.Drawing.Point(822, 147)
        Me.BunifuMetroTextbox2.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMetroTextbox2.MaxLength = 32767
        Me.BunifuMetroTextbox2.Name = "BunifuMetroTextbox2"
        Me.BunifuMetroTextbox2.Size = New System.Drawing.Size(337, 30)
        Me.BunifuMetroTextbox2.TabIndex = 121
        Me.BunifuMetroTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuMetroTextbox1
        '
        Me.BunifuMetroTextbox1.BackColor = System.Drawing.Color.White
        Me.BunifuMetroTextbox1.BorderColorFocused = System.Drawing.Color.Black
        Me.BunifuMetroTextbox1.BorderColorIdle = System.Drawing.Color.White
        Me.BunifuMetroTextbox1.BorderColorMouseHover = System.Drawing.Color.Black
        Me.BunifuMetroTextbox1.BorderThickness = 1
        Me.BunifuMetroTextbox1.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.BunifuMetroTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMetroTextbox1.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.BunifuMetroTextbox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BunifuMetroTextbox1.isPassword = False
        Me.BunifuMetroTextbox1.Location = New System.Drawing.Point(822, 75)
        Me.BunifuMetroTextbox1.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMetroTextbox1.MaxLength = 32767
        Me.BunifuMetroTextbox1.Name = "BunifuMetroTextbox1"
        Me.BunifuMetroTextbox1.Size = New System.Drawing.Size(337, 30)
        Me.BunifuMetroTextbox1.TabIndex = 120
        Me.BunifuMetroTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Subcategorynametxt
        '
        Me.Subcategorynametxt.BackColor = System.Drawing.Color.White
        Me.Subcategorynametxt.BorderColorFocused = System.Drawing.Color.Black
        Me.Subcategorynametxt.BorderColorIdle = System.Drawing.Color.White
        Me.Subcategorynametxt.BorderColorMouseHover = System.Drawing.Color.Black
        Me.Subcategorynametxt.BorderThickness = 1
        Me.Subcategorynametxt.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.Subcategorynametxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Subcategorynametxt.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Subcategorynametxt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Subcategorynametxt.isPassword = False
        Me.Subcategorynametxt.Location = New System.Drawing.Point(822, 448)
        Me.Subcategorynametxt.Margin = New System.Windows.Forms.Padding(4)
        Me.Subcategorynametxt.MaxLength = 32767
        Me.Subcategorynametxt.Name = "Subcategorynametxt"
        Me.Subcategorynametxt.Size = New System.Drawing.Size(337, 30)
        Me.Subcategorynametxt.TabIndex = 119
        Me.Subcategorynametxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Location = New System.Drawing.Point(825, 203)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(95, 16)
        Me.Label11.TabIndex = 115
        Me.Label11.Text = "Subcategory ID"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label12.Location = New System.Drawing.Point(825, 429)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(116, 16)
        Me.Label12.TabIndex = 118
        Me.Label12.Text = "Subcategory Name"
        '
        'SubcategoryIDtxt
        '
        Me.SubcategoryIDtxt.BackColor = System.Drawing.Color.White
        Me.SubcategoryIDtxt.BorderColorFocused = System.Drawing.Color.Black
        Me.SubcategoryIDtxt.BorderColorIdle = System.Drawing.Color.White
        Me.SubcategoryIDtxt.BorderColorMouseHover = System.Drawing.Color.Black
        Me.SubcategoryIDtxt.BorderThickness = 1
        Me.SubcategoryIDtxt.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.SubcategoryIDtxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SubcategoryIDtxt.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.SubcategoryIDtxt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.SubcategoryIDtxt.isPassword = False
        Me.SubcategoryIDtxt.Location = New System.Drawing.Point(822, 223)
        Me.SubcategoryIDtxt.Margin = New System.Windows.Forms.Padding(4)
        Me.SubcategoryIDtxt.MaxLength = 32767
        Me.SubcategoryIDtxt.Name = "SubcategoryIDtxt"
        Me.SubcategoryIDtxt.Size = New System.Drawing.Size(337, 30)
        Me.SubcategoryIDtxt.TabIndex = 116
        Me.SubcategoryIDtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label13.Location = New System.Drawing.Point(827, 55)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(55, 16)
        Me.Label13.TabIndex = 117
        Me.Label13.Text = "Asset ID"
        '
        'SubcategoryUC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.AssetAddbtn)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.SubcategoryCodetxt)
        Me.Controls.Add(Me.SubcategoryDestxt)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.BunifuMetroTextbox2)
        Me.Controls.Add(Me.BunifuMetroTextbox1)
        Me.Controls.Add(Me.Subcategorynametxt)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.SubcategoryIDtxt)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "SubcategoryUC"
        Me.Size = New System.Drawing.Size(1220, 791)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents AssetAddbtn As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents SubcategoryCodetxt As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents SubcategoryDestxt As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label16 As Label
    Friend WithEvents BunifuMetroTextbox2 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuMetroTextbox1 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Subcategorynametxt As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents SubcategoryIDtxt As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label13 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Searchtxt As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents DataGridView1 As DataGridView
End Class
