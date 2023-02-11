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

        //Assignment8
        public static int numNeighbors(int x, int y, int[,] board, int rows, int cols)
        {
            if (x > 0 && x < cols - 1 && y > 0 && y < rows - 1)
            {
                return board[x - 1, y - 1] + board[x, y - 1] + board[x + 1, y - 1] + board[x + 1, y] + board[x + 1, y + 1] +
                    board[x, y + 1] + board[x - 1, y + 1] + board[x - 1, y];
            }
            if (x == 0 && y > 0 && y < rows - 1)
            {
                return board[x, y - 1] + board[x + 1, y - 1] + board[x + 1, y] + board[x + 1, y + 1] +
                    board[x, y + 1];
            }
            if (x > 0 && x < cols - 1 && y == 0)
            {
                return board[x + 1, y] + board[x + 1, y + 1] +
                    board[x, y + 1] + board[x - 1, y + 1] + board[x - 1, y];
            }
            if (x == cols - 1 && y > 0 && y < rows - 1)
            {
                return board[x - 1, y - 1] + board[x, y - 1] +
                    board[x, y + 1] + board[x - 1, y + 1] + board[x - 1, y];
            }
            if (x > 0 && x < cols - 1 && y == rows - 1)
            {
                return board[x - 1, y - 1] + board[x, y - 1] + board[x + 1, y - 1] + board[x + 1, y] + board[x - 1, y];
            }
            if (x == 0 && y == 0)
            {
                return board[x + 1, y] + board[x + 1, y + 1] +
                    board[x, y + 1];
            }
            if (x == 0 && y == rows - 1)
            {
                return board[x, y - 1] + board[x + 1, y - 1] + board[x + 1, y];
            }
            if (x == cols - 1 && y == 0)
            {
                return board[x, y + 1] + board[x - 1, y + 1] + board[x - 1, y];
            }
            if (x == cols - 1 && y == rows - 1)
            {
                return board[x - 1, y - 1] + board[x, y - 1] + board[x - 1, y];
            }
            return -1;
        }
        //Assignment8

        //Assignment9
        public static bool isBouncingNumber(int n)
        {
            String s = n.ToString();
            int index = 0;
            int len = s.Length;
            if (len < 3)
            {
                return false;
            }
            while (index + 2 <= len - 1)
            {
                char c1 = s[index];
                char c2 = s[index + 1];
                char c3 = s[index + 2];
                int num1 = c1 - '0';
                int num2 = c2 - '0';
                int num3 = c3 - '0';
                int k = 1;
                while (num2 == num3 && index + 2 + k <= len - 1)
                {
                    c3 = s[index + 2 + k];
                    num3 = c3 - '0';
                    k++;
                }
                index++;
                if ((num1 < num2 && num2 > num3) || (num1 > num2 && num2 < num3))
                {
                    return true;
                }
            }
            return false;
        }
        //Assignment9
    }

}
