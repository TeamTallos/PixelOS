Public Class Form15
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
        Form23.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If RichTextBox1.Text = "000" Then
            Form21.Show()
            Me.Close()
        End If
    End Sub
End Class