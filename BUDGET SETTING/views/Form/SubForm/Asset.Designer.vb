<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Asset
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
        Me.Cancelbtn = New System.Windows.Forms.Button()
        Me.Assettxt = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AssetSavebtn = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AssetDescrptiontxt = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Cancelbtn
        '
        Me.Cancelbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Cancelbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancelbtn.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Cancelbtn.ForeColor = System.Drawing.Color.White
        Me.Cancelbtn.Location = New System.Drawing.Point(48, 229)
        Me.Cancelbtn.Name = "Cancelbtn"
        Me.Cancelbtn.Size = New System.Drawing.Size(216, 29)
        Me.Cancelbtn.TabIndex = 79
        Me.Cancelbtn.Text = "Cancel"
        Me.Cancelbtn.UseVisualStyleBackColor = False
        '
        'Assettxt
        '
        Me.Assettxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Assettxt.BorderColorFocused = System.Drawing.Color.White
        Me.Assettxt.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Assettxt.BorderColorMouseHover = System.Drawing.Color.White
        Me.Assettxt.BorderThickness = 1
        Me.Assettxt.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.Assettxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Assettxt.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Assettxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Assettxt.isPassword = False
        Me.Assettxt.Location = New System.Drawing.Point(196, 29)
        Me.Assettxt.Margin = New System.Windows.Forms.Padding(4)
        Me.Assettxt.MaxLength = 32767
        Me.Assettxt.Name = "Assettxt"
        Me.Assettxt.Size = New System.Drawing.Size(313, 30)
        Me.Assettxt.TabIndex = 73
        Me.Assettxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(47, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 16)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "Asset Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(47, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 16)
        Me.Label3.TabIndex = 71
        Me.Label3.Text = "Asset Description"
        '
        'AssetSavebtn
        '
        Me.AssetSavebtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.AssetSavebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AssetSavebtn.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.AssetSavebtn.ForeColor = System.Drawing.Color.White
        Me.AssetSavebtn.Location = New System.Drawing.Point(293, 229)
        Me.AssetSavebtn.Name = "AssetSavebtn"
        Me.AssetSavebtn.Size = New System.Drawing.Size(216, 29)
        Me.AssetSavebtn.TabIndex = 70
        Me.AssetSavebtn.Text = "Save"
        Me.AssetSavebtn.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(580, 41)
        Me.Panel2.TabIndex = 119
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 19)
        Me.Label1.TabIndex = 125
        Me.Label1.Text = "ADD ASSETS"
        '
        'AssetDescrptiontxt
        '
        Me.AssetDescrptiontxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.AssetDescrptiontxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AssetDescrptiontxt.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.AssetDescrptiontxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.AssetDescrptiontxt.Location = New System.Drawing.Point(196, 107)
        Me.AssetDescrptiontxt.Multiline = True
        Me.AssetDescrptiontxt.Name = "AssetDescrptiontxt"
        Me.AssetDescrptiontxt.Size = New System.Drawing.Size(313, 91)
        Me.AssetDescrptiontxt.TabIndex = 120
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.AssetDescrptiontxt)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Cancelbtn)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.AssetSavebtn)
        Me.Panel1.Controls.Add(Me.Assettxt)
        Me.Panel1.Location = New System.Drawing.Point(11, 51)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(557, 299)
        Me.Panel1.TabIndex = 121
        '
        'Asset
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(580, 362)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Asset"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Asset"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Cancelbtn As Button
    Friend WithEvents Assettxt As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents AssetSavebtn As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents AssetDescrptiontxt As TextBox
    Friend WithEvents Panel1 As Panel
End Class
