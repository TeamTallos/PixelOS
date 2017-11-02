Public Class Form7
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        WebBrowser1.Navigate(TextBox1.Text)
        If TextBox1.Text = "https://youtube.com" Then
            Timer1.Start()
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        WebBrowser1.Navigate("http://pixelos.myfreesites.net/bl")
        Timer1.Stop()
    End Sub
End Class