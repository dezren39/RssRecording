<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RssSingleForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.txtUrl = New System.Windows.Forms.TextBox()
        Me.lblUrl = New System.Windows.Forms.Label()
        Me.lblItem = New System.Windows.Forms.Label()
        Me.lblDescr = New System.Windows.Forms.Label()
        Me.lblRss = New System.Windows.Forms.Label()
        Me.lblDispItem = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.rtbXml = New System.Windows.Forms.RichTextBox()
        Me.rtbDescr = New System.Windows.Forms.RichTextBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.lbxStory = New System.Windows.Forms.ListBox()
        Me.lblDoubleClick = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(334, 5)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(76, 47)
        Me.btnSubmit.TabIndex = 3
        Me.btnSubmit.Text = "Submit Changes"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'txtUrl
        '
        Me.txtUrl.Location = New System.Drawing.Point(79, 48)
        Me.txtUrl.Name = "txtUrl"
        Me.txtUrl.Size = New System.Drawing.Size(250, 20)
        Me.txtUrl.TabIndex = 2
        '
        'lblUrl
        '
        Me.lblUrl.AutoSize = True
        Me.lblUrl.Location = New System.Drawing.Point(38, 51)
        Me.lblUrl.Name = "lblUrl"
        Me.lblUrl.Size = New System.Drawing.Size(32, 13)
        Me.lblUrl.TabIndex = 8
        Me.lblUrl.Text = "URL:"
        '
        'lblItem
        '
        Me.lblItem.AutoSize = True
        Me.lblItem.Location = New System.Drawing.Point(8, 85)
        Me.lblItem.Name = "lblItem"
        Me.lblItem.Size = New System.Drawing.Size(62, 13)
        Me.lblItem.TabIndex = 11
        Me.lblItem.Text = "Latest Item:"
        '
        'lblDescr
        '
        Me.lblDescr.AutoSize = True
        Me.lblDescr.Location = New System.Drawing.Point(7, 111)
        Me.lblDescr.Name = "lblDescr"
        Me.lblDescr.Size = New System.Drawing.Size(63, 13)
        Me.lblDescr.TabIndex = 12
        Me.lblDescr.Text = "Description:"
        '
        'lblRss
        '
        Me.lblRss.AutoSize = True
        Me.lblRss.Location = New System.Drawing.Point(19, 247)
        Me.lblRss.Name = "lblRss"
        Me.lblRss.Size = New System.Drawing.Size(51, 13)
        Me.lblRss.TabIndex = 13
        Me.lblRss.Text = "Full RSS:"
        '
        'lblDispItem
        '
        Me.lblDispItem.AutoSize = True
        Me.lblDispItem.Location = New System.Drawing.Point(76, 85)
        Me.lblDispItem.Name = "lblDispItem"
        Me.lblDispItem.Size = New System.Drawing.Size(141, 13)
        Me.lblDispItem.TabIndex = 14
        Me.lblDispItem.Text = "***Item Name Placeholder***"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(32, 15)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(38, 13)
        Me.lblName.TabIndex = 7
        Me.lblName.Text = "Name:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(79, 12)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(250, 20)
        Me.txtName.TabIndex = 1
        '
        'rtbXml
        '
        Me.rtbXml.Location = New System.Drawing.Point(76, 238)
        Me.rtbXml.Name = "rtbXml"
        Me.rtbXml.Size = New System.Drawing.Size(334, 120)
        Me.rtbXml.TabIndex = 6
        Me.rtbXml.TabStop = False
        Me.rtbXml.Text = ""
        '
        'rtbDescr
        '
        Me.rtbDescr.Location = New System.Drawing.Point(76, 108)
        Me.rtbDescr.Name = "rtbDescr"
        Me.rtbDescr.Size = New System.Drawing.Size(334, 131)
        Me.rtbDescr.TabIndex = 5
        Me.rtbDescr.TabStop = False
        Me.rtbDescr.Text = ""
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(334, 58)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(76, 47)
        Me.btnRefresh.TabIndex = 4
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'lbxStory
        '
        Me.lbxStory.FormattingEnabled = True
        Me.lbxStory.Location = New System.Drawing.Point(412, 5)
        Me.lbxStory.Name = "lbxStory"
        Me.lbxStory.Size = New System.Drawing.Size(538, 342)
        Me.lbxStory.TabIndex = 0
        '
        'lblDoubleClick
        '
        Me.lblDoubleClick.AutoSize = True
        Me.lblDoubleClick.Location = New System.Drawing.Point(780, 350)
        Me.lblDoubleClick.Name = "lblDoubleClick"
        Me.lblDoubleClick.Size = New System.Drawing.Size(139, 13)
        Me.lblDoubleClick.TabIndex = 21
        Me.lblDoubleClick.Text = "*Double-Click Item To Open"
        '
        'RssSingleForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(955, 366)
        Me.Controls.Add(Me.lblDoubleClick)
        Me.Controls.Add(Me.lbxStory)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.rtbDescr)
        Me.Controls.Add(Me.rtbXml)
        Me.Controls.Add(Me.lblDescr)
        Me.Controls.Add(Me.lblDispItem)
        Me.Controls.Add(Me.lblRss)
        Me.Controls.Add(Me.lblItem)
        Me.Controls.Add(Me.txtUrl)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblUrl)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnSubmit)
        Me.KeyPreview = True
        Me.Name = "RssSingleForm"
        Me.Text = "Rss Recorder: Single Item"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSubmit As Button
    Friend WithEvents txtUrl As TextBox
    Friend WithEvents lblUrl As Label
    Friend WithEvents lblItem As Label
    Friend WithEvents lblDescr As Label
    Friend WithEvents lblRss As Label
    Friend WithEvents lblDispItem As Label
    Friend WithEvents lblName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents rtbXml As RichTextBox
    Friend WithEvents rtbDescr As RichTextBox
    Friend WithEvents btnRefresh As Button
    Friend WithEvents lbxStory As ListBox
    Friend WithEvents lblDoubleClick As Label
End Class
