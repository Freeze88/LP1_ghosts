using System;
using System.Collections.Generic;
using System.Text;

namespace LP1
{
    class Player
    {
        private int blue_ghost;
        private int[,] blue_position = new int[6,2];

        private int red_ghost;
        private int[] red_position;

        private int yellow_ghost;
        private int[] yellow_position;

        public Player(int blue, int red, int yellow)
        {
            this.blue_ghost = blue;
            this.red_ghost = red;
            this.yellow_ghost = yellow;
        }

        public void Positions(int pos1, int pos2, int arrayN)
        {
            //blue_position = new int[b,c] {{ pos1, pos2 }, { pos1, pos2 }, { pos1, pos2 } };
            blue_position[arrayN, 0] = pos1;
            blue_position[arrayN, 1] = pos2;
        }

        public int GetGhostsBlue()
        {
            return blue_ghost;
        }
        public int GetGhostsRed()
        {
            return red_ghost;
        }
        public int GetGhostsYellow()
        {
            return yellow_ghost;
        }
        public void Update(int blue, int red, int yellow)
        {
            this.blue_ghost = blue;
            this.red_ghost = red;
            this.yellow_ghost = yellow;
        }
        public int getPos(int i, int c)
        {
            return blue_position[i,c];
        }
    }
}
