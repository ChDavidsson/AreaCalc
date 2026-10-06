namespace AreaCalc;

class Program
{
    static void Main(string[] args)
    {
        // Be användaren att mata in de nödvändiga måtten och sedan beräkna och visa arean.
        Console.WriteLine("Ange sidlängd för kvadraten:");
        double squareSide = double.Parse(Console.ReadLine());

        Console.WriteLine("Ange längd och bredd för rektangeln:");
        double rectangleLength = double.Parse(Console.ReadLine());
        double rectangleWidth = double.Parse(Console.ReadLine());

        Console.WriteLine("Ange radie för cirkeln:");
        double circleRadius = double.Parse(Console.ReadLine());

        Square square = new Square { SideLength = squareSide };
        Rectangle rectangle = new Rectangle { SideLength = rectangleLength, Width = rectangleWidth };
        Circle circle = new Circle { Radius = circleRadius };

        Console.WriteLine($"Area av kvadraten: {square.CalculateArea()}");
        Console.WriteLine($"Area av rektangeln: {rectangle.CalculateArea()}");
        Console.WriteLine($"Area av cirkeln: {circle.CalculateArea()}");
    }
}

// Mål: Introducera abstraktion och polymorfism genom att skapa en klasshierarki för former.
// Be användaren att mata in de nödvändiga måtten och sedan beräkna och visa arean.
