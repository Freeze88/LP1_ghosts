using System;
using System.Collections.Generic;
using System.Text;

namespace LP1
{
    public class Movement
    {
        public Combat combat = new Combat();

        public void Move(Player player1, Player player2)
        {
            Coordinates coordinates = new Coordinates();

            Console.WriteLine("Where's the ghost you want to move?");
            int position = Convert.ToInt32(Console.ReadLine());
            Position pos = coordinates.CheckPos(position);

            Console.WriteLine("Where do you want to put it?");
            int position2 = Convert.ToInt32(Console.ReadLine());
            if (position + 5 == position2 || position - 5 == position2 ||
                position + 1 == position2 || position - 1 == position2)
            {

                Position pos2 = coordinates.CheckPos(position);
                combat.StateChecker(player1, player2, pos, pos2);

                if (player1.ghost1.GhostState[pos.Row, pos.Column] != State.none &&
                    player1.ghost1.GhostState[pos2.Row, pos2.Column] !=
                    player1.ghost1.GhostState[pos.Row, pos.Column])
                {
                    player1.ghost1.GhostState[pos2.Row, pos2.Column] = player1.ghost1.GhostState[pos.Row, pos.Column];
                    player1.ghost1.GhostState[pos.Row, pos.Column] = State.none;
                }
            }
            else Console.WriteLine("You can only move 1 at a time");
        }
    }
}
