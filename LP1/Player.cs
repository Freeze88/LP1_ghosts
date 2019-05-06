using System;
using System.Collections.Generic;
using System.Text;

namespace LP1
{
    public class Player
    {
        public Position GetPosition(Board board)
        {
            Console.WriteLine("Choose the position you want to put your ghost (0/25) and the color");
            int position = Convert.ToInt32(Console.ReadLine());
            int ghost_color = Convert.ToInt32(Console.ReadLine());
            Position desiredCoordinate = PositionForNumber(position, ghost_color);
            return desiredCoordinate;
        }

        private Position PositionForNumber(int position, int color)
        {
            switch (position)
            {
                case 1: return new Position(0, 0, color); 
                case 2: return new Position(0, 1, color);
                case 3: return new Position(0, 2, color);
                case 4: return new Position(0, 3, color);
                case 5: return new Position(0, 4, color);

                case 6: return new Position(1, 0, color);
                case 7: return new Position(1, 1, color);
                case 8: return new Position(1, 2, color);
                case 9: return new Position(1, 3, color);
                case 10: return new Position(1, 4, color);

                case 11: return new Position(2, 0, color);
                case 12: return new Position(2, 1, color);
                case 13: return new Position(2, 2, color);
                case 14: return new Position(2, 3, color);
                case 15: return new Position(2, 4, color);

                case 16: return new Position(3, 0, color);
                case 17: return new Position(3, 1, color);
                case 18: return new Position(3, 2, color);
                case 19: return new Position(3, 3, color);
                case 20: return new Position(3, 4, color);

                case 21: return new Position(4, 0, color);
                case 22: return new Position(4, 1, color);
                case 23: return new Position(4, 2, color);
                case 24: return new Position(4, 3, color);
                case 25: return new Position(4, 4, color);

                default: return null;
            }
        }
    }
}
