Module Module1

    Sub Main()
        Dim char1 As Char
        Dim s, str2, a, b As String

        char1 = " "
        s = " "
        a = " "
        b = " "
        str2 = " "

        Console.Write("enter string: ")
        s = Console.ReadLine()

        If Len(s) > 2 Then
            a = Left(s, 2)
            b = Right(s, 2)
            str2 = a & b
        Else
            str2 = s
        End If

        Console.Write("output string is: " & str2)
        Console.ReadKey()

    End Sub

End Module
