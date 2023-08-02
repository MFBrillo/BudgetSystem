<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AssetUC
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Cancelbtn = New System.Windows.Forms.Button()
        Me.Assettxt = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AssetDescrptiontxt = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AssetSavebtn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Searchtxt = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cancelbtn
        '
        Me.Cancelbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Cancelbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancelbtn.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Cancelbtn.ForeColor = System.Drawing.Color.White
        Me.Cancelbtn.Location = New System.Drawing.Point(25, 295)
        Me.Cancelbtn.Name = "Cancelbtn"
        Me.Cancelbtn.Size = New System.Drawing.Size(379, 30)
        Me.Cancelbtn.TabIndex = 80
        Me.Cancelbtn.Text = "Cancel"
        Me.Cancelbtn.UseVisualStyleBackColor = False
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
        Me.Assettxt.Location = New System.Drawing.Point(23, 165)
        Me.Assettxt.Margin = New System.Windows.Forms.Padding(4)
        Me.Assettxt.MaxLength = 32767
        Me.Assettxt.Name = "Assettxt"
        Me.Assettxt.Size = New System.Drawing.Size(381, 30)
        Me.Assettxt.TabIndex = 73
        Me.Assettxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(22, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 16)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "Asset Name"
        '
        'AssetDescrptiontxt
        '
        Me.AssetDescrptiontxt.BackColor = System.Drawing.Color.White
        Me.AssetDescrptiontxt.BorderColorFocused = System.Drawing.Color.Black
        Me.AssetDescrptiontxt.BorderColorIdle = System.Drawing.Color.White
        Me.AssetDescrptiontxt.BorderColorMouseHover = System.Drawing.Color.Black
        Me.AssetDescrptiontxt.BorderThickness = 1
        Me.AssetDescrptiontxt.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.AssetDescrptiontxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.AssetDescrptiontxt.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.AssetDescrptiontxt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.AssetDescrptiontxt.isPassword = False
        Me.AssetDescrptiontxt.Location = New System.Drawing.Point(25, 234)
        Me.AssetDescrptiontxt.Margin = New System.Windows.Forms.Padding(4)
        Me.AssetDescrptiontxt.MaxLength = 32767
        Me.AssetDescrptiontxt.Name = "AssetDescrptiontxt"
        Me.AssetDescrptiontxt.Size = New System.Drawing.Size(379, 30)
        Me.AssetDescrptiontxt.TabIndex = 72
        Me.AssetDescrptiontxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(22, 213)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 16)
        Me.Label3.TabIndex = 71
        Me.Label3.Text = "Asset Description"
        '
        'AssetSavebtn
        '
        Me.AssetSavebtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.AssetSavebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AssetSavebtn.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.AssetSavebtn.ForeColor = System.Drawing.Color.White
        Me.AssetSavebtn.Location = New System.Drawing.Point(25, 355)
        Me.AssetSavebtn.Name = "AssetSavebtn"
        Me.AssetSavebtn.Size = New System.Drawing.Size(379, 30)
        Me.AssetSavebtn.TabIndex = 70
        Me.AssetSavebtn.Text = "Save"
        Me.AssetSavebtn.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Assettxt)
        Me.Panel1.Controls.Add(Me.Cancelbtn)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.AssetDescrptiontxt)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.AssetSavebtn)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(789, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(431, 791)
        Me.Panel1.TabIndex = 81
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(42, 415)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 85
        Me.Button2.Text = "Load"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(42, 456)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 84
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
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
        Me.Searchtxt.Location = New System.Drawing.Point(15, 11)
        Me.Searchtxt.Margin = New System.Windows.Forms.Padding(4)
        Me.Searchtxt.MaxLength = 32767
        Me.Searchtxt.Name = "Searchtxt"
        Me.Searchtxt.Size = New System.Drawing.Size(693, 44)
        Me.Searchtxt.TabIndex = 83
        Me.Searchtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.Searchtxt)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(789, 63)
        Me.Panel2.TabIndex = 82
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.DataGridView1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 63)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(789, 728)
        Me.Panel3.TabIndex = 83
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGray
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.Color.White
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 35
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(789, 728)
        Me.DataGridView1.TabIndex = 0
        '
        'AssetUC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "AssetUC"
        Me.Size = New System.Drawing.Size(1220, 791)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Cancelbtn As Button
    Friend WithEvents Assettxt As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label2 As Label
    Friend WithEvents AssetDescrptiontxt As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label3 As Label
    Friend WithEvents AssetSavebtn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Searchtxt As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
