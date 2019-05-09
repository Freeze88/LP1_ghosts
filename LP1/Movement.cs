using System;
using System.Collections.Generic;
using System.Text;

namespace LP1
{
    public class Movement
    {
        public Combat combat = new Combat();
        private Coordinates coordinates = new Coordinates();

        public void Move(Player currentPlayer, Player targetPlayer)
        {
            Console.WriteLine("Where's the ghost you want to move?");
            int position = Convert.ToInt32(Console.ReadLine());
            Position pos = coordinates.CheckPos(position);

            Console.WriteLine("Where do you want to put it?");
            int position2 = Convert.ToInt32(Console.ReadLine());

            if (position2 == 8) position = position - 5;
            else if (position2 == 6) position = position + 1;
            else if (position2 == 2) position = position + 5;
            else if (position2 == 4) position = position - 1;
            else Move(currentPlayer, targetPlayer);
            
            if (position == 7) position = 19;
            else if (position == 9) position = 17;
            else if (position == 19) position = 7;
            else if (position == 17) position = 9;

            if (position <= 0 || position > 25) Console.WriteLine("You cannot move a ghost outside the board");
            else if (position == 3 || position == 15 || position == 23) Console.WriteLine("You cannot move a ghost to a portal");
            else
            {
                Position pos2 = coordinates.CheckPos(position);

                combat.StateChecker(currentPlayer, targetPlayer, pos, pos2);

                if (currentPlayer.ghost1.GhostState[pos.Row, pos.Column] != State.none &&
                    currentPlayer.ghost1.GhostState[pos2.Row, pos2.Column] !=
                    currentPlayer.ghost1.GhostState[pos.Row, pos.Column])
                {
                    currentPlayer.ghost1.GhostState[pos2.Row, pos2.Column] = currentPlayer.ghost1.GhostState[pos.Row, pos.Column];
                    currentPlayer.ghost1.GhostState[pos.Row, pos.Column] = State.none;
                }
                else Console.WriteLine("You either don't have a ghost there or it's the same color");
            }
        }
    }
}
