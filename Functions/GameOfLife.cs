using System;

public class GameOfLife
{
    public static bool[,] NextGeneration(bool[,] grid, int M, int N)
    {
            bool[,] future = new bool[M, N];
            for (int l = 1; l < M - 1; l++)
            {
                for (int m = 1; m < N - 1; m++)
                {
                    int aliveNeighbours = 0;
                    for (int i = -1; i <= 1; i++)
                    {
                        for (int j = -1; j <= 1; j++)
                        {
                            if (grid[l + i, m + j])
                            {
                                aliveNeighbours++;
                            }
                        }
                    }
                    if (grid[l, m])
                    {
                        aliveNeighbours--;
                    }

                    if (grid[l, m] && (aliveNeighbours < 2))
                    {
                        future[l, m] = false;
                    }
                    else if (grid[l, m] && (aliveNeighbours > 3))
                    {
                        future[l, m] = false;
                    }
                    else if (!grid[l, m] && (aliveNeighbours == 3))
                    {
                        future[l, m] = true;
                    }
                    else
                    {
                        future[l, m] = grid[l, m];
                    }
                }
            }
        return future;
    }



}
