using System;


// Base class representing a game character

public class Character
{

    public float horizontalSpeed { get; set; }

    public float verticalSpeed { get; set; }

    void Move(int newX, int newY) { }
    void FlyAway() { }

}


public class GroundPlayer : Character
{
  


}


public class FlyingEnemy : Character
{
   

}

