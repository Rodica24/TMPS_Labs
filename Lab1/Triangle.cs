public class RightAngledTriangle : IShape
{
    public string Name { get; }
    public double Cat1 { get; }
    public double Cat2 { get; }

    public RightAngledTriangle(string name, double cat1, double cat2)
    {
        Name = name;
        Cat1 = cat1;
        Cat2 = cat2;
    }

    public double CalculateArea()
    {
        return (Cat1 * Cat2) / 2;
    }

    public double CalculatePerimeter()
    {
        double hypotenuse = Math.Sqrt(Math.Pow(Cat1, 2) + Math.Pow(Cat2, 2));
        return Cat1 + Cat2 + hypotenuse;
    }
}