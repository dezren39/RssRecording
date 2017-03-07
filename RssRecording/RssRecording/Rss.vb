Public Class Rss
    Sub New()

    End Sub
    Sub New(ByVal urlValue As String)
        Me.Url = urlValue

    End Sub

    Private LastXmlValue As XDocument
    Public Property LastXML() As XDocument
        Get
            Return LastXmlValue
        End Get
        Set(ByVal value As XDocument)
            LastXmlValue = value
        End Set
    End Property

    Private TitleValue As String
    Public Property Title() As String
        Get
            Return TitleValue
        End Get
        Set(ByVal value As String)
            TitleValue = value
        End Set
    End Property

    Private UrlValue As String
    Public Property Url() As String
        Get
            Return UrlValue
        End Get
        Set(ByVal value As String)
            UrlValue = value
        End Set
    End Property

End Class
