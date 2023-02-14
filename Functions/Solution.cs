using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    internal class Solution
    {
        private static int p2=0;
        private static int p1=0;

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
            /*
             * TODO: Write code here
             */
        }

        public static void Assignment5(ref string str, char[] letters)
        {
            /*
             * TODO: Write code here
             */
        }

        public static bool Assignment6(string str)
        {
            /*
             * TODO: Write code here
             */
        }

        public static int Assignment7(int[] nums)
        {
            /*
             * TODO: Write code here
             */
        }

        public static bool[,] Assignment8(bool[,] board, int rows, int cols)
        {
            /*
             * TODO: Write code here
             */
        }

        public static int Assignment9()
        {
            /*
             * TODO: Write code here
             */
        }
        #endregion

        #region Bonus solutions
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
