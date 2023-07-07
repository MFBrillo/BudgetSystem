<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registry
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.AssetIDtxt = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.AddFundbtn = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Registrynametxt = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RegistryDescriptiontxt = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Registrycodetxt = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.AssetIDtxt)
        Me.Panel2.Controls.Add(Me.AddFundbtn)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label18)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Registrynametxt)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.RegistryDescriptiontxt)
        Me.Panel2.Controls.Add(Me.Registrycodetxt)
        Me.Panel2.Location = New System.Drawing.Point(17, 17)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(301, 480)
        Me.Panel2.TabIndex = 63
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
        Me.AssetIDtxt.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.AssetIDtxt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.AssetIDtxt.isPassword = False
        Me.AssetIDtxt.Location = New System.Drawing.Point(22, 76)
        Me.AssetIDtxt.Margin = New System.Windows.Forms.Padding(4)
        Me.AssetIDtxt.MaxLength = 32767
        Me.AssetIDtxt.Name = "AssetIDtxt"
        Me.AssetIDtxt.Size = New System.Drawing.Size(256, 30)
        Me.AssetIDtxt.TabIndex = 80
        Me.AssetIDtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'AddFundbtn
        '
        Me.AddFundbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.AddFundbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddFundbtn.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.AddFundbtn.ForeColor = System.Drawing.Color.White
        Me.AddFundbtn.Location = New System.Drawing.Point(27, 364)
        Me.AddFundbtn.Name = "AddFundbtn"
        Me.AddFundbtn.Size = New System.Drawing.Size(252, 30)
        Me.AddFundbtn.TabIndex = 63
        Me.AddFundbtn.Text = "Add"
        Me.AddFundbtn.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(24, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 16)
        Me.Label6.TabIndex = 79
        Me.Label6.Text = "Asset ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(21, 269)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 16)
        Me.Label4.TabIndex = 67
        Me.Label4.Text = "Registry Description"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label18.Location = New System.Drawing.Point(21, 194)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(91, 16)
        Me.Label18.TabIndex = 64
        Me.Label18.Text = "Registry Name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(104, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(115, 24)
        Me.Label7.TabIndex = 77
        Me.Label7.Text = "REGISTRY"
        '
        'Registrynametxt
        '
        Me.Registrynametxt.BackColor = System.Drawing.Color.White
        Me.Registrynametxt.BorderColorFocused = System.Drawing.Color.Black
        Me.Registrynametxt.BorderColorIdle = System.Drawing.Color.White
        Me.Registrynametxt.BorderColorMouseHover = System.Drawing.Color.Black
        Me.Registrynametxt.BorderThickness = 1
        Me.Registrynametxt.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.Registrynametxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Registrynametxt.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Registrynametxt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Registrynametxt.isPassword = False
        Me.Registrynametxt.Location = New System.Drawing.Point(24, 215)
        Me.Registrynametxt.Margin = New System.Windows.Forms.Padding(4)
        Me.Registrynametxt.MaxLength = 32767
        Me.Registrynametxt.Name = "Registrynametxt"
        Me.Registrynametxt.Size = New System.Drawing.Size(254, 30)
        Me.Registrynametxt.TabIndex = 65
        Me.Registrynametxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(24, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 16)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "Registry Code"
        '
        'RegistryDescriptiontxt
        '
        Me.RegistryDescriptiontxt.BackColor = System.Drawing.Color.White
        Me.RegistryDescriptiontxt.BorderColorFocused = System.Drawing.Color.Black
        Me.RegistryDescriptiontxt.BorderColorIdle = System.Drawing.Color.White
        Me.RegistryDescriptiontxt.BorderColorMouseHover = System.Drawing.Color.Black
        Me.RegistryDescriptiontxt.BorderThickness = 1
        Me.RegistryDescriptiontxt.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.RegistryDescriptiontxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.RegistryDescriptiontxt.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.RegistryDescriptiontxt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.RegistryDescriptiontxt.isPassword = False
        Me.RegistryDescriptiontxt.Location = New System.Drawing.Point(24, 290)
        Me.RegistryDescriptiontxt.Margin = New System.Windows.Forms.Padding(4)
        Me.RegistryDescriptiontxt.MaxLength = 32767
        Me.RegistryDescriptiontxt.Name = "RegistryDescriptiontxt"
        Me.RegistryDescriptiontxt.Size = New System.Drawing.Size(254, 30)
        Me.RegistryDescriptiontxt.TabIndex = 68
        Me.RegistryDescriptiontxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Registrycodetxt
        '
        Me.Registrycodetxt.BackColor = System.Drawing.Color.White
        Me.Registrycodetxt.BorderColorFocused = System.Drawing.Color.Black
        Me.Registrycodetxt.BorderColorIdle = System.Drawing.Color.White
        Me.Registrycodetxt.BorderColorMouseHover = System.Drawing.Color.Black
        Me.Registrycodetxt.BorderThickness = 1
        Me.Registrycodetxt.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.Registrycodetxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Registrycodetxt.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Registrycodetxt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Registrycodetxt.isPassword = False
        Me.Registrycodetxt.Location = New System.Drawing.Point(22, 144)
        Me.Registrycodetxt.Margin = New System.Windows.Forms.Padding(4)
        Me.Registrycodetxt.MaxLength = 32767
        Me.Registrycodetxt.Name = "Registrycodetxt"
        Me.Registrycodetxt.Size = New System.Drawing.Size(256, 30)
        Me.Registrycodetxt.TabIndex = 66
        Me.Registrycodetxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(27, 422)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(252, 30)
        Me.Button1.TabIndex = 81
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Registry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(337, 525)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Registry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registry"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents AssetIDtxt As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents AddFundbtn As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Registrynametxt As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label5 As Label
    Friend WithEvents RegistryDescriptiontxt As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Registrycodetxt As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Button1 As Button
End Class
