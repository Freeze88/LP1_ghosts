using System;
using System.Collections.Generic;
using System.Text;

namespace LP1
{
    public class Player
    {
        public Position GetPosition(Board board)
        {
            int position = Convert.ToInt32(Console.ReadKey());
            int ghost_color = Convert.ToInt32(Console.ReadKey());
            Position desiredCoordinate = PositionForNumber(position);
            compare(board);
            return desiredCoordinate;
        }

        private Position PositionForNumber(int position)
        {
            
            switch (position)
            {
                case 1: return new Position(2, 0); 
                case 2: return new Position(2, 1);
                default:return null;
            }
        }

        private void compare(Board board)
        {
            if (board.state[1, 1] == State.blue)
            {
            }

        }
    }
}
