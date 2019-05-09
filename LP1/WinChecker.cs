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
        public bool CheckNearExit(Player targetPlayer, Movement move, int playerNumber)
        {
            //
            int rotation = move.combat.rotation; 
            
            if (targetPlayer.ghost1.GhostState[0, 3] == State.red && rotation == 1 ||
                targetPlayer.ghost1.GhostState[1, 2] == State.red && rotation == 2 ||
                targetPlayer.ghost1.GhostState[0, 1] == State.red && rotation == 3)
            {
                if (rotation == 1) targetPlayer.ghost1.GhostState[0, 3] = State.none;
                if (rotation == 2) targetPlayer.ghost1.GhostState[1, 2] = State.none;
                if (rotation == 3) targetPlayer.ghost1.GhostState[0, 1] = State.none;

                targetPlayer.redGhosts --;
                Console.WriteLine("\n Player {0} wins", playerNumber);
            }

            if (targetPlayer.ghost1.GhostState[4, 1] == State.blue && rotation == 1 ||
                targetPlayer.ghost1.GhostState[3, 2] == State.blue && rotation == 2 ||
                targetPlayer.ghost1.GhostState[4, 3] == State.blue && rotation == 3)
            {
                if (rotation == 1) targetPlayer.ghost1.GhostState[4, 1] = State.none;
                if (rotation == 2) targetPlayer.ghost1.GhostState[3, 2] = State.none;
                if (rotation == 3) targetPlayer.ghost1.GhostState[4, 3] = State.none;

                targetPlayer.blueGhosts--;
                Console.WriteLine("\n Player {0} wins", playerNumber);
            }

            if (targetPlayer.ghost1.GhostState[3, 4] == State.yellow && rotation == 1 ||
                targetPlayer.ghost1.GhostState[2, 3] == State.yellow && rotation == 2 ||
                targetPlayer.ghost1.GhostState[1, 4] == State.yellow && rotation == 3)
            {
                if (rotation == 1) targetPlayer.ghost1.GhostState[3, 4] = State.none;
                if (rotation == 2) targetPlayer.ghost1.GhostState[2, 3] = State.none;
                if (rotation == 3) targetPlayer.ghost1.GhostState[1, 4] = State.none;

                targetPlayer.yellowGhosts--;
                Console.WriteLine("\n Player {0} wins", playerNumber);
            }
            Console.WriteLine(targetPlayer.redGhosts);
            Console.WriteLine(targetPlayer.blueGhosts);
            Console.WriteLine(targetPlayer.yellowGhosts);
            if (targetPlayer.redGhosts <= 0 || targetPlayer.blueGhosts <= 0 ||
                targetPlayer.yellowGhosts <= 0) return false;
            return true;
        }
    }
}
