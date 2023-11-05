Imports System

Namespace FizzBuzz
    Public Class FizzBuzz
        Public Function Execute(input as Integer) As String
            Dim returnString = new System.Text.StringBuilder()
            If IsDivisibleBy3(input) Then
                returnString.Append("Fizz")
            End If

            If input Mod 5 = 0 Then
                returnString.Append("Buzz")
            End If

            If returnString.ToString = ""
                Return input.ToString
            Else
                Return returnString.ToString
            End If
        End Function

        Private Function IsDivisibleBy3(input As Integer) As Boolean 
            Return input Mod 3 = 0
        End Function
        
        ' private bool IsDivisibleBy5(int input) {
        '     return input % 5 == 0;
        ' }
    End Class
End Namespace
