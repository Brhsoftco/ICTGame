'
' Created by SharpDevelop.
' User: bharr0
' Date: 9/11/2017
' Time: 2:00 PM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class MainForm
	Inherits System.Windows.Forms.Form
	
	''' <summary>
	''' Designer variable used to keep track of non-visual components.
	''' </summary>
	Private components As System.ComponentModel.IContainer
	
	''' <summary>
	''' Disposes resources used by the form.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
	
	''' <summary>
	''' This method is required for Windows Forms designer support.
	''' Do not change the method contents inside the source code editor. The Forms designer might
	''' not be able to load this method if it was changed manually.
	''' </summary>
	Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.radioButton4 = New System.Windows.Forms.RadioButton()
        Me.radioButton3 = New System.Windows.Forms.RadioButton()
        Me.radioButton2 = New System.Windows.Forms.RadioButton()
        Me.radioButton1 = New System.Windows.Forms.RadioButton()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.groupBox1.SuspendLayout()
        Me.panel1.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.panel1)
        Me.groupBox1.Location = New System.Drawing.Point(12, 12)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(262, 61)
        Me.groupBox1.TabIndex = 0
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Select Difficulty"
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me.radioButton4)
        Me.panel1.Controls.Add(Me.radioButton3)
        Me.panel1.Controls.Add(Me.radioButton2)
        Me.panel1.Controls.Add(Me.radioButton1)
        Me.panel1.Location = New System.Drawing.Point(6, 19)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(249, 38)
        Me.panel1.TabIndex = 0
        '
        'radioButton4
        '
        Me.radioButton4.Location = New System.Drawing.Point(196, 3)
        Me.radioButton4.Name = "radioButton4"
        Me.radioButton4.Size = New System.Drawing.Size(48, 24)
        Me.radioButton4.TabIndex = 3
        Me.radioButton4.TabStop = True
        Me.radioButton4.Text = "Hard"
        Me.radioButton4.UseVisualStyleBackColor = True
        '
        'radioButton3
        '
        Me.radioButton3.Location = New System.Drawing.Point(133, 3)
        Me.radioButton3.Name = "radioButton3"
        Me.radioButton3.Size = New System.Drawing.Size(104, 24)
        Me.radioButton3.TabIndex = 2
        Me.radioButton3.TabStop = True
        Me.radioButton3.Text = "Medium"
        Me.radioButton3.UseVisualStyleBackColor = True
        '
        'radioButton2
        '
        Me.radioButton2.Location = New System.Drawing.Point(74, 3)
        Me.radioButton2.Name = "radioButton2"
        Me.radioButton2.Size = New System.Drawing.Size(104, 24)
        Me.radioButton2.TabIndex = 1
        Me.radioButton2.TabStop = True
        Me.radioButton2.Text = "Normal"
        Me.radioButton2.UseVisualStyleBackColor = True
        '
        'radioButton1
        '
        Me.radioButton1.Location = New System.Drawing.Point(3, 3)
        Me.radioButton1.Name = "radioButton1"
        Me.radioButton1.Size = New System.Drawing.Size(104, 24)
        Me.radioButton1.TabIndex = 0
        Me.radioButton1.TabStop = True
        Me.radioButton1.Text = "Simpleton"
        Me.radioButton1.UseVisualStyleBackColor = True
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.label1)
        Me.groupBox2.Controls.Add(Me.textBox1)
        Me.groupBox2.Location = New System.Drawing.Point(12, 79)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(262, 62)
        Me.groupBox2.TabIndex = 1
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Player Name"
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(127, 42)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(128, 17)
        Me.label1.TabIndex = 1
        Me.label1.Text = "16 Characters Remaining"
        '
        'textBox1
        '
        Me.textBox1.Location = New System.Drawing.Point(6, 19)
        Me.textBox1.MaxLength = 16
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(249, 20)
        Me.textBox1.TabIndex = 0
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(12, 147)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(262, 23)
        Me.button1.TabIndex = 2
        Me.button1.Text = "Go"
        Me.button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 176)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(262, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "How to Play"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 208)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.groupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainForm"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Numbers! Launcher"
        Me.groupBox1.ResumeLayout(False)
        Me.panel1.ResumeLayout(False)
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents button1 As System.Windows.Forms.Button
	Public WithEvents textBox1 As System.Windows.Forms.TextBox
	Private label1 As System.Windows.Forms.Label
	Private groupBox2 As System.Windows.Forms.GroupBox
	Private WithEvents radioButton1 As System.Windows.Forms.RadioButton
	Private WithEvents radioButton2 As System.Windows.Forms.RadioButton
	Private WithEvents radioButton3 As System.Windows.Forms.RadioButton
	Private WithEvents radioButton4 As System.Windows.Forms.RadioButton
	Private panel1 As System.Windows.Forms.Panel
	Private groupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As Button
End Class
