var side1 = Convert.ToDouble(Console.ReadLine());
var side2 = Convert.ToDouble(Console.ReadLine());

Rectangle r = new Rectangle(side1, side2);

Console.WriteLine("Площадь: "+r.Area); // Площадь
Console.WriteLine("Периметр: "+r.Perimeter); // Периметр

public class Rectangle
{
    private double _side1;
    private double _side2;

    public Rectangle(double sideA, double sideB)
    {
        _side1 = sideA;
        _side2 = sideB;
        Area = AreaCalc();
        Perimeter = PerimeterCalc();
    }

    private double AreaCalc() => _side1 * _side2;
    private double PerimeterCalc() => 2 * (_side1 + _side2);
    
    public double Area { get; }
    public double Perimeter { get; }
}

