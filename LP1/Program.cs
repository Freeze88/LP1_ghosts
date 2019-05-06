using System;

namespace LP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();
            Renderer renderer = new Renderer();


            renderer.Render(board);

            while (true)
            {
                Position nextMove;

                //nextMove = player1.GetPosition(board);
            }
        }
    }
}
