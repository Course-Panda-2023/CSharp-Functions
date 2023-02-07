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
            /*
             * TODO: Write code here
             */
            return 0;
        }

        public static void Assignment8(bool[,] board, int rows, int cols)
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
            return 0;
        }
        #endregion

        #region Bonus solutions
        public static int Bonus1()
        {
            /*
             * TODO: Write code here
             */
            return 0;
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
