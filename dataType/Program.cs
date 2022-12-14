// See https://aka.ms/new-console-template for more information
namespace data_type;

public class DataType {
  public static void Main() 
  {
    string phrase = "Kerli Schroeder";
    char grade = 'A';
    int age = 34;
    // float, double, decimal - do menos para o mais preciso
    double height = 1.70;
    bool female = true;

    Console.WriteLine("Name: " + phrase + "\n grade: " + grade + "\n age: " +  age + "\n height: " +  height + "\n female: " +  female);
    Console.WriteLine("Kerli\"Schroeder"); // imprimir as aspas
    Console.WriteLine(phrase.ToUpper()); // ACESSANDO MÉTODOS
    Console.WriteLine(phrase.Contains("der")); // verifica se contêm esta informação, retorna um boolean.
    Console.WriteLine(phrase[0]); // retorna o index
    Console.WriteLine(phrase.IndexOf("li")); // mostra o index da palavra pesquisada
    Console.WriteLine(phrase.Substring(6, 5)); // identifica o início da extração e quantos dados serão extraídos
    Console.WriteLine(Math.Pow(3, 2)); // exponenciação
    Console.WriteLine(Math.Max(10, 21)); // extrai o maior número MÉTODOS MATEMÁTICOS

    Console.WriteLine((float)1 / (float)2); // definir o tipo da dado na variável
    Console.WriteLine(1 > 2 && 2 < 3); // retorna false
    System.Console.WriteLine(1 > 2 & 2 < 3); // ???? 
  }
}
