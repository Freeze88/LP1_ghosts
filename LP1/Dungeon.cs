using System;
using System.Collections.Generic;
using System.Text;

namespace LP1
{
    public class Dungeon
    {
        public int[] numberOfGhosts = new int[16];
        
        public void DungeonGhosts(int color)
        {
            for (int a = 0; a < 16; a++)
            {
                if (numberOfGhosts[a] == 0)
                {
                    numberOfGhosts[a] = color;
                }
            }
        }

        public bool RetriveDungeons(int color)
        {
            for (int a = 0; a < numberOfGhosts.Length; a++)
            {
                Console.WriteLine(numberOfGhosts[a]);
                if (numberOfGhosts[a] == color)
                {
                    numberOfGhosts[a] = 0;
                    return true;
                }
                else if (numberOfGhosts[a] != color)
                {
                    Console.WriteLine("There's no ghost of that color");
                    return false;
                }
            }
            return false;
        }
    }
}
