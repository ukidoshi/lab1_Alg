Console.Write("Сколько точек? (3->5)  => ");
int n = Convert.ToInt32(Console.ReadLine());

Point[] mass = new Point[n];

for (int i = 0; i <= n-1; i++)
{
    Console.WriteLine((i+1)+"-ая точка: X=");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine((i+1)+"-ая точка: Y=");
    int y = Convert.ToInt32(Console.ReadLine());
    
    mass[i] = new Point(x, y);
}

Figure figure;

figure = new Figure(n, mass[0], mass[1], mass[2]);

if (n == 4)
{
    figure = new Figure(n, mass[0], mass[1], mass[2], mass[3]);
} else if (n == 5)
{
    figure = new Figure(n, mass[0], mass[1], mass[2], mass[3], mass[4]);
}

Console.WriteLine("Периметр "+figure.name+"а - "+figure.PerimeterCalc());

public class Point
{
    private int _x;
    private int _y;

    public Point(int pointX, int pointY) => (x, y) = (pointX, pointY);

    public double x { get; }
    public double y { get; }
}




public class Figure
{
    public string name;
    private int _n = 0;
    private Point _p1;
    private Point _p2;
    private Point _p3;
    private Point _p4;
    private Point _p5;

    public Figure(int n, Point p1, Point p2, Point p3)
    {
        _p1 = p1;
        _p2 = p2;
        _p3 = p3;
        _n = n;
        name = "Треугольник";
    }

    public Figure(int n, Point p1, Point p2, Point p3, Point p4)
    {
        _p1 = p1;
        _p2 = p2;
        _p3 = p3;
        _p4 = p4;
        _n = n;
        name = "Прямоугольник";
    }
    
    public Figure(int n, Point p1, Point p2, Point p3, Point p4, Point p5)
    {
        _p1 = p1;
        _p2 = p2;
        _p3 = p3;
        _p4 = p4;
        _p5 = p5;
        _n = n;
        name = "Многоугольник";
    }

    private double LengthSide(Point A, Point B)
    {
        return Math.Sqrt(((A.x - B.x)*(A.x - B.x)) + ((A.y - B.y)*(A.y - B.y)) );
    }

    public double PerimeterCalc()
    {
        if (_n == 3)
        {
            return LengthSide(_p1, _p2) + LengthSide(_p2, _p3) + LengthSide(_p3, _p1);
        }
        if (_n == 4)
        {
            return LengthSide(_p1, _p2) + LengthSide(_p2, _p3) + LengthSide(_p3, _p4) + LengthSide(_p4, _p1);
        }
        if (_n == 5)
        {
            return LengthSide(_p1, _p2) + LengthSide(_p2, _p3) + LengthSide(_p3, _p4) + LengthSide(_p4, _p5) + LengthSide(_p5,_p1);
        }
        return 0;
    }
    
}
