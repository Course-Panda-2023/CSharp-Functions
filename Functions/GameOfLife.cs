using System;

public class GameOfLife
{
    public static bool[,] PerformPass(bool[,] matrix, in int n, in int m)
    {
        bool[,] updatedBoard = new bool[n, m];
        List<bool> neighbors = new List<bool>();
        int statCounter = 0;
        for(int i = 0; i < n; i++) 
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write($"{Convert.ToInt32(matrix[i, j])} ");
                neighbors = GetAllNeighbours(matrix, i, j, n, m); 
                
                foreach (bool neighbor in neighbors)
                {
                    
                    if (neighbor) { statCounter++; }                    
                }                
                if (matrix[i, j])
                {
                    if(statCounter < 2) { updatedBoard[i, j] = false; }
                    if (statCounter == 2 || statCounter == 3) { updatedBoard[i, j] = matrix[i, j]; }
                    else { updatedBoard[i, j] = false; }
                }
                else
                {
                    if(statCounter == 3) { updatedBoard[i, j] = true; }
                    else { updatedBoard[i, j] = matrix[i, j]; }
                }                
                //Console.WriteLine("");
                neighbors.Clear();
                statCounter = 0;
            }            
            Console.WriteLine();
        }
        Console.WriteLine();
        neighbors = GetAllNeighbours(matrix, 0, 0, n, m);        
        return updatedBoard;
    }

    public static List<bool> GetAllNeighbours(bool[,] matrix, in int i, in int j, in int n, in int m)
    {
        List<bool> neigbours = new List<bool>();
        if (CheckIsValidPos(matrix, i, j - 1, n, m))
        {
            neigbours.Add(matrix[i,j-1]);
        }
        if (CheckIsValidPos(matrix, i - 1, j - 1, n, m))
        {
            neigbours.Add(matrix[i - 1, j - 1]);
        }
        if (CheckIsValidPos(matrix, i - 1, j, n, m))
        {
            neigbours.Add(matrix[i - 1, j]);
        }
        if (CheckIsValidPos(matrix, i - 1, j + 1, n, m))
        {
            neigbours.Add(matrix[i - 1, j + 1]);
        }
        if (CheckIsValidPos(matrix, i, j + 1, n, m))
        {            
            neigbours.Add(matrix[i, j + 1]);
        }
        if (CheckIsValidPos(matrix, i + 1, j + 1, n, m))
        {
            neigbours.Add(matrix[i + 1, j + 1]);
        }
        if (CheckIsValidPos(matrix, i + 1, j, n, m))
        {
            neigbours.Add(matrix[i + 1, j]);
        }
        if (CheckIsValidPos(matrix, i + 1, j - 1, n, m))
        {
            neigbours.Add(matrix[i + 1, j - 1]);
        }
        return neigbours;
    }
    public static bool CheckIsValidPos(bool[,] matrix, in int i, in int j, in int n, in int m)
    {
        if (i < 0 || j < 0 || i >= n || j >= m)
        {
            return false;
        }
        return true;
    }
}
