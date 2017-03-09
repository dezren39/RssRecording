Public Class Rss
    Sub New()
    End Sub

    Sub New(ByVal urlValue As String)
        Me.Url = urlValue
    End Sub

    Private idVal As Integer
    Public Property Id() As Integer
        Get
            Return idVal
        End Get
        Set(ByVal value As Integer)
            idVal = value
        End Set
    End Property

    Private lastXmlValue As XDocument
    Public Property LastXML() As XDocument
        Get
            Return lastXmlValue
        End Get
        Set(ByVal value As XDocument)
            lastXmlValue = value
        End Set
    End Property

    Private titleValue As String
    Public Property Title() As String
        Get
            Return titleValue
        End Get
        Set(ByVal value As String)
            titleValue = value
        End Set
    End Property

    Private urlValue As String
    Public Property Url() As String
        Get
            Return urlValue
        End Get
        Set(ByVal value As String)
            urlValue = value
        End Set
    End Property
End Class
