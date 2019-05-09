using System;
using System.Collections.Generic;
using System.Text;

namespace LP1
{
    public class Combat
    {
        //Sets an integer that saves the rotation
        public int rotation = 0;
        //Creates an instance of Dungeon
        public Dungeon dungeon = new Dungeon();

        /// <summary>
        /// Checks if any of the Ghosts enteres in combat
        /// </summary>
        /// <param name="currentPlayer">Gets the information about the player the moved</param>
        /// <param name="targetPlayer">Gets the information about the player the was stationary</param>
        /// <param name="position">Gets the position the player that moved</param>
        /// <param name="position2">Gets the position of the player that was stationary</param>
        public void StateChecker(Player currentPlayer, Player targetPlayer, Position position, Position position2)
        {
            //Checks if the moving player was blue and the other player yellow
            if (currentPlayer.ghost1.GhostState[position.Row, position.Column] == State.blue &&
                targetPlayer.ghost1.GhostState[position2.Row, position2.Column] == State.yellow)
            {
                //Sends an integer to the Dungeon
                dungeon.DungeonGhosts(3);
                //increments 1 to the rotation
                rotation++;
                //Sets the state of the ghost of the losing player to none
                targetPlayer.ghost1.GhostState[position2.Row, position2.Column] = State.none;
            }

            //Checks if the moving player was red and the other player blue
            if (currentPlayer.ghost1.GhostState[position.Row, position.Column] == State.red &&
                targetPlayer.ghost1.GhostState[position2.Row, position2.Column] == State.blue)
            {
                //Sends an integer to the Dungeon
                dungeon.DungeonGhosts(1);
                //increments 1 to the rotation
                rotation++;
                //Sets the state of the ghost of the losing player to none
                targetPlayer.ghost1.GhostState[position2.Row, position2.Column] = State.none;
            }

            //Checks if the moving player was yellow and the other player red
            if (currentPlayer.ghost1.GhostState[position.Row, position.Column] == State.yellow &&
                targetPlayer.ghost1.GhostState[position2.Row, position2.Column] == State.red)
            {
                //Sends an integer to the Dungeon
                dungeon.DungeonGhosts(2);
                //increments 1 to the rotation
                rotation++;
                //Sets the state of the ghost of the losing player to none
                targetPlayer.ghost1.GhostState[position2.Row, position2.Column] = State.none;
            }
            //Cheks if the rotation is bigger than 3 and sets it to 0
            if (rotation > 3) rotation = 0;
        }
    }
}
