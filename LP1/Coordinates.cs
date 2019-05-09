using System;
using System.Collections.Generic;
using System.Text;

namespace LP1
{
    /// <summary>
    /// This class convert the player input and stores them in a new Position
    /// </summary>
    class Coordinates
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public Position CheckPos(int position)
        {
            //
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
                //
                default: return null;
            }
        }
    }
}
