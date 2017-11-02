Imports System.ComponentModel

Public Class Form17
    Private Sub Form17_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk
                         )
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

    End Sub

    Private Sub Form17_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        e.Cancel = True
        MsgBox("Oh you thang you can hide well You are idoit")
        Timer1.Start()
    End Sub
End Class