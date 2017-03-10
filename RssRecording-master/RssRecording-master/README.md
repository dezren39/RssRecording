# RssRecording
VB.NET Project for school. I had to make a form that accepted and saved input to a database, but I also wanted to try my hand at multiple forms and pulling web content into my program. I think it turned out well. I'd like to make the story form nicer looking, and I'd also like to implement an RSS icon on the main form and pull icons for each RSS feed which would either get pulled each time one is opened, or stored in the DB and pulled each time the refresh button is pressed.

    Option Explicit On
    Option Strict On

    Imports System.ComponentModel
    Imports System.Data.SqlClient
    Imports System.Data.SqlTypes
    Imports System.Xml

    'Resources used include:
    '   http://btk.tillnagel.com/tutorials/rss-feeds-processing.html
    '   https://channel9.msdn.com/coding4fun/articles/A-Simple-RSS-Feed
    '   https://www.codeproject.com/articles/820669/how-to-parse-rss-feeds-in-net
    '   https://msdn.microsoft.com/en-us/library/bb918016.aspx

    Public Class RssMainForm
        Public Shared rssList As New BindingList(Of Rss)
        Dim selectedRss As Rss

        Public Function DbConnectString() As SqlConnection
            Dim dbConnect As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=S:\Downloadsf\RssRecording-master\RssRecording\RssRecording\RssRecording.mdf;Integrated Security=True")
            Return dbConnect
        End Function

        Public Sub Reload(sender As Object, e As EventArgs)
            rssList.Clear()
            RssMainForm_Load(sender, e)
        End Sub

        Public Sub RssMainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Dim dbConnect As SqlConnection = DbConnectString()
            lbxRss.DataSource = rssList
            lbxRss.DisplayMember = "Title"

            Try
                dbConnect.Open()
                Dim selectCommand As New SqlCommand("SELECT * FROM Rss", dbConnect)
                Dim reader As SqlDataReader = selectCommand.ExecuteReader()

                If reader.HasRows Then
                    While reader.Read
                        Dim dbRss As New Rss(reader.Item("Url").ToString) With {
                            .Id = CInt(reader.Item("Id"))
                        }

                        If Not IsDBNull(reader.Item("LastXML")) Then
                            Try
                                dbRss.LastXML = XDocument.Parse(CType(reader.Item("LastXML"), String))
                            Catch ex As Exception
                                MessageBox.Show("A5: Sorry, Error. Try again.")
                            End Try
                        End If

                        If IsDBNull(reader.Item("Title")) Or reader.Item("Title") Is "" Then
                            dbRss.Title = dbRss.Url
                        Else
                            dbRss.Title = reader.Item("Title").ToString
                        End If
                        rssList.Add(dbRss)
                    End While

                    lbxRss.SelectedIndex = rssList.Count - 1
                End If
                reader.Close()
            Catch ex As Exception
                MessageBox.Show("A6: Sorry, Error. Try again.")
            Finally
                dbConnect.Close()
                dbConnect.Dispose()
            End Try
        End Sub

        Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
            Dim dbConnect As SqlConnection = DbConnectString()

            If txtUrl.Text Is Nothing Then
                MessageBox.Show("A1: Sorry, URL required. Please try again.")
            Else
                Dim urlHolder = txtUrl.Text.ToLower

                If Not urlHolder.StartsWith("http://") And Not urlHolder.StartsWith("https://") Then
                    txtUrl.Text = txtUrl.Text.Insert(0, "http://")
                End If

                Dim newRss As New Rss(txtUrl.Text)
                Dim sqlString As String = "INSERT INTO Rss (Url, LastXML, Title) VALUES (@url, @xml, @title)"
                Dim insertUpdate As New SqlCommand(sqlString, dbConnect)

                Try
                    Dim xmlVal = XDocument.Load(newRss.Url)
                    newRss.LastXML = xmlVal
                Catch ex As Exception
                    MessageBox.Show("A2: Sorry, invalid URL or web error. Please try again." + vbCrLf + newRss.Url)
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
                        Dim identQuery As New SqlCommand("SELECT IDENT_CURRENT('Rss')", dbConnect)
                        Dim identReader As SqlDataReader = identQuery.ExecuteReader()
                        If identReader.HasRows Then
                            identReader.Read()
                            newRss.Id = CInt(identReader.Item(0))
                            identReader.Close()
                        End If
                        txtUrl.Text = ""
                        rssList.Add(newRss)
                        lbxRss.SelectedIndex = lbxRss.Items.Count - 1
                        LbxRss_DoubleClick(sender, e)
                    Else
                        MessageBox.Show("A3: Sorry, DB Error. Try again.")
                    End If
                Catch ex As Exception
                    MessageBox.Show("A4: Sorry, DB Error. Try again.")
                Finally
                    dbConnect.Close()
                    dbConnect.Dispose()
                End Try
            End If
        End Sub

        Private Sub BtnDel_Click(sender As Object, e As EventArgs) Handles BtnDel.Click
            If Not lbxRss.SelectedItem Is Nothing Then
                Dim dbConnect As SqlConnection = DbConnectString()
                Dim deleteCommand As New SqlCommand("DELETE FROM Rss WHERE Id=@id", dbConnect)
                deleteCommand.Parameters.AddWithValue("@id", selectedRss.Id)

                Try
                    dbConnect.Open()
                    deleteCommand.ExecuteNonQuery()
                    rssList.RemoveAt(CInt(lbxRss.SelectedIndex))
                Catch ex As Exception
                    MessageBox.Show("A7: Sorry, DB Error. Try again.")
                Finally
                    dbConnect.Close()
                    dbConnect.Dispose()
                End Try
            End If
        End Sub

        Private Sub LbxRss_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxRss.SelectedIndexChanged
            selectedRss = CType(lbxRss.SelectedItem, Rss)
        End Sub

        Private Sub LbxRss_DoubleClick(sender As Object, e As EventArgs) Handles lbxRss.DoubleClick
            Dim singleForm As New RssSingleForm(selectedRss)
            singleForm.Show()
        End Sub
    End Class