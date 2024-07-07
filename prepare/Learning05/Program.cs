using System;

class Program
{
    static void Main(string[] args)
    {
        Shape square = new Square(4, "blue");
        Console.WriteLine($"Here is a {square.GetColor()} square with an area of {square.GetArea()}m2");
        
        Shape rectangle = new Rectangle(4.1, 5, "Green");
        Shape circle = new Circle(2.5, "Black");

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (var shape in shapes)
        {
            Console.WriteLine(
                $"{shape}: {shape.GetColor()} and Area: {shape.GetArea()}"
            );
        }
    }
}