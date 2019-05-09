using System;
using System.Collections.Generic;
using System.Text;

namespace LP1
{
    /// <summary>
    /// This class creat a new Position
    /// </summary>
    public class Position
    {
        //
        public int Row { get; }
        //
        public int Column { get; }
        //
        public Position(int row, int column)
        {
            //
            Row = row;
            //
            Column = column;
        }
    }
}
