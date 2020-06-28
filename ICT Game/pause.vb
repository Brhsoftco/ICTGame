Public Class pause
    Public togglemode As Boolean
    Private Sub RectangleShape1_Click(sender As Object, e As EventArgs) Handles RectangleShape1.Click

    End Sub
    Private Sub pause_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
    Private Sub pause_FormClosing(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        Timer1.Stop()
        Label1.Visible = True
        togglemode = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If togglemode Then
            Label1.Visible = False
            togglemode = False
        Else
            Label1.Visible = True
            togglemode = True
        End If
    End Sub
    Private Sub pause_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = Keys.P Then
            Form1.Timer2.Start()
            Me.Close()
        End If
    End Sub
End Class