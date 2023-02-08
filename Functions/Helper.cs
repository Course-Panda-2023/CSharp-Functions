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

        private static String ones(int number)
        {
            String numStr = "";
            switch (number)
            {
                case 1:
                    numStr = "One";
                    break;
                case 2:
                    numStr = "Two";
                    break;
                case 3:
                    numStr = "Three";
                    break;
                case 4:
                    numStr = "Four";
                    break;
                case 5:
                    numStr = "Five";
                    break;
                case 6:
                    numStr = "Six";
                    break;
                case 7:
                    numStr = "Seven";
                    break;
                case 8:
                    numStr = "Eight";
                    break;
                case 9:
                    numStr = "Nine";
                    break;
            }
            return numStr;
        }

        private static String tens(int number)
        {
            String numStr = "";
            switch (number)
            {
                case 10:
                    numStr = "Ten";
                    break;
                case 11:
                    numStr = "Eleven";
                    break;
                case 12:
                    numStr = "Twelve";
                    break;
                case 13:
                    numStr = "Thirteen";
                    break;
                case 14:
                    numStr = "Fourteen";
                    break;
                case 15:
                    numStr = "Fifteen";
                    break;
                case 16:
                    numStr = "Sixteen";
                    break;
                case 17:
                    numStr = "Seventeen";
                    break;
                case 18:
                    numStr = "Eighteen";
                    break;
                case 19:
                    numStr = "Nineteen";
                    break;
                case 20:
                    numStr = "Twenty";
                    break;
                case 30:
                    numStr = "Thirty";
                    break;
                case 40:
                    numStr = "Forty";
                    break;
                case 50:
                    numStr = "Fifty";
                    break;
                case 60:
                    numStr = "Sixty";
                    break;
                case 70:
                    numStr = "Seventy";
                    break;
                case 80:
                    numStr = "Eighty";
                    break;
                case 90:
                    numStr = "Ninety";
                    break;
                default:
                    if (number > 0)
                    {
                        numStr = tens(number - (number %10) ) + ones(number % 10);
                    }
                    break;
            }
            return numStr;
        }

        public static string[] GetNumName()
        {
            string[] numsName = new string[99];
            for (int num = 1; num < 100; num++)
            {
                numsName[num-1] = tens(num);
            }
            return numsName;
        }
    }
}
