Module Module1

    Sub Main()
        Dim char1, char2 As Char
        Dim i As Integer
        Dim s, str2 As String

        char1 = " "
        char2 = " "
        i = 0
        s = " "
        str2 = " "

        Console.Write("input text: ")
        s = Console.ReadLine

        For i = 1 To Len(s)
            char1 = Mid(s, i, 1)
            char2 = Left(s, 1)

            If char1 = char2 And i > 1 Then
                str2 = str2 & "*"

            Else
                str2 = str2 & char1
            End If
        Next

        Console.Write("output string is: " & str2)
        Console.ReadKey()
    End Sub

End Module
