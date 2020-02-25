Public Class web

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            WebBrowser1.Show()
            Dim myUrl As String
            myUrl = Form1.url_txt.Text
            WebBrowser1.Navigate(myUrl)
            CheckBox1.Text = "Browser On"
        Else
            WebBrowser1.Hide()
            CheckBox1.Text = "Browser Off"
        End If
    End Sub
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Dim web As New System.Net.WebClient
        web.DownloadString("http://192.168.100.115/cmd.cgi?cmd=REL,2,0")
        web.DownloadString("http://192.168.100.115/cmd.cgi?cmd=REL,1,1")
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Dim web As New System.Net.WebClient
        web.DownloadString("http://192.168.100.115/cmd.cgi?cmd=REL,1,0")
        web.DownloadString("http://192.168.100.115/cmd.cgi?cmd=REL,2,1")
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim web As New System.Net.WebClient
        web.DownloadString("http://192.168.100.115/cmd.cgi?cmd=REL,1,0")
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim web As New System.Net.WebClient
        web.DownloadString("http://192.168.100.115/cmd.cgi?cmd=REL,2,0")
    End Sub

    Private Sub relay()

    End Sub


End Class