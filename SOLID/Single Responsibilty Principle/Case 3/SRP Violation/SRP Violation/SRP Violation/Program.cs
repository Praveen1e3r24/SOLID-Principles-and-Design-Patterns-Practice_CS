using System;

public class Player
{
    private int position;
    private int ammo;

    public Player()
    {
        position = 0;
        ammo = 10;
    }

    public void Move(int delta)
    {
        position += delta;
        Console.WriteLine("Player moved to position: " + position);
    }

    public void Shoot()
    {
        if (ammo > 0)
        {
            ammo--;
            Console.WriteLine("Player shot. Ammo left: " + ammo);
        }
        else
        {
            Console.WriteLine("No ammo left!");
        }
    }

    public void Update()
    {
        // Simulate input for movement and shooting
        Move(1);
        Shoot();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Player player = new Player();

        // Game loop
        for (int i = 0; i < 5; i++)
        {
            player.Update();
        }
    }
}
