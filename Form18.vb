Public Class Form18
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Process1.Start("C:\Users\Kim\Documents\Advanced Installer\Projects\PixelOS 7\Setup Files\PixelOS 2.0 installer.exe")
        Me.Close()
    End Sub

    Private Sub Form18_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form19.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.TopMost = True
    End Sub
End Class