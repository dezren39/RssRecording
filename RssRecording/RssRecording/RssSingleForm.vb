Imports System.Data.SqlClient

Public Class RssSingleForm
    Dim selectedRss As Rss()
    Sub New(ByRef rssVal As Rss)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim selectedRss As Rss = rssVal

        txtName.Text = selectedRss.Title
        txtUrl.Text = selectedRss.Url
        txtRss.Text = selectedRss.LastXML.ToString
        lblDispItem.Text = selectedRss.LastXML.<rss>.<channel>.<item>.<title>.Value
        lblDispDesc.Text = selectedRss.LastXML.<rss>.<channel>.<description>.Value
    End Sub
    Private Sub lblMod_Click(sender As Object, e As EventArgs) Handles lblMod.Click

        Dim dbConnect As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\drewr\Desktop\RssRecording\RssRecording\RssRecording.mdf;Integrated Security=True") ' "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & Environment.CurrentDirectory & "\RssRecording.mdf;Integrated Security=True")
        Dim sqlString As String = "UPDATE Rss SET Url=@url, LastXML=@xml, Title=@title"
        Dim insertUpdate As New SqlCommand(sqlString, dbConnect)

        insertUpdate.Parameters.AddWithValue("@title", txtName.Text)
        insertUpdate.Parameters.AddWithValue("@url", txtUrl.Text)
        insertUpdate.Parameters.AddWithValue("@xml", txtRss.Text)

        Try

            dbConnect.Open()

            Dim rowsAffected = insertUpdate.ExecuteNonQuery()

            If rowsAffected = 1 Then

                MessageBox.Show(txtName.Text + " was successfully modified.")

            Else

                MessageBox.Show("1. Sorry, Error. Try again.")

            End If

        Catch ex As Exception

            MessageBox.Show("2. Sorry, Error. Try again.")

        Finally

            dbConnect.Close()

        End Try

    End Sub

End Class