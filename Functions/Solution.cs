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
            //Assuming that ther input is valid (not mentioned in the list)
            //string[] player_choices_str = new string[players_num];
            string player_choice;
            RockPaperScissors.RPS[] player_choices = new RockPaperScissors.RPS[players_num];
            while (counter < players_num)
            {
                player_choice = Console.ReadLine();
                
                 //Enum.Parse<Week>(day1);


                if (Enum.IsDefined(typeof(RockPaperScissors.RPS), player_choice)){
                    player_choices[counter] = Enum.Parse<RockPaperScissors.RPS>(player_choice);                    
                }
                else
                {
                    Console.WriteLine("Wrong choice!");
                    return;
                }


                /*RockPaperScissors.RPS choice;
                Enum.TryParse(player_choices_str[counter], out choice);
                player_choices[counter] = choice;*/


                /* if (Enum.IsDefined(typeof(RockPaperScissors.RPS), player_choices_str){
                     Week week3 = Enum.Parse<Week>(day3);
                 }
                 else
                 {
                     Console.WriteLine("Wrong Week Day");
                 }*/


                counter++;
            }
            //Console.WriteLine($"{Math.Abs(player_choices[0] - player_choices[1])}");
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
            else if(Math.Abs(player_choices[0] - player_choices[1]) == 1)
            {
                if (player_choices[0] > player_choices[1])
                {
                    Console.WriteLine("First player wins!");
                }
                else
                {
                    Console.WriteLine("Second player wins!");
                }
            }
            /*foreach (string choice in player_choices)
            {
                Console.WriteLine($"{choice}");
            }*/
                //RockPaperScissors.RPS[] player_choices = new RockPaperScissors.RPS[players_num];
                /*while (counter < players_num)
                {
                    player_choices[counter] = Console.ReadLine();
                    counter++;
                }*/
                /*foreach (RockPaperScissors.RPS choice in player_choices)
                {
                    Console.WriteLine(choice);
                }*/
                //RockPaperScissors.RPS choice = RockPaperScissors.RPS.Scissors;
                //Console.WriteLine(Enum.Parse(typeof(RockPaperScissors.RPS), "Scissors"));
                //RockPaperScissors.RPS 
        }

       /* public static double[] Assignment4(bool asc, params double[] nums)
        {
            *//*
             * TODO: Write code here
             *//*
            //if (asc) { }
            return;
            
        }*/

        public static void Assignment5(string str, char[] letters)
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
