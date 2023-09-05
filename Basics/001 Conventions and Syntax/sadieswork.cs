using System;
					
public class Program
{
	public Weapon miniGun;
	public PowerUp weaponPowerUp;

	public void Main()
	{
		miniGun = new Weapon();
		weaponPowerUp = new PowerUp();
		
		miniGun.ammoCount ++;
		miniGun.firePower += weaponPowerUp.powerLevel;
		Console.WriteLine("Sadie was Here!!");
		Console.WriteLine("The fire power of " + miniGun.weaponName + " has an ammo count of " + miniGun.ammoCount + ".");
		Console.WriteLine("Your weapon now has a fire power of " + miniGun.firePower + ", it has increased.");
		Console.WriteLine("Mission Compeleted");
	}
}
public class Weapon
{ 
	public int ammoCount = 20;
	public String weaponName = "peacemaker";
	public float firePower = 25.5f;
}
public class PowerUp 
{
	public float powerLevel = 2.5f;
}
public class ClassWithVariables
{
	public int x = 8 + 50;
	public string userName = "Sadie";
}
	public class ClassWithFunctions
	
{
public void RunFunction()
{
Console.WriteLine("Running Function");

}
	}

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      string name = "Sadie";
      Console.WriteLine(name);  
     }
  }
}

namespace application
{
  class example
  {
    static void Main(string[] args)
    {
      int myNum;
      myNum = 15;
      Console.WriteLine(myNum);
     }
  }
}

namespace labs
{
  class lab
  {
    static void Main(string[] args)
    {
      int myNum = 15;
      myNum = 20;
      Console.WriteLine(myNum);
    }
  }
}