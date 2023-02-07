using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    internal class Helper
    {
        //Assignment 2

        public static RockPaperScissors.RPS determineInput()
        {
            bool gotValue = false;
            string input;
            while (gotValue == false)
            {
                input = Console.ReadLine();
                if (String.Equals(input, "R"))
                {
                    return RockPaperScissors.RPS.ROCK;
                }
                else if (String.Equals(input, "P"))
                {
                    return RockPaperScissors.RPS.PAPER;
                }
                else if (String.Equals(input, "S"))
                {
                    return RockPaperScissors.RPS.SCISSORS;
                }
                else
                {
                    Console.WriteLine("INVALID WEAPON, TRY AGAIN");
                }
            }
            return RockPaperScissors.RPS.SCISSORS;
        }

        public static void determineOutcome(RockPaperScissors.RPS player1, RockPaperScissors.RPS player2)
        {
            if (player1 == player2)
            {
                Console.WriteLine("It's a tie!");
                return;
            }
            if (player1 == RockPaperScissors.RPS.ROCK && player2 == RockPaperScissors.RPS.PAPER)
            {
                Console.WriteLine("Second player wins!");
                return;
            }
            if (player1 == RockPaperScissors.RPS.ROCK && player2 == RockPaperScissors.RPS.SCISSORS)
            {
                Console.WriteLine("First player wins!");
                return;
            }
            if (player1 == RockPaperScissors.RPS.PAPER && player2 == RockPaperScissors.RPS.ROCK)
            {
                Console.WriteLine("First player wins!");
                return;
            }
            if (player1 == RockPaperScissors.RPS.PAPER && player2 == RockPaperScissors.RPS.SCISSORS)
            {
                Console.WriteLine("Second player wins!");
                return;
            }
            if (player1 == RockPaperScissors.RPS.SCISSORS && player2 == RockPaperScissors.RPS.ROCK)
            {
                Console.WriteLine("Second player wins!");
                return;
            }
            if (player1 == RockPaperScissors.RPS.SCISSORS && player2 == RockPaperScissors.RPS.PAPER)
            {
                Console.WriteLine("First player wins!");
                return;
            }
        }
        //Assignment 2

        //Assignment4
        public static void sortTopToBottom(params double[] arr)
        {
            double temp;
            int len = arr.Length;
            for (int i = 0; i < len - 1; i++)
            {
                for (int j = 0; j < len - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            Console.Write("{");
            foreach (double num in arr)
            {
                Console.Write(num.ToString());
                Console.Write(", ");
            }
            Console.WriteLine("}");
        }
        public static void sortBottomToTop(params double[] arr)
        {
            double temp;
            int len = arr.Length;
            for (int i = 0; i < len - 1; i++)
            {
                for (int j = 0; j < len - i - 1; j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            Console.Write("{");
            foreach (double num in arr)
            {
                Console.Write(num.ToString());
                Console.Write(", ");
            }
            Console.WriteLine("}");
        }
        //Assignment4

        //Assignment5
        public static char shiftLetters(char c)
        {
            int asciValue = (int)c;
            if (asciValue >= 113)
            {
                asciValue = 97 + asciValue - 113;
            }
            else
            {
                asciValue += 10;
            }
            return (char)asciValue;
        }
        //Assignment5

        //Assignment6
        public static String formatStrLowerCase(String str)
        {
            int asciInt = 0;
            String s = "";
            char cFixed;
            foreach (char c in str)
            {
                asciInt = (int)c;
                if (asciInt <= 90 && asciInt >= 65)
                {
                    asciInt = asciInt + 97 - 65;
                    cFixed = (char)asciInt;
                    s = s + cFixed;
                } else if (asciInt <= 122 && asciInt >= 97)
                {
                    s += c;
                }
            }
            return s;
        }
        //Assignment6

        //Assignment7
        public static int sumRemoveDuplicates(int[] intArr)
        {
            int index = 0;
            int sum = 0;
            int[] newIntArr = new int[intArr.Length];
            for (int i = 0; i < intArr.Length; i++)
            {
                newIntArr[i] = 0;
            }
            foreach (int integer in intArr)
            {
                if (!newIntArr.Contains(integer))
                {
                    newIntArr[index] = integer;
                    sum = sum + index;
                    index++;
                }
            }
            return sum;
        }
        //Assignment7
    }

}
