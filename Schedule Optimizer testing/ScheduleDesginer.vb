Public Class ScheduleDesignGui
    Dim something As String = "something"

    Private Sub btnLoadClasses_Click(sender As Object, e As EventArgs)
        ' Loop through all items in lvEnterClasses and add them to lvSchedule
        For Each item As ListViewItem In lvEnterClasses.Items
            Dim className As String = item.Text ' First column (Course Name)

            'Create a variable that stores the entered course name

            'Error Message if no courses ae enterered
            If lvEnterClasses.Items.Count = 0 Then
                MessageBox.Show("There are no classes available to load.", "Empty List", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

    End Sub

    Private Sub ScheduleDesignGui_Load(sender As Object, e As EventArgs) 

    End Sub


End Class
