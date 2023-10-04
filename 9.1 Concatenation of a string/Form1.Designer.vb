<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		BtnShow = New Button()
		Label1 = New Label()
		SuspendLayout()
		' 
		' BtnShow
		' 
		BtnShow.Location = New Point(252, 244)
		BtnShow.Margin = New Padding(5, 4, 5, 4)
		BtnShow.Name = "BtnShow"
		BtnShow.Size = New Size(179, 41)
		BtnShow.TabIndex = 0
		BtnShow.Text = "Button1"
		BtnShow.UseVisualStyleBackColor = True
		' 
		' Label1
		' 
		Label1.AutoSize = True
		Label1.Location = New Point(190, 55)
		Label1.Margin = New Padding(5, 0, 5, 0)
		Label1.Name = "Label1"
		Label1.Size = New Size(290, 30)
		Label1.TabIndex = 1
		Label1.Text = "Concatenating String"
		' 
		' Form1
		' 
		AutoScaleDimensions = New SizeF(16F, 30F)
		AutoScaleMode = AutoScaleMode.Font
		BackColor = SystemColors.ControlDark
		ClientSize = New Size(1280, 540)
		Controls.Add(Label1)
		Controls.Add(BtnShow)
		Font = New Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
		Margin = New Padding(5, 4, 5, 4)
		Name = "Form1"
		Text = "Concatenation string"
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents BtnShow As Button
	Friend WithEvents Label1 As Label
End Class
