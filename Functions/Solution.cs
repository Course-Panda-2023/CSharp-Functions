using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        
        public static double[] Assignment4(bool asc, params double[] nums)
        {
            double[] sortedNums = Helper.SortArray(nums);
            if (asc) 
            {
                return sortedNums;
            }
            else 
            {
                return Helper.ReverseArray(sortedNums);
            }
        }

        public static void Assignment5(string str, char[] letters)
        {
            foreach(char c in letters) 
            {
                int letterInASCII = (int)c + 10;
                if (letterInASCII > 122)
                {
                    letterInASCII = letterInASCII - 26;
                }
                str = str.Replace(c, (char)letterInASCII);
            }  
            Console.WriteLine(str);
        }

        public static bool Assignment6(string str)
        {
            str = Regex.Replace(str, "[^a-zA-Z]", String.Empty);
            str = str.ToLower();
            char[] letters = str.ToCharArray(); 
            Array.Reverse(letters);
            string reversedStr = new string(letters);
            return str.Equals(reversedStr);
        }

        public static int Assignment7(int[] nums)
        {
            foreach (int num in nums)
            {
                if (nums.Count(tempNum => tempNum == num) == 1)
                {
                    return num;
                }
            }
            return -1;
        }

        #endregion
        /*
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
