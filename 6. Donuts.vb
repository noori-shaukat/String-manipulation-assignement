Module Module1

    Sub Main()
        'donuts:
        'INPUT an INT count of a number of donuts, OUTPUT a string of the form 'Number of donuts: <count>', where <count> is the number
        'input. However, if the count is 10 or more, then use the word 'many' instead of the actual count.

            Dim str1 As String
            Dim x As Integer

            x = 0
            str1 = " "

            Console.Write("enter number of donuts: ")
            x = Console.ReadLine()

            If x >= 10 Then
                str1 = "many"

            Else
                str1 = x

            End If

            'output
            Console.WriteLine("donuts: " & str1)

            Console.ReadKey()
        End Sub

    End Module
