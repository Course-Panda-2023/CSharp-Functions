using System;
using System.ComponentModel;

public class GameOfLife
{
    public static bool change(bool[,] board, int rows, int cols, int pointX, int pointY, bool oneOrZero)
    {
        int[] rowsToCheck = new int[3], colsToCheck = new int[3];
        int j1 = 0;
        for (int i = -1; i <= 1; i++)
        {
            if ((pointX + i < rows) && (pointX + i >= 0))
            {
                rowsToCheck[j1] = pointX + i;
                j1++;
            }
        }
        int j2 = 0;
        for (int i = -1; i <= 1; i++)
        {
            if ((pointY + i < cols) && (pointY + i >= 0))
            {
                colsToCheck[j2] = pointY + i;
                j2++;
            }
        }

        int aliveCounter = 0;
        for (int k = 0; k < j1; k++)
        {
            for (int k2 = 0; k2 < j2; k2++)
            {
                if (!((rowsToCheck[k] == pointX) && (colsToCheck[k2] == pointY)))
                {
                    if (board[rowsToCheck[k], colsToCheck[k2]] == false)
                    {
                        aliveCounter++;
                    }
                }
            }
        }

        if (oneOrZero)
        {
            if (aliveCounter == 3)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        else
        {
            if (aliveCounter > 3)
            {
                return true;
            }
            else if (aliveCounter < 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
