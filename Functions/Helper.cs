using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    internal class Helper
    {
        /*
         * TODO: Add any needed helper functions
         */
        RockPaperScissors.RPS getMove() 
        {
            Console.WriteLine("Write a move: Rock or Paper or Scissors");
            string move = Console.ReadLine();
            RockPaperScissors.RPS moveRe = null;
            switch (move)
            {
                case "Rock":
                    moveRe =  RockPaperScissors.RPS.Rock; 
                    break;
                case "Paper":
                    moveRe = RockPaperScissors.RPS.Paper;
                    break;
                case "Scissors":
                    moveRe = RockPaperScissors.RPS.Scissors;
                    break;
                default:
                    moveRe = getMove(); //In case of invalid selection
            }
            return moveRe;
        }

        public static void reversArray(params double[] nums) 
        {

            for (int i = 0; i < nums.Length / 2; i++)
            {
                double tmp = nums[i];
                nums[i] = nums[nums.Length - i - 1];
                nums[nums.Length - i - 1] = tmp;
            } 
        }

        public static List<(int, int)> indexTOCheck(int rows, int cols, int bordRos, int bordCol)
        {
            //Gets the index of the neighbors
            List<(int, int)> list = new List<(int, int)>();
            for (int j = -1; j < 2 && rows + j < bordRos; j++)
            {
                for (int i = -1; i < 2 && cols + i < bordCol; i++)
                {
                    if ((rows + j >= 0) && (cols + i >= 0))
                    {
                        list.Add((rows + j, cols + i));
                    }
                }
            }
            list.Remove((rows, cols));
            return list;
        }

        public static int numberOfLive(int[,] board, List<(int, int)> list)
        {
            //Count how many neighbors there are in life
            int count = 0;
            for (int i = 0; i < list.Count; i++)
            {
                count += board[list[i].Item1, list[i].Item2];
            }
            return count;
        }

        public static int isAlive(int[,] board, int rows, int cols)
        {
            // Returns whether the indexed cell (board[rows,cols]) is alive
            List<(int, int)> listOfN = Helper.indexTOCheck(rows, cols, board.GetLength(0), board.GetLength(1));
            int numOfLiveN = Helper.numberOfLive(board, listOfN);
            int isAliveTemp = 0;
            if (board[rows, cols] == 1)
            {
                if (numOfLiveN < 2)
                {
                    isAliveTemp = 0;
                }
                else if (numOfLiveN == 2 || numOfLiveN == 3)
                {
                    isAliveTemp = 1;
                }
                else
                {
                    isAliveTemp = 0;
                }
            }
            else
            {
                isAliveTemp = numOfLiveN == 3 ? 1 : 0;
            }
            return isAliveTemp;
        }


    }
}
