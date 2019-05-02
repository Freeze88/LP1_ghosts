using System;
using System.Collections.Generic;
using System.Text;

namespace LP1
{
    class Player
    {
        private int blue_ghost;
        private int red_ghost;
        private int yellow_ghost;

        public Player(int blue, int red, int yellow)
        {
            this.blue_ghost = blue;
            this.red_ghost = red;
            this.yellow_ghost = yellow;
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
    }
}
