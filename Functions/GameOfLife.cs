using System;

public class GameOfLife
{
    public static bool[,] PerformPass(bool[,] matrix, in int n, in int m)
    {
        bool[,] updated_board = new bool[n, m];
        List<bool> neighbors = new List<bool>();
        int stat_counter = 0;
        for(int i = 0; i < n; i++) 
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write($"{Convert.ToInt32(matrix[i, j])} ");
                neighbors = GetAllNeighbours(matrix, i, j, n, m); 
                
                foreach (bool neighbor in neighbors)
                {
                    
                    if (neighbor) { stat_counter++; }                    
                }                
                if (matrix[i, j])
                {
                    if(stat_counter < 2) { updated_board[i, j] = false; }
                    if (stat_counter == 2 || stat_counter == 3) { updated_board[i, j] = matrix[i, j]; }
                    else { updated_board[i, j] = false; }
                }
                else
                {
                    if(stat_counter == 3) { updated_board[i, j] = true; }
                    else { updated_board[i, j] = matrix[i, j]; }
                }                
                //Console.WriteLine("");
                neighbors.Clear();
                stat_counter = 0;
            }            
            Console.WriteLine();
        }
        Console.WriteLine();
        neighbors = GetAllNeighbours(matrix, 0, 0, n, m);        
        return updated_board;
    }

    public static List<bool> GetAllNeighbours(bool[,] matrix, in int i, in int j, in int n, in int m)
    {
        //const int max_neigbours_num = 6;
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
