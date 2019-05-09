using System;
using System.Collections.Generic;
using System.Text;

namespace LP1
{
    public class Player
    {
        Board board = new Board();
        public Combat combat= new Combat();
        public Ghosts ghost1 = new Ghosts();
        Comparer comparer = new Comparer();

        public int blueGhosts = 0;
        public int redGhosts = 0;
        public int yellowGhosts = 0;
        bool canPlace = true;

        public Position GetPosition(Player targetPlayer, Ghosts ghost, bool Start)
        {
            Coordinates coordinates = new Coordinates();

            int position = Convert.ToInt32(Console.ReadLine());
            int ghost_color = Convert.ToInt32(Console.ReadLine());
            Position desiredCoordinate = coordinates.CheckPos(position);

            if (!Start) canPlace = combat.dungeon.RetriveDungeons(ghost_color);

            if (canPlace)
            {
                canPlace = comparer.ComparePlayerToBoard(targetPlayer, board, desiredCoordinate, ghost_color);

                while (canPlace != true)
                {
                    Console.WriteLine("Please choose a valid place to put your ghost");
                    ghost1.GhostState[desiredCoordinate.Row, desiredCoordinate.Column] = State.none;
                    GetPosition(targetPlayer, ghost, Start);
                }
                return desiredCoordinate;
            }
            return null;
        }

    }
}
