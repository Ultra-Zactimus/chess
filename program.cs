using System;
using System.Collections.Generic;

class Chessboard 
{
  public static void QueenMove()
{
    Console.WriteLine("Please enter the x coordinate for the queen as a number: a(0), b(1), c(2), d(3), e(4), f(5), g(6), h(7)");
    int queenX = int.Parse(Console.ReadLine());
    Console.WriteLine("Please enter the y coordinate for the queen: (1, 2, 3, 4, 5, 6, 7, 8)");
    int queenY = int.Parse(Console.ReadLine());

    Console.WriteLine("Please enter the x coordinate for the opponent as a number: a(0), b(1), c(2), d(3), e(4), f(5), g(6), h(7)");
    int targetX = int.Parse(Console.ReadLine());
    Console.WriteLine("Please enter the y coordinate for the opponent: (1, 2, 3, 4, 5, 6, 7, 8)");
    int targetY = int.Parse(Console.ReadLine());

    if (queenX == targetX || queenY == targetY || (queenX - targetX) == (queenY - targetY))
    {
      Console.WriteLine("The queen can attack");
    } 
    else
    {
      Console.WriteLine("The queen cannot attack");
    }    
  }
  
  public static void Main()
  {
    QueenMove();
  }
}