<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddOffice
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
        Me.Officetypetxt = New System.Windows.Forms.ComboBox()
        Me.Savebtn = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Titletxt = New System.Windows.Forms.Label()
        Me.AIPCodetxt = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.PBOCodetxt = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.AccountingCodeTxt = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Accronymtxt = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Nametxt = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Descriptiontxt = New System.Windows.Forms.TextBox()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Officetypetxt
        '
        Me.Officetypetxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Officetypetxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Officetypetxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Officetypetxt.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Officetypetxt.ForeColor = System.Drawing.Color.White
        Me.Officetypetxt.FormattingEnabled = True
        Me.Officetypetxt.Location = New System.Drawing.Point(231, 83)
        Me.Officetypetxt.Name = "Officetypetxt"
        Me.Officetypetxt.Size = New System.Drawing.Size(313, 22)
        Me.Officetypetxt.TabIndex = 116
        '
        'Savebtn
        '
        Me.Savebtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.Savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Savebtn.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Savebtn.ForeColor = System.Drawing.Color.White
        Me.Savebtn.Location = New System.Drawing.Point(364, 739)
        Me.Savebtn.Name = "Savebtn"
        Me.Savebtn.Size = New System.Drawing.Size(177, 35)
        Me.Savebtn.TabIndex = 115
        Me.Savebtn.Text = "SAVE"
        Me.Savebtn.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(33, 476)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 16)
        Me.Label8.TabIndex = 111
        Me.Label8.Text = "Accronym"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(37, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 16)
        Me.Label2.TabIndex = 102
        Me.Label2.Text = "Office Type"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(36, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 16)
        Me.Label4.TabIndex = 104
        Me.Label4.Text = "PBO Code"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(35, 554)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 16)
        Me.Label7.TabIndex = 110
        Me.Label7.Text = "Description"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(37, 319)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(103, 16)
        Me.Label9.TabIndex = 112
        Me.Label9.Text = "Accounting Code"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(37, 403)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 16)
        Me.Label6.TabIndex = 109
        Me.Label6.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(36, 243)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 16)
        Me.Label3.TabIndex = 103
        Me.Label3.Text = "AIP Code"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Titletxt)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(580, 41)
        Me.Panel2.TabIndex = 118
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(551, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(14, 13)
        Me.Label5.TabIndex = 125
        Me.Label5.Text = "X"
        '
        'Titletxt
        '
        Me.Titletxt.AutoSize = True
        Me.Titletxt.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Titletxt.ForeColor = System.Drawing.Color.White
        Me.Titletxt.Location = New System.Drawing.Point(12, 11)
        Me.Titletxt.Name = "Titletxt"
        Me.Titletxt.Size = New System.Drawing.Size(108, 19)
        Me.Titletxt.TabIndex = 125
        Me.Titletxt.Text = "ADD OFFICE"
        '
        'AIPCodetxt
        '
        Me.AIPCodetxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.AIPCodetxt.BorderColorFocused = System.Drawing.Color.White
        Me.AIPCodetxt.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.AIPCodetxt.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.AIPCodetxt.BorderThickness = 1
        Me.AIPCodetxt.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.AIPCodetxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.AIPCodetxt.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AIPCodetxt.ForeColor = System.Drawing.Color.White
        Me.AIPCodetxt.isPassword = False
        Me.AIPCodetxt.Location = New System.Drawing.Point(230, 229)
        Me.AIPCodetxt.Margin = New System.Windows.Forms.Padding(4)
        Me.AIPCodetxt.MaxLength = 32767
        Me.AIPCodetxt.Name = "AIPCodetxt"
        Me.AIPCodetxt.Size = New System.Drawing.Size(313, 30)
        Me.AIPCodetxt.TabIndex = 119
        Me.AIPCodetxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'PBOCodetxt
        '
        Me.PBOCodetxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.PBOCodetxt.BorderColorFocused = System.Drawing.Color.White
        Me.PBOCodetxt.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.PBOCodetxt.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.PBOCodetxt.BorderThickness = 1
        Me.PBOCodetxt.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.PBOCodetxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PBOCodetxt.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PBOCodetxt.ForeColor = System.Drawing.Color.White
        Me.PBOCodetxt.isPassword = False
        Me.PBOCodetxt.Location = New System.Drawing.Point(230, 152)
        Me.PBOCodetxt.Margin = New System.Windows.Forms.Padding(4)
        Me.PBOCodetxt.MaxLength = 32767
        Me.PBOCodetxt.Name = "PBOCodetxt"
        Me.PBOCodetxt.Size = New System.Drawing.Size(313, 30)
        Me.PBOCodetxt.TabIndex = 120
        Me.PBOCodetxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'AccountingCodeTxt
        '
        Me.AccountingCodeTxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.AccountingCodeTxt.BorderColorFocused = System.Drawing.Color.White
        Me.AccountingCodeTxt.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.AccountingCodeTxt.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.AccountingCodeTxt.BorderThickness = 1
        Me.AccountingCodeTxt.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.AccountingCodeTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.AccountingCodeTxt.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccountingCodeTxt.ForeColor = System.Drawing.Color.White
        Me.AccountingCodeTxt.isPassword = False
        Me.AccountingCodeTxt.Location = New System.Drawing.Point(231, 305)
        Me.AccountingCodeTxt.Margin = New System.Windows.Forms.Padding(4)
        Me.AccountingCodeTxt.MaxLength = 32767
        Me.AccountingCodeTxt.Name = "AccountingCodeTxt"
        Me.AccountingCodeTxt.Size = New System.Drawing.Size(313, 30)
        Me.AccountingCodeTxt.TabIndex = 121
        Me.AccountingCodeTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Accronymtxt
        '
        Me.Accronymtxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Accronymtxt.BorderColorFocused = System.Drawing.Color.White
        Me.Accronymtxt.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Accronymtxt.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Accronymtxt.BorderThickness = 1
        Me.Accronymtxt.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.Accronymtxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Accronymtxt.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Accronymtxt.ForeColor = System.Drawing.Color.White
        Me.Accronymtxt.isPassword = False
        Me.Accronymtxt.Location = New System.Drawing.Point(230, 476)
        Me.Accronymtxt.Margin = New System.Windows.Forms.Padding(4)
        Me.Accronymtxt.MaxLength = 32767
        Me.Accronymtxt.Name = "Accronymtxt"
        Me.Accronymtxt.Size = New System.Drawing.Size(313, 30)
        Me.Accronymtxt.TabIndex = 122
        Me.Accronymtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Nametxt
        '
        Me.Nametxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Nametxt.BorderColorFocused = System.Drawing.Color.White
        Me.Nametxt.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Nametxt.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Nametxt.BorderThickness = 1
        Me.Nametxt.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.Nametxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Nametxt.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nametxt.ForeColor = System.Drawing.Color.White
        Me.Nametxt.isPassword = False
        Me.Nametxt.Location = New System.Drawing.Point(229, 389)
        Me.Nametxt.Margin = New System.Windows.Forms.Padding(4)
        Me.Nametxt.MaxLength = 32767
        Me.Nametxt.Name = "Nametxt"
        Me.Nametxt.Size = New System.Drawing.Size(313, 30)
        Me.Nametxt.TabIndex = 123
        Me.Nametxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Descriptiontxt
        '
        Me.Descriptiontxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Descriptiontxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Descriptiontxt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Descriptiontxt.ForeColor = System.Drawing.Color.White
        Me.Descriptiontxt.Location = New System.Drawing.Point(229, 555)
        Me.Descriptiontxt.Multiline = True
        Me.Descriptiontxt.Name = "Descriptiontxt"
        Me.Descriptiontxt.Size = New System.Drawing.Size(312, 131)
        Me.Descriptiontxt.TabIndex = 124
        '
        'AddOffice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(580, 801)
        Me.Controls.Add(Me.Descriptiontxt)
        Me.Controls.Add(Me.Nametxt)
        Me.Controls.Add(Me.Accronymtxt)
        Me.Controls.Add(Me.AccountingCodeTxt)
        Me.Controls.Add(Me.PBOCodetxt)
        Me.Controls.Add(Me.AIPCodetxt)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Officetypetxt)
        Me.Controls.Add(Me.Savebtn)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AddOffice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddOffice"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Officetypetxt As ComboBox
    Friend WithEvents Savebtn As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents AIPCodetxt As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents PBOCodetxt As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents AccountingCodeTxt As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Accronymtxt As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Nametxt As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Descriptiontxt As TextBox
    Friend WithEvents Titletxt As Label
    Friend WithEvents Label5 As Label
End Class
