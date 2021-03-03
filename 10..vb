Module Module1

    Sub Main()
        Dim str1, str2 As String
        Dim i As Integer

        str1 = " "
        str2 = " "
        i = 0

        Console.Write("enter word: ")
        str1 = Console.ReadLine
        i = Len(str1)

        If i < 3 Then
            str2 = str1
        ElseIf i >= 3 Then
            If Right(str1, 3) = "ing" Then
                str2 = str1 & "ly"
            Else : str2 = str1 & "ing"
            End If
        End If

        Console.WriteLine(str2)
        Console.ReadKey()


    End Sub

End Module
