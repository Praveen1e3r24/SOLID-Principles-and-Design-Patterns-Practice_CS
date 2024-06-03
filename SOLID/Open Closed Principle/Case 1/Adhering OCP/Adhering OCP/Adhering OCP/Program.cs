using System;
using System.Collections.Generic;

public class Game
{
    private List<Weapon> weapons;

    public Game()
    {
        weapons = new List<Weapon>
        {
            new Sword(),
            new Bow()
            // Add new weapons here without modifying existing code
        };
    }

    public void CalculateDamage()
    {
        foreach (var weapon in weapons)
        {
            Console.WriteLine(weapon.GetDamage());
        }
    }
}

public abstract class Weapon
{
    public abstract string GetDamage();
}

public class Sword : Weapon
{
    public override string GetDamage()
    {
        return "Sword damage: 10";
    }
}

public class Bow : Weapon
{
    public override string GetDamage()
    {
        return "Bow damage: 5";
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
