using Xunit;
using System.IO;
using System;
using TikTakToe;
using FluentAssertions;

namespace TikTakToe.Test;

[Collection("Sequential")]
public class TestTikTakToeGame
{
    [Theory(DisplayName = "Deve preencher o tabuleiro com o caractere correto na posição adequada")]
    [InlineData(
        1,
        1,
        'x',
        new char[] {
            ' ', ' ', ' ',
            ' ', 'x', ' ',
            ' ', ' ', ' '
        }
    )]
    public void TestMakeMove(int lineEntry, int columnEntry, char playerEntry, char[] expected)
    {
        TikTakToeGame game = new();

        var expectedDimArray = FromArrayToMultiDimArray(expected, 3, 3);

        game.MakeMove(lineEntry, columnEntry, playerEntry);
        game.Board.Should().BeEquivalentTo(expectedDimArray);
    }
    
    [Theory(DisplayName = "Deve imprimir o tabuleiro")]
    [InlineData(
        new char[] {
            'x', 'x', 'x',
            'x', 'x', 'x',
            'x', 'x', 'x'
        },
        new string[] {
            "x x x",
            "x x x",
            "x x x"
        }
    )]
    public void TestPrintBoard(char[] entry, string[] expected)
    {
        var strWriter = new StringWriter();
        Console.SetOut(strWriter);

        TikTakToeGame game = new();

        game.Board = FromArrayToMultiDimArray(entry, 3, 3);
        game.PrintBoard();

        var result = strWriter.ToString().Trim().Split("\n");

        result[0].Should().Be(expected[0]);
    }

    [Theory(DisplayName = "Deve retornar corretamente se o jogo acabou ou não")]
    [InlineData(
        new char[] {
            'x', 'x', 'x',
            'x', 'x', 'x',
            'x', 'x', 'x'
        },
        'x',
        true
    )]
    public void TestIsGameOver(char[] entry, char expectedWinner, bool expectedReturn)
    {
        TikTakToeGame game = new()
        {
            Board = FromArrayToMultiDimArray(entry, 3, 3)
        };

        game.IsGameOver().Should().Be(expectedReturn);
        game.Winner.Should().Be(expectedWinner);
    }

    [Theory(DisplayName = "Deve imprimir o vencedor correto do jogo")]
    [InlineData(' ', "Empate! Deu Velha!")]
    public void TestPrintResults(char entry, string expected)
    {
        var strWriter = new StringWriter();
        Console.SetOut(strWriter);

        TikTakToeGame game = new()
        {
            Winner = entry
        };

        game.PrintResults();

        var result = strWriter.ToString().Trim();
        result.Should().Be(expected);
    }

    public static char[,] FromArrayToMultiDimArray(char[] array, int lines, int columns)
    {
        char[,] result = new char[lines, columns];
        for (int i = 0; i < array.Length; i++)
        {
            result[i / columns, i % columns] = array[i];
        }
        return result;
    }
}