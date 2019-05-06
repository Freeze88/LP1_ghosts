using System;
using System.Collections.Generic;
using System.Text;

namespace LP1
{
    public class Board
    {
        private State[,] state;
        public State NextTurn { get; private set; }

        public Board()
        {
            state = new State[5, 5];
        }

        public State GetState(Position position)
        {

            Console.WriteLine(state);
            return state[position.Row, position.Column];

        }
    }
}
