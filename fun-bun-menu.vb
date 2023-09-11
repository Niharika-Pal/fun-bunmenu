
Imports System
Module Program
    Sub Main(args As String())
        Dim item As Int64
        Dim bill As Int64
        Dim order As Int64
        Dim totalbill As Int64
        Dim ans1 As String = "yes"
    
        Console.WriteLine()
        Console.WriteLine("WELCOME TO FUN-BUN CAFE :<) " & vbCrLf & vbCrLf & "FUN-BUN CAFE MENU" & vbCrLf & vbCrLf & "1. COFFEE = 20 Rs." & vbCrLf & "2. Latte = 20 Rs." & vbCrLf & "3. Cake = 200 Rs." & vbCrLf & "4. Cappuccino = 20 Rs.")
        Console.WriteLine()
        While True
            If (ans1 = "no") Then
                Exit While
            ElseIf ans1 = "yes" Then
                Console.WriteLine("Enter order no. = ")
                item = Console.ReadLine()
                Select Case item
                    Case 1
                        Console.WriteLine("How many Coffee do you want to order?")
                        order = Console.ReadLine()
                        bill = order * 20
                        totalbill += bill
                        Console.WriteLine()
                        Console.WriteLine("Do you want to order anything else? :)  (yes/no)")
                        ans1 = Console.ReadLine()

                    Case 2
                        Console.WriteLine("How many Latte do you want to order?")
                        order = Console.ReadLine()
                        bill = order * 20
                        totalbill += bill
                        Console.WriteLine()
                        Console.WriteLine("Do you want to order anything else? :)   (yes/no)")
                        ans1 = Console.ReadLine()

                    Case 3
                        Console.WriteLine("How many cake do you want to order ?")
                        order = Console.ReadLine()
                        bill = order * 200
                        totalbill += bill
                        Console.WriteLine()
                        Console.WriteLine("Do you want to order anything else? :)   (yes/no)")
                        ans1 = Console.ReadLine()

                    Case 4
                        Console.WriteLine("How many cappuccinos do you want to order ?")
                        order = Console.ReadLine()
                        bill = order * 20
                        totalbill += bill
                        Console.WriteLine()
                        Console.WriteLine("Do you want to order anything else? :)    (yes/no)")
                        ans1 = Console.ReadLine()
                    Case Else
                        Console.WriteLine("Wrong entry!")
                End Select

            End If
        End While
        Console.WriteLine(vbCrLf & "Total bill of your order is = {0}", totalbill & "Rs." & vbCrLf & "THANK YOU FOR COMING :>)...HAVE A NICE DAY ;)")
        Console.ReadLine()
    End Sub
End Module
