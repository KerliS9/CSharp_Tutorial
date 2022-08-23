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
        // System.Console.WriteLine(value);
        count++;
      }
    }
    return count;
  }

      public static int IndexOf(int[] numbers, int value)
    {     
        var position = -1;

        for(int i=0; i < numbers.Count(); i++)
        {        
            if(numbers[i] == value)
            {
                position = i; // pega a posição do array que está o value
                // System.Console.WriteLine(position);
                break;
            }        
        }
        
        return position;
    }

    public static int CountEvenNumbers(int[] numbers)
    {     
        var count = 0;

        foreach(var number in numbers)   
        {          
        // System.Console.WriteLine(number);
            if(number%2 != 0) continue; // verifica se a divisão gera sobra 0, se sim, conta e continua percorrendo o array

            count ++;
        }

        return count;
    }

    public static void Hello(string name)
    {
        Console.WriteLine($"Hey, Hello {name}");
    }

    public static void HelloHarder(string name)
    {
        Console.WriteLine($"Hey, Hello {name}");
        Console.WriteLine($"Can i call u {name}zito?");
        Console.WriteLine($"No?");
        Console.WriteLine($"Ok?");
    }

    public static void HelloSayYourName()
    {
        Console.Write("Hey, say me your name:");
        var userName = Console.ReadLine();
        Console.WriteLine($"Ok, Hello {userName}");
    }
}
