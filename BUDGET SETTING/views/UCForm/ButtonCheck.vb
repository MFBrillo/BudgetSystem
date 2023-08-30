Public Class ButtonCheck
    Inherits UserControl

    Public Sub New()
        InitializeComponent()
        LblLineColor = False ' Initialize the property for each instance
    End Sub

    Private _buttontext As String
    Public Property Buttontext As String
        Get
            Return _buttontext
        End Get
        Set(ByVal value As String)
            _buttontext = value
            BtnText.Text = value
        End Set
    End Property

    Private _lblLineColor As Boolean
    Public Property LblLineColor As Boolean
        Get
            Return _lblLineColor
        End Get
        Set(value As Boolean)
            _lblLineColor = value
            LineColor.Visible = value
        End Set
    End Property

    ' ... (existing code for UserBtn class)

    Private Sub BtnText_Click(sender As Object, e As EventArgs) Handles BtnText.Click
        'Me.LblLineColor = True
        'MsgBox(sender.Name)
    End Sub

    Private Sub ButtonCheck_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

