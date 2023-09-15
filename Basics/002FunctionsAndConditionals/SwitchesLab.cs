using System;
					
public class Program
{
	public GameStates gameStates;
	
	public void Main()
	{
		gameStates = new GameStates();
		gameStates.currentState = GameStates.States.Finished;
		gameStates.CheckState();
	}
}

public class GameStates {
	
	public enum States {
		Begin,
		Comence,
		Finished
	}
	
	public States currentState = States.Begin;
	
	public void CheckState () {
		switch (currentState) {
			case States.Begin:
				Console.WriteLine("Begin");
				break;
			case States.Comence:
				Console.WriteLine("Comence");
				break;
			case States.Finished:
				Console.WriteLine("Finished");
				break;
		}
	}
}