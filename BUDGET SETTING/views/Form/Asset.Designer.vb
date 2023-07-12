<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Asset
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
        Me.Cancelbtn = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Assettxt = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AssetDescrptiontxt = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AssetAddbtn = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.Cancelbtn)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Assettxt)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.AssetDescrptiontxt)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.AssetAddbtn)
        Me.Panel1.Location = New System.Drawing.Point(13, 18)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(490, 323)
        Me.Panel1.TabIndex = 62
        '
        'Cancelbtn
        '
        Me.Cancelbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Cancelbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancelbtn.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Cancelbtn.ForeColor = System.Drawing.Color.White
        Me.Cancelbtn.Location = New System.Drawing.Point(22, 252)
        Me.Cancelbtn.Name = "Cancelbtn"
        Me.Cancelbtn.Size = New System.Drawing.Size(216, 30)
        Me.Cancelbtn.TabIndex = 79
        Me.Cancelbtn.Text = "Cancel"
        Me.Cancelbtn.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(198, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 24)
        Me.Label8.TabIndex = 78
        Me.Label8.Text = "ASSETS"
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
        Me.Assettxt.Location = New System.Drawing.Point(22, 94)
        Me.Assettxt.Margin = New System.Windows.Forms.Padding(4)
        Me.Assettxt.MaxLength = 32767
        Me.Assettxt.Name = "Assettxt"
        Me.Assettxt.Size = New System.Drawing.Size(438, 30)
        Me.Assettxt.TabIndex = 73
        Me.Assettxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(21, 74)
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
        Me.AssetDescrptiontxt.Location = New System.Drawing.Point(24, 165)
        Me.AssetDescrptiontxt.Margin = New System.Windows.Forms.Padding(4)
        Me.AssetDescrptiontxt.MaxLength = 32767
        Me.AssetDescrptiontxt.Name = "AssetDescrptiontxt"
        Me.AssetDescrptiontxt.Size = New System.Drawing.Size(436, 30)
        Me.AssetDescrptiontxt.TabIndex = 72
        Me.AssetDescrptiontxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(21, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 16)
        Me.Label3.TabIndex = 71
        Me.Label3.Text = "Asset Description"
        '
        'AssetAddbtn
        '
        Me.AssetAddbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.AssetAddbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AssetAddbtn.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.AssetAddbtn.ForeColor = System.Drawing.Color.White
        Me.AssetAddbtn.Location = New System.Drawing.Point(244, 252)
        Me.AssetAddbtn.Name = "AssetAddbtn"
        Me.AssetAddbtn.Size = New System.Drawing.Size(216, 30)
        Me.AssetAddbtn.TabIndex = 70
        Me.AssetAddbtn.Text = "Add"
        Me.AssetAddbtn.UseVisualStyleBackColor = False
        '
        'Asset
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(518, 362)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Asset"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Asset"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Cancelbtn As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Assettxt As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label2 As Label
    Friend WithEvents AssetDescrptiontxt As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label3 As Label
    Friend WithEvents AssetAddbtn As Button
End Class
