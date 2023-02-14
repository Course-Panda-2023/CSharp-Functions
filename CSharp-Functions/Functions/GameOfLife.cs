using System;

public class GameOfLife
{
    public static int[,] ConvertBoardToInt(bool[,] board, int rows, int cols)
    {
        int[,] newBoard = new int[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                newBoard[i, j] = Convert.ToInt32(board[i, j]);
            }
        }
        return newBoard;
    }

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
        // CurrentRow[0] = row - 1 (if there is one) and currentRow[1] = row + 1 (if there is one).
        int[] currentRow = { -1, -1, row };
        // Same for currentCol.
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
                // first part of the if - makes sure that I'm not calculating the current index as a neighbor.
                // the rest of the if if to make sure that indexes that don't exist in the board aren't calculated.
                if (!(i == 2 && j == 2) && currentRow[i] != -1 && currentCol[j] != -1)
                {
                    neighborCounter += board[currentRow[i], currentCol[j]];
                }
            }
        }
        return neighborCounter;
    }
}
