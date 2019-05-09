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
            bool loop = true;
            int turn = 1;

            for (int i = 0; i < 2; i++)
            {
                if (i != 1) renderer.Render(board, player1, player2);
                start.SetStartPositions(player1, player2, ghosts, i);
            }

            while (loop)
            {
                renderer.Render(board, player1, player2);
                loop = checker.CheckNearExit(player1, move, 1);
                loop = checker.CheckNearExit(player2, move, 2);
                if (loop == false) break;

                Console.WriteLine("What do you want to do?\n1 - move a ghost\n2 - get a ghost from the dungeon");

                int input = Convert.ToInt32(Console.ReadLine());
                if (turn == 1)
                {
                    Console.WriteLine("Player 1 Turn");
                    if (input == 1) move.Move(player1, player2);
                    else if (input == 2) player1.GetPosition(player1, ghosts, false);
                    if (input == 1 || input == 2) turn++;
                    else Console.WriteLine("Please insert 1 or 2");
                }
                if (turn == 2)
                {
                    Console.WriteLine("Player 2 Turn");
                    if (input == 1) move.Move(player2, player1);
                    else if (input == 2) player2.GetPosition(player1, ghosts, false);
                    if (input == 1 || input == 2) turn--;
                    else Console.WriteLine("Please insert 1 or 2");
                }
            }
            Console.ReadLine();
        }
    }
}
