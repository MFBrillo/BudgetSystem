﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ChartofAccounts
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChartofAccounts))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Descriptionbtn = New System.Windows.Forms.Button()
        Me.Searchtxt = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.TitleBar = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.AddSubcategorybtn = New System.Windows.Forms.Button()
        Me.AddCategorybtn = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Addbtn = New System.Windows.Forms.Button()
        Me.Savebtn = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Decriptiontxt = New System.Windows.Forms.TextBox()
        Me.CategoryIDtxt = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.AccountCodetxt = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.AssetIDTxt = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Accountnametxt = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.SubcategoryIDtxt = New System.Windows.Forms.ComboBox()
        Me.AccountIDtxt = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuGradientPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1319, 50)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "CHART OF ACCOUNTS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel1)
        Me.Panel3.Controls.Add(Me.DataGridView1)
        Me.Panel3.Controls.Add(Me.BunifuGradientPanel1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(457, 50)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(862, 810)
        Me.Panel3.TabIndex = 75
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Descriptionbtn)
        Me.Panel1.Controls.Add(Me.Searchtxt)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 38)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(862, 37)
        Me.Panel1.TabIndex = 73
        '
        'Descriptionbtn
        '
        Me.Descriptionbtn.Dock = System.Windows.Forms.DockStyle.Right
        Me.Descriptionbtn.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Descriptionbtn.Location = New System.Drawing.Point(708, 0)
        Me.Descriptionbtn.Name = "Descriptionbtn"
        Me.Descriptionbtn.Size = New System.Drawing.Size(154, 37)
        Me.Descriptionbtn.TabIndex = 1
        Me.Descriptionbtn.Text = "Add Description"
        Me.Descriptionbtn.UseVisualStyleBackColor = True
        '
        'Searchtxt
        '
        Me.Searchtxt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Searchtxt.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Searchtxt.Location = New System.Drawing.Point(6, 5)
        Me.Searchtxt.Name = "Searchtxt"
        Me.Searchtxt.Size = New System.Drawing.Size(679, 27)
        Me.Searchtxt.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(5, 76)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 35
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(853, 709)
        Me.DataGridView1.TabIndex = 0
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Me.TitleBar)
        Me.BunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(862, 38)
        Me.BunifuGradientPanel1.TabIndex = 72
        '
        'TitleBar
        '
        Me.TitleBar.BackColor = System.Drawing.Color.Transparent
        Me.TitleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.TitleBar.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleBar.ForeColor = System.Drawing.Color.White
        Me.TitleBar.Location = New System.Drawing.Point(0, 0)
        Me.TitleBar.Name = "TitleBar"
        Me.TitleBar.Size = New System.Drawing.Size(862, 38)
        Me.TitleBar.TabIndex = 1
        Me.TitleBar.Text = "Chart of Account"
        Me.TitleBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.AddSubcategorybtn)
        Me.Panel2.Controls.Add(Me.AddCategorybtn)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Addbtn)
        Me.Panel2.Controls.Add(Me.Savebtn)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.Decriptiontxt)
        Me.Panel2.Controls.Add(Me.CategoryIDtxt)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.AccountCodetxt)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.AssetIDTxt)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Accountnametxt)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.SubcategoryIDtxt)
        Me.Panel2.Controls.Add(Me.AccountIDtxt)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 50)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(457, 810)
        Me.Panel2.TabIndex = 74
        '
        'AddSubcategorybtn
        '
        Me.AddSubcategorybtn.Location = New System.Drawing.Point(353, 193)
        Me.AddSubcategorybtn.Name = "AddSubcategorybtn"
        Me.AddSubcategorybtn.Size = New System.Drawing.Size(77, 23)
        Me.AddSubcategorybtn.TabIndex = 78
        Me.AddSubcategorybtn.Text = "Add"
        Me.AddSubcategorybtn.UseVisualStyleBackColor = True
        '
        'AddCategorybtn
        '
        Me.AddCategorybtn.Location = New System.Drawing.Point(353, 125)
        Me.AddCategorybtn.Name = "AddCategorybtn"
        Me.AddCategorybtn.Size = New System.Drawing.Size(77, 23)
        Me.AddCategorybtn.TabIndex = 77
        Me.AddCategorybtn.Text = "Add"
        Me.AddCategorybtn.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(353, 62)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(77, 23)
        Me.Button1.TabIndex = 75
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Addbtn
        '
        Me.Addbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Addbtn.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Addbtn.ForeColor = System.Drawing.Color.White
        Me.Addbtn.Location = New System.Drawing.Point(30, 632)
        Me.Addbtn.Name = "Addbtn"
        Me.Addbtn.Size = New System.Drawing.Size(402, 40)
        Me.Addbtn.TabIndex = 71
        Me.Addbtn.Text = "ADD"
        Me.Addbtn.UseVisualStyleBackColor = False
        '
        'Savebtn
        '
        Me.Savebtn.BackColor = System.Drawing.Color.Crimson
        Me.Savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Savebtn.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Savebtn.ForeColor = System.Drawing.Color.White
        Me.Savebtn.Location = New System.Drawing.Point(30, 692)
        Me.Savebtn.Name = "Savebtn"
        Me.Savebtn.Size = New System.Drawing.Size(402, 40)
        Me.Savebtn.TabIndex = 42
        Me.Savebtn.Text = "SAVE"
        Me.Savebtn.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label14.Location = New System.Drawing.Point(26, 235)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(69, 16)
        Me.Label14.TabIndex = 43
        Me.Label14.Text = "Account ID"
        '
        'Decriptiontxt
        '
        Me.Decriptiontxt.Location = New System.Drawing.Point(29, 464)
        Me.Decriptiontxt.Multiline = True
        Me.Decriptiontxt.Name = "Decriptiontxt"
        Me.Decriptiontxt.Size = New System.Drawing.Size(404, 91)
        Me.Decriptiontxt.TabIndex = 70
        '
        'CategoryIDtxt
        '
        Me.CategoryIDtxt.BackColor = System.Drawing.Color.White
        Me.CategoryIDtxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CategoryIDtxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CategoryIDtxt.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.CategoryIDtxt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CategoryIDtxt.FormattingEnabled = True
        Me.CategoryIDtxt.Location = New System.Drawing.Point(29, 124)
        Me.CategoryIDtxt.Name = "CategoryIDtxt"
        Me.CategoryIDtxt.Size = New System.Drawing.Size(318, 24)
        Me.CategoryIDtxt.TabIndex = 62
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label12.Location = New System.Drawing.Point(26, 101)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 16)
        Me.Label12.TabIndex = 61
        Me.Label12.Text = "Category"
        '
        'AccountCodetxt
        '
        Me.AccountCodetxt.BackColor = System.Drawing.Color.White
        Me.AccountCodetxt.BorderColorFocused = System.Drawing.Color.Black
        Me.AccountCodetxt.BorderColorIdle = System.Drawing.Color.White
        Me.AccountCodetxt.BorderColorMouseHover = System.Drawing.Color.Black
        Me.AccountCodetxt.BorderThickness = 1
        Me.AccountCodetxt.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.AccountCodetxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.AccountCodetxt.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccountCodetxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.AccountCodetxt.isPassword = False
        Me.AccountCodetxt.Location = New System.Drawing.Point(30, 329)
        Me.AccountCodetxt.Margin = New System.Windows.Forms.Padding(4)
        Me.AccountCodetxt.MaxLength = 32767
        Me.AccountCodetxt.Name = "AccountCodetxt"
        Me.AccountCodetxt.Size = New System.Drawing.Size(400, 28)
        Me.AccountCodetxt.TabIndex = 68
        Me.AccountCodetxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label16.Location = New System.Drawing.Point(28, 373)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(90, 16)
        Me.Label16.TabIndex = 45
        Me.Label16.Text = "Account Name"
        '
        'AssetIDTxt
        '
        Me.AssetIDTxt.BackColor = System.Drawing.Color.White
        Me.AssetIDTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AssetIDTxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AssetIDTxt.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.AssetIDTxt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.AssetIDTxt.FormattingEnabled = True
        Me.AssetIDTxt.Location = New System.Drawing.Point(29, 61)
        Me.AssetIDTxt.Name = "AssetIDTxt"
        Me.AssetIDTxt.Size = New System.Drawing.Size(320, 24)
        Me.AssetIDTxt.TabIndex = 47
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Location = New System.Drawing.Point(26, 41)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(55, 16)
        Me.Label11.TabIndex = 40
        Me.Label11.Text = "Asset ID"
        '
        'Accountnametxt
        '
        Me.Accountnametxt.BackColor = System.Drawing.Color.White
        Me.Accountnametxt.BorderColorFocused = System.Drawing.Color.Black
        Me.Accountnametxt.BorderColorIdle = System.Drawing.Color.White
        Me.Accountnametxt.BorderColorMouseHover = System.Drawing.Color.Black
        Me.Accountnametxt.BorderThickness = 1
        Me.Accountnametxt.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.Accountnametxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Accountnametxt.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Accountnametxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Accountnametxt.isPassword = False
        Me.Accountnametxt.Location = New System.Drawing.Point(29, 393)
        Me.Accountnametxt.Margin = New System.Windows.Forms.Padding(4)
        Me.Accountnametxt.MaxLength = 32767
        Me.Accountnametxt.Name = "Accountnametxt"
        Me.Accountnametxt.Size = New System.Drawing.Size(404, 31)
        Me.Accountnametxt.TabIndex = 56
        Me.Accountnametxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label13.Location = New System.Drawing.Point(26, 170)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(85, 16)
        Me.Label13.TabIndex = 63
        Me.Label13.Text = "Sub Category"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label15.Location = New System.Drawing.Point(28, 307)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(86, 16)
        Me.Label15.TabIndex = 65
        Me.Label15.Text = "Account Code"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label17.Location = New System.Drawing.Point(26, 443)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(71, 16)
        Me.Label17.TabIndex = 46
        Me.Label17.Text = "Description"
        '
        'SubcategoryIDtxt
        '
        Me.SubcategoryIDtxt.BackColor = System.Drawing.Color.White
        Me.SubcategoryIDtxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SubcategoryIDtxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SubcategoryIDtxt.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.SubcategoryIDtxt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.SubcategoryIDtxt.FormattingEnabled = True
        Me.SubcategoryIDtxt.Location = New System.Drawing.Point(29, 192)
        Me.SubcategoryIDtxt.Name = "SubcategoryIDtxt"
        Me.SubcategoryIDtxt.Size = New System.Drawing.Size(320, 24)
        Me.SubcategoryIDtxt.TabIndex = 64
        '
        'AccountIDtxt
        '
        Me.AccountIDtxt.BackColor = System.Drawing.Color.White
        Me.AccountIDtxt.BorderColorFocused = System.Drawing.Color.Black
        Me.AccountIDtxt.BorderColorIdle = System.Drawing.Color.White
        Me.AccountIDtxt.BorderColorMouseHover = System.Drawing.Color.Black
        Me.AccountIDtxt.BorderThickness = 1
        Me.AccountIDtxt.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.AccountIDtxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.AccountIDtxt.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccountIDtxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.AccountIDtxt.isPassword = False
        Me.AccountIDtxt.Location = New System.Drawing.Point(29, 258)
        Me.AccountIDtxt.Margin = New System.Windows.Forms.Padding(4)
        Me.AccountIDtxt.MaxLength = 32767
        Me.AccountIDtxt.Name = "AccountIDtxt"
        Me.AccountIDtxt.Size = New System.Drawing.Size(399, 28)
        Me.AccountIDtxt.TabIndex = 57
        Me.AccountIDtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 10
        '
        'ChartofAccounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ChartofAccounts"
        Me.Size = New System.Drawing.Size(1319, 860)
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents TitleBar As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Addbtn As Button
    Friend WithEvents Savebtn As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents Decriptiontxt As TextBox
    Friend WithEvents CategoryIDtxt As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents AccountCodetxt As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label16 As Label
    Friend WithEvents AssetIDTxt As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Accountnametxt As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents SubcategoryIDtxt As ComboBox
    Friend WithEvents AccountIDtxt As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Button1 As Button
    Friend WithEvents AddSubcategorybtn As Button
    Friend WithEvents AddCategorybtn As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Searchtxt As TextBox
    Friend WithEvents Descriptionbtn As Button
End Class
