Public Class Form5
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = (My.Computer.Info.AvailablePhysicalMemory)
        Label3.Text = (My.Computer.Info.TotalVirtualMemory)
        Label4.Text = (My.Computer.Info.OSVersion)
    End Sub
End Class