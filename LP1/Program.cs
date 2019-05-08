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
            Position posP1, posP2;



            Player player1 = new Player();
            Player player2 = new Player();

            Movement move = new Movement();

            //player1.GetPosition(ghosts);
            for (int i = 0; i < 1; i++)
            {
                renderer.Render(board);

                Console.WriteLine("Player 1 Turn");
                posP1 = player1.GetPosition(ghosts);

                while (player1.ghost1.GhostState[posP1.Row, posP1.Column]
                    == player2.ghost1.GhostState[posP1.Row, posP1.Column])
                {
                    Console.WriteLine("There's already a player there");
                    player1.ghost1.GhostState[posP1.Row, posP1.Column] = State.none;
                    posP1 = player1.GetPosition(ghosts);
                }

                Console.WriteLine("Player 2 Turn");
                posP2 = player2.GetPosition(ghosts);

                while (player1.ghost1.GhostState[posP2.Row, posP2.Column]
                    == player2.ghost1.GhostState[posP2.Row, posP2.Column])
                {
                    Console.WriteLine("There's already a player there");
                    player2.ghost1.GhostState[posP2.Row, posP2.Column] = State.none;
                    posP2 = player2.GetPosition(ghosts);
                }

                if (i == 0)
                {
                    Console.WriteLine("Choose one more position");
                    posP2 = player2.GetPosition(ghosts);
                    while (player1.ghost1.GhostState[posP2.Row, posP2.Column] == player2.ghost1.GhostState[posP2.Row, posP2.Column])
                    {
                        Console.WriteLine("There's already a player there");
                        player2.ghost1.GhostState[posP2.Row, posP2.Column] = State.none;
                        player2.GetPosition(ghosts);
                    }
                }

                while (true)
                {
                    Console.WriteLine(player1.ghost1.GhostState[0, 0]);
                    Console.WriteLine(player1.ghost1.GhostState[0, 1]);
                    Console.WriteLine(player1.ghost1.GhostState[0, 2]);
                    Console.WriteLine(player1.ghost1.GhostState[0, 3]);
                    Console.WriteLine(player1.ghost1.GhostState[0, 4]);
                    Console.WriteLine("\n");
                    Console.WriteLine(player2.ghost1.GhostState[0, 0]);
                    Console.WriteLine(player2.ghost1.GhostState[0, 1]);
                    Console.WriteLine(player2.ghost1.GhostState[0, 2]);
                    Console.WriteLine(player2.ghost1.GhostState[0, 3]);
                    Console.WriteLine(player2.ghost1.GhostState[0, 4]);

                    renderer.Render(board);

                    move.moveP1(player1);
                    move.moveP2(player2);
                }


            }
        }
    }
}
