using System;

public class GameOfLife
{

    public static bool[] GetNeighbors(bool[,] board, int row, int col, int rowsNum, int colsNum)
	{
        if (row == 0 && col == 0)
            return new bool[] { board[0, 1], board[1, 0], board[1, 1] };
        else if (row == 0 && col == colsNum - 1)
            return new bool[] { board[0, colsNum - 2], board[1, colsNum - 1], board[1, colsNum - 2] };
        else if (row == rowsNum - 1 && col == 0)
            return new bool[] { board[rowsNum - 2, 0], board[rowsNum - 1, 1], board[rowsNum - 2, 1] };
        else if (row == rowsNum - 1 && col == colsNum - 1)
            return new bool[] { board[rowsNum - 2, colsNum - 1], board[rowsNum - 1, colsNum - 2], board[rowsNum - 2, colsNum - 2] };
        else if (row == 0)
            return new bool[] { board[row, col - 1], board[row, col + 1], board[row + 1, col - 1], board[row + 1, col], board[row + 1, col + 1] };
        else if (row == rowsNum - 1)
            return new bool[] { board[row, col - 1], board[row, col + 1], board[row - 1, col - 1], board[row - 1, col], board[row - 1, col + 1] };
        else if (col == 0)
            return new bool[] { board[row - 1, col], board[row + 1, col], board[row - 1, col + 1], board[row, col + 1], board[row + 1, col + 1] };
        else if (col == colsNum - 1)
            return new bool[] { board[row - 1, col], board[row + 1, col], board[row - 1, col - 1], board[row, col - 1], board[row + 1, col - 1] };
        else
            return new bool[] { board[row - 1, col - 1], board[row - 1, col], board[row - 1, col + 1], board[row, col - 1], board[row, col + 1], board[row + 1, col - 1], board[row + 1, col], board[row + 1, col + 1] };
    }

    public static void PrintBoard(bool[,] board, int rows, int cols)
    {
        for (int i=0; i<rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"{board[i, j]} ");
            }
            Console.Write("\n");
        }
    }
}
