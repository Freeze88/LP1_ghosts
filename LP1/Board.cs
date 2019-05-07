using System;
using System.Collections.Generic;
using System.Text;

namespace LP1
{
    public class Board
    {
        public State[,] state;
        private int[] colors = new int[5];

        public Board()
        {
            state = new State[5, 5];
            Colorous();
        }

        public State GetState(Position position)
        {
            return state[position.Row, position.Column];
        }

        public void Colorous()
        {
            int[,] colors = { {1, 2, 6, 1, 2 }, { 1, 4, 2, 4, 2 } , { 1, 2, 2, 1, 7 } , { 1, 4, 2, 4, 2 } , { 1, 2, 5, 1, 3 } };

            for (int j = 0; j < 5; j++)
            {
                for (int i = 0; i < 5; i++)
                {
                    switch (colors[j,i])
                    {
                        case 1: state[j, i] = State.blue; break;
                        case 2: state[j, i] = State.red; break;
                        case 3: state[j, i] = State.yellow; break;
                        case 4: state[j, i] = State.mirror; break;
                        case 5: state[j, i] = State.portalBlue; break;
                        case 6: state[j, i] = State.portalRed; break;
                        case 7: state[j, i] = State.portalYellow; break;
                    }
                }
            }
        }

        /*public State GetStateColor(int[] color)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(color[i]);

                /*switch (colors[i])
                {
                    case 1: state[0, i] = State.blue; break;
                    case 2: state[0, i] = State.red; break;
                    case 3: state[0, i] = State.yellow; break;
                    case 4: state[0, i] = State.mirror; break;
                }
            }
            return 0;
        }*/
    }
}
