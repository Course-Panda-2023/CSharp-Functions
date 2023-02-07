using System;

public class GameOfLife
{
    public static int CountNeighbors(int[,] board, int cellIndexRow, int cellIndexCol)
    {
        int aliveCounter = 0;
        for (int rowIndex = cellIndexRow - 1; rowIndex <= cellIndexRow + 1; rowIndex++)
        {
            if (rowIndex > board.GetLength(0) - 1 || rowIndex == -1)
            {
                continue;
            }
            for (int colIndex = cellIndexCol - 1; colIndex <= cellIndexCol; colIndex++)
            {
                if (colIndex > board.GetLength(1) - 1 || colIndex == -1)
                {
                    continue;
                }
                if (board[rowIndex,colIndex] == 1 && (rowIndex != cellIndexRow || cellIndexCol != colIndex))
                {
                    aliveCounter++;
                }
            }
        }
        return aliveCounter;
    }

    public static int CellNewState(int[,] board, int rowIndex, int colIndex)
    {
        int aliveCounter = CountNeighbors(board, rowIndex, colIndex);
        if (board[rowIndex,colIndex] == 1)
        {
            if (aliveCounter <2)
            {
                return 0;
            }
            if ( aliveCounter == 2 || aliveCounter == 3)
            {
                return 1;
            }
            if (aliveCounter > 3)
            {
                return 0
            }
        }
        if (board[rowIndex,colIndex] == 0 && aliveCounter == 3)
        {
            return 1;
        }
        return 0;
    }
}
