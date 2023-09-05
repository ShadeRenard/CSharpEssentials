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
		Console.WriteLine("the fire power of " + miniGun.weaponName + " has an ammo count of " + miniGun.ammoCount + ".");
		Console.WriteLine("it now has a fire power of " + miniGun.firePower + ", it has increased.");
	}
}
public class Weapon
{ 
	public int ammoCount = 10;
	public String weaponName = "mini Gun";
	public float firePower = 11.5f;
}
public class PowerUp 
{
	public float powerLevel = 2.5f;
}

public class ClassExample
{
	
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
int number = 24
}
}
public class Labs
{
	int myNum = 50;
	String userName "Sadie";
	Console WriteLine (userName)
}
using System;

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
using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int myNum = 8;
      Console.WriteLine(myNum);
     }
  }
}
using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int myNum = 8;
      myNum = 20;
      Console.WriteLine(myNum);
    }
  }
}