<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RssStoryForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lnkTitleDate = New System.Windows.Forms.LinkLabel()
        Me.webStory = New System.Windows.Forms.WebBrowser()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lnkTitleDate
        '
        Me.lnkTitleDate.AutoSize = True
        Me.lnkTitleDate.Location = New System.Drawing.Point(36, 398)
        Me.lnkTitleDate.Name = "lnkTitleDate"
        Me.lnkTitleDate.Size = New System.Drawing.Size(27, 13)
        Me.lnkTitleDate.TabIndex = 0
        Me.lnkTitleDate.TabStop = True
        Me.lnkTitleDate.Text = "Title"
        '
        'webStory
        '
        Me.webStory.Location = New System.Drawing.Point(-1, 1)
        Me.webStory.MinimumSize = New System.Drawing.Size(20, 20)
        Me.webStory.Name = "webStory"
        Me.webStory.Size = New System.Drawing.Size(799, 394)
        Me.webStory.TabIndex = 1
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(587, 398)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblDate.Size = New System.Drawing.Size(30, 13)
        Me.lblDate.TabIndex = 4
        Me.lblDate.Text = "Date"
        '
        'RssStoryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(799, 420)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lnkTitleDate)
        Me.Controls.Add(Me.webStory)
        Me.Name = "RssStoryForm"
        Me.Text = "RssStoryForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lnkTitleDate As LinkLabel
    Friend WithEvents webStory As WebBrowser
    Friend WithEvents lblDate As Label
End Class
