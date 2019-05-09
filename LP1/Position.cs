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
        //Gets the y given
        public int Row { get; }
        //gets the x given
        public int Column { get; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="row">Gets the x given</param>
        /// <param name="column">Gets the y given</param>
        public Position(int row, int column)
        {
            //Sets this Row to the value given
            Row = row;
            //Sets this Column to the value given
            Column = column;
        }
    }
}
