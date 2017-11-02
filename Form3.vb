Public Class Form3
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Panel2.Visible = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = (My.Computer.Clock.LocalTime)
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel2.Visible = False
        Panel3.Visible = False
        Form19.Show()
        Form18.Show()

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Form4.Show()
    End Sub


    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Form5.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

        Panel2.Visible = False
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Panel3.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "Shake it up" Then
            Process1.Start("C:\Users\Kim\Downloads\Earthquake (5)\Earthquake.exe")
        End If
        If TextBox1.Text = "shake it up" Then
            Process1.Start("C:\Users\Kim\Downloads\Earthquake (5)\Earthquake.exe")
        End If
        If TextBox1.Text = "savage" Then
            Process1.Start("C:\Users\Kim\Downloads\MLG.exe")
        End If
        If TextBox1.Text = "draw" Then
            Process1.Start("C:\Users\Kim\Downloads\Earthquake (5)\Earthquake.exe")
            Process1.Start("C:\Users\Kim\Downloads\Earthquake (5)\Earthquake.exe")

        End If
        If TextBox1.Text = "die" Then
            Panel1.Visible = False

        End If
        If TextBox1.Text = "im not dumb" Then
            Form17.Show()

        End If
        If TextBox1.Text = "what is the lowest intger form for the time" Then
            Label2.Text = "000"
        End If
    End Sub

    Private Sub ChangeDesktopBackgroundToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeDesktopBackgroundToolStripMenuItem.Click
        OpenFileDialog1.ShowDialog()
        Me.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Panel3.Visible = False
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Form6.Show()
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub ReloadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReloadToolStripMenuItem.Click
        Me.Refresh()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If My.Computer.Keyboard.CtrlKeyDown.Equals(True) Then
            If My.Computer.Keyboard.AltKeyDown.Equals(True) Then
                Form10.Show()
            End If
        End If
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Form7.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Form8.Show()
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        Form9.Show()
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Form11.Show()
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs)
        Form14.Show()
    End Sub

    Private Sub PictureBox10_Click_1(sender As Object, e As EventArgs) Handles PictureBox10.Click
        Form15.Show()
        Form23.Show()
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        Form16.Show()
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        Form20.Show()

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If Label2.Text = "000" Then
            Form21.Show()
        End If
    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        Form22.Show()
    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        Form14.Show()
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick

    End Sub

    Private Sub form3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress

    End Sub

    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles PictureBox15.Click
        Process1.Start("C:\Users\Kim\source\repos\pokemon fire\pokemon fire\bin\Debug\PixelOS.exe")
        Form1.Close()
    End Sub
    Private Sub Application_Idle(ByVal sender As Object, ByVal e As EventArgs)

        Process1.Start("C:\Users\Kim\Desktop\LA media\pixel\PixelOS 1.5\ScreenSaver.scr")

    End Sub
End Class
