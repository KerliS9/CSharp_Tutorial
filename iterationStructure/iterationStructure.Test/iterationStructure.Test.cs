using Xunit;
using FluentAssertions;
using System.IO; // para escrever usando o Console.WiteLine definido na função
using iterationStructure;

namespace iterationStructure.Test;

public class UnitTest1
{
    [Theory(DisplayName = "Deve realizar a contagem do valor passado como parâmetro.")]
    [InlineData(new int[]{1, 1, 1}, 1, 3)]
    public void TestCountOf(int[] entnumbers, int value, int countExpected)
    {   
        var count = NumbersTools.CountOf(entnumbers, value);
        count.Should().Be(countExpected);
    }

    [Theory(DisplayName = "Deve localizar a posição do número no vetor.")]
    [InlineData(new int[]{5, 6, 7}, 5, 0)]
    [InlineData(new int[]{8, 9, 10}, 9, 1)]
    [InlineData(new int[]{11, 12, 13}, 13, 2)]
    [InlineData(new int[]{11, 12, 13, 13}, 13, 2)]
    [InlineData(new int[]{11, 12, 13}, 10, -1)]
    public void TestIndexOf(int[] entnumbers, int value, int positionExpected)
    {        
        var position = NumbersTools.IndexOf(entnumbers, value);
        // System.Console.WriteLine(value);
        position.Should().Be(positionExpected);
    }

    [Theory(DisplayName = "Deve contar a quantidade de números pares")]
    [InlineData(new int[]{5, 3, 7}, 0)]
    [InlineData(new int[]{11, 9, 10}, 1)]
    [InlineData(new int[]{8, 9, 10}, 2)]   
    public void TestCountEvenNumbers(int[] entnumbers, int countExpected)
    {        
        var count = NumbersTools.CountEvenNumbers(entnumbers);
        // System.Console.WriteLine(count);
        count.Should().Be(countExpected);
    }

    [Theory]
    [InlineData("Rahel", "Hey, Hello Rahel")]
    [InlineData("Marina", "Hey, Hello Marina")]
    [InlineData("Luiz", "Hey, Hello Luiz")]
    [InlineData("Arthur", "Hey, Hello Arthur")]
    [InlineData("Livia", "Hey, Hello Livia")]
    public void TestHello(string entry, string expected)
    {
        using(var stringWriter = new StringWriter())         //1
        {     
            Console.SetOut(stringWriter);                    //2
            NumbersTools.Hello(entry);                         //3
            var response = stringWriter.ToString().Trim();   //4
            response.Should().Be(expected);                  //5                                              
        }
    }

    [Theory]
    [InlineData("Rahel", "Hey, Hello Rahel", "Can i call u Rahelzito?")]
    [InlineData("Marina", "Hey, Hello Marina", "Can i call u Marinazito?")]
    [InlineData("Luiz", "Hey, Hello Luiz", "Can i call u Luizzito?")]
    [InlineData("Arthur", "Hey, Hello Arthur", "Can i call u Arthurzito?")]
    [InlineData("Livia", "Hey, Hello Livia", "Can i call u Liviazito?")]
    public void TestHelloHarder(string entry, string expected1call, string expected2call)
    {
        using(var stringWriter = new StringWriter()) 
        {     
            Console.SetOut(stringWriter);
            NumbersTools.HelloHarder(entry);
            var response = stringWriter.ToString().Trim().Split("\n");  // 1
            response[0].Should().Be(expected1call);                     // 2                              
            response[1].Should().Be(expected2call);                     // 3
        }
    }

    [Theory]
    [InlineData("Rahel", "Ok, Hello Rahel")]
    [InlineData("Marina", "Ok, Hello Marina")]
    [InlineData("Luiz", "Ok, Hello Luiz")]
    [InlineData("Arthur", "Ok, Hello Arthur")]
    [InlineData("Livia", "Ok, Hello Livia")]
    public void TestHelloSayYourName(string entry, string expected)
    {
        using(var stringWriter = new StringWriter()) //1
        {
            using(var stringReader = new StringReader(String.Join("\n", entry))) //1
            {      
                Console.SetOut(stringWriter); 
                Console.SetIn(stringReader);                                     //2
                NumbersTools.HelloSayYourName();                                   //3
                
                var response = stringWriter.ToString().Trim();                   //4
                response.Should().Contain(expected);                             //5                    
            }          
        }
    }
}