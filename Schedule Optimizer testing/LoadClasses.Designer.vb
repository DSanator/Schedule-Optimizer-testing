<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoadClasses
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbxCourseCode = New System.Windows.Forms.TextBox()
        Me.lvwAvailableClasses = New System.Windows.Forms.ListView()
        Me.CourseTitle = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CourseCode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnAddCourse = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.ProgressBar4 = New System.Windows.Forms.ProgressBar()
        Me.ProgressBar5 = New System.Windows.Forms.ProgressBar()
        Me.ProgressBar6 = New System.Windows.Forms.ProgressBar()
        Me.ProgressBar7 = New System.Windows.Forms.ProgressBar()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnRemoveCourse = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 71)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Course Code"
        '
        'tbxCourseCode
        '
        Me.tbxCourseCode.Location = New System.Drawing.Point(29, 90)
        Me.tbxCourseCode.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tbxCourseCode.Name = "tbxCourseCode"
        Me.tbxCourseCode.Size = New System.Drawing.Size(140, 20)
        Me.tbxCourseCode.TabIndex = 1
        '
        'lvwAvailableClasses
        '
        Me.lvwAvailableClasses.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.CourseTitle, Me.CourseCode, Me.ColumnHeader2})
        Me.lvwAvailableClasses.GridLines = True
        Me.lvwAvailableClasses.HideSelection = False
        Me.lvwAvailableClasses.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.lvwAvailableClasses.Location = New System.Drawing.Point(192, 90)
        Me.lvwAvailableClasses.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.lvwAvailableClasses.Name = "lvwAvailableClasses"
        Me.lvwAvailableClasses.Size = New System.Drawing.Size(218, 256)
        Me.lvwAvailableClasses.TabIndex = 2
        Me.lvwAvailableClasses.UseCompatibleStateImageBehavior = False
        Me.lvwAvailableClasses.View = System.Windows.Forms.View.Details
        '
        'CourseTitle
        '
        Me.CourseTitle.Text = "Course Title"
        Me.CourseTitle.Width = 110
        '
        'CourseCode
        '
        Me.CourseCode.Text = "Course Code"
        Me.CourseCode.Width = 98
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Credits"
        '
        'btnAddCourse
        '
        Me.btnAddCourse.Location = New System.Drawing.Point(29, 113)
        Me.btnAddCourse.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnAddCourse.Name = "btnAddCourse"
        Me.btnAddCourse.Size = New System.Drawing.Size(140, 42)
        Me.btnAddCourse.TabIndex = 3
        Me.btnAddCourse.Text = "Add Course" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnAddCourse.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(190, 71)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Previously taken courses" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(497, 28)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BackToolStripMenuItem
        '
        Me.BackToolStripMenuItem.Name = "BackToolStripMenuItem"
        Me.BackToolStripMenuItem.Size = New System.Drawing.Size(54, 24)
        Me.BackToolStripMenuItem.Text = "Back"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(94, 198)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(75, 19)
        Me.ProgressBar1.TabIndex = 6
        '
        'ProgressBar4
        '
        Me.ProgressBar4.Location = New System.Drawing.Point(94, 232)
        Me.ProgressBar4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ProgressBar4.Name = "ProgressBar4"
        Me.ProgressBar4.Size = New System.Drawing.Size(75, 19)
        Me.ProgressBar4.TabIndex = 9
        '
        'ProgressBar5
        '
        Me.ProgressBar5.Location = New System.Drawing.Point(94, 264)
        Me.ProgressBar5.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ProgressBar5.Name = "ProgressBar5"
        Me.ProgressBar5.Size = New System.Drawing.Size(75, 19)
        Me.ProgressBar5.TabIndex = 10
        '
        'ProgressBar6
        '
        Me.ProgressBar6.Location = New System.Drawing.Point(94, 296)
        Me.ProgressBar6.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ProgressBar6.Name = "ProgressBar6"
        Me.ProgressBar6.Size = New System.Drawing.Size(75, 19)
        Me.ProgressBar6.TabIndex = 11
        '
        'ProgressBar7
        '
        Me.ProgressBar7.Location = New System.Drawing.Point(94, 327)
        Me.ProgressBar7.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ProgressBar7.Name = "ProgressBar7"
        Me.ProgressBar7.Size = New System.Drawing.Size(75, 19)
        Me.ProgressBar7.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 37)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(460, 15)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Please enter the course code of all previously taken courses in the format XXX123" &
    "4."
        '
        'btnRemoveCourse
        '
        Me.btnRemoveCourse.Location = New System.Drawing.Point(29, 160)
        Me.btnRemoveCourse.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnRemoveCourse.Name = "btnRemoveCourse"
        Me.btnRemoveCourse.Size = New System.Drawing.Size(140, 33)
        Me.btnRemoveCourse.TabIndex = 14
        Me.btnRemoveCourse.Text = "Remove Course"
        Me.btnRemoveCourse.UseVisualStyleBackColor = True
        '
        'LoadClasses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(497, 397)
        Me.Controls.Add(Me.btnRemoveCourse)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ProgressBar7)
        Me.Controls.Add(Me.ProgressBar6)
        Me.Controls.Add(Me.ProgressBar5)
        Me.Controls.Add(Me.ProgressBar4)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnAddCourse)
        Me.Controls.Add(Me.lvwAvailableClasses)
        Me.Controls.Add(Me.tbxCourseCode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "LoadClasses"
        Me.Text = "Load Previously Taken Classes"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents tbxCourseCode As TextBox
    Friend WithEvents lvwAvailableClasses As ListView
    Friend WithEvents CourseTitle As ColumnHeader
    Friend WithEvents CourseCode As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents btnAddCourse As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BackToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents ProgressBar4 As ProgressBar
    Friend WithEvents ProgressBar5 As ProgressBar
    Friend WithEvents ProgressBar6 As ProgressBar
    Friend WithEvents ProgressBar7 As ProgressBar
    Friend WithEvents Label3 As Label
    Friend WithEvents btnRemoveCourse As Button


End Class
