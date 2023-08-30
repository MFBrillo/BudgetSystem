<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ButtonCheck
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
        Me.LineColor = New System.Windows.Forms.Label()
        Me.BtnText = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.SuspendLayout()
        '
        'LineColor
        '
        Me.LineColor.AutoSize = True
        Me.LineColor.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LineColor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.LineColor.Location = New System.Drawing.Point(11, 32)
        Me.LineColor.Name = "LineColor"
        Me.LineColor.Size = New System.Drawing.Size(202, 33)
        Me.LineColor.TabIndex = 1
        Me.LineColor.Text = "___________"
        '
        'BtnText
        '
        Me.BtnText.Active = False
        Me.BtnText.Activecolor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.BtnText.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.BtnText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnText.BorderRadius = 0
        Me.BtnText.ButtonText = "ASSET"
        Me.BtnText.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnText.DisabledColor = System.Drawing.Color.Gray
        Me.BtnText.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.BtnText.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnText.Iconimage = Nothing
        Me.BtnText.Iconimage_right = Nothing
        Me.BtnText.Iconimage_right_Selected = Nothing
        Me.BtnText.Iconimage_Selected = Nothing
        Me.BtnText.IconMarginLeft = 0
        Me.BtnText.IconMarginRight = 0
        Me.BtnText.IconRightVisible = True
        Me.BtnText.IconRightZoom = 0R
        Me.BtnText.IconVisible = True
        Me.BtnText.IconZoom = 90.0R
        Me.BtnText.IsTab = False
        Me.BtnText.Location = New System.Drawing.Point(14, 3)
        Me.BtnText.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnText.Name = "BtnText"
        Me.BtnText.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.BtnText.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.BtnText.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnText.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.BtnText.selected = False
        Me.BtnText.Size = New System.Drawing.Size(199, 55)
        Me.BtnText.TabIndex = 124
        Me.BtnText.Text = "ASSET"
        Me.BtnText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnText.Textcolor = System.Drawing.Color.White
        Me.BtnText.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'ButtonCheck
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Controls.Add(Me.BtnText)
        Me.Controls.Add(Me.LineColor)
        Me.Name = "ButtonCheck"
        Me.Size = New System.Drawing.Size(220, 68)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LineColor As Label
    Friend WithEvents BtnText As Bunifu.Framework.UI.BunifuFlatButton
End Class
