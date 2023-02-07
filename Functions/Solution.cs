using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
            const int ERROR_OCCURED = -1;
            const int ZERO = 0;
            if (low < ZERO)
            {
                Console.WriteLine("Negative low bound of range");
                res = ERROR_OCCURED;
                return;
            }
            if (low > high)
            {
                Console.WriteLine("Low is bigger than high");
                res = ERROR_OCCURED;
                return;
            }
            Random random = new Random();
            res = random.Next(low, high);
        }

        public static void Assignment3()
        {
            /*
             * TODO: Write code here
             */
        }

        public static double[] Assignment4(bool asc, params double[] nums)
        {
            double[] numbers = {   3, 6, 8 };
            return numbers;
        }

        public static void Assignment5(string str, char[] letters)
        {
            string result = "";
            HashSet<int> lettersSet = new HashSet<int>();
            Span<char> lettersAsSpan = letters.AsSpan();
            for (int i = 0; i < lettersAsSpan.Length; ++i)
            {
                lettersSet.Add(lettersAsSpan[i]);
            }
            
            const int CYCLIC_LETTER_OFFSET = 10;
            const int BORDER_LOWERCASE_LETTER_UPPER_BOUND = 122;
            const int BORDER_LOWERCASE_LETTER_LOWER_BOUND = 96;
            const int ZERO = 0;
            int ch;
            int difference;
            int with_offset;
            for (int i = 0; i < str.Length; ++i)
            {
                ch = str[i];
                if (lettersSet.Contains(ch))
                {
                    with_offset = ch + CYCLIC_LETTER_OFFSET;
                    difference = BORDER_LOWERCASE_LETTER_UPPER_BOUND - with_offset;
                    if (difference > ZERO)
                    {
                        result += (char)with_offset;
                    }
                    else
                    {
                        result += (char)(BORDER_LOWERCASE_LETTER_LOWER_BOUND - difference);
                    }
                }
                else
                {
                    result += (char)ch;
                }
                
            }
            str = result;
            Console.WriteLine(result);
        }

        public static bool Assignment6(string str)
        {
            return true;
            /*
             * TODO: Write code here
             */
        }

        public static int Assignment7(int[] nums)
        {
            const int APPEARS_ONCE = 1;
            const int NOT_FOUND = -1;
            int result = NOT_FOUND;
            Dictionary<int, int> frequency = new Dictionary<int, int>();
            Span<int> arrayAsSpan = nums.AsSpan();
            
            for (var i = 0; i < arrayAsSpan.Length; ++i)
            {

                if (frequency.ContainsKey(arrayAsSpan[i]))
                {
                    frequency[arrayAsSpan[i]] += 1;
                }
                else
                {
                    frequency.Add(arrayAsSpan[i], 1);
                }
            }

            for (var i = 0; i < arrayAsSpan.Length; ++i)
            {
                if (arrayAsSpan[i] == APPEARS_ONCE)
                {
                    result = arrayAsSpan[i];
                    return result;
                }
                
            }
            return result;
        }

        public static void Assignment8(bool[,] board, int rows, int cols)
        {
            /*
             * TODO: Write code here
             */
        }

        public static int Assignment9()
        {
            return 0;
            /*
             * TODO: Write code here
             */
        }
        #endregion

        #region Bonus solutions
        public static int Bonus1()
        {
            return 0;
            /*
             * TODO: Write code here
             */
        }

        public static int Bonus2(uint[] hightMap)
        {
            return 0;
            /*
             * TODO: Write code here
             */
        }
        #endregion
    }
}
