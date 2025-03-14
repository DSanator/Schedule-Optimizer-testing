<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WelcomeScreen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnStudentVIew = New System.Windows.Forms.Button()
        Me.btnAdminView = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(123, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(549, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Welcome to the University of Florida Industrial and Systens Engineering Schedule " &
    "Assistant!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btnStudentVIew
        '
        Me.btnStudentVIew.Location = New System.Drawing.Point(239, 157)
        Me.btnStudentVIew.Name = "btnStudentVIew"
        Me.btnStudentVIew.Size = New System.Drawing.Size(296, 77)
        Me.btnStudentVIew.TabIndex = 1
        Me.btnStudentVIew.Text = "Student View"
        Me.btnStudentVIew.UseVisualStyleBackColor = True
        '
        'btnAdminView
        '
        Me.btnAdminView.Location = New System.Drawing.Point(239, 256)
        Me.btnAdminView.Name = "btnAdminView"
        Me.btnAdminView.Size = New System.Drawing.Size(296, 77)
        Me.btnAdminView.TabIndex = 2
        Me.btnAdminView.Text = "Admin View"
        Me.btnAdminView.UseVisualStyleBackColor = True
        '
        'WelcomeScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnAdminView)
        Me.Controls.Add(Me.btnStudentVIew)
        Me.Controls.Add(Me.Label1)
        Me.Name = "WelcomeScreen"
        Me.Text = "Welcome Page"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnStudentVIew As Button
    Friend WithEvents btnAdminView As Button
End Class
