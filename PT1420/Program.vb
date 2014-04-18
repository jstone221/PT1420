'
' User: 14936606
' Date: 4/17/2014
' Time: 3:41 PM
' 
' This code is property of Joshua Stone.
' 
Module Program
	Sub Main()
		' declare vars
		Dim subtotal As Double = 0.0
		Dim tax As Double = 0.06
		Dim taxAmt As Double = 0.0
		Dim total As Double = 0.0
		Dim lineItems As Integer = 0
		Dim count As Integer = 0
		Dim currentItem As Double = 0
		' ask how many items and set item array
		Console.WriteLine("How many Items?")
		lineItems = Console.ReadLine()
		Console.Clear()
		Dim items(lineItems)
		' get item amounts and add up subtotal
		While count < lineItems 
			Console.WriteLine("Please enter item " & (count + 1) & ".")
			Console.Write("$")
			items(count) = Console.ReadLine()
			subtotal = subtotal + items(count)
			count +=1 
			Console.Clear()
		End While
		' reset counter
		count = 0
		' display amounts
		While count < lineItems 
			currentItem=items(count)
			Console.WriteLine((count + 1) & ". $" & currentItem)
			count +=1 
		End While
		' calculate and display calculations
		taxAmt = Math.Round((subtotal * tax),2)
		total = subtotal + taxAmt
		Console.WriteLine("Subtotal : $" & subtotal)
		Console.WriteLine("Tax      : $" & taxAmt)
		Console.WriteLine("Total    : $" & total)
		Console.ReadLine()
		
	End Sub
End Module
