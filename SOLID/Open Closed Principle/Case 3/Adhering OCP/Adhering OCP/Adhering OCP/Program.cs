using System;

public interface IPlayer
{
    double CalculateScore(double baseScore);
}

public class Beginner : IPlayer
{
    public double Bonus { get; set; }

    public Beginner(double bonus)
    {
        Bonus = bonus;
    }

    public double CalculateScore(double baseScore)
    {
        return baseScore + Bonus * 0.1; // Simple calculation for beginners
    }
}

public class Intermediate : IPlayer
{
    public double Experience { get; set; }

    public Intermediate(double experience)
    {
        Experience = experience;
    }

    public double CalculateScore(double baseScore)
    {
        return baseScore + Experience * 0.5; // Intermediate calculation
    }
}

public class Expert : IPlayer
{
    public double Trophies { get; set; }

    public Expert(double trophies)
    {
        Trophies = trophies;
    }

    public double CalculateScore(double baseScore)
    {
        return baseScore + Trophies * 1.5; // Expert calculation
    }
}

public class Legend : IPlayer
{
    public double Trophies { get; set; }
    public double Experience { get; set; }

    public Legend(double trophies, double experience)
    {
        Trophies = trophies;
        Experience = experience;
    }

    public double CalculateScore(double baseScore)
    {
        return baseScore + Trophies * 2.0 + Experience * 1.0; // Legend calculation
    }
}


public class ScoreCalculator
{
    public double GetScore(IPlayer player, double baseScore)
    {
        return player.CalculateScore(baseScore);
    }
}

public class Program
{
    public static void Main()
    {
        // Instantiate the ScoreCalculator class
        ScoreCalculator scoreCalculator = new ScoreCalculator();

        // Instantiate different player types with their respective properties
        IPlayer beginner = new Beginner(10);
        IPlayer intermediate = new Intermediate(20);
        IPlayer expert = new Expert(15);
        IPlayer legend = new Legend(20, 30);

        // Calculate and display scores for each player type
        Console.WriteLine("Beginner Score: " + scoreCalculator.GetScore(beginner, 100));
        Console.WriteLine("Intermediate Score: " + scoreCalculator.GetScore(intermediate, 100));
        Console.WriteLine("Expert Score: " + scoreCalculator.GetScore(expert, 100));
        Console.WriteLine("Legend Score: " + scoreCalculator.GetScore(legend, 100));
    }
}
