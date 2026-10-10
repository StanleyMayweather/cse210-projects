
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Test a square
        Square square = new Square("Blue", 4);

        Console.WriteLine(square.GetColor());
        Console.WriteLine(square.GetArea());

        Console.WriteLine();

        // Test a rectangle
        Rectangle rectangle = new Rectangle("Red", 5, 3);

        Console.WriteLine(rectangle.GetColor());
        Console.WriteLine(rectangle.GetArea());

        Console.WriteLine();

        // Test a circle
        Circle circle = new Circle("Green", 2);

        Console.WriteLine(circle.GetColor());
        Console.WriteLine(circle.GetArea());

        Console.WriteLine();

        // Create a list that can hold different shapes
        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Square("Blue", 4));
        shapes.Add(new Rectangle("Red", 5, 3));
        shapes.Add(new Circle("Green", 2));

        // Display the color and area of every shape
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()}");
            Console.WriteLine($"Area: {shape.GetArea():F2}");
            Console.WriteLine();
        }
    }
}