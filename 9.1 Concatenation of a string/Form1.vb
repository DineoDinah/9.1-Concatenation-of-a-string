Public Class Form1
	Private Sub BtnShow_Click(sender As Object, e As EventArgs) Handles BtnShow.Click
		Dim text1 As String
		Dim text2 As String
		Dim text3 As String
		Dim text4 As String
		text1 = "Visual"
		text2 = "Basic"
		text3 = "2022"
		text4 = text1 + " " + text2 + " " + text3
		MsgBox(text4)
	End Sub


End Class
