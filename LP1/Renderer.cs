using System;
using System.Collections.Generic;
using System.Text;

namespace LP1
{

    public class Renderer
    {
        public void Render(Board board)
        {
            char[,] symbols = new char[5, 5];

            for (int row = 0; row < 5; row++)
                for (int column = 0; column < 5; column++)
                    symbols[row, column] = SymbolFor(board.GetState(new Position(row, column)));


            Console.WriteLine(" +---+---+---+---+---+");
            Console.WriteLine($" | {symbols[0, 0]} | {symbols[0, 1]} | {symbols[0, 2]} | {symbols[0, 3]} | {symbols[0, 4]} |");
            Console.WriteLine(" +---+---+---+---+---+");
            Console.WriteLine($" | {symbols[1, 0]} | {symbols[1, 1]} | {symbols[1, 2]} | {symbols[1, 3]} | {symbols[1, 4]} |");
            Console.WriteLine(" +---+---+---+---+---+");
            Console.WriteLine($" | {symbols[2, 0]} | {symbols[2, 1]} | {symbols[2, 2]} | {symbols[2, 3]} | {symbols[2, 4]} |");
            Console.WriteLine(" +---+---+---+---+---+");
            Console.WriteLine($" | {symbols[3, 0]} | {symbols[3, 1]} | {symbols[3, 2]} | {symbols[3, 3]} | {symbols[3, 4]} |");
            Console.WriteLine(" +---+---+---+---+---+");
            Console.WriteLine($" | {symbols[4, 0]} | {symbols[4, 1]} | {symbols[4, 2]} | {symbols[4, 3]} | {symbols[4, 4]} |");
            Console.WriteLine(" +---+---+---+---+---+");

        }

        private char SymbolFor(State state)
        {
            switch (state)
            {

                case State.blue:
                {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        return 'b';
                }
                case State.red:
                {
                        Console.ForegroundColor = ConsoleColor.Red;
                        return 'r';
                }
                case State.yellow:
                {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        return 'y';
                }
                case State.mirror:
                {
                        Console.ResetColor();
                        return 'm';
                }
                case State.portalBlue:
                    {
                        
                        return 'p';
                    }
                case State.portalRed:
                    {
                        Console.ResetColor();
                        return 'p';
                    }
                case State.portalYellow:
                    {
                        Console.ResetColor();
                        return 'p';
                    }
                default: return ' ';
            }
        }

    }
}
