using System;
using System.Collections.Generic;
using System.Text;

namespace LP1
{
    public class Combat
    {
        public void StateChecker(Player player1, Player player2, Position position, Position position2)
        {

            if (player1.ghost1.GhostState[position.Row, position.Column] == State.blue && player2.ghost1.GhostState[position2.Row, position2.Column] == State.red)
            {
                Console.WriteLine("Winner is Player1");
                player2.ghost1.GhostState[position2.Row, position2.Column] = State.none;
            }
            if (player1.ghost1.GhostState[position.Row, position.Column] == State.red && player2.ghost1.GhostState[position2.Row, position2.Column] == State.blue)
            {
                Console.WriteLine("Winner is Player1");
                player2.ghost1.GhostState[position2.Row, position2.Column] = State.none;
            }
            if (player1.ghost1.GhostState[position.Row, position.Column] == State.yellow && player2.ghost1.GhostState[position2.Row, position2.Column] == State.red)
            {
                Console.WriteLine("Winner is Player1");
                player2.ghost1.GhostState[position2.Row, position2.Column] = State.none;
            }

            if (player2.ghost1.GhostState[position.Row, position.Column] == State.blue && player1.ghost1.GhostState[position2.Row, position2.Column] == State.red)
            {
                Console.WriteLine("Winner is Player2");
                player1.ghost1.GhostState[position2.Row, position2.Column] = State.none;
            }
            if (player2.ghost1.GhostState[position.Row, position.Column] == State.red && player1.ghost1.GhostState[position2.Row, position2.Column] == State.blue)
            {
                Console.WriteLine("Winner is Player2");
                player1.ghost1.GhostState[position2.Row, position2.Column] = State.none;
            }
            if (player2.ghost1.GhostState[position.Row, position.Column] == State.yellow && player1.ghost1.GhostState[position2.Row, position2.Column] == State.red)
            {
                Console.WriteLine("Winner is Player2");
                player1.ghost1.GhostState[position2.Row, position2.Column] = State.none;
            }
        }
    }
}
