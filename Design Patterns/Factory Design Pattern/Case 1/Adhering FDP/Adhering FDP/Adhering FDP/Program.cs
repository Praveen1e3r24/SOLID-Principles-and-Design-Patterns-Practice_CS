using System;

namespace EnemyFactoryPattern
{
    // Abstract product interface
    public interface IEnemy
    {
        void Attack();
    }

    // Concrete products
    public class Goblin : IEnemy
    {
        public void Attack()
        {
            Console.WriteLine("Goblin attacks with a club!");
        }
    }

    public class Orc : IEnemy
    {
        public void Attack()
        {
            Console.WriteLine("Orc attacks with an axe!");
        }
    }

    // Abstract factory interface
    public interface IEnemyFactory
    {
        IEnemy CreateEnemy();
    }

    // Concrete factories
    public class GoblinFactory : IEnemyFactory
    {
        public IEnemy CreateEnemy()
        {
            return new Goblin();
        }
    }

    public class OrcFactory : IEnemyFactory
    {
        public IEnemy CreateEnemy()
        {
            return new Orc();
        }
    }

    // Client code
    public class Game
    {
        private readonly IEnemyFactory _enemyFactory;

        public Game(IEnemyFactory enemyFactory)
        {
            _enemyFactory = enemyFactory;
        }

        public void SpawnEnemy()
        {
            IEnemy enemy = _enemyFactory.CreateEnemy();
            enemy.Attack();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IEnemyFactory goblinFactory = new GoblinFactory();
            IEnemyFactory orcFactory = new OrcFactory();

            Game gameWithGoblins = new Game(goblinFactory);
            Game gameWithOrcs = new Game(orcFactory);

            Console.WriteLine("Spawning Goblin:");
            gameWithGoblins.SpawnEnemy();

            Console.WriteLine("Spawning Orc:");
            gameWithOrcs.SpawnEnemy();
        }
    }
}
