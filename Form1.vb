Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form2.Show()
        Process1.Start("C:\Users\Kim\Desktop\spam\runme.bat")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.BackgroundImage = Image.FromFile("C:\Users\Kim\Pictures\Backgrounds\Snow_Mountain.jpg")
        Timer1.Enabled = False
    End Sub
End Class
