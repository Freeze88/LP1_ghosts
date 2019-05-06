using System;
using System.Collections.Generic;
using System.Text;

namespace LP1
{
    public class Position
    {
        public int Row { get; }
        public int Column { get; }
        public int Color { get; }

        public Position(int row, int column, int color)
        {
            Row = row;
            Column = column;
            Color = color;
        }
    }
}
