Imports System.Net
Imports System.IO

Public Class Form1
    Public DownloadLocation = "E:/Downloads"
    Dim SW As New Stopwatch

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles AddLinksToListBtn.Click
        'Move links into list box
        For Each line In TextBox1.Text.Split(vbNewLine)
            If line.ToString().Contains("http") Or line.ToString().Contains("https") Then
                ListBox1.Items.Add(line.ToString())
            End If
        Next

        'Clear out moved links from textbox
        TextBox1.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ClearLinkListBtn.Click
        ListBox1.Items.Clear()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        DownloadLocation = TextBox2.Text.ToString()
    End Sub

    Private WithEvents WebManager As WebClient
    Public StopDownload As Boolean = False

    'Download Function
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles StartDownloadBtn.Click
        SW = Stopwatch.StartNew
        WebManager = New WebClient

        For Each item In ListBox1.Items
            Dim strs = item.Split("/")

            Label4.Text = "Active Download: " + item.ToString
            Label6.Text = TextBox2.Text + strs(UBound(strs)).ToString

            WebManager.DownloadFileAsync(New Uri(item), TextBox2.Text + strs(UBound(strs)).ToString)

            Do While WebManager.IsBusy
                Application.DoEvents()

                If StopDownload Then
                    WebManager.CancelAsync()
                    StopDownload = False
                End If
            Loop
        Next
    End Sub

    Private Sub WebManager_DownloadProgressChanged(sender As Object, ByVal e As System.Net.DownloadProgressChangedEventArgs) Handles WebManager.DownloadProgressChanged
        DownloadProgressBar.Maximum = Math.Round(e.TotalBytesToReceive / 1000000)
        DownloadProgressBar.Value = Math.Round(e.BytesReceived / 1000000)
        DownloadProgress.Text = e.ProgressPercentage.ToString() + "%"

        Label5.Text = "Download Speed: " + (Math.Round(e.BytesReceived / SW.ElapsedMilliseconds / 1000, 2, MidpointRounding.AwayFromZero)).ToString + "MB/s"

        If e.ProgressPercentage = 100 Then
            DownloadProgress.Text = "Completed"
            Label5.Text = "Download Speed: " + "0 MB/s"

            System.Threading.Thread.Sleep(250)
            DownloadProgress.Text = ""
            Label5.Text = "Download Speed: "
            Label4.Text = "Current Download: "
            Label6.Text = "Location: "
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles StopDownloadBtn.Click
        'Stop Download Function
        StopDownload = True
    End Sub
End Class
