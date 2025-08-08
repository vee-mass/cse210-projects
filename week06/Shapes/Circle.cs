using System;

public class Circle : Shapes
{
    private double _pi = 3.142;
    private double _radius;

    public Circle(double radius, string color) : base(color)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        return _pi *  Math.Pow(_radius, 2);
    }

}
