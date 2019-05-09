using System;
using System.Collections.Generic;
using System.Text;

namespace LP1
{
    class Comparer
    {
        /// <summary>
        /// Checks if the player can put the ghost in the desired position
        /// </summary>
        /// <param name="targetPlayer">The player that is being checked</param>
        /// <param name="board">Gets all the information of the board</param>
        /// <param name="position">Gets the position that the user wants</param>
        /// <param name="color">Gets the color the user wants for the ghost</param>
        /// <returns></returns>
        public bool ComparePlayerToBoard(Player targetPlayer, Board board, Position position, int color)
        {
            //checks if the State of the position is none
            if (targetPlayer.ghost1.GhostState[position.Row, position.Column] == State.none)
            {
                //checks the color the user is blue and has less then 3 blue ghosts
                if (color == 1 && targetPlayer.blueGhosts < 3)
                {
                    //checks if the position of the board is also blue
                    if (board.state[position.Row, position.Column] == State.blue)
                    {
                        //Increments 1 to blue ghosts
                        targetPlayer.blueGhosts++;
                        //Sets the user state on that position to blue
                        targetPlayer.ghost1.GhostState[position.Row, position.Column] = State.blue;
                        //returns true
                        return true;
                    }
                    //If the condition is not met returns false
                    else return false;
                }
                //checks the color the user is red and has less then 3 red ghosts
                else if (color == 2 && targetPlayer.redGhosts < 3)
                {
                    //checks if the position of the board is also red
                    if (board.state[position.Row, position.Column] == State.red)
                    {
                        //Increments 1 to blue ghosts
                        targetPlayer.redGhosts++;
                        //Sets the user state on that position to red
                        targetPlayer.ghost1.GhostState[position.Row, position.Column] = State.red;
                        //returns true
                        return true;
                    }
                    //If the condition is not met returns false
                    else return false;
                }
                //checks the color the user is yellow and has less then 3 yellow ghosts
                else if (color == 3 && targetPlayer.yellowGhosts < 3)
                {
                    //checks if the position of the board is also yellow
                    if (board.state[position.Row, position.Column] == State.yellow)
                    {
                        //Increments 1 to blue ghosts
                        targetPlayer.yellowGhosts++;
                        //Sets the user state on that position to yellow
                        targetPlayer.ghost1.GhostState[position.Row, position.Column] = State.yellow;
                        //returns true
                        return true;
                    }
                    //If the condition is not met returns false
                    else return false;
                }
                //In case none of the conditions is true
                else
                {
                    //Checks if the color is more than 3 and gives the user a message
                    if (color > 3) Console.WriteLine("You can only pick 1, 2 or 3");
                    //Checks i the user already has 3 of a color
                    if (targetPlayer.blueGhosts >= 3 || targetPlayer.redGhosts >= 3 || targetPlayer.yellowGhosts >= 3) Console.WriteLine("You already have 3 ghosts of that color");
                    //returns false
                    return false;
                }
            }
            //In case the first condition is not met
            else return false;
        }
    }
}
