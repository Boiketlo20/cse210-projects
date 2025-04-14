using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("Yellow", 6);
        Rectangle rectangle = new Rectangle("Pink", 6, 3);
        Circle circle = new Circle("Purple", 6);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor(); 
            double area = shape.GetArea();
            Console.WriteLine($"{color}: {area}cm");
        }
    }
}