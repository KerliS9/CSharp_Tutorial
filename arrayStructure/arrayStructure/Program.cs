using System;

namespace arrayStructure;
public class PlayingWithArrays
{
  static void Main()
  {
    multiDimArrays();
    jaggedArrays();

    int[,] myArray = new int[3,3] {
      {1, 2, 3},
      {4, 5, 6},
      {7, 8, 9},
    };
    // System.Console.WriteLine(myArray.GetLength(0)); // comprimento da dimensão 0
    int result = getSumDiagonal(myArray);
    System.Console.WriteLine(result);

    int[] uniqueArray = new int[9];

    FromArrayToTwoDimArray(uniqueArray, 3, 3);
  }
  public static void multiDimArrays()
  {
    // int[,] multiDimensionalArray1 = new int[2, 3]; // fez duas linhas e três colunas
    int[,] multiDimensionalArray = { { 1, 2, 3 }, { 4, 5, 6 } };
    // System.Console.WriteLine(multiDimensionalArray[0,0]); // 1
    // System.Console.WriteLine(multiDimensionalArray[0,1]); // 2
    // System.Console.WriteLine(multiDimensionalArray[0,2]); // 3
    // System.Console.WriteLine(multiDimensionalArray[1,0]); // 4
    // System.Console.WriteLine(multiDimensionalArray[1,1]); // 5
    // System.Console.WriteLine(multiDimensionalArray[1,2]); // 6

  }

  public static void jaggedArrays()
  {
    // Somente instanciamos o array mais externo neste primeiro passo
    // Repare que apenas o primeiro colchetes contém números
    int[][] jaggedArray = new int[4][];

    // Agora precisamos instanciar um novo array para cada posição do array mais externo
    jaggedArray[0] = new int[4] { 6, 7, 8, 9 };
    jaggedArray[1] = new int[3] { 6, 7, 8 };
    jaggedArray[2] = new int[5] { 6, 7, 8, 8, 9 };
    jaggedArray[3] = new int[2] { 6, 8 };

    // System.Console.WriteLine(jaggedArray[0][2]); // 8
    // primeiro colchetes busca de qual arrayJagged esta sendo solicitado, segundo colchetes busca o dado no índice
  }

/* int[,,] multiDimensionalArray1 = new int[2, 3, 3];

int[,,] multiDimensionalArray2 = { { { 1, 2 }, { 3, 4 } },{ { 5, 6 }, { 7, 8 } } };

// O array jagged precisa ser instanciado em partes. Primeiro instanciamos o array com 3 dimensões
int[][][] jaggedArray = new int[6][][];

// Depois vamos instanciar a primeira linha do array, recebendo um novo array jagged de 2 dimensões
jaggedArray[0] = new int[3][];

// E assim finalmente podemos instanciar a primeira coluna da primeira linha do array com um novo array de 1 dimensão
jaggedArray[0][0] = new int[4] { 1, 2, 3, 4 }; */
  
  public static int getSumDiagonal(int[,] matrix)
  {
    int sum = 0;
    // getLength mostra o comprimento do array de determinada  dimensão
    for (int i = 0; i < matrix.GetLength(0); i++)
    { 
      System.Console.WriteLine(matrix[i, i]);
      sum += matrix[i, i];
    }
    return sum;
  }

    public static int[,] FromArrayToTwoDimArray(int[] array, int lines, int columns)
    {
      int[,] result = new int[lines, columns];
      for (int i = 0; i < array.Length; i++)
      {
          result[i / lines, i % columns] = array[i];
      }
      return result;
    }
}