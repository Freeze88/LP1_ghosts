using System;
using System.Collections.Generic;
using System.Text;

namespace LP1
{
    public class Renderer
    {
        public void Render(Board board, Player player1, Player player2)
        {
            string[,] symbols = new string[5, 5];

            for (int row = 0; row < 5; row++)
                for (int column = 0; column < 5; column++)
                    symbols[row, column] = SymbolFor(board.GetState(new Position(row, column)));
            for (int b = 0; b < 5; b++)
            {
                Console.WriteLine(" +---------+---------+---------+---------+---------+");
                Console.WriteLine($" |    { symbols[b, 0]}    |    { symbols[b, 1]}    |    { symbols[b, 2]}    |    { symbols[b, 3]}    |    { symbols[b, 4]}    | ");
                Console.WriteLine($" | p1 {player1.ghost1.GhostState[b, 0]} | p1 {player1.ghost1.GhostState[b, 1]} | p1 {player1.ghost1.GhostState[b, 2]} | p1 {player1.ghost1.GhostState[b, 3]} | p1 {player1.ghost1.GhostState[b, 4]} | ");
                Console.WriteLine($" | p2 {player2.ghost1.GhostState[b, 0]} | p2 {player2.ghost1.GhostState[b, 1]} | p2 {player2.ghost1.GhostState[b, 2]} | p2 {player2.ghost1.GhostState[b, 3]} | p2 {player2.ghost1.GhostState[b, 4]} | ");
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
                case State.portal: return "O";
                default: return " ";
            }
        }
    }
}
