using System;
using Chessboard.Queen;


namespace Chessboard
{
  class Program
  {
  public static void Main()
  {
    Chess chess = new Chess();
    Console.WriteLine("Please enter the x coordinate for the queen as a number: a(0), b(1), c(2), d(3), e(4), f(5), g(6), h(7)");
    int queenX = int.Parse(Console.ReadLine());
    Console.WriteLine("Please enter the y coordinate for the queen: (1, 2, 3, 4, 5, 6, 7, 8)");
    int queenY = int.Parse(Console.ReadLine());

    Console.WriteLine("Please enter the x coordinate for the opponent as a number: a(0), b(1), c(2), d(3), e(4), f(5), g(6), h(7)");
    int targetX = int.Parse(Console.ReadLine());
    Console.WriteLine("Please enter the y coordinate for the opponent: (1, 2, 3, 4, 5, 6, 7, 8)");
    int targetY = int.Parse(Console.ReadLine());
    chess.QueenMove(queenX, queenY, targetX, targetY);
    }
  }
}