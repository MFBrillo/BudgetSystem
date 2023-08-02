<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CategoryUC
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
        Me.Searchtxt = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.AddCategorybtn = New System.Windows.Forms.Button()
        Me.Categorycodetxt = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CategoryDestxt = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.AssetIDtxt = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Categorynametxt = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.CategoryIDtxt = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Searchtxt.Location = New System.Drawing.Point(23, 14)
        Me.Searchtxt.Margin = New System.Windows.Forms.Padding(4)
        Me.Searchtxt.MaxLength = 32767
        Me.Searchtxt.Name = "Searchtxt"
        Me.Searchtxt.Size = New System.Drawing.Size(693, 44)
        Me.Searchtxt.TabIndex = 83
        Me.Searchtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(43, 431)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(337, 30)
        Me.Button2.TabIndex = 115
        Me.Button2.Text = "Edit"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(43, 552)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(335, 30)
        Me.Button3.TabIndex = 116
        Me.Button3.Text = "Cancel"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'AddCategorybtn
        '
        Me.AddCategorybtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.AddCategorybtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddCategorybtn.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.AddCategorybtn.ForeColor = System.Drawing.Color.White
        Me.AddCategorybtn.Location = New System.Drawing.Point(43, 490)
        Me.AddCategorybtn.Name = "AddCategorybtn"
        Me.AddCategorybtn.Size = New System.Drawing.Size(337, 30)
        Me.AddCategorybtn.TabIndex = 114
        Me.AddCategorybtn.Text = "Add"
        Me.AddCategorybtn.UseVisualStyleBackColor = False
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
        Me.Categorycodetxt.Enabled = False
        Me.Categorycodetxt.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Categorycodetxt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Categorycodetxt.isPassword = False
        Me.Categorycodetxt.Location = New System.Drawing.Point(43, 366)
        Me.Categorycodetxt.Margin = New System.Windows.Forms.Padding(4)
        Me.Categorycodetxt.MaxLength = 32767
        Me.Categorycodetxt.Name = "Categorycodetxt"
        Me.Categorycodetxt.Size = New System.Drawing.Size(337, 30)
        Me.Categorycodetxt.TabIndex = 113
        Me.Categorycodetxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(40, 342)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 16)
        Me.Label9.TabIndex = 112
        Me.Label9.Text = "Category Code"
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
        Me.CategoryDestxt.Location = New System.Drawing.Point(43, 291)
        Me.CategoryDestxt.Margin = New System.Windows.Forms.Padding(4)
        Me.CategoryDestxt.MaxLength = 32767
        Me.CategoryDestxt.Name = "CategoryDestxt"
        Me.CategoryDestxt.Size = New System.Drawing.Size(337, 30)
        Me.CategoryDestxt.TabIndex = 111
        Me.CategoryDestxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label10.Location = New System.Drawing.Point(40, 267)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(126, 16)
        Me.Label10.TabIndex = 110
        Me.Label10.Text = "Category Description"
        '
        'AssetIDtxt
        '
        Me.AssetIDtxt.BackColor = System.Drawing.Color.White
        Me.AssetIDtxt.BorderColorFocused = System.Drawing.Color.Black
        Me.AssetIDtxt.BorderColorIdle = System.Drawing.Color.White
        Me.AssetIDtxt.BorderColorMouseHover = System.Drawing.Color.Black
        Me.AssetIDtxt.BorderThickness = 1
        Me.AssetIDtxt.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.AssetIDtxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.AssetIDtxt.Enabled = False
        Me.AssetIDtxt.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.AssetIDtxt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.AssetIDtxt.isPassword = False
        Me.AssetIDtxt.Location = New System.Drawing.Point(43, 147)
        Me.AssetIDtxt.Margin = New System.Windows.Forms.Padding(4)
        Me.AssetIDtxt.MaxLength = 32767
        Me.AssetIDtxt.Name = "AssetIDtxt"
        Me.AssetIDtxt.Size = New System.Drawing.Size(337, 30)
        Me.AssetIDtxt.TabIndex = 109
        Me.AssetIDtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(40, 124)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 16)
        Me.Label7.TabIndex = 108
        Me.Label7.Text = "Asset ID"
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
        Me.Categorynametxt.Location = New System.Drawing.Point(43, 79)
        Me.Categorynametxt.Margin = New System.Windows.Forms.Padding(4)
        Me.Categorynametxt.MaxLength = 32767
        Me.Categorynametxt.Name = "Categorynametxt"
        Me.Categorynametxt.Size = New System.Drawing.Size(337, 30)
        Me.Categorynametxt.TabIndex = 107
        Me.Categorynametxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
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
        Me.CategoryIDtxt.Enabled = False
        Me.CategoryIDtxt.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.CategoryIDtxt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CategoryIDtxt.isPassword = False
        Me.CategoryIDtxt.Location = New System.Drawing.Point(43, 218)
        Me.CategoryIDtxt.Margin = New System.Windows.Forms.Padding(4)
        Me.CategoryIDtxt.MaxLength = 32767
        Me.CategoryIDtxt.Name = "CategoryIDtxt"
        Me.CategoryIDtxt.Size = New System.Drawing.Size(337, 30)
        Me.CategoryIDtxt.TabIndex = 105
        Me.CategoryIDtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label18.Location = New System.Drawing.Point(40, 196)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(75, 16)
        Me.Label18.TabIndex = 104
        Me.Label18.Text = "Category ID"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(40, 56)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 16)
        Me.Label8.TabIndex = 106
        Me.Label8.Text = "Category Name"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.Categorynametxt)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.CategoryIDtxt)
        Me.Panel1.Controls.Add(Me.AddCategorybtn)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Categorycodetxt)
        Me.Panel1.Controls.Add(Me.AssetIDtxt)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.CategoryDestxt)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(810, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(410, 791)
        Me.Panel1.TabIndex = 117
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.Searchtxt)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(810, 72)
        Me.Panel2.TabIndex = 118
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.DataGridView1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(0, 72)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(810, 719)
        Me.Panel3.TabIndex = 119
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
        Me.DataGridView1.Size = New System.Drawing.Size(810, 719)
        Me.DataGridView1.TabIndex = 1
        '
        'CategoryUC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "CategoryUC"
        Me.Size = New System.Drawing.Size(1220, 791)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents AddCategorybtn As Button
    Friend WithEvents Categorycodetxt As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label9 As Label
    Friend WithEvents CategoryDestxt As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label10 As Label
    Friend WithEvents AssetIDtxt As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label7 As Label
    Friend WithEvents Categorynametxt As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents CategoryIDtxt As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Searchtxt As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents DataGridView1 As DataGridView
End Class
