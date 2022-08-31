using System;

namespace guessing_game;
public class GuessingGame
{
  static void Main()
  {
    string secretWord = "giraffe";
    string? guess = "";
    int guessCount = 0;
    int guessLimit = 3;
    bool outOfGuesses = false;

    while(guess != secretWord && !outOfGuesses)
    { 
      if (guessCount < guessLimit) {
        Console.WriteLine("Enter guess: ");
        guess = Console.ReadLine();
        guessCount++;
      } else
      {
        outOfGuesses = true;
      }
    }
    if (outOfGuesses)
    {
      System.Console.WriteLine("You lose!");
    } else
    {
    System.Console.WriteLine("You win!");
    }
  }
}