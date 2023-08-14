<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class YesNoPrompt
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(YesNoPrompt))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.AppName = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BunifuGradientPanel2 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.NoBtn = New System.Windows.Forms.Button()
        Me.YesBtn = New System.Windows.Forms.Button()
        Me.MsgText = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TitleText = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.BunifuGradientPanel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.AppName)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(206, 378)
        Me.Panel2.TabIndex = 13
        '
        'AppName
        '
        Me.AppName.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AppName.BackColor = System.Drawing.Color.Transparent
        Me.AppName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AppName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.AppName.Location = New System.Drawing.Point(4, 237)
        Me.AppName.Name = "AppName"
        Me.AppName.Size = New System.Drawing.Size(199, 62)
        Me.AppName.TabIndex = 1
        Me.AppName.Text = "APPNAME"
        Me.AppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'BunifuGradientPanel2
        '
        Me.BunifuGradientPanel2.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel2.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel2.Controls.Add(Me.TitleText)
        Me.BunifuGradientPanel2.Controls.Add(Me.NoBtn)
        Me.BunifuGradientPanel2.Controls.Add(Me.YesBtn)
        Me.BunifuGradientPanel2.Controls.Add(Me.MsgText)
        Me.BunifuGradientPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.BunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.Teal
        Me.BunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.BunifuGradientPanel2.GradientTopRight = System.Drawing.Color.Teal
        Me.BunifuGradientPanel2.Location = New System.Drawing.Point(206, 0)
        Me.BunifuGradientPanel2.Name = "BunifuGradientPanel2"
        Me.BunifuGradientPanel2.Quality = 10
        Me.BunifuGradientPanel2.Size = New System.Drawing.Size(459, 378)
        Me.BunifuGradientPanel2.TabIndex = 14
        '
        'NoBtn
        '
        Me.NoBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.NoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NoBtn.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NoBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.NoBtn.Location = New System.Drawing.Point(249, 294)
        Me.NoBtn.Name = "NoBtn"
        Me.NoBtn.Size = New System.Drawing.Size(91, 45)
        Me.NoBtn.TabIndex = 15
        Me.NoBtn.Text = "No"
        Me.NoBtn.UseVisualStyleBackColor = False
        '
        'YesBtn
        '
        Me.YesBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.YesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.YesBtn.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.YesBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.YesBtn.Location = New System.Drawing.Point(122, 294)
        Me.YesBtn.Name = "YesBtn"
        Me.YesBtn.Size = New System.Drawing.Size(91, 45)
        Me.YesBtn.TabIndex = 14
        Me.YesBtn.Text = "Yes"
        Me.YesBtn.UseVisualStyleBackColor = False
        '
        'MsgText
        '
        Me.MsgText.BackColor = System.Drawing.Color.Transparent
        Me.MsgText.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MsgText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.MsgText.Location = New System.Drawing.Point(3, 113)
        Me.MsgText.Name = "MsgText"
        Me.MsgText.Size = New System.Drawing.Size(459, 154)
        Me.MsgText.TabIndex = 12
        Me.MsgText.Text = "MESSAGE"
        Me.MsgText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Moises.My.Resources.Resources.CAPIZ
        Me.PictureBox1.Location = New System.Drawing.Point(9, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(188, 169)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'TitleText
        '
        Me.TitleText.BackColor = System.Drawing.Color.Transparent
        Me.TitleText.Font = New System.Drawing.Font("Tahoma", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleText.ForeColor = System.Drawing.Color.White
        Me.TitleText.Location = New System.Drawing.Point(0, 9)
        Me.TitleText.Name = "TitleText"
        Me.TitleText.Size = New System.Drawing.Size(459, 77)
        Me.TitleText.TabIndex = 16
        Me.TitleText.Text = "TITLE TEXT"
        Me.TitleText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'YesNoPrompt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(665, 378)
        Me.ControlBox = False
        Me.Controls.Add(Me.BunifuGradientPanel2)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "YesNoPrompt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "YesNoPromt"
        Me.Panel2.ResumeLayout(False)
        Me.BunifuGradientPanel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuGradientPanel2 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents NoBtn As Button
    Friend WithEvents YesBtn As Button
    Friend WithEvents MsgText As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents AppName As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TitleText As Label
End Class
