using System;

namespace control_Structure;
public class ControlStructure
{
  static void Main() {

    System.Console.WriteLine("Informe o raio de um círculo (deve ser um número inteiro)");
    string? response = Console.ReadLine();
    int radius;
    var canConvert = Int32.TryParse(response, out radius); 
    if (canConvert) // se conseguir converter, calcula.
    {
      const double pi = 3.14159;
      double circumference = pi * (2 * radius);
      string[] text = new String[] {$"A circunferência de um circulo com raio {radius} é igual a {circumference}"};
      System.Console.WriteLine(String.Join("\n", text));
    } else 
    {
      System.Console.WriteLine("O texto digitado não é um número inteiro.");
    }
  }

  public static string IdentifyTriangle(double xSide, double ySide, double zSide)
  {
    string name = "";

    if (xSide == ySide && xSide == zSide)
    {
      name = "Triângulo Equilátero";
    } else if ((xSide == ySide) || (xSide == zSide) || (ySide ==zSide))
    {
      name = "Triângulo Isóscele";
    } else
    {
      name = "Triângulo Escaleno";
    }

    return name;

  }

  public static string IdentifyPolygon(int sideCount)
  {
    var name = string.Empty;
    switch (sideCount)
    {
        case < 3:
            name = "Não é um polígono";
            break;
        case 3:
            name = "Triângulo";
            break;
        case 4:
            name = "Quadrado";
            break;
        case 5:
            name = "Pentágono";
            break;
        default:
            name = "Polígono não identificado";
            break;
    }
    return name;
  }
  
}
