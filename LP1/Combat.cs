﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LP1
{
    public class Combat
    {
        
        public int rotation = 0;
        public Dungeon dungeon = new Dungeon();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="currentPlayer"></param>
        /// <param name="targetPlayer"></param>
        /// <param name="position"></param>
        /// <param name="position2"></param>
        public void StateChecker(Player currentPlayer, Player targetPlayer, Position position, Position position2)
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
