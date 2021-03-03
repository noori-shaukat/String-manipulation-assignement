Module Module1

    Sub Main()
        Dim char1 As Char
        Dim str1 As String
        Dim vowelcounter, i As Integer

        char1 = " "
        str1 = " "
        vowelcounter = 0
        i = 0

        'input
        Console.Write("enter text: ")
        str1 = Console.ReadLine

        For i = 1 To Len(str1)
            char1 = Mid(str1, i, 1)
            char1 = UCase(char1)

            If char1 = "A" Or char1 = "E" Or char1 = "I" _
            Or char1 = "O" Or char1 = "U" Then
                vowelcounter = vowelcounter + 1
            End If
        Next
        Console.WriteLine("number of vowels in text are: " & vowelcounter)
        Console.ReadKey()
    End Sub

End Module
