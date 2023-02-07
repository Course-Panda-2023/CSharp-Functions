using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    internal class Helper
    {
        public static RockPaperScissors.RPS GetRPSType(string playerInput)
        {
            if (playerInput == "Scissors" || playerInput == "scissors" || playerInput == "s")
            {
                return RockPaperScissors.RPS.Scissors;
            }
            else if (playerInput == "Rock" || playerInput == "rock" || playerInput == "r")
            {
                return RockPaperScissors.RPS.Rock;
            }
            else if (playerInput == "Paper" || playerInput == "paper" || playerInput == "p")
            {
                return RockPaperScissors.RPS.Paper;
            }
            else
            {
                return RockPaperScissors.RPS.Paper;
            }
        }

        public static string Winner(RockPaperScissors.RPS firstPlayerAction , RockPaperScissors.RPS secondPlayerAction)
        {
            if (firstPlayerAction == RockPaperScissors.RPS.InValid || secondPlayerAction == RockPaperScissors.RPS.InValid)
            {
                return "One or more of the action isn't valid";
            }
            else if ( firstPlayerAction == secondPlayerAction)
            {
                return " It's a tie!";
            }
            else if ( (firstPlayerAction == RockPaperScissors.RPS.Scissors && secondPlayerAction == RockPaperScissors.RPS.Paper) || (firstPlayerAction == RockPaperScissors.RPS.Rock && secondPlayerAction == RockPaperScissors.RPS.Scissors) || (firstPlayerAction == RockPaperScissors.RPS.Paper && secondPlayerAction == RockPaperScissors.RPS.Rock))
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
            double temp; 
            for (int i = 0; i < array.Length - 1; i++)

                for (int j = i + 1; j < array.Length; j++)

                    if (array[i] > array[j])
                    {

                        temp = array[i];

                        array[i] = array[j];

                        array[j] = temp;

                    }
            return array;
        }

        public static double[] ReverseArray(double[] array)
        {
            double[] reverseArray = new double[array.Length];
            for (int i = 0; i < array.Length ; i++)
                reverseArray[array.Length-1-i] = array[i];
            return reverseArray;
        }

        public static void PrintArray(double[] array)
        {
            foreach ( double value in array) 
            {
                Console.WriteLine(value);
            }
        }
    }
}
