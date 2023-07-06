<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FundsSpecialFunds
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.FundNametxt = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.FundIDtxt = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.AddFundbtn = New System.Windows.Forms.Button()
        Me.FundCodetxt = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Decriptiontxt = New System.Windows.Forms.Panel()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.SpeicialFundtxt = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AddSpcFund = New System.Windows.Forms.Button()
        Me.FundIDCBB = New System.Windows.Forms.ComboBox()
        Me.SpecialFundIDtxt = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Decriptiontxt.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.DataGridView1)
        Me.Panel3.Controls.Add(Me.FundNametxt)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.FundIDtxt)
        Me.Panel3.Controls.Add(Me.AddFundbtn)
        Me.Panel3.Controls.Add(Me.FundCodetxt)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label18)
        Me.Panel3.Location = New System.Drawing.Point(37, 73)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(627, 874)
        Me.Panel3.TabIndex = 55
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(625, 41)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "FUNDS"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.LightGray
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Tahoma", 9.0!)
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(9, 223)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 35
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(606, 644)
        Me.DataGridView1.TabIndex = 56
        '
        'FundNametxt
        '
        Me.FundNametxt.BackColor = System.Drawing.Color.White
        Me.FundNametxt.BorderColorFocused = System.Drawing.Color.Black
        Me.FundNametxt.BorderColorIdle = System.Drawing.Color.White
        Me.FundNametxt.BorderColorMouseHover = System.Drawing.Color.Black
        Me.FundNametxt.BorderThickness = 1
        Me.FundNametxt.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.FundNametxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FundNametxt.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.FundNametxt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FundNametxt.isPassword = False
        Me.FundNametxt.Location = New System.Drawing.Point(11, 150)
        Me.FundNametxt.Margin = New System.Windows.Forms.Padding(4)
        Me.FundNametxt.MaxLength = 32767
        Me.FundNametxt.Name = "FundNametxt"
        Me.FundNametxt.Size = New System.Drawing.Size(281, 30)
        Me.FundNametxt.TabIndex = 55
        Me.FundNametxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(8, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 16)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "Fund Name"
        '
        'FundIDtxt
        '
        Me.FundIDtxt.BackColor = System.Drawing.Color.White
        Me.FundIDtxt.BorderColorFocused = System.Drawing.Color.Black
        Me.FundIDtxt.BorderColorIdle = System.Drawing.Color.White
        Me.FundIDtxt.BorderColorMouseHover = System.Drawing.Color.Black
        Me.FundIDtxt.BorderThickness = 1
        Me.FundIDtxt.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.FundIDtxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FundIDtxt.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.FundIDtxt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FundIDtxt.isPassword = False
        Me.FundIDtxt.Location = New System.Drawing.Point(9, 83)
        Me.FundIDtxt.Margin = New System.Windows.Forms.Padding(4)
        Me.FundIDtxt.MaxLength = 32767
        Me.FundIDtxt.Name = "FundIDtxt"
        Me.FundIDtxt.Size = New System.Drawing.Size(283, 30)
        Me.FundIDtxt.TabIndex = 52
        Me.FundIDtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'AddFundbtn
        '
        Me.AddFundbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.AddFundbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddFundbtn.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.AddFundbtn.ForeColor = System.Drawing.Color.White
        Me.AddFundbtn.Location = New System.Drawing.Point(325, 150)
        Me.AddFundbtn.Name = "AddFundbtn"
        Me.AddFundbtn.Size = New System.Drawing.Size(279, 30)
        Me.AddFundbtn.TabIndex = 42
        Me.AddFundbtn.Text = "Add"
        Me.AddFundbtn.UseVisualStyleBackColor = False
        '
        'FundCodetxt
        '
        Me.FundCodetxt.BackColor = System.Drawing.Color.White
        Me.FundCodetxt.BorderColorFocused = System.Drawing.Color.Black
        Me.FundCodetxt.BorderColorIdle = System.Drawing.Color.White
        Me.FundCodetxt.BorderColorMouseHover = System.Drawing.Color.Black
        Me.FundCodetxt.BorderThickness = 1
        Me.FundCodetxt.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.FundCodetxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FundCodetxt.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.FundCodetxt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FundCodetxt.isPassword = False
        Me.FundCodetxt.Location = New System.Drawing.Point(323, 83)
        Me.FundCodetxt.Margin = New System.Windows.Forms.Padding(4)
        Me.FundCodetxt.MaxLength = 32767
        Me.FundCodetxt.Name = "FundCodetxt"
        Me.FundCodetxt.Size = New System.Drawing.Size(281, 30)
        Me.FundCodetxt.TabIndex = 49
        Me.FundCodetxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(8, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 16)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Fund ID"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label18.Location = New System.Drawing.Point(320, 62)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(69, 16)
        Me.Label18.TabIndex = 46
        Me.Label18.Text = "Fund Code"
        '
        'Decriptiontxt
        '
        Me.Decriptiontxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Decriptiontxt.BackColor = System.Drawing.SystemColors.Control
        Me.Decriptiontxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Decriptiontxt.Controls.Add(Me.Label19)
        Me.Decriptiontxt.Controls.Add(Me.DataGridView2)
        Me.Decriptiontxt.Controls.Add(Me.SpeicialFundtxt)
        Me.Decriptiontxt.Controls.Add(Me.Label3)
        Me.Decriptiontxt.Controls.Add(Me.AddSpcFund)
        Me.Decriptiontxt.Controls.Add(Me.FundIDCBB)
        Me.Decriptiontxt.Controls.Add(Me.SpecialFundIDtxt)
        Me.Decriptiontxt.Controls.Add(Me.Label20)
        Me.Decriptiontxt.Controls.Add(Me.Label26)
        Me.Decriptiontxt.Location = New System.Drawing.Point(670, 73)
        Me.Decriptiontxt.Name = "Decriptiontxt"
        Me.Decriptiontxt.Size = New System.Drawing.Size(627, 874)
        Me.Decriptiontxt.TabIndex = 56
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Label19.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(0, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(625, 37)
        Me.Label19.TabIndex = 0
        Me.Label19.Text = "SPECIAL FUNDS"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.LightGray
        Me.DataGridView2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridView2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGridView2.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(10, 223)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowTemplate.Height = 35
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(606, 644)
        Me.DataGridView2.TabIndex = 57
        '
        'SpeicialFundtxt
        '
        Me.SpeicialFundtxt.BackColor = System.Drawing.Color.White
        Me.SpeicialFundtxt.BorderColorFocused = System.Drawing.Color.Black
        Me.SpeicialFundtxt.BorderColorIdle = System.Drawing.Color.White
        Me.SpeicialFundtxt.BorderColorMouseHover = System.Drawing.Color.Black
        Me.SpeicialFundtxt.BorderThickness = 1
        Me.SpeicialFundtxt.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.SpeicialFundtxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SpeicialFundtxt.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.SpeicialFundtxt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.SpeicialFundtxt.isPassword = False
        Me.SpeicialFundtxt.Location = New System.Drawing.Point(10, 150)
        Me.SpeicialFundtxt.Margin = New System.Windows.Forms.Padding(4)
        Me.SpeicialFundtxt.MaxLength = 32767
        Me.SpeicialFundtxt.Name = "SpeicialFundtxt"
        Me.SpeicialFundtxt.Size = New System.Drawing.Size(279, 30)
        Me.SpeicialFundtxt.TabIndex = 55
        Me.SpeicialFundtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(8, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(148, 16)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "Special Fund Description"
        '
        'AddSpcFund
        '
        Me.AddSpcFund.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.AddSpcFund.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddSpcFund.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.AddSpcFund.ForeColor = System.Drawing.Color.White
        Me.AddSpcFund.Location = New System.Drawing.Point(339, 150)
        Me.AddSpcFund.Name = "AddSpcFund"
        Me.AddSpcFund.Size = New System.Drawing.Size(277, 30)
        Me.AddSpcFund.TabIndex = 42
        Me.AddSpcFund.Text = "Add"
        Me.AddSpcFund.UseVisualStyleBackColor = False
        '
        'FundIDCBB
        '
        Me.FundIDCBB.BackColor = System.Drawing.Color.White
        Me.FundIDCBB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FundIDCBB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FundIDCBB.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.FundIDCBB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FundIDCBB.FormattingEnabled = True
        Me.FundIDCBB.Location = New System.Drawing.Point(10, 89)
        Me.FundIDCBB.Name = "FundIDCBB"
        Me.FundIDCBB.Size = New System.Drawing.Size(279, 24)
        Me.FundIDCBB.TabIndex = 43
        '
        'SpecialFundIDtxt
        '
        Me.SpecialFundIDtxt.BackColor = System.Drawing.Color.White
        Me.SpecialFundIDtxt.BorderColorFocused = System.Drawing.Color.Black
        Me.SpecialFundIDtxt.BorderColorIdle = System.Drawing.Color.White
        Me.SpecialFundIDtxt.BorderColorMouseHover = System.Drawing.Color.Black
        Me.SpecialFundIDtxt.BorderThickness = 1
        Me.SpecialFundIDtxt.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.SpecialFundIDtxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SpecialFundIDtxt.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.SpecialFundIDtxt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.SpecialFundIDtxt.isPassword = False
        Me.SpecialFundIDtxt.Location = New System.Drawing.Point(339, 83)
        Me.SpecialFundIDtxt.Margin = New System.Windows.Forms.Padding(4)
        Me.SpecialFundIDtxt.MaxLength = 32767
        Me.SpecialFundIDtxt.Name = "SpecialFundIDtxt"
        Me.SpecialFundIDtxt.Size = New System.Drawing.Size(277, 30)
        Me.SpecialFundIDtxt.TabIndex = 41
        Me.SpecialFundIDtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label20.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label20.Location = New System.Drawing.Point(9, 66)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(52, 16)
        Me.Label20.TabIndex = 39
        Me.Label20.Text = "Fund ID"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label26.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label26.Location = New System.Drawing.Point(336, 60)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(97, 16)
        Me.Label26.TabIndex = 45
        Me.Label26.Text = "Special Fund ID"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1323, 50)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "FUNDS AND SPECIAL FUNDS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FundsSpecialFunds
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Decriptiontxt)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "FundsSpecialFunds"
        Me.Size = New System.Drawing.Size(1323, 1037)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Decriptiontxt.ResumeLayout(False)
        Me.Decriptiontxt.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents FundNametxt As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents FundIDtxt As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents AddFundbtn As Button
    Friend WithEvents FundCodetxt As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Decriptiontxt As Panel
    Friend WithEvents SpeicialFundtxt As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents AddSpcFund As Button
    Friend WithEvents FundIDCBB As ComboBox
    Friend WithEvents SpecialFundIDtxt As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Label1 As Label
End Class
