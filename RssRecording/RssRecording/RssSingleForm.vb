Imports System.Data.SqlClient

Public Class RssSingleForm
    Dim selectedRss As Rss

    Sub New(ByRef rssVal As Rss)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.selectedRss = rssVal

        txtName.Text = selectedRss.Title
        txtUrl.Text = selectedRss.Url
        txtRss.Text = selectedRss.LastXML.ToString
        lblDispItem.Text = selectedRss.LastXML.<rss>.<channel>.<item>.<title>.Value
        lblDispDesc.Text = selectedRss.LastXML.<rss>.<channel>.<description>.Value
    End Sub

    Private Sub lblMod_Click(sender As Object, e As EventArgs) Handles lblMod.Click

        Dim dbConnect As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dpope3\Desktop\RssRecording\RssRecording\SchoolRssRecording.mdf;Integrated Security=True") ' "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & Environment.CurrentDirectory & "\RssRecording.mdf;Integrated Security=True")
        Dim sqlString As String = "UPDATE Rss SET Url=@url, LastXML=@xml, Title=@title WHERE Id=@id"
        Dim insertUpdate As New SqlCommand(sqlString, dbConnect)

        Try

            selectedRss.LastXML = XDocument.Parse(txtRss.Text)

        Catch ex As Exception

            MessageBox.Show("1: Sorry, invalid XML. Please try again.")
            Return

        End Try

        selectedRss.Title = txtName.Text
        selectedRss.Url = txtUrl.Text

        insertUpdate.Parameters.AddWithValue("@id", selectedRss.Id)
        insertUpdate.Parameters.AddWithValue("@title", selectedRss.Title)
        insertUpdate.Parameters.AddWithValue("@url", selectedRss.Url)
        insertUpdate.Parameters.AddWithValue("@xml", selectedRss.LastXML.ToString)

        Try

            dbConnect.Open()

            Dim rowsAffected = insertUpdate.ExecuteNonQuery()

            If rowsAffected = 1 Then

                MessageBox.Show(txtName.Text + " was successfully modified.")
                RssMainForm.rssList.Item(RssMainForm.rssList.IndexOf(selectedRss)) = selectedRss

            Else

                MessageBox.Show("2. Sorry, DB Error. Try again.")

            End If

        Catch ex As Exception

            MessageBox.Show("3. Sorry, DB Error. Try again.")

        Finally

            dbConnect.Close()
            dbConnect.Dispose()

        End Try

    End Sub

End Class