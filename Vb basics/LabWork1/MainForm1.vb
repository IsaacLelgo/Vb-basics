Public Class MainForm1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'terminate application
        Me.Close()
    End Sub

    Private Sub btnLoadObject_Click(sender As Object, e As EventArgs) Handles btnLoadObject.Click
        'load and display object
        Dim objectDemonstrations As New ObjectDemonstrations()
        objectDemonstrations.Show()
    End Sub
End Class
