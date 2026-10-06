namespace AreaCalc;

public class Rectangle : Shape
{
    public double SideLength { get; set; }
    public double Width { get; set; }

    public override double CalculateArea()
    {
        return SideLength * Width;
    }
}