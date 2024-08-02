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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Positiontxt = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Headtxt = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Cancelbtn = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Officetypetxt
        '
        Me.Officetypetxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Officetypetxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Officetypetxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Officetypetxt.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Officetypetxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Officetypetxt.FormattingEnabled = True
        Me.Officetypetxt.Location = New System.Drawing.Point(195, 28)
        Me.Officetypetxt.Name = "Officetypetxt"
        Me.Officetypetxt.Size = New System.Drawing.Size(313, 22)
        Me.Officetypetxt.TabIndex = 1
        '
        'Savebtn
        '
        Me.Savebtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.Savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Savebtn.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Savebtn.ForeColor = System.Drawing.Color.White
        Me.Savebtn.Location = New System.Drawing.Point(271, 669)
        Me.Savebtn.Name = "Savebtn"
        Me.Savebtn.Size = New System.Drawing.Size(234, 29)
        Me.Savebtn.TabIndex = 10
        Me.Savebtn.Text = "SAVE"
        Me.Savebtn.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(41, 394)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 16)
        Me.Label8.TabIndex = 111
        Me.Label8.Text = "Accronym"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(36, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 16)
        Me.Label2.TabIndex = 102
        Me.Label2.Text = "Office Type"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(36, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 16)
        Me.Label4.TabIndex = 104
        Me.Label4.Text = "PBO Code"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(34, 488)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 16)
        Me.Label7.TabIndex = 110
        Me.Label7.Text = "Description"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(36, 177)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(103, 16)
        Me.Label9.TabIndex = 112
        Me.Label9.Text = "Accounting Code"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(37, 231)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 16)
        Me.Label6.TabIndex = 109
        Me.Label6.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(36, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 16)
        Me.Label3.TabIndex = 103
        Me.Label3.Text = "AIP Code"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
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
        Me.Titletxt.ForeColor = System.Drawing.Color.Black
        Me.Titletxt.Location = New System.Drawing.Point(12, 11)
        Me.Titletxt.Name = "Titletxt"
        Me.Titletxt.Size = New System.Drawing.Size(108, 19)
        Me.Titletxt.TabIndex = 125
        Me.Titletxt.Text = "ADD OFFICE"
        '
        'AIPCodetxt
        '
        Me.AIPCodetxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.AIPCodetxt.BorderColorFocused = System.Drawing.Color.White
        Me.AIPCodetxt.BorderColorIdle = System.Drawing.Color.Transparent
        Me.AIPCodetxt.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.AIPCodetxt.BorderThickness = 1
        Me.AIPCodetxt.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.AIPCodetxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.AIPCodetxt.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AIPCodetxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.AIPCodetxt.isPassword = False
        Me.AIPCodetxt.Location = New System.Drawing.Point(195, 120)
        Me.AIPCodetxt.Margin = New System.Windows.Forms.Padding(4)
        Me.AIPCodetxt.MaxLength = 32767
        Me.AIPCodetxt.Name = "AIPCodetxt"
        Me.AIPCodetxt.Size = New System.Drawing.Size(313, 30)
        Me.AIPCodetxt.TabIndex = 3
        Me.AIPCodetxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'PBOCodetxt
        '
        Me.PBOCodetxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PBOCodetxt.BorderColorFocused = System.Drawing.Color.White
        Me.PBOCodetxt.BorderColorIdle = System.Drawing.Color.Transparent
        Me.PBOCodetxt.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.PBOCodetxt.BorderThickness = 1
        Me.PBOCodetxt.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.PBOCodetxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PBOCodetxt.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PBOCodetxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.PBOCodetxt.isPassword = False
        Me.PBOCodetxt.Location = New System.Drawing.Point(195, 72)
        Me.PBOCodetxt.Margin = New System.Windows.Forms.Padding(4)
        Me.PBOCodetxt.MaxLength = 32767
        Me.PBOCodetxt.Name = "PBOCodetxt"
        Me.PBOCodetxt.Size = New System.Drawing.Size(313, 30)
        Me.PBOCodetxt.TabIndex = 2
        Me.PBOCodetxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'AccountingCodeTxt
        '
        Me.AccountingCodeTxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.AccountingCodeTxt.BorderColorFocused = System.Drawing.Color.White
        Me.AccountingCodeTxt.BorderColorIdle = System.Drawing.Color.Transparent
        Me.AccountingCodeTxt.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.AccountingCodeTxt.BorderThickness = 1
        Me.AccountingCodeTxt.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.AccountingCodeTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.AccountingCodeTxt.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccountingCodeTxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.AccountingCodeTxt.isPassword = False
        Me.AccountingCodeTxt.Location = New System.Drawing.Point(195, 174)
        Me.AccountingCodeTxt.Margin = New System.Windows.Forms.Padding(4)
        Me.AccountingCodeTxt.MaxLength = 32767
        Me.AccountingCodeTxt.Name = "AccountingCodeTxt"
        Me.AccountingCodeTxt.Size = New System.Drawing.Size(313, 30)
        Me.AccountingCodeTxt.TabIndex = 4
        Me.AccountingCodeTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Accronymtxt
        '
        Me.Accronymtxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Accronymtxt.BorderColorFocused = System.Drawing.Color.White
        Me.Accronymtxt.BorderColorIdle = System.Drawing.Color.Transparent
        Me.Accronymtxt.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Accronymtxt.BorderThickness = 1
        Me.Accronymtxt.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.Accronymtxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Accronymtxt.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Accronymtxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Accronymtxt.isPassword = False
        Me.Accronymtxt.Location = New System.Drawing.Point(195, 394)
        Me.Accronymtxt.Margin = New System.Windows.Forms.Padding(4)
        Me.Accronymtxt.MaxLength = 32767
        Me.Accronymtxt.Name = "Accronymtxt"
        Me.Accronymtxt.Size = New System.Drawing.Size(313, 30)
        Me.Accronymtxt.TabIndex = 8
        Me.Accronymtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Nametxt
        '
        Me.Nametxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Nametxt.BorderColorFocused = System.Drawing.Color.White
        Me.Nametxt.BorderColorIdle = System.Drawing.Color.Transparent
        Me.Nametxt.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Nametxt.BorderThickness = 1
        Me.Nametxt.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.Nametxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Nametxt.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nametxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Nametxt.isPassword = False
        Me.Nametxt.Location = New System.Drawing.Point(194, 228)
        Me.Nametxt.Margin = New System.Windows.Forms.Padding(4)
        Me.Nametxt.MaxLength = 32767
        Me.Nametxt.Name = "Nametxt"
        Me.Nametxt.Size = New System.Drawing.Size(313, 30)
        Me.Nametxt.TabIndex = 5
        Me.Nametxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Descriptiontxt
        '
        Me.Descriptiontxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Descriptiontxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Descriptiontxt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Descriptiontxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Descriptiontxt.Location = New System.Drawing.Point(193, 500)
        Me.Descriptiontxt.Multiline = True
        Me.Descriptiontxt.Name = "Descriptiontxt"
        Me.Descriptiontxt.Size = New System.Drawing.Size(312, 131)
        Me.Descriptiontxt.TabIndex = 9
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Positiontxt)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Headtxt)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Cancelbtn)
        Me.Panel1.Controls.Add(Me.Descriptiontxt)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Savebtn)
        Me.Panel1.Controls.Add(Me.Nametxt)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Accronymtxt)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.AccountingCodeTxt)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PBOCodetxt)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.AIPCodetxt)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Officetypetxt)
        Me.Panel1.Location = New System.Drawing.Point(15, 56)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(550, 730)
        Me.Panel1.TabIndex = 119
        '
        'Positiontxt
        '
        Me.Positiontxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Positiontxt.BorderColorFocused = System.Drawing.Color.White
        Me.Positiontxt.BorderColorIdle = System.Drawing.Color.Transparent
        Me.Positiontxt.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Positiontxt.BorderThickness = 1
        Me.Positiontxt.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.Positiontxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Positiontxt.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Positiontxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Positiontxt.isPassword = False
        Me.Positiontxt.Location = New System.Drawing.Point(195, 330)
        Me.Positiontxt.Margin = New System.Windows.Forms.Padding(4)
        Me.Positiontxt.MaxLength = 32767
        Me.Positiontxt.Name = "Positiontxt"
        Me.Positiontxt.Size = New System.Drawing.Size(313, 30)
        Me.Positiontxt.TabIndex = 7
        Me.Positiontxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(38, 333)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 16)
        Me.Label10.TabIndex = 120
        Me.Label10.Text = "Position"
        '
        'Headtxt
        '
        Me.Headtxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Headtxt.BorderColorFocused = System.Drawing.Color.White
        Me.Headtxt.BorderColorIdle = System.Drawing.Color.Transparent
        Me.Headtxt.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Headtxt.BorderThickness = 1
        Me.Headtxt.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.Headtxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Headtxt.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Headtxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Headtxt.isPassword = False
        Me.Headtxt.Location = New System.Drawing.Point(195, 278)
        Me.Headtxt.Margin = New System.Windows.Forms.Padding(4)
        Me.Headtxt.MaxLength = 32767
        Me.Headtxt.Name = "Headtxt"
        Me.Headtxt.Size = New System.Drawing.Size(313, 30)
        Me.Headtxt.TabIndex = 6
        Me.Headtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(38, 281)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 16)
        Me.Label1.TabIndex = 118
        Me.Label1.Text = "Office Head"
        '
        'Cancelbtn
        '
        Me.Cancelbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Cancelbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancelbtn.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Cancelbtn.ForeColor = System.Drawing.Color.White
        Me.Cancelbtn.Location = New System.Drawing.Point(19, 669)
        Me.Cancelbtn.Name = "Cancelbtn"
        Me.Cancelbtn.Size = New System.Drawing.Size(234, 29)
        Me.Cancelbtn.TabIndex = 11
        Me.Cancelbtn.Text = "Cancel"
        Me.Cancelbtn.UseVisualStyleBackColor = False
        '
        'AddOffice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(580, 801)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AddOffice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddOffice"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

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
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Cancelbtn As Button
    Friend WithEvents Positiontxt As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label10 As Label
    Friend WithEvents Headtxt As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label1 As Label
End Class
