'
' Created by SharpDevelop.
' User: bharr0
' Date: 9/11/2017e
' Time: 2:00 PM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Partial Class MainForm
	Public difficulty As Integer = 0	
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub

    Sub TextBox1TextChanged(sender As Object, e As EventArgs) Handles textBox1.TextChanged
        If textBox1.TextLength = 16 Then
            label1.Text = "0 Characters Remaining"
        End If
        If textBox1.TextLength < 16 Then
            label1.Text = 16 - textBox1.TextLength & " Characters Remaining"
        End If
    End Sub

    Sub MainFormLoad(sender As Object, e As EventArgs)
        highscore.Close()
        revival.Close()
        Form1.Close()
    End Sub

    Sub RadioButton1CheckedChanged(sender As Object, e As EventArgs) Handles radioButton1.CheckedChanged
    	difficulty = 2
    	Form1.timeleft = 5
    End Sub

    Sub RadioButton2CheckedChanged(sender As Object, e As EventArgs) Handles radioButton2.CheckedChanged
    	difficulty = 4
    	Form1.timeleft = 10
    End Sub

    Sub RadioButton3CheckedChanged(sender As Object, e As EventArgs) Handles radioButton3.CheckedChanged
    	difficulty = 6
    	Form1.timeleft = 15
    End Sub

    Sub RadioButton4CheckedChanged(sender As Object, e As EventArgs) Handles radioButton4.CheckedChanged
    	difficulty = 8
    	Form1.timeleft = 20
    End Sub

    Sub Button1Click(sender As Object, e As EventArgs) Handles button1.Click
        If textBox1.Text = "" Or textBox1.TextLength < 3 Then
            MsgBox("Nothing was entered, or name was under 3 characters.")
            Exit Sub
        End If
        Form1.Show()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("Hello and Welcome!" & vbCrLf &
               "Numbers! Is a game about memory and focus; the more numbers remembered the higher the score." &
               " Playing the game is very simple. There are green circular number tiles spread accross the game." &
               " Upon startup, a demonstration of the numbers needing to be remembered are presented by each tile flashing blue for one second at a time." &
               " You will have three chances to get the combination right, upon getting one wrong, a life is lost and the combination is regenerated with another demonstration." &
               " If you run out of lives, you will get ONE revival which will refill all of your lives upon getting the question right, once the revival is used it cannot be used again." &
               " There is no winning to this game, as it is endless. The only limits to this game is your memory!")
        Exit Sub
    End Sub
End Class
