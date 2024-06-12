using System.Numerics;

// Base class representing a vehicle
public class Vehicle
{
    public float Speed { get; set; } = 100;
    public Vector3 Direction { get; set; }

    // Methods for moving and turning are left 

    public void GoForward()
    {
    
    }
    public void Reverse()
    {
        
    }
    public void TurnRight()
    {
        
    }
    public void TurnLeft()
    {
        
    }
}


public class Car : Vehicle
{
    
}


public class Truck : Vehicle
{
   
}


public class Train : Vehicle
{
 
}

// Explanation in comments:

// The provided code violates the Liskov Substitution Principle (LSP) because it assumes that all vehicles, including cars, trucks, and trains, can perform the same actions: GoForward, Reverse, TurnRight, and TurnLeft.
// This assumption is incorrect because trains, in reality, cannot turn left or right like cars or trucks. Trains typically follow fixed tracks and can only move forward or backward.

// Violation Explanation:

// If a program were to treat all vehicles interchangeably, according to the Vehicle base class, it would expect that a Train object can also perform the TurnRight and TurnLeft actions. However, attempting to call these methods on a Train object would either lead to a compilation error or, if implemented, to unexpected behavior.
// Therefore, the code violates the Liskov Substitution Principle because it allows for the possibility of substituting objects of derived class (Train) for objects of the base class (Vehicle) without preserving the desired behavior.
