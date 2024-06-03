using System;

namespace SceneFactoryViolation
{
    // Concrete products
    public class Gun
    {
        public void Initialize()
        {
            Console.WriteLine("Gun has been initialized.");
        }
    }

    public class Car
    {
        public void Initialize()
        {
            Console.WriteLine("Car has been initialized.");
        }
    }

    public class AmmoBox
    {
        public void Initialize()
        {
            Console.WriteLine("Ammo box has been initialized.");
        }
    }

    // Client code
    public class SceneSetup
    {
        public void SetupElement(string elementType)
        {
            if (elementType == "Gun")
            {
                Gun gun = new Gun();
                gun.Initialize();
            }
            else if (elementType == "Car")
            {
                Car car = new Car();
                car.Initialize();
            }
            else if (elementType == "AmmoBox")
            {
                AmmoBox ammoBox = new AmmoBox();
                ammoBox.Initialize();
            }
            else
            {
                Console.WriteLine("Unknown element type!");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SceneSetup sceneSetup = new SceneSetup();

            Console.WriteLine("Setting up Gun:");
            sceneSetup.SetupElement("Gun");

            Console.WriteLine("Setting up Car:");
            sceneSetup.SetupElement("Car");

            Console.WriteLine("Setting up Ammo Box:");
            sceneSetup.SetupElement("AmmoBox");
        }
    }
}
