using System;
using System.Collections.Generic;
using System.Text;

namespace LP1
{
    public class Start
    {
        Position posP1, posP2;

        public void SetStartPositions(Player player1, Player player2, Ghosts ghosts, int i)
        {
            if (i != 1)
            {
                Console.WriteLine("First choose a position: 1 - 25\nThen choose a color:\n1 - blue\n2 - red\n3 - Yellow");
                Console.WriteLine("Player 1 Turn:");
                posP1 = player1.GetPosition(player1, ghosts, true);
                while (player1.ghost1.GhostState[posP1.Row, posP1.Column]
                    == player2.ghost1.GhostState[posP1.Row, posP1.Column])
                {
                    Console.WriteLine("There's already a player there");
                    player1.ghost1.GhostState[posP1.Row, posP1.Column] = State.none;
                    posP1 = player1.GetPosition(player1, ghosts, true);
                }
            }

            Console.WriteLine("Player 2 Turn:");
            posP2 = player2.GetPosition(player2, ghosts, true);

            while (player1.ghost1.GhostState[posP2.Row, posP2.Column]
                == player2.ghost1.GhostState[posP2.Row, posP2.Column])
            {
                Console.WriteLine("There's already a player there");
                player2.ghost1.GhostState[posP2.Row, posP2.Column] = State.none;
                posP2 = player2.GetPosition(player2, ghosts, true);
            }

        }
    }
}
