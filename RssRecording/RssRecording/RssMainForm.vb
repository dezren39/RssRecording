Option Explicit On
Option Strict On

Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports System.Xml

Public Class RssMainForm

    'Resources used include:
    '   http://btk.tillnagel.com/tutorials/rss-feeds-processing.html
    '   https://channel9.msdn.com/coding4fun/articles/A-Simple-RSS-Feed
    '   https://www.codeproject.com/articles/820669/how-to-parse-rss-feeds-in-net
    '   https://msdn.microsoft.com/en-us/library/bb918016.aspx

    Dim rssList As New BindingList(Of Rss)
    Dim selectedRss As Rss

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Dim dbConnect As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\drewr\Desktop\RssRecording\RssRecording\RssRecording.mdf;Integrated Security=True") ' "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & Environment.CurrentDirectory & "\RssRecording.mdf;Integrated Security=True")

        If txtUrl.Text Is Nothing Then

            MessageBox.Show("Please enter a feed url.")

        Else

            Dim newRss As New Rss(txtUrl.Text)
            Dim sqlString As String = "INSERT INTO Rss (Url, LastXML, Title) VALUES (@url, @xml, @title)"
            Dim insertUpdate As New SqlCommand(sqlString, dbConnect)

            Try

                Dim xmlVal = XDocument.Load(newRss.Url)
                newRss.LastXML = xmlVal
                ' MessageBox.Show(newRss.LastXML.ToString)

            Catch ex As Exception

                MessageBox.Show("Please enter a valid address, " + newRss.Url)
                Return

            End Try

            newRss.Title = newRss.LastXML.<rss>.<channel>.<title>.Value

            insertUpdate.Parameters.AddWithValue("@url", newRss.Url)
            insertUpdate.Parameters.AddWithValue("@xml", newRss.LastXML.ToString)
            insertUpdate.Parameters.AddWithValue("@title", newRss.Title)

            Try

                dbConnect.Open()

                Dim rowsAffected = insertUpdate.ExecuteNonQuery()

                If rowsAffected = 1 Then

                    txtUrl.Text = ""
                    rssList.Add(newRss)
                    lbxRss.SelectedIndex = lbxRss.Items.Count - 1
                    MessageBox.Show(selectedRss.Title + " was successfully added.")

                Else

                    MessageBox.Show("1: Sorry, Error. Try again.")

                End If

            Catch ex As Exception

                MessageBox.Show("2: Sorry, Error. Try again.")

            Finally

                dbConnect.Close()
                dbConnect.Dispose()

            End Try

        End If

    End Sub

    Private Sub RssMainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim dbConnect As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\drewr\Desktop\RssRecording\RssRecording\RssRecording.mdf;Integrated Security=True")

        lbxRss.DataSource = rssList
        lbxRss.DisplayMember = "Title"

        Try

            dbConnect.Open()

            Dim selectCommand As New SqlCommand("SELECT * FROM Rss", dbConnect)
            Dim reader As SqlDataReader = selectCommand.ExecuteReader()

            If reader.HasRows Then

                While reader.Read

                    Dim dbRss As New Rss(reader.Item("Url").ToString)


                    If Not IsDBNull(reader.Item("LastXML")) Then

                        Try

                            dbRss.LastXML = XDocument.Parse(CType(reader.Item("LastXML"), String))

                        Catch ex As Exception

                            MessageBox.Show("3: Sorry, Error. Try again.")

                        End Try

                    End If

                    If IsDBNull(reader.Item("Title")) Or reader.Item("Title") Is "" Then

                        dbRss.Title = dbRss.Url

                    Else

                        dbRss.Title = reader.Item("Title").ToString

                    End If

                    rssList.Add(dbRss)

                End While

                selectedRss = rssList.Item(rssList.Count - 1)

            End If

        Catch ex As Exception

            MessageBox.Show("4: Sorry, Error. Try again.")

        Finally

            dbConnect.Close()
            dbConnect.Dispose()

        End Try

    End Sub

    Private Sub lbxRss_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxRss.SelectedIndexChanged

        selectedRss = CType(lbxRss.SelectedItem, Rss)

        Dim singleForm As New RssSingleForm(selectedRss)

        singleForm.ShowDialog()

    End Sub

End Class