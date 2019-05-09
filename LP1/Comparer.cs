using System;
using System.Collections.Generic;
using System.Text;

namespace LP1
{
    class Comparer
    {
        public bool ComparePlayerToBoard(Player targetPlayer, Board board, Position position, int color)
        {
            if (targetPlayer.ghost1.GhostState[position.Row, position.Column] == State.none)
            {
                if (color == 1 && targetPlayer.blueGhosts < 3) // checks if the specific coordinate == the color of the ghost
                {
                    if (board.state[position.Row, position.Column] == State.blue)
                    {
                        targetPlayer.blueGhosts++;
                        targetPlayer.ghost1.GhostState[position.Row, position.Column] = State.blue;
                        return true;
                    }
                    else return false;
                }
                else if (color == 2 && targetPlayer.redGhosts < 3)
                {
                    if (board.state[position.Row, position.Column] == State.red)
                    {
                        targetPlayer.redGhosts++;
                        targetPlayer.ghost1.GhostState[position.Row, position.Column] = State.red;
                        return true;
                    }
                    else return false;
                }
                else if (color == 3 && targetPlayer.yellowGhosts < 3)
                {
                    if (board.state[position.Row, position.Column] == State.yellow)
                    {
                        targetPlayer.yellowGhosts++;
                        targetPlayer.ghost1.GhostState[position.Row, position.Column] = State.yellow;
                        return true;
                    }
                    else return false;
                }
                else
                {
                    if (color > 3) Console.WriteLine("You can only pick 1, 2 or 3");
                    if (targetPlayer.blueGhosts >= 3 || targetPlayer.redGhosts >= 3 || targetPlayer.yellowGhosts >= 3) Console.WriteLine("You already have 3 ghosts of that color");
                    return false;
                }
            }
            else return false;
        }
    }
}
