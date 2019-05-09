using System;
using System.Collections.Generic;
using System.Text;

namespace LP1
{
    //Constructor of the Dunfeon class
    public class Dungeon
    {
        //Declares an Arrary of integers
        public int[] numberOfGhosts = new int[16];
        /// <summary>
        /// Checks the array for the first 0 and puts the color in there
        /// </summary>
        /// <param name="color">Gets the color the was sent to the dungeon</param>
        public void DungeonGhosts(int color)
        {
            //A for loop the size of the Array
            for (int a = 0; a < numberOfGhosts.Length; a++)
            {
                //Checks if the position of the array is 0
                if (numberOfGhosts[a] == 0)
                {
                    //Sets that array number to the number of the color given
                    numberOfGhosts[a] = color;
                }
            }
        }
        /// <summary>
        /// Checks if the dungeon has the color the user wants
        /// </summary>
        /// <param name="color">Gets the color that the user wants</param>
        /// <returns>true or false</returns>
        public bool RetriveDungeons(int color)
        {
            //A for loop the size of the Array
            for (int a = 0; a < numberOfGhosts.Length; a++)
            {
                //Checks if the position of the array is the same as the color
                if (numberOfGhosts[a] == color)
                {
                    //sets the array number to 0
                    numberOfGhosts[a] = 0;
                    //returns true
                    return true;
                }
                //If the array doesn't have the color given
                else if (numberOfGhosts[a] != color)
                {
                    //Sends the user a message
                    Console.WriteLine("There's no ghost of that color");
                    //returns false
                    return false;
                }
            }
            //default return false
            return false;
        }
    }
}
