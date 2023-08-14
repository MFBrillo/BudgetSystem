Public Class UC_Item
    Inherits UserControl
    Public Property ItemText As String
        Get
            Return lblText.Text
        End Get
        Set(ByVal value As String)
            lblText.Text = value
        End Set
    End Property
    Public Property ItemAmount As String
        Get
            Return lblAmount.Text
        End Get
        Set(ByVal value As String)
            lblAmount.Text = value
        End Set
    End Property

    'Private _backgroundColor As Color = Color.White

    'Public Property BackgroundColor As Color
    '    Get
    '        Return _backgroundColor
    '    End Get
    '    Set(value As Color)
    '        _backgroundColor = value
    '        Me.BackColor = value
    '    End Set
    'End Property

End Class
