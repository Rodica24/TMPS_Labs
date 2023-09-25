public class GeometryPrinter : IShapePrinter
{
    public void Print(IShape shape)
    {
        Console.WriteLine($"{shape.GetType().Name}: Area = {shape.CalculateArea():F2}, Perimeter = {shape.CalculatePerimeter():F2}");
    }
}
