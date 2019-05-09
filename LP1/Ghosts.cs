using System;
using System.Collections.Generic;
using System.Text;

namespace LP1
{
    /// <summary>
    /// This class creats a new State and saves it
    /// </summary>
    public class Ghosts
    {
        //Creates a bi-demsional Array
        public State[,] GhostState;
        /// <summary>
        /// Gives the Array a size
        /// </summary>
        public Ghosts()
        {
            //Gives a value of 5 by 5 to the array
            GhostState = new State[5, 5];
        }
        /// <summary>
        /// Gets the state of the ghost in the position given
        /// </summary>
        /// <param name="position"></param>
        /// <returns>A position (x,y)</returns>
        public State GetState(Position position)
        {
            //Returns the State of the ghost in that position
            return GhostState[position.Row, position.Column];
        }
    }
}
