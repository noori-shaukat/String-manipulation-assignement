Module Module1

    Sub Main()
        Dim str1, str2, leftstr, rightstr As String
        Dim notstart, badstart As Integer

        str1 = ""
        str2 = ""
        leftstr = ""
        rightstr = ""
        notstart = 0
        badstart = 0

        Console.Write("enter text: ")
        str1 = Console.ReadLine

        notstart = InStr(str1, "not")
        badstart = InStr(str1, "bad")

        If notstart < badstart Then
            leftstr = Left(str1, notstart - 1)
            rightstr = Right(str1, Len(str1) - badstart - 2)
            str2 = leftstr & "good" & rightstr
        Else
            str2 = str1
        End If

        Console.Write(str2)
        Console.ReadKey()



    End Sub

End Module
