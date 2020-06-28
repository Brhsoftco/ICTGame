Public Class highscore
    Dim highscore_ As New Highscore_Manager
    Private Sub showMSG(text As String)
        msg.msgHere.Text = text
        msg.ShowDialog()
    End Sub
    Private Sub highscore_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            highscore_.LoadScores(10, 0, "AVAILABLE", "Numbers!", True)
            If highscore_.CheckScore(Convert.ToInt32(Form1.lbl_score.Text), True) Then
                highscore_.SaveScore("Numbers!", MainForm.textBox1.Text, Convert.ToInt32(Form1.lbl_score.Text), True)
                highscore_.LoadScores(10, 0, "AVAILABLE", "Numbers!", True)
                showMSG("You made it to the" & vbCrLf &
                    "highscore board!")
            End If
            Dim s As String

            For i = 0 To 9
                s = highscore_.GetPlayerName(i) & " - " & highscore_.GetPlayerScore(i) & vbCrLf
                If i = 0 Then
                    first.Text = s
                ElseIf i = 1 Then
                    second.Text = s
                ElseIf i = 2 Then
                    third.Text = s
                ElseIf i = 3 Then
                    fourth.Text = s
                ElseIf i = 4 Then
                    fifth.Text = s
                ElseIf i = 5 Then
                    sixth.Text = s
                ElseIf i = 6 Then
                    seventh.Text = s
                ElseIf i = 7 Then
                    eighth.Text = s
                ElseIf i = 8 Then
                    nineth.Text = s
                ElseIf i = 9 Then
                    tenth.Text = s
                End If

            Next i
        Catch ex As Exception
            MsgBox("An unhandled exception occurred in your application, details:" & vbCrLf &
                   ex.ToString, vbCritical, "Unhandled Exception - NUMBERS_READWRITESCORE")
            revival.Close()
            Form1.Close()
            Me.Close()
        End Try
    End Sub

    Private Sub RectangleShape2_Click(sender As Object, e As EventArgs) Handles RectangleShape2.Click, RectangleShape1.Click

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        revival.Close()
        Form1.Close()
        Me.Close()
    End Sub
End Class