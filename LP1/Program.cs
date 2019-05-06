using System;

namespace LP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();
            Player player1 = new Player();
            Player player2 = new Player();

            while (true)
            {
                Position nextMove;

                nextMove = player1.GetPosition(board);
            }
        }
    }
}
