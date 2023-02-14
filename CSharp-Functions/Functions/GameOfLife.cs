using System;

public class GameOfLife
{
    public static int[,] UpdatedBoard(int[,] board, int rows, int cols)
    {
        int[,] newBoard = new int[rows, cols];
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                int current = board[row, col];
                int amountOfNeighbors = AmountOfNeighbors(board, row, col, rows, cols);

                if (amountOfNeighbors + current == 3 || amountOfNeighbors == 3)
                    newBoard[row, col] = 1;
                else
                    newBoard[row, col] = 0;
            }
        }
        return newBoard;
    }

    public static int AmountOfNeighbors(int[,] board, int row, int col, int rows, int cols)
    {
        int[] currentRow = { -1, -1, row };
        int[] currentCol = { -1, -1, col };
        int neighborCounter = 0;

        if (row > 0)
            currentRow[0] = row - 1;
        if (col > 0)
            currentCol[0] = col - 1;
        if (row < rows - 1)
            currentRow[1] = row + 1;
        if (col < cols - 1)
            currentCol[1] = col + 1;

        for (int i = 0; i < currentRow.Length; i++)
        {
            for (int j = 0; j < currentCol.Length; j++)
            {
                if (!(i == 2 && j == 2) && currentRow[i] != -1 && currentCol[j] != -1)
                    neighborCounter += board[currentRow[i], currentCol[j]];
            }
        }
        return neighborCounter;
    }
}
