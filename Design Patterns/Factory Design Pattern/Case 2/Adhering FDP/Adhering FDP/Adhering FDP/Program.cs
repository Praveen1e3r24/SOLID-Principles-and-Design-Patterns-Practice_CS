using System;

namespace SceneFactoryPattern
{
    // Abstract product interface
    public interface ISceneElement
    {
        void Initialize();
        void SetPosition(float x, float y);
    }

    // Concrete products
    public class Gun : ISceneElement
    {
        private float _x, _y;
        public void Initialize()
        {
            Console.WriteLine($"Gun has been initialized at position ({_x}, {_y}).");
        }

        public void SetPosition(float x, float y)
        {
            _x = x;
            _y = y;
        }
    }

    public class Car : ISceneElement
    {
        private float _x, _y;
        public void Initialize()
        {
            Console.WriteLine($"Car has been initialized at position ({_x}, {_y}).");
        }

        public void SetPosition(float x, float y)
        {
            _x = x;
            _y = y;
        }
    }

    public class AmmoBox : ISceneElement
    {
        private float _x, _y;
        public void Initialize()
        {
            Console.WriteLine($"Ammo box has been initialized at position ({_x}, {_y}).");
        }

        public void SetPosition(float x, float y)
        {
            _x = x;
            _y = y;
        }
    }

    // Abstract factory interface
    public interface ISceneElementFactory
    {
        ISceneElement CreateSceneElement();
    }

    // Concrete factories
    public class GunFactory : ISceneElementFactory
    {
        public ISceneElement CreateSceneElement()
        {
            return new Gun();
        }
    }

    public class CarFactory : ISceneElementFactory
    {
        public ISceneElement CreateSceneElement()
        {
            return new Car();
        }
    }

    public class AmmoBoxFactory : ISceneElementFactory
    {
        public ISceneElement CreateSceneElement()
        {
            return new AmmoBox();
        }
    }

    // Client code
    public class SceneSetup
    {
        private readonly ISceneElementFactory _sceneElementFactory;
        private readonly Random _random;

        public SceneSetup(ISceneElementFactory sceneElementFactory)
        {
            _sceneElementFactory = sceneElementFactory;
            _random = new Random();
        }

        public void SpawnElements(int count)
        {
            for (int i = 0; i < count; i++)
            {
                ISceneElement element = _sceneElementFactory.CreateSceneElement();
                float x = (float)_random.NextDouble() * 100;
                float y = (float)_random.NextDouble() * 100;
                // By calling _random.NextDouble() inside the loop in SpawnElements,
                // each iteration generates a new random position for each instance.
                // This ensures that each product is placed at a different spot on the scene.
                element.SetPosition(x, y);
                element.Initialize();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ISceneElementFactory gunFactory = new GunFactory();
            ISceneElementFactory carFactory = new CarFactory();
            ISceneElementFactory ammoBoxFactory = new AmmoBoxFactory();

            SceneSetup sceneWithGuns = new SceneSetup(gunFactory);
            SceneSetup sceneWithCars = new SceneSetup(carFactory);
            SceneSetup sceneWithAmmoBoxes = new SceneSetup(ammoBoxFactory);

            Console.WriteLine("Spawning Guns:");
            sceneWithGuns.SpawnElements(3);

            Console.WriteLine("Spawning Cars:");
            sceneWithCars.SpawnElements(3);

            Console.WriteLine("Spawning Ammo Boxes:");
            sceneWithAmmoBoxes.SpawnElements(3);
        }
    }
}
