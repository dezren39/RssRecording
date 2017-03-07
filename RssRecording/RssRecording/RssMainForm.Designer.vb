<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RssMainForm
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
        Me.lbxRss = New System.Windows.Forms.ListBox()
        Me.VScrollBar1 = New System.Windows.Forms.VScrollBar()
        Me.lblGreet = New System.Windows.Forms.Label()
        Me.lblUrl = New System.Windows.Forms.Label()
        Me.txtUrl = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.BtnDel = New System.Windows.Forms.Button()
        Me.lblDoubleClick = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbxRss
        '
        Me.lbxRss.FormattingEnabled = True
        Me.lbxRss.Location = New System.Drawing.Point(12, 85)
        Me.lbxRss.Name = "lbxRss"
        Me.lbxRss.Size = New System.Drawing.Size(394, 186)
        Me.lbxRss.TabIndex = 0
        '
        'VScrollBar1
        '
        Me.VScrollBar1.Location = New System.Drawing.Point(406, 85)
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.Size = New System.Drawing.Size(20, 186)
        Me.VScrollBar1.TabIndex = 1
        '
        'lblGreet
        '
        Me.lblGreet.AutoSize = True
        Me.lblGreet.Location = New System.Drawing.Point(74, 18)
        Me.lblGreet.Name = "lblGreet"
        Me.lblGreet.Size = New System.Drawing.Size(115, 13)
        Me.lblGreet.TabIndex = 2
        Me.lblGreet.Text = "Welcome to your RSS!"
        '
        'lblUrl
        '
        Me.lblUrl.AutoSize = True
        Me.lblUrl.Location = New System.Drawing.Point(13, 51)
        Me.lblUrl.Name = "lblUrl"
        Me.lblUrl.Size = New System.Drawing.Size(39, 13)
        Me.lblUrl.TabIndex = 4
        Me.lblUrl.Text = "* URL:"
        '
        'txtUrl
        '
        Me.txtUrl.Location = New System.Drawing.Point(63, 48)
        Me.txtUrl.Name = "txtUrl"
        Me.txtUrl.Size = New System.Drawing.Size(180, 20)
        Me.txtUrl.TabIndex = 6
        Me.txtUrl.Text = "http://feeds.twit.tv/ttg_video_hd.xml"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(260, 12)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 58)
        Me.btnAdd.TabIndex = 7
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'BtnDel
        '
        Me.BtnDel.Location = New System.Drawing.Point(351, 12)
        Me.BtnDel.Name = "BtnDel"
        Me.BtnDel.Size = New System.Drawing.Size(75, 58)
        Me.BtnDel.TabIndex = 8
        Me.BtnDel.Text = "Delete"
        Me.BtnDel.UseVisualStyleBackColor = True
        '
        'lblDoubleClick
        '
        Me.lblDoubleClick.AutoSize = True
        Me.lblDoubleClick.Location = New System.Drawing.Point(257, 274)
        Me.lblDoubleClick.Name = "lblDoubleClick"
        Me.lblDoubleClick.Size = New System.Drawing.Size(139, 13)
        Me.lblDoubleClick.TabIndex = 9
        Me.lblDoubleClick.Text = "*Double-Click Item To Open"
        '
        'RssMainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 291)
        Me.Controls.Add(Me.lblDoubleClick)
        Me.Controls.Add(Me.BtnDel)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtUrl)
        Me.Controls.Add(Me.lblUrl)
        Me.Controls.Add(Me.lblGreet)
        Me.Controls.Add(Me.VScrollBar1)
        Me.Controls.Add(Me.lbxRss)
        Me.Name = "RssMainForm"
        Me.Text = "RSS Recording: Main Application"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbxRss As ListBox
    Friend WithEvents VScrollBar1 As VScrollBar
    Friend WithEvents lblGreet As Label
    Friend WithEvents lblUrl As Label
    Friend WithEvents txtUrl As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents BtnDel As Button
    Friend WithEvents lblDoubleClick As Label
End Class
