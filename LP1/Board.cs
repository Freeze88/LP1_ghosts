using System;
using System.Collections.Generic;
using System.Text;

namespace LP1
{
    public class Board
    {
        //Creates an bi-demensional Array
        public State[,] state;

        /// <summary>
        /// Gives the Array a size and calls a function
        /// </summary>
        public Board()
        {
            //Gives a value of 5 by 5 to the array
            state = new State[5, 5];
            //Calls Colourus
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
        /// Gives the board all the correct states acording to the array colors
        /// </summary>
        public void Colorous()
        {
            //Creates an Array with all the colors on the board
            int[,] colors = { { 1, 2, 5, 1, 2 }, { 3, 4, 3, 4, 3 }, 
                { 2, 1, 2, 1, 5 }, { 1, 4, 3, 4, 2 }, { 3, 2, 5, 1, 3 } };

            //A for loop the y of the field
            for (int j = 0; j < 5; j++)
            {
                //A loop for the x of the field
                for (int i = 0; i < 5; i++)
                {
                    //Sets the State depending on the Array colors
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
