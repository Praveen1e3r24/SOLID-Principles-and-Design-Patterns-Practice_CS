using System;
using System.Collections.Generic;

// Abstract class representing a weapon
public abstract class Weapon
{
    // Method to calculate damage
    public abstract int CalculateDamage();
}

// Concrete weapon classes
public class Sword : Weapon
{
    // Damage inflicted by a sword
    public override int CalculateDamage()
    {
        return 10;
    }
}

public class Bow : Weapon
{
    // Damage inflicted by a bow
    public override int CalculateDamage()
    {
        return 5;
    }
}

// Game class responsible for managing weapons and damage calculation
public class Game
{
    private List<Weapon> weapons;

    public Game()
    {
        weapons = new List<Weapon>
        {
            new Sword(),
            new Bow()
        };
    }

    public void CalculateDamage()
    {
        foreach (var weapon in weapons)
        {
            Console.WriteLine($"Damage inflicted by {weapon.GetType().Name}: {weapon.CalculateDamage()}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Game game = new Game();
        game.CalculateDamage();
    }
}
