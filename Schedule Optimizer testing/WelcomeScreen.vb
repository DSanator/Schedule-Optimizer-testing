Public Class WelcomeScreen
    Private Sub BtnStudentView_Click(sender As Object, e As EventArgs) Handles btnStudentVIew.Click
        Dim studentForm As New StudentIDForm()
        studentForm.Show()
        Me.Close()
    End Sub

End Class