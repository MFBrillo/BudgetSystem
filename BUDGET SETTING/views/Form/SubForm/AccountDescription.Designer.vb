<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AccountDescription
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
        Me.Nametxt = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Descriptiontxt = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Savebtn = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Titletxt = New System.Windows.Forms.Label()
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
        Me.Cancelbtn.Location = New System.Drawing.Point(34, 174)
        Me.Cancelbtn.Name = "Cancelbtn"
        Me.Cancelbtn.Size = New System.Drawing.Size(216, 30)
        Me.Cancelbtn.TabIndex = 86
        Me.Cancelbtn.Text = "Cancel"
        Me.Cancelbtn.UseVisualStyleBackColor = False
        '
        'Nametxt
        '
        Me.Nametxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Nametxt.BorderColorFocused = System.Drawing.Color.Black
        Me.Nametxt.BorderColorIdle = System.Drawing.Color.White
        Me.Nametxt.BorderColorMouseHover = System.Drawing.Color.Black
        Me.Nametxt.BorderThickness = 1
        Me.Nametxt.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.Nametxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Nametxt.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Nametxt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Nametxt.isPassword = False
        Me.Nametxt.Location = New System.Drawing.Point(34, 44)
        Me.Nametxt.Margin = New System.Windows.Forms.Padding(4)
        Me.Nametxt.MaxLength = 32767
        Me.Nametxt.Name = "Nametxt"
        Me.Nametxt.Size = New System.Drawing.Size(438, 30)
        Me.Nametxt.TabIndex = 85
        Me.Nametxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(33, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 16)
        Me.Label2.TabIndex = 81
        Me.Label2.Text = "Account Name"
        '
        'Descriptiontxt
        '
        Me.Descriptiontxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Descriptiontxt.BorderColorFocused = System.Drawing.Color.Black
        Me.Descriptiontxt.BorderColorIdle = System.Drawing.Color.White
        Me.Descriptiontxt.BorderColorMouseHover = System.Drawing.Color.Black
        Me.Descriptiontxt.BorderThickness = 1
        Me.Descriptiontxt.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.Descriptiontxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Descriptiontxt.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Descriptiontxt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Descriptiontxt.isPassword = False
        Me.Descriptiontxt.Location = New System.Drawing.Point(36, 115)
        Me.Descriptiontxt.Margin = New System.Windows.Forms.Padding(4)
        Me.Descriptiontxt.MaxLength = 32767
        Me.Descriptiontxt.Name = "Descriptiontxt"
        Me.Descriptiontxt.Size = New System.Drawing.Size(436, 30)
        Me.Descriptiontxt.TabIndex = 84
        Me.Descriptiontxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(33, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 16)
        Me.Label3.TabIndex = 83
        Me.Label3.Text = "Account Description"
        '
        'Savebtn
        '
        Me.Savebtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.Savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Savebtn.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Savebtn.ForeColor = System.Drawing.Color.White
        Me.Savebtn.Location = New System.Drawing.Point(256, 174)
        Me.Savebtn.Name = "Savebtn"
        Me.Savebtn.Size = New System.Drawing.Size(216, 30)
        Me.Savebtn.TabIndex = 82
        Me.Savebtn.Text = "Save"
        Me.Savebtn.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Titletxt)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(528, 41)
        Me.Panel2.TabIndex = 119
        '
        'Titletxt
        '
        Me.Titletxt.AutoSize = True
        Me.Titletxt.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Titletxt.ForeColor = System.Drawing.Color.Black
        Me.Titletxt.Location = New System.Drawing.Point(12, 11)
        Me.Titletxt.Name = "Titletxt"
        Me.Titletxt.Size = New System.Drawing.Size(142, 19)
        Me.Titletxt.TabIndex = 125
        Me.Titletxt.Text = "ADD Description"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Descriptiontxt)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Cancelbtn)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Savebtn)
        Me.Panel1.Controls.Add(Me.Nametxt)
        Me.Panel1.Location = New System.Drawing.Point(8, 51)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(511, 298)
        Me.Panel1.TabIndex = 120
        '
        'AccountDescription
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(528, 360)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AccountDescription"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AccountDectription"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Cancelbtn As Button
    Friend WithEvents Nametxt As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label2 As Label
    Friend WithEvents Descriptiontxt As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label3 As Label
    Friend WithEvents Savebtn As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Titletxt As Label
    Friend WithEvents Panel1 As Panel
End Class
