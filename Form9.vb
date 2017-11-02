Public Class Form9
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Hide()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If CheckBox1.Checked.Equals(True) Then
            Form3.BackgroundImage = Image.FromFile("C:\Users\Kim\Pictures\scrach data\Kidmode background.png")
            Form3.PictureBox9.Visible = False
            Timer2.Start()
            Timer1.Stop()
        End If
    End Sub

    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Form10.Label1.Visible = False
        Form10.Label2.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.ShowDialog()
        Form1.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub
End Class