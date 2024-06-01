using System;

public class Player
{
    private PlayerMovement movement;
    private PlayerShooting shooting;

    public Player()
    {
        movement = new PlayerMovement();
        shooting = new PlayerShooting();
    }

    public void Update()
    {
        // Simulate input for movement and shooting
        movement.Move(1);
        shooting.Shoot();
    }
}

public class PlayerMovement
{
    private int position;

    public PlayerMovement()
    {
        position = 0;
    }

    public void Move(int delta)
    {
        position += delta;
        Console.WriteLine("Player moved to position: " + position);
    }
}

public class PlayerShooting
{
    private int ammo;

    public PlayerShooting()
    {
        ammo = 10;
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
