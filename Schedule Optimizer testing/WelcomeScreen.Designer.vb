﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(102, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(581, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Welcome to the University of Florida Industrial and Systens Engineering Course Tr" &
    "acker Website!"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(239, 157)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(296, 77)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Start Course Tracker"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(239, 256)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(296, 77)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Admin View"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'WelcomeScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "WelcomeScreen"
        Me.Text = "Welcome Page"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
