using System;

namespace Chessboard.Queen
{
  class Chess 
  {
    public void QueenMove(int queenX, int queenY, int targetX, int targetY)
    {
      if (queenX == targetX || queenY == targetY || (queenX - targetX) == (queenY - targetY))
      {
        Console.WriteLine("The queen can attack");
      } 
      else
      {
        Console.WriteLine("The queen cannot attack");
      }    
    }
  }
}