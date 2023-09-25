public class Circle : IShape
{
    public string Name { get; }
    public double Radius { get; }

    public Circle(string name, double radius)
    {
        Name = name;
        Radius = radius;
    }

    public double CalculateArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }

    public double CalculatePerimeter()
    {
        return 2 * Math.PI * Radius;
    }
}