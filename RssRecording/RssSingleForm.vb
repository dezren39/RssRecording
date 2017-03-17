Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Xml

Public Class RssSingleForm
    Private selectedRss As Rss
    Private selectedStory As Story
    Private storyList As New BindingList(Of Story)

    Public Sub New(ByRef rssVal As Rss)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Me.selectedRss = rssVal

        Expand_Rss()
        Load_Story()
    End Sub

    Private Sub BtnMod_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Modify_Rss()
    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Refresh_Rss()
    End Sub

    Private Sub Expand_Rss()
        Me.Text = selectedRss.Title

        txtName.Text = selectedRss.Title
        txtUrl.Text = selectedRss.Url
        rtbXml.Text = selectedRss.LastXML.ToString
        lblDispItem.Text = selectedRss.LastXML.<rss>.<channel>.<item>.<title>.Value
        rtbDescr.Text = selectedRss.LastXML.<rss>.<channel>.<description>.Value
    End Sub

    Private Sub LbxItems_DoubleClick(sender As Object, e As EventArgs) Handles lbxStory.DoubleClick
        Open_Story()
    End Sub

    Private Sub LbxItems_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxStory.SelectedIndexChanged
        Select_Current_Story()
    End Sub

    Private Sub Load_Story()
        Dim xelementHolder As XElement = XElement.Parse(selectedRss.LastXML.ToString)
        Dim stories As IEnumerable(Of XElement) = xelementHolder.Descendants("item")

        For Each item As XElement In stories
            Dim storyHold As New Story(item.<title>.Value, item.<pubDate>.Value, item.<link>.Value, item.<description>.Value)
            storyList.Add(storyHold)
        Next
    End Sub

    Private Sub Modify_Rss()
        Dim dbConnect = RssMainForm.DbConnectString
        Dim sqlString As String = "UPDATE Rss SET Url=@url, LastXML=@xml, Title=@title WHERE Id=@id"
        Dim insertUpdate As New SqlCommand(sqlString, dbConnect)

        Try
            selectedRss.LastXML = XDocument.Parse(rtbXml.Text)
        Catch ex As Exception
            MessageBox.Show("B1: Sorry, invalid XML. Please try again.")
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
                RssMainForm.Reload()
            Else
                MessageBox.Show("B2: Sorry, DB Error. Try again.")
            End If
        Catch ex As Exception
            MessageBox.Show("B3: Sorry, DB Error. Try again.")
        Finally
            dbConnect.Close()
            dbConnect.Dispose()
        End Try
    End Sub

    Private Sub Open_Story()
        Select_Current_Story()
    End Sub

    Private Sub Refresh_Rss()
        Try
            Dim xmlVal = XDocument.Load(txtUrl.Text)
            rtbXml.Text = xmlVal.ToString
            Modify_Rss()
            storyList.Clear()
        Catch ex As Exception
            MessageBox.Show("B4: Sorry, invalid URL or web error. Please try again." + vbCrLf + txtUrl.Text)
            Return
        End Try

        Dim xelementHolder As XElement = XElement.Parse(selectedRss.LastXML.ToString)
        Dim stories As IEnumerable(Of XElement) = xelementHolder.Descendants("item")

        For Each item As XElement In stories
            Dim storyHold As New Story(item.<title>.Value, item.<pubDate>.Value, item.<link>.Value, item.<description>.Value)
            storyList.Add(storyHold)
        Next
    End Sub

    Private Sub RssSingleForm_KeyEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Or (lbxStory.Focused And e.KeyCode = Keys.Space) Then
            Dim storyForm As New RssStoryForm(selectedStory)
            storyForm.Show()
        End If

        If e.KeyCode = Keys.Escape Then
            Me.Close()
            Me.Dispose()
        End If
    End Sub

    Private Sub RssSingleForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbxStory.DataSource = storyList
        lbxStory.DisplayMember = "TitleDate"
        lbxStory.Focus()
    End Sub

    Private Sub RssSingleForm_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseWheel, lbxStory.MouseWheel, rtbDescr.MouseWheel, rtbXml.MouseWheel, txtName.MouseWheel, txtUrl.MouseWheel
        If Not rtbDescr.Focus And Not rtbXml.Focus Then
            lbxStory.Focus()
        End If

        If e.Delta > 0 And lbxStory.SelectedIndex >= 0 Then
            If Not lbxStory.SelectedIndex = 0 Then
                lbxStory.SelectedIndex = lbxStory.SelectedIndex - 1
            End If
        ElseIf lbxStory.SelectedIndex < lbxStory.Items.Count - 1 Then
            lbxStory.SelectedIndex = lbxStory.SelectedIndex + 1
        End If
    End Sub

    Public Sub Select_Current_Story()
        selectedStory = CType(lbxStory.SelectedItem, Story)
    End Sub
End Class