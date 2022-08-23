using System;

namespace iterationStructure;
public class NumbersTools
{
  static void Main(){}
  public static int CountOf(int[] numbers, int value)
  {
    var count = 0;
    foreach(var number in numbers)
    {
      if(number == value)
      {
        System.Console.WriteLine(value);
        count++;
      }
    }
    return count;
  }
}
