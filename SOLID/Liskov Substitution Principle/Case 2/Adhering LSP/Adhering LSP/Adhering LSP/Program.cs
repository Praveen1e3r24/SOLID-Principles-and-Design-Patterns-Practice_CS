using System;

// Interface for flying behavior
public interface IFlyable
{
    void FlyAway();
}

// Interface for moving behavior
public interface IMoveable
{
    void Move(int newX, int newY);
}

// Base class representing a game character
public class NonFlyingCharacter
{
    public float horizontalSpeed { get; set; }
  
}

// Base class representing a game character
public class FlyingCharacter
{

    public float horizontalSpeed { get; set; }

    public float verticalSpeed { get; set; }

}

// Player class inheriting from Character and implementing interfaces
public class GroundPlayer : NonFlyingCharacter, IMoveable
    public void Move(int newX, int newY)
    {
        Console.WriteLine($"Player moves to ({newX}, {newY})");
        // Logic to move the player
    }


}


// FlyingEnemy class inheriting from Enemy and implementing IFlyable interface
public class FlyingEnemy : FlyingCharacter, IFlyable , IMoveable
{
    public void FlyAway()
    {
        Console.WriteLine("FlyingEnemy flies away!");
        // Logic for flying enemy to fly away
    }

    public void Move(int newX, int newY)
    {
        Console.WriteLine($"Player moves to ({newX}, {newY})");
        // Logic to move the player
    }



}

