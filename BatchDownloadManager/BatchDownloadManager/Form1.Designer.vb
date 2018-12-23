<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ClearLinkListBtn = New System.Windows.Forms.Button()
        Me.StartDownloadBtn = New System.Windows.Forms.Button()
        Me.AddLinksToListBtn = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DownloadProgress = New System.Windows.Forms.Label()
        Me.DownloadProgressBar = New System.Windows.Forms.ProgressBar()
        Me.StopDownloadBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(15, 32)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(251, 212)
        Me.TextBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Link List"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(279, 9)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(32, 13)
        Me.label2.TabIndex = 3
        Me.label2.Text = "Links"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(282, 32)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(907, 212)
        Me.ListBox1.TabIndex = 4
        '
        'ClearLinkListBtn
        '
        Me.ClearLinkListBtn.Location = New System.Drawing.Point(282, 250)
        Me.ClearLinkListBtn.Name = "ClearLinkListBtn"
        Me.ClearLinkListBtn.Size = New System.Drawing.Size(81, 31)
        Me.ClearLinkListBtn.TabIndex = 5
        Me.ClearLinkListBtn.Text = "Clear"
        Me.ClearLinkListBtn.UseVisualStyleBackColor = True
        '
        'StartDownloadBtn
        '
        Me.StartDownloadBtn.Location = New System.Drawing.Point(1108, 250)
        Me.StartDownloadBtn.Name = "StartDownloadBtn"
        Me.StartDownloadBtn.Size = New System.Drawing.Size(81, 31)
        Me.StartDownloadBtn.TabIndex = 6
        Me.StartDownloadBtn.Text = "Download"
        Me.StartDownloadBtn.UseVisualStyleBackColor = True
        '
        'AddLinksToListBtn
        '
        Me.AddLinksToListBtn.Location = New System.Drawing.Point(185, 250)
        Me.AddLinksToListBtn.Name = "AddLinksToListBtn"
        Me.AddLinksToListBtn.Size = New System.Drawing.Size(81, 31)
        Me.AddLinksToListBtn.TabIndex = 7
        Me.AddLinksToListBtn.Text = "Add Batch"
        Me.AddLinksToListBtn.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(597, 6)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(511, 20)
        Me.TextBox2.TabIndex = 8
        Me.TextBox2.Text = "E:/Downloads/"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(1114, 4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 9
        Me.Button5.Text = "Set"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(515, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Save Location"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 294)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Current Download"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 317)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Speed"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 339)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Location"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 362)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Progress"
        '
        'DownloadProgress
        '
        Me.DownloadProgress.AutoSize = True
        Me.DownloadProgress.Location = New System.Drawing.Point(73, 362)
        Me.DownloadProgress.Name = "DownloadProgress"
        Me.DownloadProgress.Size = New System.Drawing.Size(48, 13)
        Me.DownloadProgress.TabIndex = 15
        Me.DownloadProgress.Text = "Progress"
        '
        'DownloadProgressBar
        '
        Me.DownloadProgressBar.Location = New System.Drawing.Point(22, 382)
        Me.DownloadProgressBar.Name = "DownloadProgressBar"
        Me.DownloadProgressBar.Size = New System.Drawing.Size(1167, 40)
        Me.DownloadProgressBar.TabIndex = 16
        '
        'StopDownloadBtn
        '
        Me.StopDownloadBtn.Location = New System.Drawing.Point(1095, 344)
        Me.StopDownloadBtn.Name = "StopDownloadBtn"
        Me.StopDownloadBtn.Size = New System.Drawing.Size(94, 31)
        Me.StopDownloadBtn.TabIndex = 17
        Me.StopDownloadBtn.Text = "Stop Download"
        Me.StopDownloadBtn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1201, 433)
        Me.Controls.Add(Me.StopDownloadBtn)
        Me.Controls.Add(Me.DownloadProgressBar)
        Me.Controls.Add(Me.DownloadProgress)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.AddLinksToListBtn)
        Me.Controls.Add(Me.StartDownloadBtn)
        Me.Controls.Add(Me.ClearLinkListBtn)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Batch Downloader"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents label2 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ClearLinkListBtn As Button
    Friend WithEvents StartDownloadBtn As Button
    Friend WithEvents AddLinksToListBtn As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents DownloadProgress As Label
    Friend WithEvents DownloadProgressBar As ProgressBar
    Friend WithEvents StopDownloadBtn As Button
End Class
