' Fiber
' User: 14936606
' Date: 4/17/2014
' Time: 3:41 PM
' 
' This code is property of Joshua Stone.
' 
Module Program
	Sub Main()
		' declare vars
		Dim feet As Double = 0.0
		Dim fiberCost As Double = 0.21
		Dim total As Double = 0.0
		Dim compName As String = ""

		' ask For Company Name
		Console.WriteLine("What is your Company Name?")
		compName = Console.ReadLine()
		Console.Clear()
		' get item amounts and add up subtotal
		Console.WriteLine("Welcome " & compName & ".")
		console.writeline("How many feet of fiber is needed?")
		feet = console.readline()
		console.clear()
		total = Math.Round((feet * fiberCost),2)
		Console.WriteLine("Welcome " & compName & ".")
		console.writeline("Total cost is $"&total)

		
		Console.ReadLine()
		
	End Sub
End Module
