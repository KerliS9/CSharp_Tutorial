namespace objectOrientation;

class Program
{
  public static void Main()
  {
    Car car = new();
    car.Engine.Capacity = 100;
    car.Engine.IsStarted = true;
    car.Drive(100,50);
  }
}
