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
        };
    }

    public void CalculateDamage()
    {
        foreach (var weapon in weapons)
        {
            if (weapon is Sword)
            {
                Console.WriteLine("Sword damage: 10");
            }
            else if (weapon is Bow)
            {
                Console.WriteLine("Bow damage: 5");
            }
            else
            {
                throw new Exception("Unknown weapon");
            }
        }
    }
}

public class Weapon { }

public class Sword : Weapon { }

public class Bow : Weapon { }

class Program
{
    static void Main(string[] args)
    {
        Game game = new Game();
        game.CalculateDamage();
    }
}
