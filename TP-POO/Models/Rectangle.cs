public class Rectangle : Figure
{
    public double Length { get; set; }
    public double Width { get; set; }

    
    public override double CalculateArea()
    {
        return Length * Width;
    }
    public Rectangle(int length, int width)
    {
        Length = length;
        Width = width;
    }
}
