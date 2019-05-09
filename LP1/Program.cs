using System;

namespace LP1
{
    /// <summary>
    /// This class contains the main method
    /// </summary>
    class Program
    {

        static void Main()
        {
            //Creates a new board
            Board board = new Board();
            //Creates a new Renderer to be used here
            Renderer renderer = new Renderer();
            //Creates an instance of ghosts
            Ghosts ghosts = new Ghosts();
            //Creates a new Win checker
            WinChecker checker = new WinChecker();
            //Creates 2 players from the Player class
            Player player1 = new Player();
            Player player2 = new Player();
            //Creates an instance of the movement to be used here
            Movement move = new Movement();
            //Creates a new start to be used to place the players
            Start start = new Start();

            //Defines a Boolean to keep the main loop running
            bool loop = true;
            //Controls which player is
            int turn = 1;

            //Runs the cycle 10 times to put all the 9 ghosts of each player
            for (int i = 0; i < 10; i++)
            {
                //Makes an aesthetic change allowing the second player to put 2 ghost without the board in the middle
                if (i != 1) renderer.Render(board, player1, player2);
                //Gets the positions and states of the players
                start.SetStartPositions(player1, player2, ghosts, i);
            }

            //The main loop of the games
            while (loop)
            {
                //Draws the field
                renderer.Render(board, player1, player2);
                //checks if the Player1 or player 2 ghost is near an exit
                loop = checker.CheckNearExit(player1, move, 1);
                loop = checker.CheckNearExit(player2, move, 2);
                //If a player wins ends the loop
                if (loop == false) break;

                //Sends the user a message
                Console.WriteLine("What do you want to do?\n1 - move a ghost\n2 - get a ghost from the dungeon");

                //Looks for input of the user
                int input = Convert.ToInt32(Console.ReadLine());
                //Checks if the turn is 1
                if (turn == 1)
                {
                    //sends the user a message
                    Console.WriteLine("Player 1 Turn");
                    //If the input is 1 the player can move a ghost
                    if (input == 1) move.Move(player1, player2);
                    //If the input is 2 the player can put a new ghost
                    else if (input == 2) player1.GetPosition(player1, ghosts, false);
                    //Checks if the user put a correct input, passes the turns
                    if (input == 1 || input == 2) turn++;
                    //If the condition is not met sends the user a warning
                    else Console.WriteLine("Please insert 1 or 2");
                    //**The user was supposed to be asked again after this but it does not**//
                }

                //Looks for input of the user
                input = Convert.ToInt32(Console.ReadLine());
                //Checks if the turn is 1
                if (turn == 2)
                {
                    //sends the user a message
                    Console.WriteLine("Player 2 Turn");
                    //If the input is 1 the player can move a ghost
                    if (input == 1) move.Move(player2, player1);
                    //If the input is 2 the player can put a new ghost
                    else if (input == 2) player2.GetPosition(player1, ghosts, false);
                    //Checks if the user put a correct input, passes the turns
                    if (input == 1 || input == 2) turn--;
                    //If the condition is not met sends the user a warning
                    else Console.WriteLine("Please insert 1 or 2");
                    //**The user was supposed to be asked again after this but it does not**//
                }
            }
            //Stops the program from closing automatically after winning
            Console.ReadLine();
        }
    }
}
