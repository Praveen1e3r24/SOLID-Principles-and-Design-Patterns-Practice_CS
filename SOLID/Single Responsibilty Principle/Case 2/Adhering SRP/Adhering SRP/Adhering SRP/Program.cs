using System;

public class Player
{
    private string weapon;

    public Player()
    {
        weapon = "Gun";
    }

    public void Shoot()
    {
        Console.WriteLine("Player shoots " + weapon);
    }
}

public class Weapon
{
    private string type;

    public Weapon(string type)
    {
        this.type = type;
    }

    public void Reload()
    {
        Console.WriteLine("Reloading " + type);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Player player = new Player();
        Weapon weapon = new Weapon("Gun");

        player.Shoot();
        weapon.Reload();
    }
}
