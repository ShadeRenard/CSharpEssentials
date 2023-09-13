using System;
					
public class Program
{
	public Operations myOperator;
	
	public void Main()
	{
		myOperator = new Operations();
		
		Console.WriteLine("Current temperture");
		myOperator.DoMath(6, 4);
		myOperator.DoMath(50, 5);
		myOperator.DoMath(100, 2);
		myOperator.Compare(4,3);
		myOperator.Compare(3,4);
	}
}

public class Operations {
	public void DoMath (int value, int value2) {
		var number = value + value2;
		Console.WriteLine(number);
	}
	
	public void Compare (int value, int value2) {
		int x = 30;
		int y = 10;
		if (x > y) 
		if(value > value2) {
			Console.WriteLine("True, stay hydrated and avoid staying in the sun for too long.");
		} else {
			Console.WriteLine("False, enjoy the pleasant weather.");
		}
	}
}