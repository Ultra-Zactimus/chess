using System;
using Chessboard.Queen;


namespace Chessboard
{
  class Program
  {
  public static void Main()
  {
    Chess chess = new Chess();
    Console.WriteLine("Please enter the x coordinate for the queen as a number: a(1), b(2), c(3), d(4), e(5), f(6), g(7), h(8)");
    int queenX = int.Parse(Console.ReadLine());
    Console.WriteLine("Please enter the y coordinate for the queen: (1, 2, 3, 4, 5, 6, 7, 8)");
    int queenY = int.Parse(Console.ReadLine());

    Console.WriteLine("Please enter the x coordinate for the opponent as a number: a(1), b(2), c(3), d(4), e(5), f(6), g(7), h(8)");
    int targetX = int.Parse(Console.ReadLine());
    Console.WriteLine("Please enter the y coordinate for the opponent: (1, 2, 3, 4, 5, 6, 7, 8)");
    int targetY = int.Parse(Console.ReadLine());
    chess.QueenMove(queenX, queenY, targetX, targetY);
    }
  }
}