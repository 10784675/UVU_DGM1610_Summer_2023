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

    public void Main()
    {
        miniGun = new Weapon();
        Console.WriteLine(miniGun.weaponName);
    }
}

public class Weapon
{
    public int ammoCount = 10;
    public string weaponName = "Mini Gun";
    public float firePower = 11.5f;
}
