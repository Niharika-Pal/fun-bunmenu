
Imports System
Module Program
    Sub Main(args As String())
        Dim item As Int64
        Dim bill As Int64
        Dim order As Int64
        Dim totalbill As Int64
        Dim ans1 As String
        Dim ans2 As String
        ans2 = "yes"
        Console.WriteLine()
        Console.WriteLine("WELCOME TO FUN-BUN CAFE :<) ")
        Console.WriteLine()
        Console.WriteLine("FUN-BUN CAFE MENU")
        Console.WriteLine("1. COFFEE = 20 Rs.")
        Console.WriteLine("2. Latte = 20 Rs.")
        Console.WriteLine("3. Cake = 20 Rs.")
        Console.WriteLine("4. Cappuccino = 20 Rs.")
        Console.WriteLine()
        Console.WriteLine("Would you like to dive into our menu options?....Enter yes or no")
        ans1 = Console.ReadLine()
        While True
            If (ans2 <> "yes") Then
                Exit While
            Else
                If ans1 = "yes" Then
                    Console.WriteLine("Enter order no. = ")
                    item = Console.ReadLine()
                    Select Case item
                        Case 1
                            Console.WriteLine("How many Coffee do you want to order?")
                            order = Console.ReadLine()
                            bill = order * 20
                            Console.WriteLine("Bill of " & order & " coffee is = {0}", bill & "Rs.")
                            totalbill += bill
                            Console.WriteLine()
                            Console.WriteLine("Do you want to order anything else? :)   (yes/no)")
                            ans1 = Console.ReadLine()

                        Case 2
                            Console.WriteLine("How many Latte do you want to order?")
                            order = Console.ReadLine()
                            bill = order * 20
                            Console.WriteLine("Bill of " & order & " latte is = {0}", bill & "Rs.")
                            totalbill += bill
                            Console.WriteLine()
                            Console.WriteLine("Do you want to order anything else? :)   (yes/no)")
                            ans1 = Console.ReadLine()

                        Case 3
                            Console.WriteLine("How many ?")
                            order = Console.ReadLine()
                            bill = order * 20
                            Console.WriteLine("Bill of " & order & " cake is = {0}", bill & "Rs.")
                            totalbill += bill
                            Console.WriteLine()
                            Console.WriteLine("Do you want to order anything else? :)   (yes/no)")
                            ans1 = Console.ReadLine()

                        Case 4
                            Console.WriteLine()
                            order = Console.ReadLine()
                            bill = order * 20
                            Console.WriteLine("bill of " & order & " cappuccino is = {0}", bill & "Rs.")
                            totalbill += bill
                            Console.WriteLine()
                            Console.WriteLine("Do you want to order anything else? :)    (yes/no)")
                            ans1 = Console.ReadLine()
                        Case Else
                            Console.WriteLine("Wrong entry!")
                    End Select
                    Console.WriteLine()
                    Console.WriteLine("Total bill of your order is = {0}", totalbill & "Rs.")
                Else
                    ans2 = "no"
                End If
            End If
        End While
       
        Console.WriteLine()
        Console.WriteLine("THANK YOU FOR COMING :>)...HAVE A NICE DAY ;) <3")
        Console.WriteLine(vbCrLf & vbCrLf)
    End Sub
End Module
