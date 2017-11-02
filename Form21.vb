Public Class Form21
    Private Sub Form21_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cursor.Hide()
        Form3.Close()
        Timer2.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.TopMost = True
        If My.Computer.Keyboard.CtrlKeyDown Then
            If My.Computer.Keyboard.AltKeyDown Then
                Cursor.Show()
                Form3.Show()
                Me.Close()
            End If
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        AxWindowsMediaPlayer1.Visible = False
        Timer2.Stop()
    End Sub
End Class