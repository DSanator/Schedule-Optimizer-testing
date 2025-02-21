<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoadClasses
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lvwAvailableClasses = New System.Windows.Forms.ListView()
        Me.Name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.ProgressBar4 = New System.Windows.Forms.ProgressBar()
        Me.ProgressBar5 = New System.Windows.Forms.ProgressBar()
        Me.ProgressBar6 = New System.Windows.Forms.ProgressBar()
        Me.ProgressBar7 = New System.Windows.Forms.ProgressBar()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(60, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Class Code (ABC1234)"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(41, 82)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(186, 22)
        Me.TextBox1.TabIndex = 1
        '
        'lvwAvailableClasses
        '
        Me.lvwAvailableClasses.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Name, Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lvwAvailableClasses.GridLines = True
        Me.lvwAvailableClasses.HideSelection = False
        Me.lvwAvailableClasses.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.lvwAvailableClasses.Location = New System.Drawing.Point(258, 82)
        Me.lvwAvailableClasses.Name = "lvwAvailableClasses"
        Me.lvwAvailableClasses.Size = New System.Drawing.Size(246, 314)
        Me.lvwAvailableClasses.TabIndex = 2
        Me.lvwAvailableClasses.UseCompatibleStateImageBehavior = False
        Me.lvwAvailableClasses.View = System.Windows.Forms.View.Details
        '
        'Name
        '
        Me.Name.Text = "Name"
        Me.Name.Width = 110
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Code"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Credits"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(41, 110)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(186, 52)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Add class to previously taken classes"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(302, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Previously taken classes:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(557, 28)
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
        Me.ProgressBar1.Location = New System.Drawing.Point(127, 181)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(100, 23)
        Me.ProgressBar1.TabIndex = 6
        '
        'ProgressBar4
        '
        Me.ProgressBar4.Location = New System.Drawing.Point(127, 222)
        Me.ProgressBar4.Name = "ProgressBar4"
        Me.ProgressBar4.Size = New System.Drawing.Size(100, 23)
        Me.ProgressBar4.TabIndex = 9
        '
        'ProgressBar5
        '
        Me.ProgressBar5.Location = New System.Drawing.Point(127, 262)
        Me.ProgressBar5.Name = "ProgressBar5"
        Me.ProgressBar5.Size = New System.Drawing.Size(100, 23)
        Me.ProgressBar5.TabIndex = 10
        '
        'ProgressBar6
        '
        Me.ProgressBar6.Location = New System.Drawing.Point(127, 301)
        Me.ProgressBar6.Name = "ProgressBar6"
        Me.ProgressBar6.Size = New System.Drawing.Size(100, 23)
        Me.ProgressBar6.TabIndex = 11
        '
        'ProgressBar7
        '
        Me.ProgressBar7.Location = New System.Drawing.Point(127, 339)
        Me.ProgressBar7.Name = "ProgressBar7"
        Me.ProgressBar7.Size = New System.Drawing.Size(100, 23)
        Me.ProgressBar7.TabIndex = 12
        '
        'LoadClasses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(557, 437)
        Me.Controls.Add(Me.ProgressBar7)
        Me.Controls.Add(Me.ProgressBar6)
        Me.Controls.Add(Me.ProgressBar5)
        Me.Controls.Add(Me.ProgressBar4)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lvwAvailableClasses)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "LoadClasses"
        Me.Text = "Load Previously Taken Classes"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lvwAvailableClasses As ListView
    Friend WithEvents Name As ColumnHeader
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BackToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents ProgressBar4 As ProgressBar
    Friend WithEvents ProgressBar5 As ProgressBar
    Friend WithEvents ProgressBar6 As ProgressBar
    Friend WithEvents ProgressBar7 As ProgressBar
End Class
