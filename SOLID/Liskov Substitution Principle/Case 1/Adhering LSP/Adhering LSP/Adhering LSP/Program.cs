using System.Numerics;

// Interface for moveable behavior
public interface IMoveable
{
    void GoForward();
    void Reverse();
}

// Interface for turnable behavior
public interface ITurnable
{
    void TurnRight();
    void TurnLeft();
}

// Interface for road vehicles
public interface IRoadVehicle : IMoveable, ITurnable
{
    public double speed;

    // No additional members required
}

// Interface for rail vehicles
public interface IRailVehicle : IMoveable
{
    public double speed;
    public double turnSpeed;
    // No additional members required
}

// Car class implementing IRoadVehicle
public class Car : IRoadVehicle
{
    public void GoForward()
    {
        // Implementation specific to car
    }

    public void Reverse()
    {
        // Implementation specific to car
    }

    public void TurnRight()
    {
        // Implementation specific to car
    }

    public void TurnLeft()
    {
        // Implementation specific to car
    }
}

// Truck class implementing IRoadVehicle
public class Truck : IRoadVehicle
{
    public void GoForward()
    {
        // Implementation specific to truck
    }

    public void Reverse()
    {
        // Implementation specific to truck
    }

    public void TurnRight()
    {
        // Implementation specific to truck
    }

    public void TurnLeft()
    {
        // Implementation specific to truck
    }
}

// Train class implementing IRailVehicle
public class Train : IRailVehicle
{
    public void GoForward()
    {
        // Implementation specific to train
    }

    public void Reverse()
    {
        // Implementation specific to train
    }
}
