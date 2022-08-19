// See https://aka.ms/new-console-template for more information
using System;

namespace calculator
{
  class Program
  {
    static void Main()
    { 
      Console.WriteLine("Insira o primeiro valor: ");
      double num1 = Convert.ToDouble(Console.ReadLine()); // usar a vírgula para números com decimais
      Console.WriteLine("Insira a operação matemática desejada: ");
      string method = Console.ReadLine();
      Console.WriteLine("Insira o segundo valor: ");
      double num2 = Convert.ToDouble(Console.ReadLine());
      if (method == "+") System.Console.WriteLine(num1 + num2);
      if (method == "-") System.Console.WriteLine(num1 - num2);
      if (method == "*") System.Console.WriteLine(num1 * num2);
      if (method == "/") System.Console.WriteLine(num1 / num2);
    }
  }
}

// int somente aceitará números inteiros // ToInt32

