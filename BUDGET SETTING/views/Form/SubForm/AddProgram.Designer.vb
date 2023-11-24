<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddProgram
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Cancelbtn = New System.Windows.Forms.Button()
        Me.Officenametxt = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Descriptiontxt = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Savebtn = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Titletxt = New System.Windows.Forms.Label()
        Me.Programnametxt = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.progidlbl = New System.Windows.Forms.Label()
        Me.sectorlbl = New System.Windows.Forms.Label()
        Me.subsectoridlbl = New System.Windows.Forms.Label()
        Me.programcodelbl = New System.Windows.Forms.Label()
        Me.sectorguidedlbl = New System.Windows.Forms.Label()
        Me.updatelbl = New System.Windows.Forms.Label()
        Me.programnamelbl = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.officeidlbl = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cancelbtn
        '
        Me.Cancelbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Cancelbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancelbtn.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Cancelbtn.ForeColor = System.Drawing.Color.White
        Me.Cancelbtn.Location = New System.Drawing.Point(48, 308)
        Me.Cancelbtn.Name = "Cancelbtn"
        Me.Cancelbtn.Size = New System.Drawing.Size(170, 30)
        Me.Cancelbtn.TabIndex = 92
        Me.Cancelbtn.Text = "Cancel"
        Me.Cancelbtn.UseVisualStyleBackColor = False
        '
        'Officenametxt
        '
        Me.Officenametxt.BackColor = System.Drawing.Color.White
        Me.Officenametxt.BorderColorFocused = System.Drawing.Color.Black
        Me.Officenametxt.BorderColorIdle = System.Drawing.Color.White
        Me.Officenametxt.BorderColorMouseHover = System.Drawing.Color.Black
        Me.Officenametxt.BorderThickness = 1
        Me.Officenametxt.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.Officenametxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Officenametxt.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Officenametxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Officenametxt.isPassword = False
        Me.Officenametxt.Location = New System.Drawing.Point(48, 164)
        Me.Officenametxt.Margin = New System.Windows.Forms.Padding(4)
        Me.Officenametxt.MaxLength = 32767
        Me.Officenametxt.Name = "Officenametxt"
        Me.Officenametxt.Size = New System.Drawing.Size(436, 30)
        Me.Officenametxt.TabIndex = 91
        Me.Officenametxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(45, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 16)
        Me.Label2.TabIndex = 87
        Me.Label2.Text = "Officen Name"
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
        Me.Descriptiontxt.Enabled = False
        Me.Descriptiontxt.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Descriptiontxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Descriptiontxt.isPassword = False
        Me.Descriptiontxt.Location = New System.Drawing.Point(48, 233)
        Me.Descriptiontxt.Margin = New System.Windows.Forms.Padding(4)
        Me.Descriptiontxt.MaxLength = 32767
        Me.Descriptiontxt.Name = "Descriptiontxt"
        Me.Descriptiontxt.Size = New System.Drawing.Size(436, 30)
        Me.Descriptiontxt.TabIndex = 90
        Me.Descriptiontxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(45, 213)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 16)
        Me.Label3.TabIndex = 89
        Me.Label3.Text = "Program Description"
        '
        'Savebtn
        '
        Me.Savebtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.Savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Savebtn.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Savebtn.ForeColor = System.Drawing.Color.White
        Me.Savebtn.Location = New System.Drawing.Point(314, 308)
        Me.Savebtn.Name = "Savebtn"
        Me.Savebtn.Size = New System.Drawing.Size(170, 30)
        Me.Savebtn.TabIndex = 88
        Me.Savebtn.Text = "Save"
        Me.Savebtn.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Titletxt)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(528, 41)
        Me.Panel2.TabIndex = 120
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
        Me.Titletxt.Size = New System.Drawing.Size(120, 19)
        Me.Titletxt.TabIndex = 125
        Me.Titletxt.Text = "ADD Program"
        '
        'Programnametxt
        '
        Me.Programnametxt.BackColor = System.Drawing.Color.White
        Me.Programnametxt.BorderColorFocused = System.Drawing.Color.Black
        Me.Programnametxt.BorderColorIdle = System.Drawing.Color.White
        Me.Programnametxt.BorderColorMouseHover = System.Drawing.Color.Black
        Me.Programnametxt.BorderThickness = 1
        Me.Programnametxt.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.Programnametxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Programnametxt.Enabled = False
        Me.Programnametxt.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Programnametxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Programnametxt.isPassword = False
        Me.Programnametxt.Location = New System.Drawing.Point(48, 94)
        Me.Programnametxt.Margin = New System.Windows.Forms.Padding(4)
        Me.Programnametxt.MaxLength = 32767
        Me.Programnametxt.Name = "Programnametxt"
        Me.Programnametxt.Size = New System.Drawing.Size(436, 30)
        Me.Programnametxt.TabIndex = 122
        Me.Programnametxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(45, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 16)
        Me.Label1.TabIndex = 121
        Me.Label1.Text = "Program Name"
        '
        'progidlbl
        '
        Me.progidlbl.AutoSize = True
        Me.progidlbl.ForeColor = System.Drawing.Color.DarkOrange
        Me.progidlbl.Location = New System.Drawing.Point(192, 361)
        Me.progidlbl.Name = "progidlbl"
        Me.progidlbl.Size = New System.Drawing.Size(36, 13)
        Me.progidlbl.TabIndex = 123
        Me.progidlbl.Text = "progid"
        '
        'sectorlbl
        '
        Me.sectorlbl.AutoSize = True
        Me.sectorlbl.ForeColor = System.Drawing.Color.DarkOrange
        Me.sectorlbl.Location = New System.Drawing.Point(45, 361)
        Me.sectorlbl.Name = "sectorlbl"
        Me.sectorlbl.Size = New System.Drawing.Size(44, 13)
        Me.sectorlbl.TabIndex = 124
        Me.sectorlbl.Text = "sectorid"
        '
        'subsectoridlbl
        '
        Me.subsectoridlbl.AutoSize = True
        Me.subsectoridlbl.ForeColor = System.Drawing.Color.DarkOrange
        Me.subsectoridlbl.Location = New System.Drawing.Point(110, 361)
        Me.subsectoridlbl.Name = "subsectoridlbl"
        Me.subsectoridlbl.Size = New System.Drawing.Size(61, 13)
        Me.subsectoridlbl.TabIndex = 125
        Me.subsectoridlbl.Text = "subsectorid"
        '
        'programcodelbl
        '
        Me.programcodelbl.AutoSize = True
        Me.programcodelbl.ForeColor = System.Drawing.Color.DarkOrange
        Me.programcodelbl.Location = New System.Drawing.Point(245, 361)
        Me.programcodelbl.Name = "programcodelbl"
        Me.programcodelbl.Size = New System.Drawing.Size(69, 13)
        Me.programcodelbl.TabIndex = 128
        Me.programcodelbl.Text = "programcode"
        '
        'sectorguidedlbl
        '
        Me.sectorguidedlbl.AutoSize = True
        Me.sectorguidedlbl.ForeColor = System.Drawing.Color.DarkOrange
        Me.sectorguidedlbl.Location = New System.Drawing.Point(332, 361)
        Me.sectorguidedlbl.Name = "sectorguidedlbl"
        Me.sectorguidedlbl.Size = New System.Drawing.Size(68, 13)
        Me.sectorguidedlbl.TabIndex = 127
        Me.sectorguidedlbl.Text = "sectorguided"
        '
        'updatelbl
        '
        Me.updatelbl.AutoSize = True
        Me.updatelbl.ForeColor = System.Drawing.Color.DarkOrange
        Me.updatelbl.Location = New System.Drawing.Point(332, 405)
        Me.updatelbl.Name = "updatelbl"
        Me.updatelbl.Size = New System.Drawing.Size(46, 13)
        Me.updatelbl.TabIndex = 126
        Me.updatelbl.Text = "update1"
        '
        'programnamelbl
        '
        Me.programnamelbl.AutoSize = True
        Me.programnamelbl.ForeColor = System.Drawing.Color.DarkOrange
        Me.programnamelbl.Location = New System.Drawing.Point(45, 405)
        Me.programnamelbl.Name = "programnamelbl"
        Me.programnamelbl.Size = New System.Drawing.Size(71, 13)
        Me.programnamelbl.TabIndex = 129
        Me.programnamelbl.Text = "programname"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToResizeColumns = False
        Me.DataGridView2.AllowUserToResizeRows = False
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.ColumnHeadersVisible = False
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(56, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Coral
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView2.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView2.EnableHeadersVisualStyles = False
        Me.DataGridView2.Location = New System.Drawing.Point(50, 120)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(63, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView2.RowHeadersVisible = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.DataGridView2.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(436, 351)
        Me.DataGridView2.TabIndex = 131
        Me.DataGridView2.Visible = False
        '
        'officeidlbl
        '
        Me.officeidlbl.AutoSize = True
        Me.officeidlbl.ForeColor = System.Drawing.Color.DarkOrange
        Me.officeidlbl.Location = New System.Drawing.Point(136, 405)
        Me.officeidlbl.Name = "officeidlbl"
        Me.officeidlbl.Size = New System.Drawing.Size(41, 13)
        Me.officeidlbl.TabIndex = 132
        Me.officeidlbl.Text = "officeid"
        '
        'AddProgram
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(528, 594)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.programnamelbl)
        Me.Controls.Add(Me.programcodelbl)
        Me.Controls.Add(Me.sectorguidedlbl)
        Me.Controls.Add(Me.updatelbl)
        Me.Controls.Add(Me.subsectoridlbl)
        Me.Controls.Add(Me.sectorlbl)
        Me.Controls.Add(Me.progidlbl)
        Me.Controls.Add(Me.Programnametxt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Cancelbtn)
        Me.Controls.Add(Me.Officenametxt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Descriptiontxt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Savebtn)
        Me.Controls.Add(Me.officeidlbl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AddProgram"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddProgram"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Cancelbtn As Button
    Friend WithEvents Officenametxt As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label2 As Label
    Friend WithEvents Descriptiontxt As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label3 As Label
    Friend WithEvents Savebtn As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Titletxt As Label
    Friend WithEvents Programnametxt As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label1 As Label
    Friend WithEvents progidlbl As Label
    Friend WithEvents sectorlbl As Label
    Friend WithEvents subsectoridlbl As Label
    Friend WithEvents programcodelbl As Label
    Friend WithEvents sectorguidedlbl As Label
    Friend WithEvents updatelbl As Label
    Friend WithEvents programnamelbl As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents officeidlbl As Label
End Class
