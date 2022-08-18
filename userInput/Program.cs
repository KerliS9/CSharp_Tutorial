// See https://aka.ms/new-console-template for more information
namespace user_input;

public class UserInput {
  public static void Main() 
  {
    Console.Write("Enter your name: ");
    string name = Console.ReadLine();
    Console.Write("Enter your age: ");
    string age = Console.ReadLine();
    Console.WriteLine("Hello " + name + "! You are " + age + " years old.");
  }
}
