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
            Random rand_num = new Random();
            res = rand_num.Next(low, high);
            Console.WriteLine(res);            
        }

        public static void Assignment3()
        {
            const int players_num = 2;
            int counter = 0;

            string player_choice;
            RockPaperScissors.RPS[] player_choices = new RockPaperScissors.RPS[players_num];
            while (counter < players_num)
            {
                player_choice = Console.ReadLine();
                if (Enum.IsDefined(typeof(RockPaperScissors.RPS), player_choice)) {
                    player_choices[counter] = Enum.Parse<RockPaperScissors.RPS>(player_choice);
                }
                else
                {
                    Console.WriteLine("Wrong choice!");
                    return;
                }
                counter++;
            }

            if (Math.Abs(player_choices[0] - player_choices[1]) == 2) {

                if (player_choices[0] < player_choices[1])
                {
                    Console.WriteLine("First player wins!");
                }
                else
                {
                    Console.WriteLine("Second player wins!");
                }
            }
            else if (Math.Abs(player_choices[0] - player_choices[1]) == 1)
            {
                if (player_choices[0] > player_choices[1])
                {
                    Console.WriteLine("First player wins!");
                }
                else
                {
                    Console.WriteLine("Second player wins!");
                }
            } else
            {
                Console.WriteLine("It's a tie!");
            }
        }

        public static double[] Assignment4(bool asc, params double[] nums)
        {            
            double[] sorted = new double[nums.Length];
            
            
            sorted = Helper.MergeSort(nums);
            if (asc)
            {
                for(int i = 0; i < sorted.Length; i++)
                {
                    Console.WriteLine($"{sorted[i]}");
                }
            }
            else
            {
                for (int i = sorted.Length - 1; i >= 0; i--)
                {
                    Console.WriteLine($"{sorted[i]}");
                }
            }
            return sorted;
        }

        public static void Assignment5(string str, char[] letters)
        {            
            Helper.ShiftLetters(ref str, letters);
        }

        public static bool Assignment6(string str)
        {
            /*
             * TODO: Write code here
             */
            for(int i = 0; i < str.Length / 2; i++)
            {
                if(str[i] == str[str.Length - 1 - i])
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        public static int Assignment7(int[] nums)
        {
            if (nums.Length == 0)
            {
                Console.WriteLine($"The input array is empty!");
                return -1;
            }
            //A little bit shooting a cannon at sparrows:)
            Dictionary<int, int> hist = new Dictionary<int, int>();
            foreach(int i in nums)
            {
                if (hist.ContainsKey(i))
                {
                    hist[i]++;
                }
                else
                {
                    hist[i] = 1;
                }
            }
            foreach (KeyValuePair<int, int> entry in hist)
            {
                
                if (entry.Value == 1)
                {
                    //Console.WriteLine($"{entry.Key}");
                    return entry.Key;
                }
            }
            return 0;
        }

        public static void Assignment8(bool[,] board, int rows, int cols)
        {
            /*
             * TODO: Write code here
             */
            bool[,] updated_board = new bool[rows, cols];
            updated_board = GameOfLife.PerformPass(board, rows, cols);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{Convert.ToInt32(updated_board[i, j])} ");

                }
                Console.WriteLine();
            }
        }
        public static int Assignment9()
        {         


            int num = BouncingNumbers.GiveNum();
            Console.WriteLine($"{num}");
            return 0;
        }
        #endregion

        #region Bonus solutions
        public static int Bonus1()
        {
            Dictionary<int, string> dic = new Dictionary<int, string>()
            {
                {1, "one" },
                {2, "two"},
                {3, "three"},
                {4, "four"},
                {5, "five" }, {6, "six"}, {7, "seven"}, {8, "eight"}, {9, "nine"}, {10, "ten"},
                {11, "eleven" }, {12, "twelve"}, {13, "thirteen"}, {14, "fourteen"}, {15, "fifteen"},
                {16, "sixteen" }, {17, "seventeen"}, {18, "eighteen"}, {19, "ninteen"}, {20, "twenty"},
                {30, "thirty" }, {40, "forty"}, {50, "fifty"}, {60, "sixty"}, {70, "seventy"}, {80, "eighty"}, {90, "ninety"}
            };
            
            const int MAX_NUMBER = 100;
            int counter = 0, letterCounter = 0;
            for(int i = 1; i < MAX_NUMBER; i++)
            {                
                if (dic.ContainsKey(i))
                {
                    letterCounter += dic[i].Length;
                }
                else
                {
                    letterCounter += dic[i - i % 10].Length + dic[i % 10].Length;
                }
                
            }
            return letterCounter;
        }

        public static int Bonus2(uint[] hightMap)
        {
            /*
             * TODO: Write code here
             */
            return 0;
        }
        #endregion
    }
}
