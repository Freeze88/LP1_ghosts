using System;
using System.Collections.Generic;
using System.Text;

namespace LP1
{
    public class WinChecker
    {
        public bool CheckNearExit(Player player1, Player player2, Movement move)
        {
            int rotation = move.combat.rotation; 

            Console.WriteLine(rotation);
            if (player1.ghost1.GhostState[0, 4] == State.red && rotation == 1 ||
                player1.ghost1.GhostState[1, 3] == State.red && rotation == 2 ||
                player1.ghost1.GhostState[0, 2] == State.red && rotation == 3)
            {
                Console.WriteLine("Player 1 wins");
                return false;
            }
            if (player1.ghost1.GhostState[4, 1] == State.blue && rotation == 1 ||
                player1.ghost1.GhostState[3, 2] == State.blue && rotation == 2 ||
                player1.ghost1.GhostState[4, 3] == State.blue && rotation == 3)
            {
                Console.WriteLine("Player 1 wins");
                return false;
            }
            if (player1.ghost1.GhostState[3, 4] == State.yellow && rotation == 1 ||
                player1.ghost1.GhostState[2, 3] == State.yellow && rotation == 2 ||
                player1.ghost1.GhostState[1, 4] == State.yellow && rotation == 3)
            {
                Console.WriteLine("Player 1 wins");
                return false;
            }
            return true;
        }
    }
}
