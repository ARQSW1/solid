public abstract class Shape
{
  public abstract double CalculateArea();
}

public class Circle : Shape
{
  public double Radius { get; set; }

  public override double CalculateArea()
  {
    return Math.PI * Radius * Radius;
  }
}


// TAMBIEN ESTAN LOS METODOS DE EXTENSION!!!!!
