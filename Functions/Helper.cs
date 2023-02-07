using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    internal class Helper
    {
        public static RockPaperScissors.RPS GetRPSType(string player_input)
        {
            if (player_input == "Rock" || player_input == "rock" || player_input == "r")
            {
                return RockPaperScissors.RPS.Rock;
            }
            else if (player_input == "Paper" || player_input == "paper" || player_input == "p")
            {
                return RockPaperScissors.RPS.Paper;
            }
            else if (player_input == "Scissors" || player_input == "scissors" || player_input == "s")
            {
                return RockPaperScissors.RPS.Scissors;
            }
            else
            {
                return RockPaperScissors.RPS.Invalid;
            }
        }

        public static string CheckWinner(RockPaperScissors.RPS playerAction1, RockPaperScissors.RPS playerAction2)
        {
            if (playerAction1 == RockPaperScissors.RPS.Invalid || playerAction2 == RockPaperScissors.RPS.Invalid)
            {
                return "One of the actions is not valid!";
            }
            else if (playerAction1 == playerAction2)
            {
                return "It's a tie!";
            }
            else if ((playerAction1 == RockPaperScissors.RPS.Rock && playerAction2 == RockPaperScissors.RPS.Scissors)
                || (playerAction1 == RockPaperScissors.RPS.Paper && playerAction2 == RockPaperScissors.RPS.Rock)
                || (playerAction1 == RockPaperScissors.RPS.Scissors && playerAction2 == RockPaperScissors.RPS.Paper))
            {
                return "First player wins!";
            }
            else
            {
                return "Second player wins!";
            }
        }

        public static double[] SortArray(double[] array)
        {
            double tmp;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        tmp = array[i];
                        array[i] = array[j];
                        array[j] = tmp;
                    }
                }
            }
            return array;
        }

        public static double[] ReverseArray(double[] array)
        {
            double[] reverseArray = new double[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                reverseArray[array.Length - 1 - i] = array[i];
            }
            return reverseArray;
        }

        public static void PrintArray(double[] array)
        {
            foreach (double value in array)
            {
                Console.WriteLine(value);
            }
        }
    }
}
