using System;
using System.Collections.Generic;
using System.Text;

namespace LP1
{
    class Movement
    {
        public Combat combat = new Combat();
        public void MoveP1(Player player1, Player player2)
        {
            Console.WriteLine("Where's the ghost you want to move?");
            int position = Convert.ToInt32(Console.ReadLine());
            Position pos = CheckPos(position);

            Console.WriteLine("Where do you want to put it?");
            position = Convert.ToInt32(Console.ReadLine());
            Position pos2 = CheckPos(position);
            if (player1.ghost1.GhostState[pos.Row, pos.Column] != State.none)
            {
                player1.ghost1.GhostState[pos2.Row, pos2.Column] = player1.ghost1.GhostState[pos.Row, pos.Column];
                player1.ghost1.GhostState[pos.Row, pos.Column] = State.none;
            }
            else
            {
                Console.WriteLine("You don't have a ghost there");
            }

        }
        public void MoveP2(Player player1, Player player2)
        {
            Console.WriteLine("Where's the ghost you want to move?");
            int position = Convert.ToInt32(Console.ReadLine());
            Position pos = CheckPos(position);

            Console.WriteLine("Where do you want to put it?");
            position = Convert.ToInt32(Console.ReadLine());
            Position pos2 = CheckPos(position);

            combat.StateChecker(player1, player2);
            if (player2.ghost1.GhostState[pos.Row, pos.Column] != State.none)
            {
                player2.ghost1.GhostState[pos2.Row, pos2.Column] = player2.ghost1.GhostState[pos.Row, pos.Column];
                player2.ghost1.GhostState[pos.Row, pos.Column] = State.none;
            }
            else
            {
                Console.WriteLine("You don't have a ghost there");
            }
        }

        public Position CheckPos(int position)
        {
            switch (position)
            {
                case 1: return new Position(0, 0);
                case 2: return new Position(0, 1);
                case 3: return new Position(0, 2);
                case 4: return new Position(0, 3);
                case 5: return new Position(0, 4);

                case 6: return new Position(1, 0);
                case 7: return new Position(1, 1);
                case 8: return new Position(1, 2);
                case 9: return new Position(1, 3);
                case 10: return new Position(1, 4);

                case 11: return new Position(2, 0);
                case 12: return new Position(2, 1);
                case 13: return new Position(2, 2);
                case 14: return new Position(2, 3);
                case 15: return new Position(2, 4);

                case 16: return new Position(3, 0);
                case 17: return new Position(3, 1);
                case 18: return new Position(3, 2);
                case 19: return new Position(3, 3);
                case 20: return new Position(3, 4);

                case 21: return new Position(4, 0);
                case 22: return new Position(4, 1);
                case 23: return new Position(4, 2);
                case 24: return new Position(4, 3);
                case 25: return new Position(4, 4);
                default: return null;
            }
        }
    }
}
