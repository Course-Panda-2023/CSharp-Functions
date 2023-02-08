using System;

public class GameOfLife
{
    public static int CountNeighbors(bool[,] board, int cellIndexRow, int cellIndexCol)
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
                if (board[rowIndex,colIndex] == true && (rowIndex != cellIndexRow || cellIndexCol != colIndex))
                {
                    aliveCounter++;
                }
            }
        }
        return aliveCounter;
    }

    public static bool CellNewState(bool[,] board, int rowIndex, int colIndex)
    {
        int aliveCounter = CountNeighbors(board, rowIndex, colIndex);
        if (board[rowIndex,colIndex] == true)
        {
            if (aliveCounter <2)
            {
                return false;
            }
            if ( aliveCounter == 2 || aliveCounter == 3)
            {
                return true;
            }
            if (aliveCounter > 3)
            {
                return false;
            }
        }
        if (board[rowIndex,colIndex] == false && aliveCounter == 3)
        {
            return true;
        }
        return false;
    }

    public static bool[,] CalcNextBoard(bool[,] oldBoard)
    {
        bool[,] newBoard = new bool[oldBoard.GetLength(0), oldBoard.GetLength(1)];

        for (int rowIndex = 0; rowIndex < oldBoard.GetLength(0); rowIndex++)
        {
            for (int colIndex = 0; colIndex < oldBoard.GetLength(1); colIndex++)
            {
                newBoard[rowIndex, colIndex] = CellNewState(oldBoard, rowIndex, colIndex);
            }
        }

        return newBoard;
    }

    public static void PrintBoard(bool[,] board)
    {
        for (int rowIndex = 0; rowIndex < board.GetLength(0); rowIndex++)
        {
            for (int colIndex = 0; colIndex < board.GetLength(1); colIndex++)
            {
                Console.WriteLine(board[rowIndex, colIndex]);
                if (board[rowIndex, colIndex]) 
                { 
                    Console.WriteLine("1");
                }
                else
                {
                    Console.WriteLine("0");
                }
            }
            Console.WriteLine();
        }
    }
}

