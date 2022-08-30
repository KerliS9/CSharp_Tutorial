// See https://aka.ms/new-console-template for more information
using System;

namespace methods;

public class Program {
  private static string? name;
  public static void Main()
  {
    SayHi();
    IfStatement();
    
    GetMax(6,5);
    int cubeNumber = Cube(5);
    System.Console.WriteLine(cubeNumber);
    
    Console.WriteLine("Digite seu nome: ");
    name = Console.ReadLine();
    SayHello(name);
  }

  static void SayHi()
  {
    Console.WriteLine("Hello user");
  }

  static void SayHello(string name)
  {
    Console.WriteLine($"You are welcome! {name}");
  }

  static int Cube(int num)
    {
      int result = num * num * num;
      return result;
    }

  static void IfStatement()
  {
    bool isFemale = true;
    bool isTall = true;
    if (isFemale && isTall) // !em frente da variável também representa negação
    {
      Console.WriteLine("You are a tall female");
    } else if (isFemale || isTall)
    {
      Console.WriteLine("You are a tall person or a female person");
    } else
    {
      Console.WriteLine("You are not tall and/or female");
    }
  }

  static int GetMax(int num1, int num2)
  {
    int result;
    if (num1 > num2) 
    {
      result = num1;
      Console.Write("Primeiro parâmetro é maior ");
      Console.WriteLine(result);
    } else
    {
      result = num2;
      Console.Write("Segundo parâmetro é maior");
      Console.WriteLine(result);
    }
    return result;
  }
}