using System;
using System.Collections.Generic;
using System.Text;

namespace LP1
{
    public class Start
    {
        //Initializes 2 different instances of the class Position
        Position posP1, posP2;

        /// <summary>
        /// Responsible for setting the position (x,y) and the color of the ghost
        /// </summary>
        /// <param name="player1">Gets all the information from the player 1</param>
        /// <param name="player2">Gets all the information from the player 2</param>
        /// <param name="ghosts">Gets the information from ghosts</param>
        /// <param name="i">Which cycle the for loop in main is in</param>
        public void SetStartPositions(Player player1, Player player2, Ghosts ghosts, int i)
        {
            //checks if it's the second loop
            if (i != 1)
            {
                //Tells the player what to choose and which turn it is
                Console.WriteLine("First choose a position: 1 - 25\nThen choose a color:\n1 - blue\n2 - red\n3 - Yellow");
                Console.WriteLine("Player 1 Turn:");

                //Gets the position from the class Player and saves it in posP1
                posP1 = player1.GetPosition(player1, ghosts, true);

                //A loop that checks if the player states are the same
                while (player1.ghost1.GhostState[posP1.Row, posP1.Column]
                    == player2.ghost1.GhostState[posP1.Row, posP1.Column])
                {
                    //Sends a message to the user
                    Console.WriteLine("There's already a player there");
                    //sets the state on the coordinates in posP1 to none
                    player1.ghost1.GhostState[posP1.Row, posP1.Column] = State.none;
                    //Gets the position from the class Player and saves it in posP1
                    posP1 = player1.GetPosition(player1, ghosts, true);
                }
            }

            if (i != 10)
            {                
                //Tells the player what to choose and which turn it is
                Console.WriteLine("First choose a position: 1 - 25\nThen choose a color:\n1 - blue\n2 - red\n3 - Yellow");
                Console.WriteLine("Player 2 Turn:");

                //Gets the position from the class Player and saves it in posP2
                posP2 = player2.GetPosition(player2, ghosts, true);

                //A loop that checks if the player states are the same
                while (player1.ghost1.GhostState[posP2.Row, posP2.Column]
                    == player2.ghost1.GhostState[posP2.Row, posP2.Column])
                {
                    //Sends a message to the user
                    Console.WriteLine("There's already a player there");
                    //sets the state on the coordinates in posP1 to none
                    player2.ghost1.GhostState[posP2.Row, posP2.Column] = State.none;
                    //Gets the position from the class Player and saves it in posP1
                    posP2 = player2.GetPosition(player2, ghosts, true);
                }
            }
        }
    }
}
