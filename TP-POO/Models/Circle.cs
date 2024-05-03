public class Circle : Figure
{
    public double Radio { get; set; }
    public Circle(double radio)
    {
        Radio=radio;
    }

    public override double CalculateArea()
    {
        return Math.PI * Math.Pow(Radio, 2);
    }
}
