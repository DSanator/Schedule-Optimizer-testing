Public Class StudentIDForm
    Public UFID As Double
    Public newStudent As Student
    '  Public idList 
    Private Sub btnNext_Click(sender As Object, e As EventArgs) handles btnNext.Click
        If tbxUFID.Text = Nothing Then
            MessageBox.Show("Please input your UF ID number!", "Input Error", MessageBoxButtons.OK)
        ElseIf IsNumeric(tbxUFID.Text) = False Then
            MessageBox.Show("Please input a numerical value in the form XXXXXXX", "Input Error", MessageBoxButtons.OK)
        ElseIf IsNumeric(tbxUFID.Text) And tbxUFID.Text.Length <> 8 Then
            MessageBox.Show("Please include all 8 digits in your UF ID", "Input Error", MessageBoxButtons.OK)
        ElseIf IsNumeric(tbxUFID.Text) = True And tbxUFID.Text.Length = 8 Then
            Dim myID As Double = CDbl(tbxUFID.Text)
            Dim newStudent As New Student
            newStudent.addAStudent(myID)
            LoadClasses.Show()
            Me.Close()
        End If
    End Sub
End Class