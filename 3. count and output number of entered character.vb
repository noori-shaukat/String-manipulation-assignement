Module Module1

    Sub Main()
        Dim str1 As String
        Dim char1, char2 As Char
        Dim i, alphacounter As Integer

        str1 = " "
        char1 = " "
        char2 = " "
        i = 0
        alphacounter = 0

        Console.Write("enter text: ")
        str1 = Console.ReadLine

        Console.Write("enter char to be counted: ")
        char1 = Console.ReadLine

        For i = 1 To Len(str1)
            char2 = Mid(str1, i, 1)

            If char1 = char2 Then
                alphacounter = alphacounter + 1
            End If
        Next

        'output
        Console.WriteLine("number of characters: " & alphacounter)

        Console.ReadKey()
    End Sub

End Module
