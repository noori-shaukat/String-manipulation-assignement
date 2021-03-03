Module Module1

    Sub Main()
        Dim char1, char2, char3 As Char
        Dim str1, str2 As String
        Dim i As Integer

        str1 = " "
        str2 = " "
        char1 = " "
        char2 = " "
        char3 = " "
        i = 0

        Console.Write("Enter text: ")
        str1 = Console.ReadLine()

        Console.Write("Enter char to be removed: ")
        char2 = Console.ReadLine

        Console.Write("Enter character to be replaced: ")
        char3 = Console.ReadLine

        For i = 1 To Len(str1)
            char1 = Mid(str1, i, 1)
            If char1 = char2 Then
                str2 = str2 & char3
            Else
                str2 = str2 & char1
            End If
        Next


        'output
        Console.WriteLine("Final text is: " & str2)

        Console.ReadKey()

    End Sub

End Module
