using System.Runtime.CompilerServices;

namespace TikTakToe;

public class TikTakToeGame
{
    public char[,] Board = new char[3, 3] { { ' ', ' ', ' ' }, { ' ', ' ', ' ' }, { ' ', ' ', ' ' } };
    public char CurrentPlayer = 'x';
    public char Winner = ' ';

    public void PrintBoard()
    {
        for (var i = 0; i < Board.GetLength(0); i++)
        {
            Console.WriteLine($"{ Board[i, 0]} {Board[i, 1]} {Board[i, 2]}");
        }
    }

    public void MakeMove(int line, int column, char player)
    {
        Board[line, column] = player;
    }

    public bool IsGameOver()
    {
        for (var i = 0; i < Board.GetLength(0); i++)
        {
            string row =$"{Board[i, 0]} {Board[i, 1]} {Board[i, 2]}";
            string column = $"{ Board[0, i]} {Board[1, i]} {Board[2, i]}";
            string leftDiagonal = $"{Board[0, 0]} {Board[1, 1]} {Board[2, 2]}";
            string rightDiagonal = $"{Board[0, 2]} {Board[1, 1]} {Board[2, 0]}";

            if (row is "x x x" or "o o o")
            {
                Winner = row[0];
                break;
            }

            if (column is "x x x" or "o o o")
            {
                Winner = column[0];
                break;
            }
            if (leftDiagonal is "x x x" or "o o o")
            {
                Winner = leftDiagonal[0];
                break;
            }
            if (rightDiagonal is "x x x" or "o o o")
            {
                Winner = rightDiagonal[0];
                break;
            }
        }

        return Winner != ' ';
    }

    public void PrintResults()
    {
        if (Winner == ' ')
        {
            Console.WriteLine("Empate! Deu Velha!");
        }
        else
        {
            Console.WriteLine($"O jogador {Winner} venceu!");
        }

    }

    public char GetCurrentPlayer()
    {
        return CurrentPlayer;
    }

    public int[] GetPlayerEntry()
    {
        Console.WriteLine("Jogador " + CurrentPlayer + " informe a linha:");
        string input = Console.ReadLine() ?? "";
        int line = int.Parse(input);

        Console.WriteLine("Jogador " + CurrentPlayer + " informe a coluna:");
        input = Console.ReadLine() ?? "";
        int column = int.Parse(input);

        return new int[] { line, column };
    }

    public void ChangePlayer()
    {
        CurrentPlayer = CurrentPlayer == 'x' ? 'o' : 'x';
    }
}