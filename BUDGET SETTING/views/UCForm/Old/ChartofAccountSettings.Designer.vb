<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ChartofAccountSettings
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Subcategorybtn = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Categorybtn = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Assetbtn = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.Panel7.SuspendLayout()
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
        Me.Label1.Size = New System.Drawing.Size(1162, 50)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "CHART OF ACCOUNT SETTING"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.Subcategorybtn)
        Me.Panel7.Controls.Add(Me.Categorybtn)
        Me.Panel7.Controls.Add(Me.Assetbtn)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 50)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1162, 59)
        Me.Panel7.TabIndex = 14
        '
        'Subcategorybtn
        '
        Me.Subcategorybtn.Active = False
        Me.Subcategorybtn.Activecolor = System.Drawing.Color.White
        Me.Subcategorybtn.BackColor = System.Drawing.Color.White
        Me.Subcategorybtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Subcategorybtn.BorderRadius = 0
        Me.Subcategorybtn.ButtonText = "SUBCATEGORY"
        Me.Subcategorybtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Subcategorybtn.DisabledColor = System.Drawing.Color.Gray
        Me.Subcategorybtn.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Subcategorybtn.Iconcolor = System.Drawing.Color.Transparent
        Me.Subcategorybtn.Iconimage = Nothing
        Me.Subcategorybtn.Iconimage_right = Nothing
        Me.Subcategorybtn.Iconimage_right_Selected = Nothing
        Me.Subcategorybtn.Iconimage_Selected = Nothing
        Me.Subcategorybtn.IconMarginLeft = 0
        Me.Subcategorybtn.IconMarginRight = 0
        Me.Subcategorybtn.IconRightVisible = True
        Me.Subcategorybtn.IconRightZoom = 0R
        Me.Subcategorybtn.IconVisible = True
        Me.Subcategorybtn.IconZoom = 90.0R
        Me.Subcategorybtn.IsTab = False
        Me.Subcategorybtn.Location = New System.Drawing.Point(673, 8)
        Me.Subcategorybtn.Name = "Subcategorybtn"
        Me.Subcategorybtn.Normalcolor = System.Drawing.Color.White
        Me.Subcategorybtn.OnHovercolor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Subcategorybtn.OnHoverTextColor = System.Drawing.SystemColors.Info
        Me.Subcategorybtn.Padding = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.Subcategorybtn.selected = False
        Me.Subcategorybtn.Size = New System.Drawing.Size(241, 48)
        Me.Subcategorybtn.TabIndex = 2
        Me.Subcategorybtn.Text = "SUBCATEGORY"
        Me.Subcategorybtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Subcategorybtn.Textcolor = System.Drawing.Color.Black
        Me.Subcategorybtn.TextFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Categorybtn
        '
        Me.Categorybtn.Active = False
        Me.Categorybtn.Activecolor = System.Drawing.Color.White
        Me.Categorybtn.BackColor = System.Drawing.Color.White
        Me.Categorybtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Categorybtn.BorderRadius = 0
        Me.Categorybtn.ButtonText = "CATEGORY"
        Me.Categorybtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Categorybtn.DisabledColor = System.Drawing.Color.Gray
        Me.Categorybtn.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Categorybtn.Iconcolor = System.Drawing.Color.Transparent
        Me.Categorybtn.Iconimage = Nothing
        Me.Categorybtn.Iconimage_right = Nothing
        Me.Categorybtn.Iconimage_right_Selected = Nothing
        Me.Categorybtn.Iconimage_Selected = Nothing
        Me.Categorybtn.IconMarginLeft = 0
        Me.Categorybtn.IconMarginRight = 0
        Me.Categorybtn.IconRightVisible = True
        Me.Categorybtn.IconRightZoom = 0R
        Me.Categorybtn.IconVisible = True
        Me.Categorybtn.IconZoom = 90.0R
        Me.Categorybtn.IsTab = False
        Me.Categorybtn.Location = New System.Drawing.Point(412, 8)
        Me.Categorybtn.Name = "Categorybtn"
        Me.Categorybtn.Normalcolor = System.Drawing.Color.White
        Me.Categorybtn.OnHovercolor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Categorybtn.OnHoverTextColor = System.Drawing.SystemColors.Info
        Me.Categorybtn.Padding = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.Categorybtn.selected = False
        Me.Categorybtn.Size = New System.Drawing.Size(241, 48)
        Me.Categorybtn.TabIndex = 1
        Me.Categorybtn.Text = "CATEGORY"
        Me.Categorybtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Categorybtn.Textcolor = System.Drawing.Color.Black
        Me.Categorybtn.TextFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Assetbtn
        '
        Me.Assetbtn.Active = False
        Me.Assetbtn.Activecolor = System.Drawing.Color.White
        Me.Assetbtn.BackColor = System.Drawing.Color.White
        Me.Assetbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Assetbtn.BorderRadius = 0
        Me.Assetbtn.ButtonText = "ASSET"
        Me.Assetbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Assetbtn.DisabledColor = System.Drawing.Color.Gray
        Me.Assetbtn.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Assetbtn.Iconcolor = System.Drawing.Color.Transparent
        Me.Assetbtn.Iconimage = Nothing
        Me.Assetbtn.Iconimage_right = Nothing
        Me.Assetbtn.Iconimage_right_Selected = Nothing
        Me.Assetbtn.Iconimage_Selected = Nothing
        Me.Assetbtn.IconMarginLeft = 0
        Me.Assetbtn.IconMarginRight = 0
        Me.Assetbtn.IconRightVisible = True
        Me.Assetbtn.IconRightZoom = 0R
        Me.Assetbtn.IconVisible = True
        Me.Assetbtn.IconZoom = 90.0R
        Me.Assetbtn.IsTab = False
        Me.Assetbtn.Location = New System.Drawing.Point(165, 8)
        Me.Assetbtn.Name = "Assetbtn"
        Me.Assetbtn.Normalcolor = System.Drawing.Color.White
        Me.Assetbtn.OnHovercolor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Assetbtn.OnHoverTextColor = System.Drawing.SystemColors.Info
        Me.Assetbtn.Padding = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.Assetbtn.selected = False
        Me.Assetbtn.Size = New System.Drawing.Size(241, 48)
        Me.Assetbtn.TabIndex = 0
        Me.Assetbtn.Text = "ASSET"
        Me.Assetbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Assetbtn.Textcolor = System.Drawing.Color.Black
        Me.Assetbtn.TextFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MainPanel
        '
        Me.MainPanel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MainPanel.Location = New System.Drawing.Point(11, 128)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(1139, 755)
        Me.MainPanel.TabIndex = 15
        '
        'ChartofAccountSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.MainPanel)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ChartofAccountSettings"
        Me.Size = New System.Drawing.Size(1162, 900)
        Me.Panel7.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Assetbtn As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Subcategorybtn As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Categorybtn As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents MainPanel As Panel
End Class
