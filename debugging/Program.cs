// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

namespace DebuggingCSharp
{
  class Program
  {
    public static void Main()
    {
      var numbers = new List<int>{ 1, 2, 3, 4, 5, 6 };
      var smallest = GetSmallests(numbers, 3); // retorne os 3 menores números desta lista

      foreach (var number in smallest)
        Console.WriteLine(number);
    }
    public static List<int> GetSmallests(List<int> list, int count)
    {
      var smallest = new List<int>();
      while (smallest.Count < count)
      {
        var min = GetSmallest(list);
        // System.Console.WriteLine(min);
        smallest.Add(min); // adiciona na nova lista smallest
        list.Remove(min); // remove da lista antiga
      }
      return smallest;
    }

    public static int GetSmallest(List<int> list)
    {
      var min = list[0];
      for (var i = 1; i < list.Count; i++)
      {
        if(list[i] < min) min = list[i];
      }
      return min;
    }
  }
}


