using System;

public class Renderer
{
    public void Render(Board board)
	{
        char[,] symbols = new char[5, 5];
        
        for (int row = 0; row < 5; row++)
            for (int column = 0; column = 5; column++)
                symbols[row, column] = SymbolFor(board.GetState(new Position(row, column)));

        Console.WriteLine()

	}
}

