// Violation of ISP
public interface IShape
{
  void Draw();
  void CalculateArea();
  void Resize();
}

public class Circle : IShape
{
  public void Draw()
  {
    // Code for drawing a circle
  }

  public void CalculateArea()
  {
    // Code for calculating the area of a circle
  }

  public void Resize()
  {
    // Code for resizing a circle
  }
}

public class Square : IShape
{
  public void Draw()
  {
    // Code for drawing a square
  }

  public void CalculateArea()
  {
    // Code for calculating the area of a square
  }

  public void Resize()
  {
    // Code for resizing a square
  }
}