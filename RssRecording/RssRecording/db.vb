Imports System.Data.SqlClient
Public Class db
    Public Function connect() As SqlConnection
        Return New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dpope3\Desktop\RssRecording\RssRecording\SchoolRssRecording.mdf;Integrated Security=True")
    End Function

End Class
