class Program
{
    private readonly IShapePrinter shapePrinter;

    public Program(IShapePrinter shapePrinter)
    {
        this.shapePrinter = shapePrinter;
    }

    static void Main()
    {
        Console.WriteLine("Welcome to the Geometry Calculator!\n");

        // Create geometric figures
        Circle circle = new Circle("Circle", 5);
        Rectangle rectangle = new Rectangle("Rectangle", 4, 6);
        RightAngledTriangle triangle = new RightAngledTriangle("Right Angled Triangle", 3, 4);

        // Initialize the program with a specific printer
        IShapePrinter printer = new GeometryPrinter();
        Program program = new Program(printer);

        // Print their areas
        program.PrintShape(circle);
        program.PrintShape(rectangle);
        program.PrintShape(triangle);

        Console.ReadLine();
    }

    public void PrintShape(IShape shape)
    {
        shapePrinter.Print(shape);
    }
}
