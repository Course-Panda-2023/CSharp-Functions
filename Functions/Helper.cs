﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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
                    numStr = "Fourty";
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
                        numStr = tens(number/10) + ones(number%10);
                    }
                    break;
            }
            return numStr;
        }

        public static string[] GetNumsNames()
        {
            string[] numsNames= new string[99];
            for (int num=1; num<100; num++)
            {
                numsNames[num-1] = tens(num);
            }
            return numsNames;
        }
   
    }
}
