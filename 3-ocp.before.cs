/// <summary>
/// Represetna un circulo
/// </summary>
public class Circle
{
  public double Radius { get; set; }
}

/// <summary>
/// Calcula el area de un circulo
/// </summary>
public class AreaCalculator
{
  public double CalculateArea(Circle circle)
  {
    return Math.PI * circle.Radius * circle.Radius;
  }
}