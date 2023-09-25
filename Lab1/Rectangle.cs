public class Rectangle : IShape
{
    public string Name { get; }
    public double Length { get; }
    public double Width { get; }

    public Rectangle(string name, double length, double width)
    {
        Name = name;
        Length = length;
        Width = width;
    }

    public double CalculateArea()
    {
        return Length * Width;
    }

    public double CalculatePerimeter()
    {
        return 2 * (Length + Width);
    }
}