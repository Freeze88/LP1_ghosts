using System;

namespace LP1
{
    class Program
    {
        static void Main()
        {
            Board board = new Board();
            Renderer renderer = new Renderer();
            Ghosts ghosts = new Ghosts();
            WinChecker checker = new WinChecker();
            Player player1 = new Player();
            Player player2 = new Player();
            Movement move = new Movement();
            Start start = new Start();
            //Dungeon dungeon = new Dungeon();

            bool loop = true;
            
            renderer.Render(board, player1, player2);
            
            for (int i = 0; i < 18; i++)
                start.SetStartPositions(player1, player2, ghosts, i);

            while (loop)
            {
                renderer.Render(board, player1, player2);
                loop = checker.CheckNearExit(player1, move, 1);
                loop = checker.CheckNearExit(player2, move, 2);
                if (loop == false) break;

                move.Move(player1, player2);
                move.Move(player2, player1);

                player1.GetPosition(player1, ghosts, false);

            }
        }
    }
}
