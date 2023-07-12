<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Category
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.AssetIDtxt = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Cancelbtn = New System.Windows.Forms.Button()
        Me.CategoryDestxt = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Categorycodetxt = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Categorynametxt = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.CategoryIDtxt = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.AddCategorybtn = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.AssetIDtxt)
        Me.Panel1.Controls.Add(Me.Cancelbtn)
        Me.Panel1.Controls.Add(Me.CategoryDestxt)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Categorycodetxt)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Categorynametxt)
        Me.Panel1.Controls.Add(Me.CategoryIDtxt)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.AddCategorybtn)
        Me.Panel1.Location = New System.Drawing.Point(18, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(580, 397)
        Me.Panel1.TabIndex = 63
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
        Me.AssetIDtxt.Location = New System.Drawing.Point(21, 182)
        Me.AssetIDtxt.Margin = New System.Windows.Forms.Padding(4)
        Me.AssetIDtxt.MaxLength = 32767
        Me.AssetIDtxt.Name = "AssetIDtxt"
        Me.AssetIDtxt.Size = New System.Drawing.Size(254, 30)
        Me.AssetIDtxt.TabIndex = 90
        Me.AssetIDtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Cancelbtn
        '
        Me.Cancelbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Cancelbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancelbtn.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Cancelbtn.ForeColor = System.Drawing.Color.White
        Me.Cancelbtn.Location = New System.Drawing.Point(23, 333)
        Me.Cancelbtn.Name = "Cancelbtn"
        Me.Cancelbtn.Size = New System.Drawing.Size(252, 30)
        Me.Cancelbtn.TabIndex = 89
        Me.Cancelbtn.Text = "Cancel"
        Me.Cancelbtn.UseVisualStyleBackColor = False
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
        Me.CategoryDestxt.Location = New System.Drawing.Point(300, 104)
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
        Me.Label6.Location = New System.Drawing.Point(18, 158)
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
        Me.Categorycodetxt.Enabled = False
        Me.Categorycodetxt.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Categorycodetxt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Categorycodetxt.isPassword = False
        Me.Categorycodetxt.Location = New System.Drawing.Point(300, 261)
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
        Me.Label9.Location = New System.Drawing.Point(297, 238)
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
        Me.Label10.Location = New System.Drawing.Point(297, 80)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(126, 16)
        Me.Label10.TabIndex = 83
        Me.Label10.Text = "Category Description"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(224, 24)
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
        Me.Categorynametxt.Location = New System.Drawing.Point(21, 104)
        Me.Categorynametxt.Margin = New System.Windows.Forms.Padding(4)
        Me.Categorynametxt.MaxLength = 32767
        Me.Categorynametxt.Name = "Categorynametxt"
        Me.Categorynametxt.Size = New System.Drawing.Size(254, 30)
        Me.Categorynametxt.TabIndex = 68
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
        Me.CategoryIDtxt.Location = New System.Drawing.Point(21, 261)
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
        Me.Label18.Location = New System.Drawing.Point(18, 238)
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
        Me.Label4.Location = New System.Drawing.Point(18, 80)
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
        Me.AddCategorybtn.Location = New System.Drawing.Point(302, 333)
        Me.AddCategorybtn.Name = "AddCategorybtn"
        Me.AddCategorybtn.Size = New System.Drawing.Size(254, 30)
        Me.AddCategorybtn.TabIndex = 63
        Me.AddCategorybtn.Text = "Add"
        Me.AddCategorybtn.UseVisualStyleBackColor = False
        '
        'Category
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(615, 454)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Category"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Category"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents CategoryDestxt As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label6 As Label
    Friend WithEvents Categorycodetxt As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Categorynametxt As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents CategoryIDtxt As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents AddCategorybtn As Button
    Friend WithEvents Cancelbtn As Button
    Friend WithEvents AssetIDtxt As Bunifu.Framework.UI.BunifuMetroTextbox
End Class
