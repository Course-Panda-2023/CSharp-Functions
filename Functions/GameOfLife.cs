using System;

public class GameOfLife
{
	public static int CalculateNumAliveNeighbors(bool[,] board, int rows, int cols, int i, int j)
	{
		int cnt = 0;

		for (int i1 = i-1; i1 <= i+1; i1++)
		{
			if ((i1 < 0) | (i1 >= rows)) { continue; } 
			for (int j1 = j-1; j1 <= j+1; j1++)
			{
				if ((j1 < 0) | (j1 >= cols)) { continue; }
				if ((i1 == i) & (j1 == j)) { continue; }

				cnt += Convert.ToInt32(board[i1, j1]);
			}
		}

		return cnt;
	}
	public static bool CalculateNextStateCoordinate(bool[,] board, int rows, int cols, int i, int j)
	{
		int numAliveNeighbors = CalculateNumAliveNeighbors(board, rows, cols, i, j);
		
		if (board[i, j])
		{
			// cell is living
			if (numAliveNeighbors < 2) { return false; }
			if ((numAliveNeighbors == 2) | (numAliveNeighbors == 3)) { return true; }
			if (numAliveNeighbors > 3) { return false; }

			// only for compilation
			return true;
		}
		else
		{
			// cell isn't living
			if (numAliveNeighbors == 3) { return true; }
			return false;
		}
	}
}
