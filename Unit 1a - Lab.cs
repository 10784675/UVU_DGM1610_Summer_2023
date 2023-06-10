using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}

public class Program
{
    public Weapon miniGun;
    public PowerUp weaponPowerUp;

    public void Main()
    {
        miniGun = new Weapon();
        weaponPowerUp = new PowerUp();

        miniGun.ammoCount++;
        miniGun.firePower += weaponPowerUp.powerLevel;
        Console.WriteLine(miniGun.weaponName + " has an ammo count of " + miniGun.ammoCount + ".");
        Console.WriteLine("The fire power of is now" + miniGun.firePower + ", it has increased ");
    }
}

public class Weapon
{
    public int ammoCount = 10;
    public string weaponName = "Mini Gun";
    public float firePower = 11.5f;
}

public class PowerUp
{
    public float powerLevel = 2.5f;
}

string name = "John";
Console.WriteLine(name);

int myNum = 15;
Console.WriteLine(myNum);

int myNum;
myNum = 15;
Console.WriteLine(myNum);

int myNum = 15;
myNum = 20; // myNum is now 20
Console.WriteLine(myNum);

float myNum = 5.75F;
Console.WriteLine(myNum);

double myNum = 19.99D;
Console.WriteLine(myNum);

float f1 = 35e3F;
double d1 = 12E4D;
Console.WriteLine(f1);
Console.WriteLine(d1);

int x = 100 + 50;

int sum1 = 100 + 50;        // 150 (100 + 50)
int sum2 = sum1 + 250;      // 400 (150 + 250)
int sum3 = sum2 + sum2;     // 800 (400 + 400)

int x = 10;

int x = 10;
x += 5;

