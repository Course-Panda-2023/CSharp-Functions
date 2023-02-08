using System;

public class GameOfLife
{
	public static int calcAliveNeighs(bool[,] board, int i, int j, int rows, int cols)
        {
            int countAlive = 0;
            for (int horizontal=-1; horizontal<=1; horizontal++)
            {
                for (int vertical=-1; vertical<=1; vertical++)
                {
                    if (horizontal != 0 || vertical != 0)
                    {   
                        if (i+horizontal >=0 && i+horizontal < rows &&
                            j+vertical >= 0 && j+vertical < cols)
                            countAlive += Convert.ToInt32(board[i+horizontal, j+vertical]);
                    }
                }
            }
            return countAlive;            
        }
}
