using Xunit;
using FluentAssertions;

using arrayStructure;
namespace arrayStructure.Test;

public class UnitTest1
{   
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4 })]
    public void TestArrayInlineData(int[] intArrayEntry)
    {
        for (int i=0; i < intArrayEntry.Length; i++) 
        {
            Console.WriteLine(intArrayEntry[i]);
        }
    }

    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4 }, "Minha string")]
    public void TestArrayInlineData2(int[] intArrayEntry, string stringEntry)
    {
        Console.WriteLine(stringEntry);
        for (int i = 0; i < intArrayEntry.Length; i++) 
        {
            Console.WriteLine(intArrayEntry[i]);
        }
    }

    [Theory]
    // Podemos também dentar nosso código de forma que fique mais fácil de visualizar o array de 2 dimensões que
    // será criado a partir do array de apenas uma dimensão
    [InlineData(new int[] {
        1, 2, 3, 
        4, 5, 6,
        7, 8, 9,
    } // Perceba que este array continua tendo apenas uma dimensão, porém foi edentado para facilitar a visualização
    )]
    public void TestArrayInlineData3(int[] intArrayEntry)
    {   
        int[,] multiDimArray = PlayingWithArrays.FromArrayToTwoDimArray(intArrayEntry, 3, 3);

        // Agora multiDimArray é um array multidimensional criado a partir dos dados passados como InlineData
    }

    [Theory(DisplayName = "Deve retornar corretamente a soma da diagonal da matriz")]
    [InlineData(new int[] {
        1, 2, 3, 
        4, 5, 6,
        7, 8, 9,
    },
    3,
    15
    )]
    [InlineData(new int[] {
        1,  2,  3,  4,
        5,  6,  7,  8,
        9,  10, 11, 12,
        13, 14, 15, 16
    },
    4,
    34
    )]
    public void TestGetSumDiagonal(int[] entryArray, int entryLines, int expected)
    {
        // Primeiro transformamos o array pois a função que vamos testar espera um array de 2 dimensões  
        int[,] multiDimArray = PlayingWithArrays.FromArrayToTwoDimArray(entryArray, entryLines, entryLines);

        // Passamos o array de 2 dimensões criado e comparamos com a resposta esperada
        PlayingWithArrays.getSumDiagonal(multiDimArray).Should().Be(expected);
    }
}