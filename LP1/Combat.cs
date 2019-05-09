using System;
using System.Collections.Generic;
using System.Text;

namespace LP1
{
    public class Combat
    {
        public int rotation = 0;
        public Dungeon dungeon = new Dungeon();

        public void StateChecker(Player currentPlayer, Player targetPlayer, Position position, Position position2)
        {
            if (currentPlayer.ghost1.GhostState[position.Row, position.Column] == State.blue &&
                targetPlayer.ghost1.GhostState[position2.Row, position2.Column] == State.red)
            {
                Console.WriteLine("Winner is Player1");
                dungeon.DungeonGhosts(2);
                rotation++;
                targetPlayer.ghost1.GhostState[position2.Row, position2.Column] = State.none;
            }
            if (currentPlayer.ghost1.GhostState[position.Row, position.Column] == State.red &&
                targetPlayer.ghost1.GhostState[position2.Row, position2.Column] == State.blue)
            {

                dungeon.DungeonGhosts(1);
                rotation++;
                Console.WriteLine("Winner is Player1");
                targetPlayer.ghost1.GhostState[position2.Row, position2.Column] = State.none;
            }
            if (currentPlayer.ghost1.GhostState[position.Row, position.Column] == State.yellow &&
                targetPlayer.ghost1.GhostState[position2.Row, position2.Column] == State.red)
            {
                dungeon.DungeonGhosts(3);
                rotation++;
                Console.WriteLine("Winner is Player1");
                targetPlayer.ghost1.GhostState[position2.Row, position2.Column] = State.none;
            }
            if (rotation > 3) rotation = 0;
        }
        public int GetRotation()
        {
            return rotation;
        }
    }
}
