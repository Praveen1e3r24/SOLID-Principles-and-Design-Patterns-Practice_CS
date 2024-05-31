using System;

// Handles player movement
public class Player
{
    public void Move()
    {
        Console.WriteLine("Player is moving...");
    }
}

// Manages the player's score
public class ScoreManager
{
    private int score;

    public ScoreManager()
    {
        score = 0;
    }

    public void IncreaseScore()
    {
        score += 10;
        Console.WriteLine("Score increased by 10. Current score: " + score);
    }
}

// Orchestrates the game by utilizing Player and ScoreManager
public class GameManager
{
    private Player player;
    private ScoreManager scoreManager;

    public GameManager()
    {
        player = new Player();
        scoreManager = new ScoreManager();
    }

    public void PlayTurn()
    {
        player.Move();
        scoreManager.IncreaseScore();
    }
}

class Program
{
    static void Main(string[] args)
    {
        GameManager gameManager = new GameManager();

        while (true)
        {
            gameManager.PlayTurn();
            Console.ReadLine(); // Wait for user input to simulate game loop
        }
    }
}
