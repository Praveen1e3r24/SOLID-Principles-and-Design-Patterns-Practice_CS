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

    public void Reload()
    {
        Console.WriteLine("Player reloads " + weapon);
    }
}

public class Main
{
    static void Program(string[] args)
    {
        Player player = new Player();

        player.Shoot();
        player.Reload();
    }
}
