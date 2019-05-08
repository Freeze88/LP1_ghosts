using System;
using System.Collections.Generic;
using System.Text;

namespace LP1
{
    public class Player
    {
        bool checkIfMatch;
        int ghost_color;
        Board board = new Board();
        public Ghosts ghost1 = new Ghosts();
        int blueGhosts = 0;
        int redGhosts = 0;
        int yellowGhosts = 0;

        public Position GetPosition(Ghosts ghost)
        {
            int position = Convert.ToInt32(Console.ReadLine());
            ghost_color = Convert.ToInt32(Console.ReadLine());
            Position desiredCoordinate = PositionForNumber(position);

            compare(board, desiredCoordinate, ghost_color);

            while (checkIfMatch != true)
            {
                Console.WriteLine("Please choose a valid place to put your ghost");
                GetPosition(ghost);
            }
            return desiredCoordinate;
        }

        private Position PositionForNumber(int position)
        {
            switch (position)
            {
                case 1: return new Position(0, 0); 
                case 2: return new Position(0, 1);
                case 3: return new Position(0, 2);
                case 4: return new Position(0, 3);
                case 5: return new Position(0, 4);

                case 6: return new Position(1, 0);
                case 7: return new Position(1, 1);
                case 8: return new Position(1, 2);
                case 9: return new Position(1, 3);
                case 10: return new Position(1, 4);

                case 11: return new Position(2, 0);
                case 12: return new Position(2, 1);
                case 13: return new Position(2, 2);
                case 14: return new Position(2, 3);
                case 15: return new Position(2, 4);

                case 16: return new Position(3, 0);
                case 17: return new Position(3, 1);
                case 18: return new Position(3, 2);
                case 19: return new Position(3, 3);
                case 20: return new Position(3, 4);

                case 21: return new Position(4, 0);
                case 22: return new Position(4, 1);
                case 23: return new Position(4, 2);
                case 24: return new Position(4, 3);
                case 25: return new Position(4, 4);
                default:return null;
            }
        }

        public void compare(Board board, Position position, int color)
        {
            if (ghost1.GhostState[position.Row, position.Column] == State.none)
            {
                if (color == 1 && blueGhosts < 3) // checks if the specific coordinate == the color of the ghost
                {
                    if (board.state[position.Row, position.Column] == State.blue )
                    {
                        blueGhosts++;
                        ghost1.GhostState[position.Row, position.Column] = State.blue;
                        checkIfMatch = true;
                    }
                    else checkIfMatch = false;
                }

                else if (color == 2 && redGhosts < 3)
                {
                    if (board.state[position.Row, position.Column] == State.red )
                    {
                        redGhosts++;
                        ghost1.GhostState[position.Row, position.Column] = State.red;
                        checkIfMatch = true;
                    }
                    else checkIfMatch = false;
                }

                else if (color == 3 && yellowGhosts < 3)
                {
                    if (board.state[position.Row, position.Column] == State.yellow )
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
                    if (blueGhosts >= 3 || redGhosts >= 3 || yellowGhosts >= 3) Console.WriteLine("You already have 3 ghosts of that color");
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
