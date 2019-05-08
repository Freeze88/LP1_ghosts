using System;
using System.Collections.Generic;
using System.Text;

namespace LP1
{
    public class WinChecker
    {
        public bool CheckNearExit(Player player1, Player player2)
        {
            if (player1.ghost1.GhostState[0,2] == State.red || 
                player1.ghost1.GhostState[0, 4] == State.red ||
                player1.ghost1.GhostState[1, 3] == State.red )
            {
                Console.WriteLine("Player 1 wins");
                return false;
            }

            if (player2.ghost1.GhostState[0, 2] == State.red ||
                player2.ghost1.GhostState[0, 4] == State.red ||
                player2.ghost1.GhostState[1, 3] == State.red)
            {
                Console.WriteLine("Player 2 wins");
                return false;
            }
            return true;
        }
    }
}
