﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm1
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
        btnLoadObject = New Button()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' btnLoadObject
        ' 
        btnLoadObject.Location = New Point(72, 171)
        btnLoadObject.Name = "btnLoadObject"
        btnLoadObject.Size = New Size(153, 59)
        btnLoadObject.TabIndex = 0
        btnLoadObject.Text = "&Load Object Demo"
        btnLoadObject.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(312, 171)
        Button2.Name = "Button2"
        Button2.Size = New Size(176, 59)
        Button2.TabIndex = 1
        Button2.Text = "E&XIT"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button2)
        Controls.Add(btnLoadObject)
        Name = "Form1"
        Text = "Welcoming Form"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnLoadObject As Button
    Friend WithEvents Button2 As Button

End Class
