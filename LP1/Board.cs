using System;
using System.Collections.Generic;
using System.Text;

namespace LP1
{
    /// <summary>
    /// This class creats a new State and saves the colors of each position
    /// </summary>
    public class Board
    {
        /// <summary>
        /// 
        /// </summary>
        public State[,] state;
        /// <summary>
        /// 
        /// </summary>
        public Board()
        {
            //
            state = new State[5, 5];
            //
            Colorous();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public State GetState(Position position)
        {
            //
            return state[position.Row, position.Column];
        }

        /// <summary>
        /// 
        /// </summary>
        public void Colorous()
        {
            //
            int[,] colors = { { 1, 2, 5, 1, 2 }, { 3, 4, 3, 4, 3 }, 
                { 2, 1, 2, 1, 5 }, { 1, 4, 3, 4, 2 }, { 3, 2, 5, 1, 3 } };

            //
            for (int j = 0; j < 5; j++)
            {
                //
                for (int i = 0; i < 5; i++)
                {
                    //
                    switch (colors[j, i])
                    {
                        case 1: state[j, i] = State.blue; break;
                        case 2: state[j, i] = State.red; break;
                        case 3: state[j, i] = State.yellow; break;
                        case 4: state[j, i] = State.mirror; break;
                        case 5: state[j, i] = State.portal; break;
                    }

                }
            }
        }
    }
}
