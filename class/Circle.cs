//Creando la clase circle que hereda de Shape
public class Circle : Shape
{
    public Circle(double radius) : base(radius, radius) { }

    public override double CalculateSurface()
    {
        double radio = Width;
        return Math.PI * Math.Pow(radio, 2);
    }
}
