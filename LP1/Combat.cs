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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="player1"></param>
        /// <param name="player2"></param>
        /// <param name="position"></param>
        /// <param name="position2"></param>
        public void StateChecker(Player player1, Player player2, Position position, Position position2)
        {
            //
            if (player1.ghost1.GhostState[position.Row, position.Column] == State.blue &&
                player2.ghost1.GhostState[position2.Row, position2.Column] == State.red)
            {
                //
                rotation++;
                //Print this message if player 1 wins the combat
                Console.WriteLine("Winner is Player1");
                //
                player2.ghost1.GhostState[position2.Row, position2.Column] = State.none;
            }
            //
            if (player1.ghost1.GhostState[position.Row, position.Column] == State.red &&
                player2.ghost1.GhostState[position2.Row, position2.Column] == State.blue)
            {
                //
                rotation++;
                //Print this message if player 1 wins the combat
                Console.WriteLine("Winner is Player1");
                //
                player2.ghost1.GhostState[position2.Row, position2.Column] = State.none;
            }
            //
            if (player1.ghost1.GhostState[position.Row, position.Column] == State.yellow &&
                player2.ghost1.GhostState[position2.Row, position2.Column] == State.red)
            {
                //
                rotation++;
                //Print this message if player 1 wins the combat
                Console.WriteLine("Winner is Player1");
                //
                player2.ghost1.GhostState[position2.Row, position2.Column] = State.none;
            }
            //
            if (rotation > 3) rotation = 0;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int GetRotation()
        {
            //
            return rotation;
        }
    }
}
