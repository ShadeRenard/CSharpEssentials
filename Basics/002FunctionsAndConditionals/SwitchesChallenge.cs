using System;
					
public class Program
{
	public Operations myOperator;
	
	public void Main()
	{
		myOperator = new Operations();
		
		Console.WriteLine("Exam Grader");
		myOperator.DoMath(10, 90, 1);
		myOperator.DoMath(10, 70, 1);
		myOperator.DoMath(10, 60, 1);
		myOperator.DoMath(10, 50, 1);
		myOperator.DoMath(10, 40, 1);
		myOperator.Compare(4,3,2);
		myOperator.Compare(3,4,2);
	}
}

public class Operations {
	public void DoMath (int value, int value2, int value3) {
		var number = value + value2 + value3;
		Console.WriteLine(number);
	}
	
	public void Compare (int value, int value2, int value3) {
		int x = 30;
		int y = 10;
		if (x > y) 
		if(value > value2) {
		 {
			Console.WriteLine("100%-90% A");
			Console.WriteLine("89%-80% B");
			Console.WriteLine("79%-70% C");
			 Console.WriteLine("69%-60% D");
			 Console.WriteLine("59%-50% F");
		}
	}
	}
}