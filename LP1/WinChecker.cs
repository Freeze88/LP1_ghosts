using System;
using System.Collections.Generic;
using System.Text;

namespace LP1
{
    /// <summary>
    /// This class checks if a player has won
    /// </summary>
    public class WinChecker
    {
        /// <summary>
        /// Checks if there's ghost near the exists, checks for the winner
        /// </summary>
        /// <param name="targetPlayer">Gets the information of the player given</param>
        /// <param name="move">Gets the rotation of the portals</param>
        /// <param name="playerNumber">Gets a number representing the player</param>
        /// <returns>true or false</returns>
        public bool CheckNearExit(Player targetPlayer, Movement move, int playerNumber)
        {
            //Sets the int rotation to the rotation on move
            int rotation = move.combat.rotation; 
            
            //checks if any red ghosts is near the read portal
            if (targetPlayer.ghost1.GhostState[0, 3] == State.red && rotation == 1 ||
                targetPlayer.ghost1.GhostState[1, 2] == State.red && rotation == 2 ||
                targetPlayer.ghost1.GhostState[0, 1] == State.red && rotation == 3)
            {
                //sets the State of the player that leaves to none
                if (rotation == 1) targetPlayer.ghost1.GhostState[0, 3] = State.none;
                if (rotation == 2) targetPlayer.ghost1.GhostState[1, 2] = State.none;
                if (rotation == 3) targetPlayer.ghost1.GhostState[0, 1] = State.none;

                //subtracts a red ghost from the player
                targetPlayer.redGhosts --;
                //Sends the user a message
                Console.WriteLine("\n Player {0} Got one out", playerNumber);
            }
            //checks if any red ghosts is near the blue portal
            if (targetPlayer.ghost1.GhostState[4, 1] == State.blue && rotation == 1 ||
                targetPlayer.ghost1.GhostState[3, 2] == State.blue && rotation == 2 ||
                targetPlayer.ghost1.GhostState[4, 3] == State.blue && rotation == 3)
            {
                //sets the State of the player that leaves to none
                if (rotation == 1) targetPlayer.ghost1.GhostState[4, 1] = State.none;
                if (rotation == 2) targetPlayer.ghost1.GhostState[3, 2] = State.none;
                if (rotation == 3) targetPlayer.ghost1.GhostState[4, 3] = State.none;

                //subtracts a blue ghost from the player
                targetPlayer.blueGhosts--;
                //Sends the user a message
                Console.WriteLine("\n Player {0} Got one out", playerNumber);
            }
            //checks if any yellow ghosts is near the blue portal
            if (targetPlayer.ghost1.GhostState[3, 4] == State.yellow && rotation == 1 ||
                targetPlayer.ghost1.GhostState[2, 3] == State.yellow && rotation == 2 ||
                targetPlayer.ghost1.GhostState[1, 4] == State.yellow && rotation == 3)
            {
                if (rotation == 1) targetPlayer.ghost1.GhostState[3, 4] = State.none;
                if (rotation == 2) targetPlayer.ghost1.GhostState[2, 3] = State.none;
                if (rotation == 3) targetPlayer.ghost1.GhostState[1, 4] = State.none;

                //subtracts a yellow ghost from the player
                targetPlayer.yellowGhosts--;
                //Sends the user a message
                Console.WriteLine("\n Player {0} Got one out", playerNumber);
            }
            //tells the user how many ghosts it has on the field
            Console.WriteLine("player {0} blue ghosts {1}", playerNumber, targetPlayer.blueGhosts);
            Console.WriteLine("player {0} red ghosts {1}", playerNumber, targetPlayer.redGhosts);
            Console.WriteLine("player {0} yellow ghosts {1}", playerNumber, targetPlayer.yellowGhosts);

            //checks if the player has 3 ghosts out
            if (targetPlayer.redGhosts <= 0 && targetPlayer.blueGhosts <= 0 &&
                targetPlayer.yellowGhosts <= 0)
                // returns false
                return false;
            //returns true
            return true;
        }
    }
}
