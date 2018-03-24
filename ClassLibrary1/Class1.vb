Imports System

Public Class Class1
    Public Function getTime()
        Dim time As String

        time = DateAndTime.TimeOfDay().ToString()

        Return time

    End Function

End Class
