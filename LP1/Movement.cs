using System;
using System.Collections.Generic;
using System.Text;

namespace LP1
{
    class Movement
    {
        
        public void moveP1(Player player1)
        {
            Coordinates coordinates = new Coordinates();
            Console.WriteLine("Where's the ghost you want to move?");
            int position = Convert.ToInt32(Console.ReadLine());
            Position pos = coordinates.CheckPos(position);

            Console.WriteLine("Where do you want to put it?");
            position = Convert.ToInt32(Console.ReadLine());
            Position pos2 = coordinates.CheckPos(position);
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
        public void moveP2(Player player2)
        {
            Coordinates coordinates = new Coordinates();
            Console.WriteLine("Where's the ghost you want to move?");
            int position = Convert.ToInt32(Console.ReadLine());
            Position pos = coordinates.CheckPos(position);

            Console.WriteLine("Where do you want to put it?");
            position = Convert.ToInt32(Console.ReadLine());
            Position pos2 = coordinates.CheckPos(position);
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

        
    }
}
