<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConnectionForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConnectionForm))
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Closebtn = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Savebtn = New System.Windows.Forms.Button()
        Me.Databasenametxt = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.PasswordDbtxt = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.PortAddresstxt = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.UsernameDbtxt = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Servernametxt = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Resettxt = New System.Windows.Forms.Button()
        CType(Me.Closebtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Label6.Size = New System.Drawing.Size(462, 50)
        Me.Label6.TabIndex = 191
        Me.Label6.Text = "Server Settings"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Closebtn
        '
        Me.Closebtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Closebtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.Closebtn.Image = CType(resources.GetObject("Closebtn.Image"), System.Drawing.Image)
        Me.Closebtn.ImageActive = Nothing
        Me.Closebtn.Location = New System.Drawing.Point(435, 12)
        Me.Closebtn.Name = "Closebtn"
        Me.Closebtn.Size = New System.Drawing.Size(15, 18)
        Me.Closebtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Closebtn.TabIndex = 198
        Me.Closebtn.TabStop = False
        Me.Closebtn.Zoom = 10
        '
        'Savebtn
        '
        Me.Savebtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.Savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Savebtn.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Savebtn.ForeColor = System.Drawing.Color.White
        Me.Savebtn.Location = New System.Drawing.Point(158, 389)
        Me.Savebtn.Name = "Savebtn"
        Me.Savebtn.Size = New System.Drawing.Size(262, 30)
        Me.Savebtn.TabIndex = 209
        Me.Savebtn.Text = "Save"
        Me.Savebtn.UseVisualStyleBackColor = False
        '
        'Databasenametxt
        '
        Me.Databasenametxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Databasenametxt.BorderColorFocused = System.Drawing.Color.Black
        Me.Databasenametxt.BorderColorIdle = System.Drawing.Color.White
        Me.Databasenametxt.BorderColorMouseHover = System.Drawing.Color.Black
        Me.Databasenametxt.BorderThickness = 1
        Me.Databasenametxt.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.Databasenametxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Databasenametxt.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Databasenametxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Databasenametxt.isPassword = False
        Me.Databasenametxt.Location = New System.Drawing.Point(158, 316)
        Me.Databasenametxt.Margin = New System.Windows.Forms.Padding(4)
        Me.Databasenametxt.MaxLength = 32767
        Me.Databasenametxt.Name = "Databasenametxt"
        Me.Databasenametxt.Size = New System.Drawing.Size(262, 30)
        Me.Databasenametxt.TabIndex = 208
        Me.Databasenametxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'PasswordDbtxt
        '
        Me.PasswordDbtxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PasswordDbtxt.BorderColorFocused = System.Drawing.Color.Black
        Me.PasswordDbtxt.BorderColorIdle = System.Drawing.Color.White
        Me.PasswordDbtxt.BorderColorMouseHover = System.Drawing.Color.Black
        Me.PasswordDbtxt.BorderThickness = 1
        Me.PasswordDbtxt.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.PasswordDbtxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PasswordDbtxt.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.PasswordDbtxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.PasswordDbtxt.isPassword = True
        Me.PasswordDbtxt.Location = New System.Drawing.Point(158, 256)
        Me.PasswordDbtxt.Margin = New System.Windows.Forms.Padding(4)
        Me.PasswordDbtxt.MaxLength = 32767
        Me.PasswordDbtxt.Name = "PasswordDbtxt"
        Me.PasswordDbtxt.Size = New System.Drawing.Size(262, 30)
        Me.PasswordDbtxt.TabIndex = 207
        Me.PasswordDbtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'PortAddresstxt
        '
        Me.PortAddresstxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PortAddresstxt.BorderColorFocused = System.Drawing.Color.Black
        Me.PortAddresstxt.BorderColorIdle = System.Drawing.Color.White
        Me.PortAddresstxt.BorderColorMouseHover = System.Drawing.Color.Black
        Me.PortAddresstxt.BorderThickness = 1
        Me.PortAddresstxt.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.PortAddresstxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PortAddresstxt.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.PortAddresstxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.PortAddresstxt.isPassword = False
        Me.PortAddresstxt.Location = New System.Drawing.Point(158, 197)
        Me.PortAddresstxt.Margin = New System.Windows.Forms.Padding(4)
        Me.PortAddresstxt.MaxLength = 32767
        Me.PortAddresstxt.Name = "PortAddresstxt"
        Me.PortAddresstxt.Size = New System.Drawing.Size(262, 30)
        Me.PortAddresstxt.TabIndex = 206
        Me.PortAddresstxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'UsernameDbtxt
        '
        Me.UsernameDbtxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.UsernameDbtxt.BorderColorFocused = System.Drawing.Color.Black
        Me.UsernameDbtxt.BorderColorIdle = System.Drawing.Color.White
        Me.UsernameDbtxt.BorderColorMouseHover = System.Drawing.Color.Black
        Me.UsernameDbtxt.BorderThickness = 1
        Me.UsernameDbtxt.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.UsernameDbtxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.UsernameDbtxt.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.UsernameDbtxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.UsernameDbtxt.isPassword = False
        Me.UsernameDbtxt.Location = New System.Drawing.Point(158, 134)
        Me.UsernameDbtxt.Margin = New System.Windows.Forms.Padding(4)
        Me.UsernameDbtxt.MaxLength = 32767
        Me.UsernameDbtxt.Name = "UsernameDbtxt"
        Me.UsernameDbtxt.Size = New System.Drawing.Size(262, 30)
        Me.UsernameDbtxt.TabIndex = 205
        Me.UsernameDbtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Servernametxt
        '
        Me.Servernametxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Servernametxt.BorderColorFocused = System.Drawing.Color.Black
        Me.Servernametxt.BorderColorIdle = System.Drawing.Color.White
        Me.Servernametxt.BorderColorMouseHover = System.Drawing.Color.Black
        Me.Servernametxt.BorderThickness = 1
        Me.Servernametxt.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.Servernametxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Servernametxt.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Servernametxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Servernametxt.isPassword = False
        Me.Servernametxt.Location = New System.Drawing.Point(158, 78)
        Me.Servernametxt.Margin = New System.Windows.Forms.Padding(4)
        Me.Servernametxt.MaxLength = 32767
        Me.Servernametxt.Name = "Servernametxt"
        Me.Servernametxt.Size = New System.Drawing.Size(262, 30)
        Me.Servernametxt.TabIndex = 204
        Me.Servernametxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.label5.Location = New System.Drawing.Point(50, 327)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(79, 19)
        Me.label5.TabIndex = 203
        Me.label5.Text = "Database:"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.label4.Location = New System.Drawing.Point(47, 267)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(82, 19)
        Me.label4.TabIndex = 202
        Me.label4.Text = "Password:"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.label3.Location = New System.Drawing.Point(85, 208)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(44, 19)
        Me.label3.TabIndex = 201
        Me.label3.Text = "Port:"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.label2.Location = New System.Drawing.Point(43, 157)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(86, 19)
        Me.label2.TabIndex = 200
        Me.label2.Text = "Username:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(69, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 19)
        Me.Label1.TabIndex = 199
        Me.Label1.Text = "Server:"
        '
        'Resettxt
        '
        Me.Resettxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.Resettxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Resettxt.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Resettxt.ForeColor = System.Drawing.Color.White
        Me.Resettxt.Location = New System.Drawing.Point(47, 389)
        Me.Resettxt.Name = "Resettxt"
        Me.Resettxt.Size = New System.Drawing.Size(105, 30)
        Me.Resettxt.TabIndex = 211
        Me.Resettxt.Text = "Reset"
        Me.Resettxt.UseVisualStyleBackColor = False
        '
        'ConnectionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 496)
        Me.Controls.Add(Me.Resettxt)
        Me.Controls.Add(Me.Savebtn)
        Me.Controls.Add(Me.Databasenametxt)
        Me.Controls.Add(Me.PasswordDbtxt)
        Me.Controls.Add(Me.PortAddresstxt)
        Me.Controls.Add(Me.UsernameDbtxt)
        Me.Controls.Add(Me.Servernametxt)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Closebtn)
        Me.Controls.Add(Me.Label6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ConnectionForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ConnectionForm"
        CType(Me.Closebtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents Closebtn As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Savebtn As Button
    Friend WithEvents Databasenametxt As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents PasswordDbtxt As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents PortAddresstxt As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents UsernameDbtxt As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Servernametxt As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents label5 As Label
    Friend WithEvents label4 As Label
    Friend WithEvents label3 As Label
    Friend WithEvents label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Resettxt As Button
End Class
