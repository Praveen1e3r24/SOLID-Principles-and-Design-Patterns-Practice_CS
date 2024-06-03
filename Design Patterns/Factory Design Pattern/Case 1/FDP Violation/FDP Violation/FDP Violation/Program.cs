using System;

namespace EnemyFactoryViolation
{
    // Concrete products
    public class Goblin
    {
        public void Attack()
        {
            Console.WriteLine("Goblin attacks with a club!");
        }
    }

    public class Orc
    {
        public void Attack()
        {
            Console.WriteLine("Orc attacks with an axe!");
        }
    }

    // Client code
    public class Game
    {
        public void SpawnEnemy(string enemyType)
        {
            if (enemyType == "Goblin")
            {
                Goblin goblin = new Goblin();
                goblin.Attack();
            }
            else if (enemyType == "Orc")
            {
                Orc orc = new Orc();
                orc.Attack();
            }
            else
            {
                Console.WriteLine("Unknown enemy type!");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();

            Console.WriteLine("Spawning Goblin:");
            game.SpawnEnemy("Goblin");

            Console.WriteLine("Spawning Orc:");
            game.SpawnEnemy("Orc");
        }
    }
}
