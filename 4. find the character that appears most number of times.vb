Module Module1

    Sub Main()
        '4. find the character that appears most number of times

        Dim Char1, Char2, Char3 As Char
        Dim Highest, Count, i, j As Integer
        Dim str1 As String

        Char1 = " "
        Char2 = " "
        Char3 = " "
        i = 0
        j = 0
        Highest = 0
        Count = 0
        str1 = " "

        Console.Write("Enter text: ")
        str1 = Console.ReadLine

        For i = 1 To Len(str1)
            Char3 = Mid(str1, i, 1)
            Count = 0
            For j = 1 To Len(str1)
                Char2 = Mid(str1, j, 1)
                If Char2 = Char3 Then Count = Count + 1
            Next

            If Count > Highest Then
                Highest = Count
                Char1 = Char3
            End If
        Next
        Console.WriteLine(Char1 & " appeared the highest number of times")
        Console.ReadKey()
    End Sub

End Module
