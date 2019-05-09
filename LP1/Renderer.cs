using System;
using System.Collections.Generic;
using System.Text;
                                                                                     
namespace LP1
{

    public class Renderer
    {
        public void Render(Board board,Player player1, Player player2)
        {
            string[,] symbols = new string[5, 5];

            for (int row = 0; row < 5; row++)
                for (int column = 0; column < 5; column++)
                {
                    symbols[row, column] = SymbolFor(board.GetState(new Position(row, column)));
                    //SymbolForPlayer1[row, column] = SymbolForP1(player1.ghost1.GhostState(new Position(row, column)));
                }

            /*
            Console.WriteLine(" +---+---+---+---+---+");
            Console.WriteLine($" |player1 {player1.ghost1.GhostState[0,0]}player2 {player2.ghost1.GhostState[0, 0]} {symbols[0,0]} | {symbols[0, 1]} | {symbols[0, 2]} | {symbols[0, 3]} | {symbols[0, 4]} |");
            Console.WriteLine(" +---+---+---+---+---+");
            Console.WriteLine($" | {symbols[1, 0]} | {symbols[1, 1]} | {symbols[1, 2]} | {symbols[1, 3]} | {symbols[1, 4]} |");
            Console.WriteLine(" +---+---+---+---+---+");
            Console.WriteLine($" | {symbols[2, 0]} | {symbols[2, 1]} | {symbols[2, 2]} | {symbols[2, 3]} | {symbols[2, 4]} |");
            Console.WriteLine(" +---+---+---+---+---+");
            Console.WriteLine($" | {symbols[3, 0]} | {symbols[3, 1]} | {symbols[3, 2]} | {symbols[3, 3]} | {symbols[3, 4]} |");
            Console.WriteLine(" +---+---+---+---+---+");
            Console.WriteLine($" | {symbols[4, 0]} | {symbols[4, 1]} | {symbols[4, 2]} | {symbols[4, 3]} | {symbols[4, 4]} |");
            Console.WriteLine(" +---+---+---+---+---+");
            */
            for (int b = 0; b < 5; b++)
            {
                Console.WriteLine(" +---------+---------+---------+---------+---------+"); 
                Console.WriteLine($" |    { symbols[b, 0]}    |    { symbols[b, 1]}    |    { symbols[b, 2]}    |    { symbols[b, 3]}    |    { symbols[b, 4]}    | ");
                Console.WriteLine($" | p1 {player1.ghost1.GhostState[b, 0]} | p1 {player1.ghost1.GhostState[b, 1]} | p1 {player1.ghost1.GhostState[b, 2]}  | p1 {player1.ghost1.GhostState[b, 3]} | p1 {player1.ghost1.GhostState[b, 4]} | ");
                Console.WriteLine($" | p2 {player2.ghost1.GhostState[b, 0]} | p2 {player2.ghost1.GhostState[b, 1]} | p2 {player2.ghost1.GhostState[b, 2]}  | p2 {player2.ghost1.GhostState[b, 3]} | p2 {player2.ghost1.GhostState[b, 4]} | ");
            }
            Console.WriteLine(" +---------+---------+---------+---------+---------+");



        }


        private string SymbolFor(State state)
        {
            switch (state)
            {
                
                case State.blue: return "b";
                case State.red: return "r";
                case State.yellow: return "y";
                case State.mirror: return "m";
                case State.portalBlue: return "Ob";
                case State.portalRed: return "Or";
                case State.portalYellow: return "Oy";
                default: return " ";
            }
        }

        public string SymbolForP1(Player player1)
        {
            if (player1.ghost1.GhostState[0,0] == State.blue) return "P1\nBlue";
            else if (player1.ghost1.GhostState[0, 0] == State.red) return "P1\nRed ";
            else if (player1.ghost1.GhostState[0, 0] == State.yellow) return "P1\nYellow";
            else return null;

        }

        public string SymbolForP2(Player player2)
        {
            if (player2.ghost1.GhostState[0, 0] == State.blue) return "P2\nBlue";
            else if (player2.ghost1.GhostState[0, 0] == State.red) return "P2\nRed ";
            else if (player2.ghost1.GhostState[0, 0] == State.yellow) return "P2\nYellow";
            else return null;
        }

    }
}
