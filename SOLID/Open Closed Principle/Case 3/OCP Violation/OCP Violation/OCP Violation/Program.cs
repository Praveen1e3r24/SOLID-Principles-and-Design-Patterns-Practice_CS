using System;

public class PlayerScoreCalculator
{
    public double CalculateScore(string playerType, double baseScore, double level, double bonus, double experience, double trophies)
    {
        if (playerType == "Beginner")
        {
            return baseScore + level * 1 + bonus * 0.1; // Simple calculation for beginners
        }
        else if (playerType == "Intermediate")
        {
            return baseScore + level * 2 + experience * 0.5; // Intermediate calculation
        }
        else if (playerType == "Expert")
        {
            return baseScore + level * 3 + trophies * 1.5; // Expert calculation
        }
        else if (playerType == "Legend")
        {
            return baseScore + level * 4 + trophies * 2.0 + experience * 1.0; // Legend calculation
        }
        else
        {
            throw new ArgumentException("Invalid player type");
        }
    }
}

public class Program
{
    public static void Main()
    {
        PlayerScoreCalculator calculator = new PlayerScoreCalculator();

        Console.WriteLine("Beginner Score: " + calculator.CalculateScore("Beginner", 100, 5, 10, 0, 0));
        Console.WriteLine("Intermediate Score: " + calculator.CalculateScore("Intermediate", 100, 5, 0, 20, 0));
        Console.WriteLine("Expert Score: " + calculator.CalculateScore("Expert", 100, 5, 0, 0, 15));
        Console.WriteLine("Legend Score: " + calculator.CalculateScore("Legend", 100, 5, 0, 30, 20));
    }
}
