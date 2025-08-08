using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Square mySquare = new Square(5, "Red");
        Console.WriteLine(mySquare.GetArea());
        Console.WriteLine(mySquare.GetColor());

        Rectangle myRectangle = new Rectangle(8, 5, "Yellow");
        Console.WriteLine(myRectangle.GetArea());
        Console.WriteLine(myRectangle.GetColor());

        Circle myCircle = new Circle(6, "Blue");
        Console.WriteLine(myCircle.GetArea());
        Console.WriteLine(myCircle.GetColor());

        List<Shapes> shape = new List<Shapes>();
        shape.Add(myCircle);
        shape.Add(myRectangle);
        shape.Add(mySquare);

        foreach (Shapes myShape in shape)
        {
            Console.WriteLine($"Color: {myShape.GetColor()}, Area: {myShape.GetArea()} ");
        }




    }
}