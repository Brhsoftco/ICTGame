Imports VB = Microsoft.VisualBasic
'
' Created by SharpDevelop.
' User: bharr0
' Date: 9/11/2017
' Time: 2:31 PM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Partial Class Form1
    Public timermode As Integer = 1
    Public sofar As String = ""
    Public combo As String = ""
    Public timeleft As Integer = 4
    Public currentdemo As Integer
    Public btns_disabled As Boolean = False
    Public comboarr As String()
    Public whileshowing As Boolean
    Public livesleft As Integer = 3
    Public revivedalready As Boolean = False
    Public lifeanimode As Integer = 0
    Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub


    Sub Form1Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btns_disabled = True
        lifeanimode = 0
        livesleft = 3
        combo = ""
        sofar = ""
        ProgressBar1.Maximum = timeleft
        ProgressBar1.Value = timeleft
        label1.Visible = True
        label2.Text = "Ready," & vbCrLf & MainForm.textBox1.Text & "?"
        label2.Visible = False
        label3.Visible = False
        timer1.Start()
    End Sub

    Sub Timer1Tick(sender As Object, e As EventArgs) Handles timer1.Tick
        If timermode = 1 Then
            label1.Visible = False
            label2.Visible = True
            timermode += 1
        ElseIf timermode = 2 Then
            timer1.Interval = 1000
            label2.Visible = False
            label3.Visible = True
            label3.Text = "THREE"
            timermode += 1
        ElseIf timermode = 3 Then
            label3.Text = "TWO"
            timermode += 1
        ElseIf timermode = 4 Then
            label3.Text = "ONE"
            timermode += 1
        ElseIf timermode = 5 Then
            livesleft = 3
            PictureBox1.Visible = True
            PictureBox2.Visible = True
            PictureBox3.Visible = True
            PictureBox4.Visible = True
            PictureBox5.Visible = True
            PictureBox6.Visible = True
            PictureBox7.Visible = True
            PictureBox8.Visible = True
            PictureBox9.Visible = True
            PictureBox10.Visible = True
            Label4.Visible = True
            ProgressBar1.Visible = True
            lbl_lives_descr.Visible = True
            lbl_score.Visible = True
            lbl_score_descr.Visible = True
            pb_life_1.Visible = True
            pb_life_2.Visible = True
            pb_life_3.Visible = True
            label3.Visible = False
            Button2.Enabled = True
            timermode += 1
        ElseIf timermode = 6 Then
            timer1.Stop()
            timermode = 0
            doGenerate()
            doDemo()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If btns_disabled = False Then
            sofar &= 0
            If sofar.Length = MainForm.difficulty Then
                doCheck()
                Exit Sub
            End If
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Not timeleft = 0 Then
            timeleft -= 1
            ProgressBar1.Value = timeleft
        Else
            If livesleft = 1 Then
                livesleft = 0
                pb_life_3.Visible = False
                If revivedalready Then
                    Timer2.Stop()
                    showMSG("Game Over!")
                    If MainForm.difficulty = 2 Then
                        timeleft = 5
                        ProgressBar1.Maximum = timeleft
                        ProgressBar1.Value = timeleft
                    ElseIf MainForm.difficulty = 4 Then
                        timeleft = 10
                        ProgressBar1.Maximum = timeleft
                        ProgressBar1.Value = timeleft
                    ElseIf MainForm.difficulty = 6 Then
                        timeleft = 15
                        ProgressBar1.Maximum = timeleft
                        ProgressBar1.Value = timeleft
                    ElseIf MainForm.difficulty = 8 Then
                        timeleft = 20
                        ProgressBar1.Maximum = timeleft
                        ProgressBar1.Value = timeleft
                    End If
                    PictureBox1.Visible = False
                    PictureBox2.Visible = False
                    PictureBox3.Visible = False
                    PictureBox4.Visible = False
                    PictureBox5.Visible = False
                    PictureBox6.Visible = False
                    PictureBox7.Visible = False
                    PictureBox8.Visible = False
                    PictureBox9.Visible = False
                    PictureBox10.Visible = False
                    Label4.Visible = False
                    ProgressBar1.Visible = False
                    ProgressBar1.Maximum = timeleft
                    ProgressBar1.Value = timeleft
                    label1.Visible = True
                    label2.Text = "Ready," & vbCrLf & MainForm.textBox1.Text & "?"
                    label2.Visible = False
                    label3.Visible = False
                    pb_life_1.Visible = False
                    pb_life_2.Visible = False
                    pb_life_3.Visible = False
                    lbl_lives_descr.Visible = False
                    lbl_score.Visible = False
                    lbl_score_descr.Visible = False
                    Button2.Enabled = False
                    Me.Hide()
                    highscore.ShowDialog()
                    Exit Sub
                Else
                    revivedalready = True
                    Timer2.Stop()
                    revival.ShowDialog()
                    Exit Sub
                End If
            Else
                If livesleft = 2 Then
                    pb_life_2.Visible = False
                    livesleft = 1
                ElseIf livesleft = 3 Then
                    pb_life_3.Visible = False
                    livesleft = 2
                End If
                If MainForm.difficulty = 2 Then
                    timeleft = 5
                    ProgressBar1.Maximum = timeleft
                    ProgressBar1.Value = timeleft
                ElseIf MainForm.difficulty = 4 Then
                    timeleft = 10
                    ProgressBar1.Maximum = timeleft
                    ProgressBar1.Value = timeleft
                ElseIf MainForm.difficulty = 6 Then
                    timeleft = 15
                    ProgressBar1.Maximum = timeleft
                    ProgressBar1.Value = timeleft
                ElseIf MainForm.difficulty = 8 Then
                    timeleft = 20
                    ProgressBar1.Maximum = timeleft
                    ProgressBar1.Value = timeleft
                End If
                Timer2.Stop()
                doGenerate()
                doDemo()
            End If
        End If
    End Sub
    Public Sub doDemo()
        Button2.Enabled = False
        PictureBox1.BackgroundImage = My.Resources.number_0
        PictureBox2.BackgroundImage = My.Resources.number_1
        PictureBox3.BackgroundImage = My.Resources.number_2
        PictureBox4.BackgroundImage = My.Resources.number_3
        PictureBox5.BackgroundImage = My.Resources.number_4
        PictureBox6.BackgroundImage = My.Resources.number_5
        PictureBox7.BackgroundImage = My.Resources.number_6
        PictureBox8.BackgroundImage = My.Resources.number_7
        PictureBox9.BackgroundImage = My.Resources.number_8
        PictureBox10.BackgroundImage = My.Resources.number_9
        Dim pos As Integer = 0
        btns_disabled = True
        For Each s As String In combo
            pos += 1
            If s = "0" Then
                PictureBox1.BackgroundImage = My.Resources.number_0_sel
                wait(1)
                PictureBox1.BackgroundImage = My.Resources.number_0
            ElseIf s = "1" Then
                PictureBox2.BackgroundImage = My.Resources.number_1_sel
                wait(1)
                PictureBox2.BackgroundImage = My.Resources.number_1
            ElseIf s = "2" Then
                PictureBox3.BackgroundImage = My.Resources.number_2_sel
                wait(1)
                PictureBox3.BackgroundImage = My.Resources.number_2
            ElseIf s = "3" Then
                PictureBox4.BackgroundImage = My.Resources.number_3_sel
                wait(1)
                PictureBox4.BackgroundImage = My.Resources.number_3
            ElseIf s = "4" Then
                PictureBox5.BackgroundImage = My.Resources.number_4_sel
                wait(1)
                PictureBox5.BackgroundImage = My.Resources.number_4
            ElseIf s = "5" Then
                PictureBox6.BackgroundImage = My.Resources.number_5_sel
                wait(1)
                PictureBox6.BackgroundImage = My.Resources.number_5
            ElseIf s = "6" Then
                PictureBox7.BackgroundImage = My.Resources.number_6_sel
                wait(1)
                PictureBox7.BackgroundImage = My.Resources.number_6
            ElseIf s = "7" Then
                PictureBox8.BackgroundImage = My.Resources.number_7_sel
                wait(1)
                PictureBox8.BackgroundImage = My.Resources.number_7
            ElseIf s = "8" Then
                PictureBox9.BackgroundImage = My.Resources.number_8_sel
                wait(1)
                PictureBox9.BackgroundImage = My.Resources.number_8
            ElseIf s = "9" Then
                PictureBox10.BackgroundImage = My.Resources.number_9_sel
                wait(1)
                PictureBox10.BackgroundImage = My.Resources.number_9
            End If
            wait(1)
        Next
        btns_disabled = False
        Button2.Enabled = True
        Timer2.Start()
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs)
        If lifeanimode = 0 Then
            pb_life_3.Location = New Point(pb_life_3.Location.Y - 7)
            pb_life_1.Location = New Point(pb_life_1.Location.Y + 7)
            lifeanimode = 1
        ElseIf lifeanimode = 1 Then
            pb_life_1.Location = New Point(pb_life_1.Location.Y - 7)
            pb_life_2.Location = New Point(pb_life_2.Location.Y + 7)
            lifeanimode = 2
        ElseIf lifeanimode = 2 Then
            pb_life_2.Location = New Point(pb_life_2.Location.Y - 7)
            pb_life_3.Location = New Point(pb_life_3.Location.Y + 7)
            lifeanimode = 0
        End If
    End Sub
    Public Sub doCheck()
        PictureBox1.BackgroundImage = My.Resources.number_0
        PictureBox2.BackgroundImage = My.Resources.number_1
        PictureBox3.BackgroundImage = My.Resources.number_2
        PictureBox4.BackgroundImage = My.Resources.number_3
        PictureBox5.BackgroundImage = My.Resources.number_4
        PictureBox6.BackgroundImage = My.Resources.number_5
        PictureBox7.BackgroundImage = My.Resources.number_6
        PictureBox8.BackgroundImage = My.Resources.number_7
        PictureBox9.BackgroundImage = My.Resources.number_8
        PictureBox10.BackgroundImage = My.Resources.number_9
        Timer2.Stop()
        If MainForm.difficulty = 2 Then
            timeleft = 5
            ProgressBar1.Maximum = timeleft
            ProgressBar1.Value = timeleft
        ElseIf MainForm.difficulty = 4 Then
            timeleft = 10
            ProgressBar1.Maximum = timeleft
            ProgressBar1.Value = timeleft
        ElseIf MainForm.difficulty = 6 Then
            timeleft = 15
            ProgressBar1.Maximum = timeleft
            ProgressBar1.Value = timeleft
        ElseIf MainForm.difficulty = 8 Then
            timeleft = 20
            ProgressBar1.Maximum = timeleft
            ProgressBar1.Value = timeleft
        End If
        If combo = sofar Then
            Timer2.Stop()
            showMSG("Correct!")
            Dim difficulty = MainForm.difficulty
            Do Until difficulty = 0
                difficulty -= 1
                lbl_score.Text += 1
                wait(0.1)
            Loop
            doGenerate()
            doDemo()
            sofar = ""
        Else
            showMSG("Combo was incorrect!")
            If livesleft = 1 Then
                pb_life_3.Visible = False
                If revivedalready Then
                    Timer2.Stop()
                    showMSG("Game Over!")
                    If MainForm.difficulty = 2 Then
                        timeleft = 5
                        ProgressBar1.Maximum = timeleft
                        ProgressBar1.Value = timeleft
                    ElseIf MainForm.difficulty = 4 Then
                        timeleft = 10
                        ProgressBar1.Maximum = timeleft
                        ProgressBar1.Value = timeleft
                    ElseIf MainForm.difficulty = 6 Then
                        timeleft = 15
                        ProgressBar1.Maximum = timeleft
                        ProgressBar1.Value = timeleft
                    ElseIf MainForm.difficulty = 8 Then
                        timeleft = 20
                        ProgressBar1.Maximum = timeleft
                        ProgressBar1.Value = timeleft
                    End If
                    PictureBox1.Visible = False
                    PictureBox2.Visible = False
                    PictureBox3.Visible = False
                    PictureBox4.Visible = False
                    PictureBox5.Visible = False
                    PictureBox6.Visible = False
                    PictureBox7.Visible = False
                    PictureBox8.Visible = False
                    PictureBox9.Visible = False
                    PictureBox10.Visible = False
                    Label4.Visible = False
                    ProgressBar1.Visible = False
                    ProgressBar1.Maximum = timeleft
                    ProgressBar1.Value = timeleft
                    label1.Visible = True
                    label2.Text = "Ready," & vbCrLf & MainForm.textBox1.Text & "?"
                    label2.Visible = False
                    label3.Visible = False
                    Button2.Enabled = False
                    Me.Hide()
                    highscore.ShowDialog()
                Else
                    revivedalready = True
                    Timer2.Stop()
                    revival.ShowDialog()
                    Exit Sub
                End If
            ElseIf livesleft = 2 Then
                livesleft = 1
                pb_life_2.Visible = False
                doGenerate()
                doDemo()
            ElseIf livesleft = 3 Then
                livesleft = 2
                pb_life_3.Visible = False
                doGenerate()
                doDemo()
            End If
            sofar = ""
        End If
        Timer2.Start()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If btns_disabled = False Then
            sofar &= 1
            If sofar.Length = MainForm.difficulty Then
                doCheck()
            End If
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If btns_disabled = False Then
            sofar &= 2
            If sofar.Length = MainForm.difficulty Then
                doCheck()
                Exit Sub
            End If
        End If
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        If btns_disabled = False Then
            sofar &= 3
            If sofar.Length = MainForm.difficulty Then
                doCheck()
                Exit Sub
            End If
        End If
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        If btns_disabled = False Then
            sofar &= 4
            If sofar.Length = MainForm.difficulty Then
                doCheck()
                Exit Sub
            End If
        End If
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        If btns_disabled = False Then
            sofar &= 5
            If sofar.Length = MainForm.difficulty Then
                doCheck()
                Exit Sub
            End If
        End If
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        If btns_disabled = False Then
            sofar &= 6
            If sofar.Length = MainForm.difficulty Then
                doCheck()
                Exit Sub
            End If
        End If
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        If btns_disabled = False Then
            sofar &= 7
            If sofar.Length = MainForm.difficulty Then
                doCheck()
                Exit Sub
            End If
        End If
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        If btns_disabled = False Then
            sofar &= 8
            If sofar.Length = MainForm.difficulty Then
                doCheck()
                Exit Sub
            End If
        End If
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        If btns_disabled = False Then
            sofar &= 9
            If sofar.Length = MainForm.difficulty Then
                doCheck()
                Exit Sub
            End If
        End If
    End Sub
    Private Sub PictureBox1_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox1.MouseEnter
        If Not btns_disabled Then
            PictureBox1.BackgroundImage = My.Resources.number_0_sel
        End If
    End Sub
    Private Sub PictureBox2_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox2.MouseEnter
        If Not btns_disabled Then
            PictureBox2.BackgroundImage = My.Resources.number_1_sel
        End If
    End Sub
    Private Sub PictureBox3_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox3.MouseEnter
        If Not btns_disabled Then
            PictureBox3.BackgroundImage = My.Resources.number_2_sel
        End If
    End Sub
    Private Sub PictureBox4_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox4.MouseEnter
        If Not btns_disabled Then
            PictureBox4.BackgroundImage = My.Resources.number_3_sel
        End If
    End Sub
    Private Sub PictureBox5_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox5.MouseEnter
        If Not btns_disabled Then
            PictureBox5.BackgroundImage = My.Resources.number_4_sel
        End If
    End Sub
    Private Sub PictureBox6_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox6.MouseEnter
        If Not btns_disabled Then
            PictureBox6.BackgroundImage = My.Resources.number_5_sel
        End If
    End Sub
    Private Sub PictureBox7_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox7.MouseEnter
        If Not btns_disabled Then
            PictureBox7.BackgroundImage = My.Resources.number_6_sel
        End If
    End Sub
    Private Sub PictureBox8_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox8.MouseEnter
        If Not btns_disabled Then
            PictureBox8.BackgroundImage = My.Resources.number_7_sel
        End If
    End Sub
    Private Sub PictureBox9_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox9.MouseEnter
        If Not btns_disabled Then
            PictureBox9.BackgroundImage = My.Resources.number_8_sel
        End If
    End Sub
    Private Sub PictureBox10_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox10.MouseEnter
        If Not btns_disabled Then
            PictureBox10.BackgroundImage = My.Resources.number_9_sel
        End If
    End Sub
    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
        If Not btns_disabled Then
            PictureBox1.BackgroundImage = My.Resources.number_0
        End If
    End Sub
    Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox2.MouseLeave
        If Not btns_disabled Then
            PictureBox2.BackgroundImage = My.Resources.number_1
        End If
    End Sub
    Private Sub PictureBox3_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox3.MouseLeave
        If Not btns_disabled Then
            PictureBox3.BackgroundImage = My.Resources.number_2
        End If
    End Sub
    Private Sub PictureBox4_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox4.MouseLeave
        If Not btns_disabled Then
            PictureBox4.BackgroundImage = My.Resources.number_3
        End If
    End Sub
    Private Sub PictureBox5_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox5.MouseLeave
        If Not btns_disabled Then
            PictureBox5.BackgroundImage = My.Resources.number_4
        End If
    End Sub
    Private Sub PictureBox6_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox6.MouseLeave
        If Not btns_disabled Then
            PictureBox6.BackgroundImage = My.Resources.number_5
        End If
    End Sub
    Private Sub PictureBox7_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox7.MouseLeave
        If Not btns_disabled Then
            PictureBox7.BackgroundImage = My.Resources.number_6
        End If
    End Sub
    Private Sub PictureBox8_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox8.MouseLeave
        If Not btns_disabled Then
            PictureBox8.BackgroundImage = My.Resources.number_7
        End If
    End Sub
    Private Sub PictureBox9_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox9.MouseLeave
        If Not btns_disabled Then
            PictureBox9.BackgroundImage = My.Resources.number_8
        End If
    End Sub
    Private Sub PictureBox10_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox10.MouseLeave
        If Not btns_disabled Then
            PictureBox10.BackgroundImage = My.Resources.number_9
        End If
    End Sub
    Public Sub doGenerate()
        Dim difficulty As Integer = MainForm.difficulty
        combo = ""
        Do Until difficulty = 0
            difficulty -= 1
            Randomize()
            combo &= Int((9 - 0 + 1) * Rnd() + 0)
            sofar = ""
        Loop
    End Sub
    Public Sub wait(ByVal seconds As Single)
        Static start As Single
        start = VB.Timer()
        Do While VB.Timer() < start + seconds
            System.Windows.Forms.Application.DoEvents()
        Loop
    End Sub
    Private Sub showMSG(text As String)
        msg.msgHere.Text = text
        msg.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer2.Stop()
        timer1.Stop()
        yesno.msgHere.Text = "Doing this will end the game" & vbCrLf &
            "with no highscore!"
        If yesno.ShowDialog = DialogResult.Yes Then
            Timer2.Stop()
            showMSG("Game Over!")
            If MainForm.difficulty = 2 Then
                timeleft = 5
                ProgressBar1.Maximum = timeleft
                ProgressBar1.Value = timeleft
            ElseIf MainForm.difficulty = 4 Then
                timeleft = 10
                ProgressBar1.Maximum = timeleft
                ProgressBar1.Value = timeleft
            ElseIf MainForm.difficulty = 6 Then
                timeleft = 15
                ProgressBar1.Maximum = timeleft
                ProgressBar1.Value = timeleft
            ElseIf MainForm.difficulty = 8 Then
                timeleft = 20
                ProgressBar1.Maximum = timeleft
                ProgressBar1.Value = timeleft
            End If
            PictureBox1.Visible = False
            PictureBox2.Visible = False
            PictureBox3.Visible = False
            PictureBox4.Visible = False
            PictureBox5.Visible = False
            PictureBox6.Visible = False
            PictureBox7.Visible = False
            PictureBox8.Visible = False
            PictureBox9.Visible = False
            PictureBox10.Visible = False
            Label4.Visible = False
            ProgressBar1.Visible = False
            ProgressBar1.Maximum = timeleft
            ProgressBar1.Value = timeleft
            label1.Visible = True
            label2.Text = "Ready," & vbCrLf & MainForm.textBox1.Text & "?"
            label2.Visible = False
            label3.Visible = False
            pb_life_1.Visible = False
            pb_life_2.Visible = False
            pb_life_3.Visible = False
            lbl_lives_descr.Visible = False
            lbl_score.Visible = False
            lbl_score_descr.Visible = False
            Button2.Enabled = False
            Me.Hide()
            highscore.ShowDialog()
            Exit Sub
        Else
            If Not pb_life_1.Visible And Not PictureBox1.Visible Then
                timer1.Start()
            End If
            Timer2.Start()
            Exit Sub
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer2.Stop()
        pause.ShowDialog()
    End Sub
End Class