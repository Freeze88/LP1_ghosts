using System;
using System.Collections.Generic;
using System.Text;

namespace LP1
{

    public class Ghosts
    {
        public State[,] GhostState;
        
        public Ghosts()
        {
            GhostState = new State[5, 5];
        }

        public State GetState(Position position)
        {
            return GhostState[position.Row, position.Column];
        }
    }
}
