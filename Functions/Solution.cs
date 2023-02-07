using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    internal class Solution
    {
        /*
         * Notice: Write helper functions in `Helper` class unless there is a special class for it
         */

        #region Assignment solutions
        public static void Assignment1(int low, int high, out int res)
        {
            try
            {
                Random random = new Random();
                res = random.Next(low, high);

            } catch(Exception)
            {
                res = -1;
            }
        }

        
        public static void Assignment3()
        {
            Console.WriteLine("Player 1, enter your decision:");
            RockPaperScissors.RPS player1 = Helper.GetRPSType(Console.ReadLine());
            Console.WriteLine("Player 2, enter your decision:");
            RockPaperScissors.RPS player2 = Helper.GetRPSType(Console.ReadLine());

            Console.WriteLine(Helper.Winner(player1, player2));
        }
        #endregion
        /*
        public static double[] Assignment4(bool asc, params double[] nums)
        {
            
        }

        public static void Assignment5(string str, char[] letters)
        {
            
        }

        public static bool Assignment6(string str)
        {
            
        }

        public static int Assignment7(int[] nums)
        {
            
        }

        public static void Assignment8(bool[,] board, int rows, int cols)
        {
            
        }

        public static int Assignment9()
        {
            
        }
        #endregion

        #region Bonus solutions
        public static int Bonus1()
        {
            
        }

        public static int Bonus2(uint[] hightMap)
        {
            
        }
        #endregion
        */
    }
}
