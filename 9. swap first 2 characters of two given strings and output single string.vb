Module Module1

    Sub Main()
        Dim str1, str2, s1, s2 As String
        Dim i1, i2 As Integer
        Dim char1, char2 As Char

        str1 = " "
        str2 = " "
        s1 = " "
        s2 = " "
        i1 = 0
        i2 = 0
        char1 = " "
        char2 = " "

        Console.Write("enter first string: ")
        str1 = Console.ReadLine

        Console.Write("enter second string: ")
        str2 = Console.ReadLine

        s1 = Left(str1, 2)
        s2 = Left(str2, 2)

        For i1 = 3 To Len(str1)
            char1 = Mid(str1, i1, 1)
            s2 = s2 & char1
        Next

        For i2 = 3 To Len(str2)
            char2 = Mid(str2, i2, 1)
            s1 = s1 & char2
        Next

        Console.Write("output is: " & s2 & " " & s1)
        Console.ReadKey()
    End Sub

End Module
