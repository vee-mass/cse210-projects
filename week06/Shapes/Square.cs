using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

public class Square : Shapes
{
    private double _side;
    public Square(double side, string color) : base(color)
    {
        _side = side;
    }

    public override double GetArea()
    {
        return _side * _side;
    }
}