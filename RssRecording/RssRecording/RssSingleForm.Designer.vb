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
        Me.lblMod = New System.Windows.Forms.Button()
        Me.txtUrl = New System.Windows.Forms.TextBox()
        Me.lblUrl = New System.Windows.Forms.Label()
        Me.lblItem = New System.Windows.Forms.Label()
        Me.lblDescr = New System.Windows.Forms.Label()
        Me.lblRss = New System.Windows.Forms.Label()
        Me.lblDispDesc = New System.Windows.Forms.Label()
        Me.lblDispItem = New System.Windows.Forms.Label()
        Me.txtRss = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblMod
        '
        Me.lblMod.Location = New System.Drawing.Point(259, 15)
        Me.lblMod.Name = "lblMod"
        Me.lblMod.Size = New System.Drawing.Size(76, 47)
        Me.lblMod.TabIndex = 0
        Me.lblMod.Text = "Submit Changes"
        Me.lblMod.UseVisualStyleBackColor = True
        '
        'txtUrl
        '
        Me.txtUrl.Location = New System.Drawing.Point(68, 48)
        Me.txtUrl.Name = "txtUrl"
        Me.txtUrl.Size = New System.Drawing.Size(180, 20)
        Me.txtUrl.TabIndex = 10
        '
        'lblUrl
        '
        Me.lblUrl.AutoSize = True
        Me.lblUrl.Location = New System.Drawing.Point(18, 51)
        Me.lblUrl.Name = "lblUrl"
        Me.lblUrl.Size = New System.Drawing.Size(32, 13)
        Me.lblUrl.TabIndex = 8
        Me.lblUrl.Text = "URL:"
        '
        'lblItem
        '
        Me.lblItem.AutoSize = True
        Me.lblItem.Location = New System.Drawing.Point(12, 92)
        Me.lblItem.Name = "lblItem"
        Me.lblItem.Size = New System.Drawing.Size(62, 13)
        Me.lblItem.TabIndex = 11
        Me.lblItem.Text = "Latest Item:"
        '
        'lblDescr
        '
        Me.lblDescr.AutoSize = True
        Me.lblDescr.Location = New System.Drawing.Point(11, 118)
        Me.lblDescr.Name = "lblDescr"
        Me.lblDescr.Size = New System.Drawing.Size(63, 13)
        Me.lblDescr.TabIndex = 12
        Me.lblDescr.Text = "Description:"
        '
        'lblRss
        '
        Me.lblRss.AutoSize = True
        Me.lblRss.Location = New System.Drawing.Point(23, 180)
        Me.lblRss.Name = "lblRss"
        Me.lblRss.Size = New System.Drawing.Size(51, 13)
        Me.lblRss.TabIndex = 13
        Me.lblRss.Text = "Full RSS:"
        '
        'lblDispDesc
        '
        Me.lblDispDesc.Location = New System.Drawing.Point(76, 118)
        Me.lblDispDesc.Name = "lblDispDesc"
        Me.lblDispDesc.Size = New System.Drawing.Size(259, 59)
        Me.lblDispDesc.TabIndex = 15
        Me.lblDispDesc.Text = "***Item Description Placeholder***"
        '
        'lblDispItem
        '
        Me.lblDispItem.AutoSize = True
        Me.lblDispItem.Location = New System.Drawing.Point(76, 92)
        Me.lblDispItem.Name = "lblDispItem"
        Me.lblDispItem.Size = New System.Drawing.Size(141, 13)
        Me.lblDispItem.TabIndex = 14
        Me.lblDispItem.Text = "***Item Name Placeholder***"
        '
        'txtRss
        '
        Me.txtRss.Location = New System.Drawing.Point(79, 177)
        Me.txtRss.Multiline = True
        Me.txtRss.Name = "txtRss"
        Me.txtRss.Size = New System.Drawing.Size(256, 100)
        Me.txtRss.TabIndex = 16
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(12, 15)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(38, 13)
        Me.lblName.TabIndex = 7
        Me.lblName.Text = "Name:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(68, 12)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(180, 20)
        Me.txtName.TabIndex = 9
        '
        'RssSingleForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(355, 303)
        Me.Controls.Add(Me.lblDescr)
        Me.Controls.Add(Me.txtRss)
        Me.Controls.Add(Me.lblDispDesc)
        Me.Controls.Add(Me.lblDispItem)
        Me.Controls.Add(Me.lblRss)
        Me.Controls.Add(Me.lblItem)
        Me.Controls.Add(Me.txtUrl)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblUrl)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblMod)
        Me.Name = "RssSingleForm"
        Me.Text = "Rss Recorder: Single Item"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMod As Button
    Friend WithEvents txtUrl As TextBox
    Friend WithEvents lblUrl As Label
    Friend WithEvents lblItem As Label
    Friend WithEvents lblDescr As Label
    Friend WithEvents lblRss As Label
    Friend WithEvents lblDispDesc As Label
    Friend WithEvents lblDispItem As Label
    Friend WithEvents txtRss As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents txtName As TextBox
End Class
