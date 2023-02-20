using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Text.RegularExpressions.Regex;


namespace Basic
{
    internal class Solution
    {
        
        private static int p2=0;
        private static int p1=0;
        private static char current;
        private static char newChar;

        /*
* Notice: Write helper functions in `Helper` class unless there is a special class for it
*/

        #region Assignment solutions
        public static void Assignment1(int low, int high, out int res)
        {
            Random ran = new Random();
            res = ran.Next(low, high);
        }

        public static void Assignment3()
        {
            string? playerInput1 = Console.ReadLine();
            string? playerInput2 = Console.ReadLine();
            
            if (playerInput1 == "Paper")
            {
                p1 = (int) RockPaperScissors.RPS.Paper;
            }
            
            if (playerInput1 == "Scissors")
            {
                p1 = (int) RockPaperScissors.RPS.Scissors;
            }

            if (playerInput2 == "Paper")
            {
                p2 = (int) RockPaperScissors.RPS.Paper;
            }

            if (playerInput2 == "Scissors")
            {
                p2 = (int) RockPaperScissors.RPS.Scissors;
            }
            
            int d=p1-p2;
            if (d<0)
            {
                d+=3;
            }

            if (d == 0)
            {
                Console.WriteLine("It's a tie!");
            }

            if (d == 1)
            {
                Console.WriteLine("First player wins!");
            }

            if (d == 2)
            {
                Console.WriteLine("Second player wins!");
            }

        }

        public static double[] Assignment4(bool asc, params double[] nums)
        {
            
        double temp;
 
        // traverse 0 to array length
        for (int i = 0; i < nums.Length - 1; i++)
 
            // traverse i+1 to array length
            for (int j = i + 1; j < nums.Length; j++)
            {
 
                // compare array element with
                // all next element
                if ((asc == false)&&(nums[i] < nums[j]))
                {
                    temp = nums[i];
                    nums[i] = nums[j];
                    nums[j] = temp;
                }
                if ((asc == true)&&(nums[j] < nums[i]))
                {
                    temp = nums[i];
                    nums[i] = nums[j];
                    nums[j] = temp;
                }
            }
        return nums;
        }

        public static void Assignment5(ref string str, char[] letters)
        {
            char[] strAsChars = str.ToCharArray();
            for (int i = 0; i < strAsChars.Length; i++)
            current=strAsChars[i];
            {
                for (int j = 0; j < letters.Length; j++)
                {
                    if (current==letters[j])
                    {
                        var n = Encoding.ASCII.GetByteCount(current.ToString())+10;
                        newChar = Convert.ToChar(n);
                        current = newChar;
                    }
                }
            }
            str = new string(strAsChars);
        }

        public static bool Assignment6(string str)
        
        {
            bool CouldBePal = true;
            str = str.ToLower();
            str = System.Text.RegularExpressions.Regex.Replace(str, @"[^a-z]", "");
            for (int i=0 ; i<(str.Length/2)-0.5; i++)
            {
                if (str[i] != str[-i-1])
                {
                    CouldBePal = false;
                }
            }
            return CouldBePal;
        }

        public static int Assignment7(int[] nums)
        {
            
            for (int i=0; i<nums.Length; i++)
            {
                bool HasPair=false;
                for (int j=0; j<nums.Length; j++)
                {
                    if (i==j)
                    {
                        continue;
                    }
                    if (nums[i]==nums[j])
                    {
                        HasPair=true;
                        break;
                    }
                }
                if (!HasPair)
                {
                    return nums[i];
                }
                
            }
            Console.WriteLine("non found, please check input paramaters");
            return -1;
        }

        public static bool[,] Assignment8(bool[,] board, int rows, int cols)
        {
            int liveNeighbors(bool[,] board, int rowIndex, int colIndex)
            {
                int liveCounter = 0;
                for (int i=Math.Max(0,colIndex-1); i<Math.Min(colIndex+1, board.GetLength(0)); i++)
                {
                    for (int j=Math.Max(0,rowIndex-1); j<Math.Min(rowIndex+1, board.GetLength(1)); j++)
                    {
                        if (((i,j)!=(colIndex,rowIndex))&&(board[i,j]==true))
                        {
                            liveCounter+=1;
                        }
                    }
                }
                return liveCounter;
            }

            bool[,] newBoard = board;

            for (int i=0; i<rows; i++)
            {
                for (int j=0; j<cols; j++)
                {
                    int live_Neighbors=liveNeighbors(board,i,j);
                    if ((board[i,j]&&((live_Neighbors<2)||(live_Neighbors>3)))||(!board[i,j]&&(live_Neighbors!=3)))
                    {
                        newBoard[i,j]=false;
                    }
                    else
                    {
                        newBoard[i,j]=true;
                    }
                }
            }
            return newBoard;
        }

        public static int Assignment9()
        {
            bool isJump(int num)
            {
                string str_n=num.ToString();
                char[] charArr=str_n.ToCharArray();
                bool isCouldGrow=true;
                bool isCouldShrink=true;
                for (int i=1; i<charArr.Length; i++)
                {
                    /* TODO: compare charArr[i-1] and charArr[i]: done
                    and see if (!couldGrow&&!couldShrink): done and returned */
                    if (charArr[i]<charArr[i-1])
                    {
                        if (!isCouldShrink)
                        {
                            return true;
                        }
                        isCouldGrow=false;
                    }
                    else if (charArr[i]>charArr[i-1])
                    {
                        if (!isCouldGrow)
                        {
                            return true;
                        }
                        isCouldShrink=false;
                    }
                }
                return false;
            }


            for (int num=1;true;num++)
            {int jumpCount=0;
                if (isJump(num))
                {
                    /* TODO: add counter: done
                    check if 99% and return num (outside the if()): done */
                jumpCount+=1;
                }
                if (jumpCount/num==0.99)
                {
                    return num;
                }
            }
        }
        #endregion

        #region Bonus solutionsnum
        public static int Bonus1()
        {
            /*
             * TODO: Write code here
             */
        }

        public static int Bonus2(uint[] hightMap)
        {
            /*
             * TODO: Write code here
             */
        }
        #endregion
    }
}
