using System;
using System.Collections.Generic;
using System.Text;

namespace LP1
{
    /// <summary>
    /// This class add the combat and determines all the possibles outcomes of the fight
    /// </summary>
    public class Combat
    {
        /// <summary>
        /// 
        /// </summary>
        public int rotation = 0;
        public Dungeon dungeon = new Dungeon();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="player1"></param>
        /// <param name="player2"></param>
        /// <param name="position"></param>
        /// <param name="position2"></param>
        public void StateChecker(Player player1, Player player2, Position position, Position position2)
        {
            if (currentPlayer.ghost1.GhostState[position.Row, position.Column] == State.blue &&
                targetPlayer.ghost1.GhostState[position2.Row, position2.Column] == State.red)
            {
                dungeon.DungeonGhosts(2);
                rotation++;
                targetPlayer.ghost1.GhostState[position2.Row, position2.Column] = State.none;
            }
            if (currentPlayer.ghost1.GhostState[position.Row, position.Column] == State.red &&
                targetPlayer.ghost1.GhostState[position2.Row, position2.Column] == State.blue)
            {

                dungeon.DungeonGhosts(1);
                //
                rotation++;
                targetPlayer.ghost1.GhostState[position2.Row, position2.Column] = State.none;
            }
            if (currentPlayer.ghost1.GhostState[position.Row, position.Column] == State.yellow &&
                targetPlayer.ghost1.GhostState[position2.Row, position2.Column] == State.red)
            {
                dungeon.DungeonGhosts(3);
                rotation++;
                targetPlayer.ghost1.GhostState[position2.Row, position2.Column] = State.none;
            }
            //
            if (rotation > 3) rotation = 0;
        }
    }
}
