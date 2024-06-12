using System;

public class AreaCalculator
{
    public float GetRectangleArea(Rectangle rectangle)
    {
        return rectangle.width * rectangle.height;
    }
    public float GetCircleArea(Circle circle)
    {
        return circle.radius * circle.radius * (float) Math.PI;
    }
}
public class Rectangle
{
    public float width;
    public float height;

    public Rectangle(float width, float height)
    {
        this.width = width;
        this.height = height;
    }
}
public class Circle
{
    public float radius;

    public Circle(float radius)
    {
        this.radius = radius;
    }
}


public class Program
{
    public static void Main()
    {
        Rectangle rectangle = new Rectangle(5,10);

        Circle circle = new Circle(5);

        AreaCalculator areaCalculator = new AreaCalculator();
        Console.WriteLine(areaCalculator.GetRectangleArea(rectangle));
        Console.WriteLine(areaCalculator.GetCircleArea(circle));
    }
}
