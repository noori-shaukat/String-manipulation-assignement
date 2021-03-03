Module Module1

    Sub Main()
        Dim Str1, Alphabets As String
        Dim Char1 As Char
        Dim i As Integer
        Dim isPangram As Boolean

        Str1 = " "
        Alphabets = "abcdefghijklmnopqrstuvwxyz"
        i = 0
        isPangram = True
        Char1 = " "

        Console.Write("Enter text: ")
        Str1 = Console.ReadLine
        Str1 = LCase(Str1)

        For i = 1 To Len(Alphabets)
            Char1 = Mid(Alphabets, i, 1)
            If InStr(Str1, Char1) = 0 Then isPangram = False
        Next i


        If isPangram = True Then
            Console.WriteLine("Entered string is a Pangram.")
        Else
            Console.WriteLine("Entered string is NOT a Pangram.")
        End If

        Console.ReadKey()
    End Sub

End Module
