using System;

namespace LP1
{
    /// <summary>
    /// This class contains the main mathod
    /// </summary>
    class Program
    {

        static void Main()
        {
            //Initiates all the classes needed to run the game
            Board board = new Board();
            Renderer renderer = new Renderer();
            Ghosts ghosts = new Ghosts();
            Position posP1, posP2;
            WinChecker checker = new WinChecker();
            Player player1 = new Player();
            Player player2 = new Player();
            Movement move = new Movement();

            //
            bool loop = true;
            //
            for (int i = 0; i < 1; i++)
            {
                //
                renderer.Render(board, player1, player2);
                //Intructions on how to  place the ghosts
                Console.WriteLine("First choose a position: 1 - 25\nThen choose" +
                    " a color:\n1 - blue\n2 - red\n3 - Yellow");
                //Says that's player 1 turn to choose the ghost position
                Console.WriteLine("Player 1 Turn:");
                //
                posP1 = player1.GetPosition(ghosts);
                //
                while (player1.ghost1.GhostState[posP1.Row, posP1.Column]
                    == player2.ghost1.GhostState[posP1.Row, posP1.Column])
                {
                    //Prints this message if that cell is occupied by other ghost 
                    Console.WriteLine("There's already a player there");
                    //
                    player1.ghost1.GhostState[posP1.Row, posP1.Column] = State.none;
                    //
                    posP1 = player1.GetPosition(ghosts);
                }
                //Says that's player 2 turn to choose the ghost position
                Console.WriteLine("Player 2 Turn:");
                //
                posP2 = player2.GetPosition(ghosts);
                //
                while (player1.ghost1.GhostState[posP2.Row, posP2.Column]
                    == player2.ghost1.GhostState[posP2.Row, posP2.Column])
                {
                    //Prints this message if that cell is occupied by other ghost 
                    Console.WriteLine("There's already a player there");
                    //
                    player2.ghost1.GhostState[posP2.Row, posP2.Column] = State.none;
                    //
                    posP2 = player2.GetPosition(ghosts);
                }
                //
                if (i == 0)
                {
                    //Says that's player 2 turn to choose another ghost position
                    Console.WriteLine("Choose one more position");
                    //
                    posP2 = player2.GetPosition(ghosts);
                    //
                    while (player1.ghost1.GhostState[posP2.Row, posP2.Column] ==
                        player2.ghost1.GhostState[posP2.Row, posP2.Column])
                    {
                        //Prints this message if that cell is occupied by other ghost 
                        Console.WriteLine("There's already a player there");
                        //
                        player2.ghost1.GhostState[posP2.Row, posP2.Column] = State.none;
                        //
                        player2.GetPosition(ghosts);
                    }
                }
                //
                while (loop)
                {
                    //
                    renderer.Render(board, player1, player2);
                    //
                    loop = checker.CheckNearExit(player1, player2, move);
                    //
                    loop = checker.CheckNearExit(player2, player1, move);
                    //if (loop == false) break;

                    //
                    move.Move(player1, player2);
                    //
                    move.Move(player2, player1);
                }
            }
        }
    }
}
