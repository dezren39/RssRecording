Imports System.Windows.Forms.LinkLabel
Public Class RssStoryForm
    Private link As String

    Public Sub New(ByRef storyVal As Story)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Text = storyVal.Title
        lnkTitleDate.Text = storyVal.Title
        link = storyVal.Link
        lblDate.Text = storyVal.PubDate
        webStory.DocumentText = storyVal.Description
        Me.Focus()
    End Sub

    Private Sub LnkTitleDate_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkTitleDate.LinkClicked
        Try
            Process.Start(link)
        Catch ex As Exception
            MessageBox.Show("C1: Sorry, web error. Please try again.")
        End Try
    End Sub

    Private Sub RssStoryForm_KeyEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
            Me.Dispose()
        End If

        If e.KeyCode = Keys.Space Then
            Try
                Process.Start(link)
            Catch ex As Exception
                MessageBox.Show("C1: Sorry, web error. Please try again.")
            End Try
        End If
    End Sub

    Private Sub RssStoryForm_WebStoryFocus(sender As Object, e As EventArgs) Handles Me.MouseEnter, Me.MouseCaptureChanged, Me.MouseHover, Me.MouseWheel, MyBase.Load
        webStory.Focus()
    End Sub
End Class