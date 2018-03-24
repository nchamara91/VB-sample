Imports ClassLibrary1

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim time As New Class1

        MessageBox.Show(time.getTime())


    End Sub
End Class
