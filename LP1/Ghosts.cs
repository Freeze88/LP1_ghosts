using System;
using System.Collections.Generic;
using System.Text;

namespace LP1
{
    /// <summary>
    /// This class creats a new State and saves 
    /// </summary>
    public class Ghosts
    {
        /// <summary>
        /// 
        /// </summary>
        public State[,] GhostState;
        /// <summary>
        /// 
        /// </summary>
        public Ghosts()
        {
            //
            GhostState = new State[5, 5];
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public State GetState(Position position)
        {
            //
            return GhostState[position.Row, position.Column];
        }
    }
}
