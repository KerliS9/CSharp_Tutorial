// See https://aka.ms/new-console-template for more information
using System;

namespace mad_lib
{
  class Program
  {
    static void Main()
    {
      string color, pluralNoun, celebrity;

      System.Console.WriteLine("Enter a color: ");
      color = Console.ReadLine();

      System.Console.WriteLine("Enter a plural noun: ");
      pluralNoun = Console.ReadLine();

      System.Console.WriteLine("Enter a celebrity name: ");
      celebrity = Console.ReadLine();

      string[] phrase = new String[] {
        $"Roses are {color}",
        $"{pluralNoun} are blue",
        $"I love {celebrity}"
      };
      System.Console.WriteLine(String.Join("\n", phrase));
    }
  }
}
