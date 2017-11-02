Public Class Form13
    Private Sub Form13_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cursor.Hide()
    End Sub

    Private Sub Form3_formclosing(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyData = Keys.Alt + Keys.F4 Then
            e.Handled = True
        End If
        If e.KeyData = Keys.LWin Then
            e.Handled = True
        End If
        If e.KeyData = Keys.RWin Then
            e.Handled = True
        End If

    End Sub
End Class