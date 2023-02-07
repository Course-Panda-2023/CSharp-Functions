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
            Random rand = new Random();
            res = -1;
            if (low>0 && low < high)
            {
                res = rand.Next(low, high);
            }

        }

        public static void Assignment3()
        {
            string player1, player2;
            int p1, p2, win;
            string[] validInput = { "p", "r", "s" };
            Console.WriteLine("-player 1- \nplease enter p for PAPER r for ROCK or s for SCISSORS");
            player1 = Console.ReadLine();
            while (!validInput.Contains(player1))
            {
                Console.WriteLine("invalid input\n-player 1- \nplease enter p for PAPER r for ROCK or s for SCISSORS");
                player1 = Console.ReadLine();
            }

            Console.WriteLine("-player 2- \nplease enter p for PAPER r for ROCK or s for SCISSORS");
            player2 = Console.ReadLine();
            while (!validInput.Contains(player2))
            {
                Console.WriteLine("invalid input\n-player 2- \nplease enter p for PAPER r for ROCK or s for SCISSORS");
                player2 = Console.ReadLine();
            }
            if (player1.Equals("p"))
                p1 = ((int)RockPaperScissors.RPS.PAPER);
            else if(player1.Equals("r"))
                p1 = ((int)RockPaperScissors.RPS.ROCK);
            else
                p1 = ((int)RockPaperScissors.RPS.SCISSORS);

            if (player2.Equals("p"))
                p2 = ((int)RockPaperScissors.RPS.PAPER);
            else if (player2.Equals("r"))
                p2 = ((int)RockPaperScissors.RPS.ROCK);
            else
                p2 = ((int)RockPaperScissors.RPS.SCISSORS);

            win = p1 - p2;
            if (win == 0)
                Console.WriteLine("tie");
            else if (win == 1 ||win == -2)
                Console.WriteLine("player1 win");
            else 
                Console.WriteLine("player2 win");


        }

        public static double[] Assignment4(bool asc, params double[] nums)
        {
            if (asc)
                Helper.ascArray(nums);
            else
                Helper.desArray(nums);
            return nums;

        }

        //public static void Assignment5(string str, char[] letters)
        //{
        //    int len = str.Length;
        //    const int addtoascii = 10;
        //    const int roundAscii = 26;
        //    for (int i = 0; i < len; i++)
        //    {
        //        if (letters.Contains(str[i]))
        //        {
        //            str[i] = (char)((int)str[i] + addtoascii);
        //            if ((int)str[i] > 122)
        //                str[i] = (char)((int)str[i] - roundAscii);
        //        }

        //    }
        //    Console.WriteLine(str);
        //}

        public static bool Assignment6(string str)
        {
            int len;
            string clearStr="";
            string reverseClearStr = "";
            foreach(char c in str)
            {
                if (Char.IsLetter(c))
                    clearStr += Char.ToLower(c);
            }
            len = clearStr.Length;
            for (int i = len - 1; i >= 0; i--)
                reverseClearStr += clearStr[i];
            if (String.Compare(reverseClearStr, clearStr) == 0)
                return true;
            return false;
        }

        public static int Assignment7(int[] nums)
        {
            Dictionary<int, int> keys = new Dictionary<int, int>();
            foreach (int num in nums)
            {
                if (keys.ContainsKey(num))
                    keys[num] += 1;
                else
                    keys.Add(num, 1);
            }

            foreach (int numINKeys in keys.Keys)
            {
                if (keys[numINKeys] == 1)
                    return numINKeys;
            }

            return -1;
        }

        //public static void Assignment8(bool[,] board, int rows, int cols)
        //{
        //    /*
        //     * TODO: Write code here
        //     */
        //}

        public static int Assignment9()
        {
            int numOfJump = 0;
            for(int i = 0; true; i++)
            {
                //Console.WriteLine(i.ToString());
                if (!Helper.isJumpingdes(i) && !Helper.isJumpingAsc(i))
                    numOfJump++;
                if ((double)numOfJump / (double)i >= 0.99)
                    return numOfJump;
            }
            return 0;
        }
        ///#endregion

        //#region Bonus solutions
        //public static int Bonus1()
        //{
        //    /*
        //     * TODO: Write code here
        //     */
        //}

        //public static int Bonus2(uint[] hightMap)
        //{
        //    /*
        //     * TODO: Write code here
        //     */
        //}
        #endregion
    }
}
