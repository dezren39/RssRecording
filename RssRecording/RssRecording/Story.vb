Public Class Story
    Sub New(ByVal title As String, ByVal pubDate As String, ByVal link As String, ByVal description As String)
        Me.Title = title
        Me.PubDate = pubDate
        Me.Link = link
        Me.Description = description
    End Sub
    Private titleVal As String
    Public Property Title() As String
        Get
            Return titleVal
        End Get
        Set(ByVal value As String)
            titleVal = value
        End Set
    End Property
    Private pubDateVal As String
    Public Property PubDate() As String
        Get
            Return pubDateVal
        End Get
        Set(ByVal value As String)
            pubDateVal = value
        End Set
    End Property
    Public ReadOnly Property TitleDate() As String
        Get
            Return titleVal + " | " + pubDateVal
        End Get
    End Property
    Private linkVal As String
    Public Property Link() As String
        Get
            Return linkVal
        End Get
        Set(ByVal value As String)
            linkVal = value
        End Set
    End Property
    Private descriptionVal As String
    Public Property Description() As String
        Get
            Return descriptionVal
        End Get
        Set(ByVal value As String)
            descriptionVal = value
        End Set
    End Property
End Class
