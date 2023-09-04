public interface IDrawable
{
  void Draw();
}

public interface ICalculatable
{
  void CalculateArea();
}

public interface IResizable
{
  void Resize();
}

public class Circle : IDrawable, ICalculatable, IResizable
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

public class Square : IDrawable, ICalculatable, IResizable
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