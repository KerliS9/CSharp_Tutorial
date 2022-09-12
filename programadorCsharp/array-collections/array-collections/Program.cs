using System;

namespace arrayCollections;

class Program
{
  public static void Main()
  {
    string[] a1 = new String[3];
    a1[0] = "Kerli";
    a1[1] = "Mauricio";
    a1[2] = "Kerli_Mauricio";

    if (Array.Exists(a1, e => e.IndexOf("li") != -1)) // busca por parte da string
    {
      Console.WriteLine("Existe o nome Kerli no array");
    }


    List<string> a = new List<string>();
    a.Add("Amêndoa");
    a.Add("Amendoim");
    a.Add("Azeitona");

    if (a.Exists(e => e == "Amendoim"))
    {
      System.Console.WriteLine("Há um Amendoim nesta lista");
    }

    foreach (string comida in a)
    {
      Console.WriteLine(comida);
    }

    Console.WriteLine(a.Count());
  }
}
