
Public Class LoadClasses
    Private newCourse As New Course
    Private Sub btnAddCourse_Click(sender As Object, e As EventArgs) Handles btnAddCourse.Click
        Dim newCourse As New Course
        Dim courseCode As String
        courseCode = tbxCourseCode.Text

        UpdateListView()
    End Sub

    Private Sub UpdateListView()

    End Sub

End Class