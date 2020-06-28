Public Class revival
    Public combo
    Private Sub revival_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        Dim opt = Int((3 - 1 + 1) * Rnd() + 1)
        If opt = 1 Then
            Dim n1 = Int((100 - 1 + 1) * Rnd() + 1)
            Dim n2 = Int((100 - 1 + 1) * Rnd() + 1)
            combo = n1 * n2
            lbl_question.Text = "WHAT IS " & n1 & "x" & n2
        ElseIf opt = 2 Then
            Dim n1 = Int((100 - 1 + 1) * Rnd() + 1)
            Dim n2 = Int((100 - 1 + 1) * Rnd() + 1)
            combo = n1 - n2
            lbl_question.Text = "WHAT IS " & n1 & "-" & n2
        ElseIf opt = 3 Then
            Dim n1 = Int((100 - 1 + 1) * Rnd() + 1)
            Dim n2 = Int((100 - 1 + 1) * Rnd() + 1)
            combo = n1 + n2
            lbl_question.Text = "WHAT IS " & n1 & "+" & n2
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MainForm.difficulty = 2 Then
            Form1.timeleft = 5
            Form1.ProgressBar1.Maximum = Form1.timeleft
            Form1.ProgressBar1.Value = Form1.timeleft
        ElseIf MainForm.difficulty = 4 Then
            Form1.timeleft = 10
            Form1.ProgressBar1.Maximum = Form1.timeleft
            Form1.ProgressBar1.Value = Form1.timeleft
        ElseIf MainForm.difficulty = 6 Then
            Form1.timeleft = 15
            Form1.ProgressBar1.Maximum = Form1.timeleft
            Form1.ProgressBar1.Value = Form1.timeleft
        ElseIf MainForm.difficulty = 8 Then
            Form1.timeleft = 20
            Form1.ProgressBar1.Maximum = Form1.timeleft
            Form1.ProgressBar1.Value = Form1.timeleft
        End If
        Form1.PictureBox1.Visible = False
        Form1.PictureBox2.Visible = False
        Form1.PictureBox3.Visible = False
        Form1.PictureBox4.Visible = False
        Form1.PictureBox5.Visible = False
        Form1.PictureBox6.Visible = False
        Form1.PictureBox7.Visible = False
        Form1.PictureBox8.Visible = False
        Form1.PictureBox9.Visible = False
        Form1.PictureBox10.Visible = False
        Form1.Label4.Visible = False
        Form1.ProgressBar1.Visible = False
        Form1.ProgressBar1.Maximum = Form1.timeleft
        Form1.ProgressBar1.Value = Form1.timeleft
        Form1.label1.Visible = False
        Form1.label2.Text = "Ready," & vbCrLf & MainForm.textBox1.Text & "?"
        Form1.label2.Visible = False
        Form1.label3.Visible = False
        Form1.lbl_score.Visible = False
        Form1.lbl_score_descr.Visible = False
        Form1.lbl_lives_descr.Visible = False
        Form1.pb_life_1.Visible = False
        Form1.pb_life_2.Visible = False
        Form1.pb_life_3.Visible = False
        Form1.Timer2.Stop()
        Me.Hide()
        highscore.ShowDialog()
    End Sub

    Private Sub showMSG(text As String)
        msg.msgHere.Text = text
        msg.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = combo.ToString Then
            showMSG("Great job! Your life is now refilled!")
            Form1.livesleft = 3
            If MainForm.difficulty = 2 Then
                Form1.timeleft = 5
                Form1.ProgressBar1.Maximum = Form1.timeleft
                Form1.ProgressBar1.Value = Form1.timeleft
            ElseIf MainForm.difficulty = 4 Then
                Form1.timeleft = 10
                Form1.ProgressBar1.Maximum = Form1.timeleft
                Form1.ProgressBar1.Value = Form1.timeleft
            ElseIf MainForm.difficulty = 6 Then
                Form1.timeleft = 15
                Form1.ProgressBar1.Maximum = Form1.timeleft
                Form1.ProgressBar1.Value = Form1.timeleft
            ElseIf MainForm.difficulty = 8 Then
                Form1.timeleft = 20
                Form1.ProgressBar1.Maximum = Form1.timeleft
                Form1.ProgressBar1.Value = Form1.timeleft
            End If
            Form1.pb_life_2.Visible = True
            Form1.pb_life_1.Visible = True
            Form1.pb_life_3.Visible = True
            Me.Hide()
            Form1.Activate()
            Form1.doGenerate()
            Form1.doDemo()
            Form1.Timer2.Start()
            Me.Close()
        Else
            showMSG("Wrong answer! Try again!")
            Exit Sub
        End If
    End Sub

    Private Sub RectangleShape2_Click(sender As Object, e As EventArgs) Handles RectangleShape2.Click

    End Sub
End Class