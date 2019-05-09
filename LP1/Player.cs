using System;
using System.Collections.Generic;
using System.Text;

namespace LP1
{
    public class Player
    {
        //Creates a new instance of the Board
        Board board = new Board();
        //Creates a comparer class
        Comparer comparer = new Comparer();
        //Creates Combat
        public Combat combat = new Combat();
        //Creates another instance of Ghosts
        public Ghosts ghost1 = new Ghosts();

        //Integers to keep the amount of ghosts the player has on the board
        public int blueGhosts = 0;
        public int redGhosts = 0;
        public int yellowGhosts = 0;

        //Boolean to check if the player can or can't place the ghost
        bool canPlace = true;

        /// <summary>
        /// Returns the position of the player along with it's state
        /// </summary>
        /// <param name="targetPlayer">Gets all the information of the player that is being checked</param>
        /// <param name="ghost">Gets the information on ghosts</param>
        /// <param name="Start">Gets a Boolean depending on being on the start or the main loop</param>
        /// <returns>A position in coordinates depending on where the player placed the ghost</returns>
        public Position GetPosition(Player targetPlayer, Ghosts ghost, bool Start)
        {
            //Creates a new instance of coordinates
            Coordinates coordinates = new Coordinates();
            //Asks for input about the position and the color the player wants
            int position = Convert.ToInt32(Console.ReadLine());
            int ghost_color = Convert.ToInt32(Console.ReadLine());
            //Gets the position in (x,y) from the class cordinates
            Position desiredCoordinate = coordinates.CheckPos(position);

            //Checks if it's the start of the program or the main loop
            if (!Start)
                //Gets a value from combat and sets CanPlace to it.
                canPlace = combat.dungeon.RetriveDungeons(ghost_color);

            //Checks the boolean can place, true by default altered by the Dungeon Class
            if (canPlace)
            {
                //Goes to Compare and checks if the Player can place the ghost or not, sets the result to canPlace
                canPlace = comparer.ComparePlayerToBoard(targetPlayer, board, desiredCoordinate, ghost_color);

                //A loop stopping the user from not putting an answer
                if (canPlace != true)
                {
                    //Sends a message to the user
                    Console.WriteLine("Please choose a valid place to put your ghost");
                    //returns to the beggining of the function
                    GetPosition(targetPlayer, ghost, Start);
                }
                //returns the position (y,x) the user wants
                return desiredCoordinate;
            }
            //Returns nothing
            return null;
        }

    }
}
