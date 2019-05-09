using System;
using System.Collections.Generic;
using System.Text;

namespace LP1
{
    /// <summary>
    /// This class is used to draw the Board and all the symbols
    /// </summary>
    public class Renderer
    {
        /// <summary>
        /// This method draws the Board
        /// </summary>
        /// <param name="board">gets all the information about the board</param>
        /// <param name="player1">Gets the player 1</param>
        /// <param name="player2">Gets the player 2</param>
        public void Render(Board board, Player player1, Player player2)
        {
            //Creates an Array with the size of the field
            string[,] symbols = new string[5, 5];
            //Creates a for loop 5 in size
            for (int row = 0; row < 5; row++)
                //Creates a for loop 5 in size
                for (int column = 0; column < 5; column++)
                    //Gets a symbol acording to the state on the board and saves it in the Array
                    symbols[row, column] = SymbolFor(board.GetState(new Position(row, column)));

            //A for loop that generates the board vertical strip by vertical strip
            for (int b = 0; b < 5; b++)
            {
                //Draw the top part of the board
                Console.WriteLine(" +---------+---------+---------+---------+---------+");
                //Draw the Symbol of the cell metioned on Board
                Console.WriteLine($" |    { symbols[b, 0]}    |    { symbols[b, 1]}    " +
                    $"|    { symbols[b, 2]}    |    { symbols[b, 3]}    |" +
                    $"    { symbols[b, 4]}    | ");
                /*Draws player 1 and the color of the ghost in there.
                If there's no ghost in there, prints "none"*/
                Console.WriteLine($" | p1 {player1.ghost1.GhostState[b, 0]} |" +
                    $" p1 {player1.ghost1.GhostState[b, 1]} |" +
                    $" p1 {player1.ghost1.GhostState[b, 2]} |" +
                    $" p1 {player1.ghost1.GhostState[b, 3]} |" +
                    $" p1 {player1.ghost1.GhostState[b, 4]} | ");
                /*Draws player 2 and the color of the ghost in there.
                If there's no ghost in there, prints "none"*/
                Console.WriteLine($" | p2 {player2.ghost1.GhostState[b, 0]} |" +
                    $" p2 {player2.ghost1.GhostState[b, 1]} |" +
                    $" p2 {player2.ghost1.GhostState[b, 2]} |" +
                    $" p2 {player2.ghost1.GhostState[b, 3]} |" +
                    $" p2 {player2.ghost1.GhostState[b, 4]} | ");
            }
            //draws the bottom part of the board

            Console.WriteLine(" +---------+---------+---------+---------+---------+");
        }
        /// <summary>
        /// This method draws the symbols of each State
        /// </summary>
        /// <param name="state">Gets the information about the state of the board</param>
        /// <returns>A character</returns>
        private string SymbolFor(State state)
        {
            /*Draws the symbol on the cell according tho the state mention on
            the class Board*/
            switch (state)
            {
                //Draws the specific symbol according to the State
                //If the State is blue, prints the letter "b"
                case State.blue: return "b";
                //If the State is red, prints the letter "r"
                case State.red: return "r";
                //If the State is yellow, prints the letter "y"
                case State.yellow: return "y";
                //If the State is mirror, prints the letter "m"
                case State.mirror: return "m";
                //If the State is portal, prints the letter "O"
                case State.portal: return "O";
                //If nothing is mentioned on state, prints nothin on the cell
                default: return " ";
            }
        }
    }
}
