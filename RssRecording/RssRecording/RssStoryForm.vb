Imports System.Windows.Forms.LinkLabel
Public Class RssStoryForm
    Private link As String

    Sub New(ByRef storyVal As Story)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Text = storyVal.Title
        lnkTitleDate.Text = storyVal.Title
        link = storyVal.Link
        lblDate.Text = storyVal.PubDate
        webStory.DocumentText = storyVal.Description
    End Sub

    Private Sub LnkTitleDate_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkTitleDate.LinkClicked
        Try
            Process.Start(link)
        Catch ex As Exception
            MessageBox.Show("C1: Sorry, web error. Please try again.")
        End Try
    End Sub
End Class