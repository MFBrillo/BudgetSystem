<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccountDescription
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
        Me.Cancelbtn = New System.Windows.Forms.Button()
        Me.Nametxt = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Descriptiontxt = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Savebtn = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Codetxt = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Cancelbtn
        '
        Me.Cancelbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Cancelbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancelbtn.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Cancelbtn.ForeColor = System.Drawing.Color.White
        Me.Cancelbtn.Location = New System.Drawing.Point(46, 286)
        Me.Cancelbtn.Name = "Cancelbtn"
        Me.Cancelbtn.Size = New System.Drawing.Size(216, 30)
        Me.Cancelbtn.TabIndex = 86
        Me.Cancelbtn.Text = "Cancel"
        Me.Cancelbtn.UseVisualStyleBackColor = False
        '
        'Nametxt
        '
        Me.Nametxt.BackColor = System.Drawing.Color.White
        Me.Nametxt.BorderColorFocused = System.Drawing.Color.Black
        Me.Nametxt.BorderColorIdle = System.Drawing.Color.White
        Me.Nametxt.BorderColorMouseHover = System.Drawing.Color.Black
        Me.Nametxt.BorderThickness = 1
        Me.Nametxt.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.Nametxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Nametxt.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Nametxt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Nametxt.isPassword = False
        Me.Nametxt.Location = New System.Drawing.Point(46, 111)
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
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(45, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 16)
        Me.Label2.TabIndex = 81
        Me.Label2.Text = "Account Name"
        '
        'Descriptiontxt
        '
        Me.Descriptiontxt.BackColor = System.Drawing.Color.White
        Me.Descriptiontxt.BorderColorFocused = System.Drawing.Color.Black
        Me.Descriptiontxt.BorderColorIdle = System.Drawing.Color.White
        Me.Descriptiontxt.BorderColorMouseHover = System.Drawing.Color.Black
        Me.Descriptiontxt.BorderThickness = 1
        Me.Descriptiontxt.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.Descriptiontxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Descriptiontxt.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Descriptiontxt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Descriptiontxt.isPassword = False
        Me.Descriptiontxt.Location = New System.Drawing.Point(48, 182)
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
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(45, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 16)
        Me.Label3.TabIndex = 83
        Me.Label3.Text = "Account Description"
        '
        'Savebtn
        '
        Me.Savebtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Savebtn.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Savebtn.ForeColor = System.Drawing.Color.White
        Me.Savebtn.Location = New System.Drawing.Point(268, 286)
        Me.Savebtn.Name = "Savebtn"
        Me.Savebtn.Size = New System.Drawing.Size(216, 30)
        Me.Savebtn.TabIndex = 82
        Me.Savebtn.Text = "Save"
        Me.Savebtn.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(168, 30)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(203, 24)
        Me.Label8.TabIndex = 88
        Me.Label8.Text = "Adding Description"
        '
        'Codetxt
        '
        Me.Codetxt.AutoSize = True
        Me.Codetxt.Location = New System.Drawing.Point(45, 216)
        Me.Codetxt.Name = "Codetxt"
        Me.Codetxt.Size = New System.Drawing.Size(39, 13)
        Me.Codetxt.TabIndex = 89
        Me.Codetxt.Text = "Label1"
        '
        'AccountDescription
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 360)
        Me.ControlBox = False
        Me.Controls.Add(Me.Codetxt)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Cancelbtn)
        Me.Controls.Add(Me.Nametxt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Descriptiontxt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Savebtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AccountDescription"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AccountDectription"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Cancelbtn As Button
    Friend WithEvents Nametxt As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label2 As Label
    Friend WithEvents Descriptiontxt As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label3 As Label
    Friend WithEvents Savebtn As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Codetxt As Label
End Class
