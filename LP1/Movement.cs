using System;
using System.Collections.Generic;
using System.Text;

namespace LP1
{
    /// <summary>
    /// This class allow player to move the ghosts
    /// </summary>
    public class Movement
    {
        //Creates a new instance of Combat
        public Combat combat = new Combat();
        //Creates a new instance od Coordinates
        private Coordinates coordinates = new Coordinates();

        /// <summary>
        /// Asks the user what cell the user wants to move from and the cell the user want to move
        /// </summary>
        /// <param name="currentPlayer"></param>
        /// <param name="targetPlayer"></param>        
        public void Move(Player currentPlayer, Player targetPlayer)
        {
            //Sends a message to the user
            Console.WriteLine("Where's the ghost you want to move?");
            //Asks for input from the user
            int position = Convert.ToInt32(Console.ReadLine());
            //Gets the position in (x,y) from the class cordinates
            Position pos = coordinates.CheckPos(position);
            //Sends a message to the user
            Console.WriteLine("Where do you want to put it?");
            //Ask the player in which cell he wants to put the ghost
            int position2 = Convert.ToInt32(Console.ReadLine());

            //Checks the position2 and sets position on to a cell adjacent to cell the user is in
            if (position2 == 8) position = position - 5;
            else if (position2 == 6) position = position + 1;
            else if (position2 == 2) position = position + 5;
            else if (position2 == 4) position = position - 1;
            //If none is met Start the function again
            else Move(currentPlayer, targetPlayer);

            //Checks if the user is on a mirror, sets the position to the diagonal mirror 
            if (position == 7) position = 19;
            else if (position == 9) position = 17;
            else if (position == 19) position = 7;
            else if (position == 17) position = 9;

            //Checks if the user is out of the Board
            if (position <= 0 || position > 25) Console.WriteLine("You cannot move a ghost outside the board");
            //Checks if the user is on a portal
            else if (position == 3 || position == 15 || position == 23) Console.WriteLine("You cannot move a ghost to a portal");
            //if none is met
            else
            {
                //Gets the position in (x,y) from the class cordinates
                Position pos2 = coordinates.CheckPos(position);

                //Checks if the players entered in combat
                combat.StateChecker(currentPlayer, targetPlayer, pos, pos2);

                //Checks if the State of the position isn't none and the color of the 2 positions aren't the same
                if (currentPlayer.ghost1.GhostState[pos.Row, pos.Column] != State.none &&
                    currentPlayer.ghost1.GhostState[pos2.Row, pos2.Column] !=
                    currentPlayer.ghost1.GhostState[pos.Row, pos.Column])
                {
                    //Copies the State of the starting position to the end position
                    currentPlayer.ghost1.GhostState[pos2.Row, pos2.Column] = currentPlayer.ghost1.GhostState[pos.Row, pos.Column];
                    //Sets the starting position to none
                    currentPlayer.ghost1.GhostState[pos.Row, pos.Column] = State.none;
                }
                //If the conditions are not met sends a warning to the user
                else Console.WriteLine("You either don't have a ghost there or it's the same color");
            }
        }
    }
}
