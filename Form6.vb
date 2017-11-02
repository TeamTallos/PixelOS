Public Class Form6
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("only .wav files are allowed", "0", "note")
        OpenFileDialog1.ShowDialog()
        My.Computer.Audio.Play(OpenFileDialog1.FileName)
    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form6_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        My.Computer.Audio.Stop()
    End Sub
End Class