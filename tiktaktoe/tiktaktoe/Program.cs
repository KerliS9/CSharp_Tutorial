namespace TikTakToe;

class Program
{
  public static void Main()
  {
    TikTakToeGame game = new();

    while (!game.IsGameOver())
    {
      game.PrintBoard();
      char player = game.GetCurrentPlayer();
      int[] playerEntry = game.GetPlayerEntry();
      
      game.MakeMove(playerEntry[0], playerEntry[1], player);
      
      game.ChangePlayer();
    }
    game.PrintResults();
  }
}
