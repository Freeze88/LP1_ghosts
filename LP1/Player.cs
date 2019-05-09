using System;
using System.Collections.Generic;
using System.Text;

namespace LP1
{
    public class Player
    {
        Board board = new Board();
        public Ghosts ghost1 = new Ghosts();

        private int blueGhosts = 0;
        private int redGhosts = 0;
        private int yellowGhosts = 0;
        private bool checkIfMatch;

        public Position GetPosition(Ghosts ghost)
        {
            Coordinates coordinates = new Coordinates();

            int position = Convert.ToInt32(Console.ReadLine());
            int ghost_color = Convert.ToInt32(Console.ReadLine());
            Position desiredCoordinate = coordinates.CheckPos(position);

            Compare(board, desiredCoordinate, ghost_color);

            while (checkIfMatch != true)
            {
                Console.WriteLine("Please choose a valid place to put your ghost");
                GetPosition(ghost);
            }
            return desiredCoordinate;
        }
        public void Compare(Board board, Position position, int color)
        {
            if (ghost1.GhostState[position.Row, position.Column] == State.none)
            {
                if (color == 1 && blueGhosts < 3) // checks if the specific coordinate == the color of the ghost
                {
                    if (board.state[position.Row, position.Column] == State.blue)
                    {
                        blueGhosts++;
                        ghost1.GhostState[position.Row, position.Column] = State.blue;
                        checkIfMatch = true;
                    }
                    else checkIfMatch = false;
                }
                else if (color == 2 && redGhosts < 3)
                {
                    if (board.state[position.Row, position.Column] == State.red)
                    {
                        redGhosts++;
                        ghost1.GhostState[position.Row, position.Column] = State.red;
                        checkIfMatch = true;
                    }
                    else checkIfMatch = false;
                }
                else if (color == 3 && yellowGhosts < 3)
                {
                    if (board.state[position.Row, position.Column] == State.yellow)
                    {
                        yellowGhosts++;
                        ghost1.GhostState[position.Row, position.Column] = State.yellow;
                        checkIfMatch = true;
                    }
                    else checkIfMatch = false;
                }
                else
                {
                    if (color > 3) Console.WriteLine("You can only pick 1,2 or 3");
                    if (blueGhosts >= 3 || redGhosts >= 3 || yellowGhosts >= 3)
                        Console.WriteLine("You already have 3 ghosts of that color");
                    checkIfMatch = false;
                }
            }
            else
            {
                Console.WriteLine("yha cannot do that");
                checkIfMatch = false;
            }
        }
    }
}
