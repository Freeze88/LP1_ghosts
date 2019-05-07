using System;

namespace LP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();
            Renderer renderer = new Renderer();
            Player player1 = new Player();



            while (true)
            {
                renderer.Render(board);

                int a = player1.GetColor();

                Position[] nextMove = { player1.GetPosition(board) };
                
                Console.WriteLine(nextMove[0].Row +1);
                Console.WriteLine(nextMove[0].Column +1);
                Console.WriteLine(a);
            }
        }
        private void AssociateColor()
        {

        }
    }
}
