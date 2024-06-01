using System;

public class Game
{
    private int playerPosition;
    private int playerHealth;
    private int playerAmmo;

    public Game()
    {
        playerPosition = 0;
        playerHealth = 100;
        playerAmmo = 10;
    }

    public void Update()
    {
        // Handle player movement
        MovePlayer(1);

        // Handle player shooting
        Shoot();

        // Handle player taking damage
        TakeDamage(10);
    }

    private void MovePlayer(int delta)
    {
        playerPosition += delta;
        Console.WriteLine("Player moved to position: " + playerPosition);
    }

    private void Shoot()
    {
        if (playerAmmo > 0)
        {
            playerAmmo--;
            Console.WriteLine("Player shot. Ammo left: " + playerAmmo);
        }
        else
        {
            Console.WriteLine("No ammo left!");
        }
    }

    private void TakeDamage(int damage)
    {
        playerHealth -= damage;
        Console.WriteLine("Player took damage. Health: " + playerHealth);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Game game = new Game();

        // Game loop
        for (int i = 0; i < 5; i++)
        {
            game.Update();
        }
    }
}
