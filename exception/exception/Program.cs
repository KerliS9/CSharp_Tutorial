using System;

namespace math_operations;

public class MathOperations
{
    static void Main()
    {
        // DivideNumbers(4,0);
        WriteName("Kerli");
    }
    public static int DivideNumbers(int numberOne, int numberTwo)
    {
        try
        {
            var result = 0;
            if (numberTwo == 0) 
            {
                throw new DivideByZeroException("Não pode dividir um número por zero!");
            }
            result = numberOne / numberTwo;
            System.Console.WriteLine(result);
            return result;
        }
        catch (DivideByZeroException e)
        {
            System.Console.WriteLine(e.Message);
            throw;
        }
    }
    
    public static void WriteName(string name)
    {
        try 
        {
            if (name == null) 
            {
                throw new ArgumentNullException("Nome não pode ser um valor nulo.");
            }
    
            Console.WriteLine(string.Concat("Seu nome é: ", name));
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine(ex.Message);
            throw ex;
        }          
    }
    
}

