using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    internal class Helper
    {
        public static void ManageAssignment1()
        {
            Console.WriteLine($"Running assignment 1...");
            int res; 
            Solution.Assignment1(5, 1, out res);
            Console.WriteLine($"Result is {res}");
        }

        public static void ManageAssignment3()
        {
            Solution.Assignment3();
        }

        public static void ManageAssignment4()
        {
            double[] nums = {1, 6, 87, 34, 5, 11};
            double[] sortedArr = Solution.Assignment4(false, nums);
            // print sorted array
            for(int i=0; i<sortedArr.Length; i++)
            {
                Console.Write($"{sortedArr[i]} ");
            }
        }

        public static void ManageAssignment5()
        {
            char[] letters = {'a', 'p'};
            string str = "apple";
            Solution.Assignment5(str, letters);
        }

        public static void ManageAssignment6()
        {
            // string str = "A man, a plan, a canal: Panama";
            string str = "race a car";
            bool isPalindrome = Solution.Assignment6(str);            
            Console.WriteLine(isPalindrome);
        }

        public static void ManageAssignment7()
        {
            int[] nums = {4, 1, 2, 1, 2};
            int numOnce = Solution.Assignment7(nums);
            Console.WriteLine(numOnce);  
        }     
        
        public static int calcAliveNeighs(bool[,] board, int i, int j, int rows, int cols)
        {
            int countAlive = 0;
            for (int horizontal=-1; horizontal<=1; horizontal++)
            {
                for (int vertical=-1; vertical<=1; vertical++)
                {
                    if (horizontal != 0 || vertical != 0)
                    {   
                        if (i+horizontal >=0 && i+horizontal < rows &&
                            j+vertical >= 0 && j+vertical < cols)
                            countAlive += Convert.ToInt32(board[i+horizontal, j+vertical]);
                    }
                }
            }
            return countAlive;            
        }
        public static void ManageAssignment8()
        {
            int rows = 4;
            int cols = 3;
            bool[,] nums = {
                {false, true, false},
                {false, false, true},
                {true, true, true},
                {false, false, false}
            };
            Solution.Assignment8(nums, rows, cols);
        }

        public static bool IsJumpingNumber(int num)
        {
            bool isAsc = true;
            bool isDesc = true;
            bool firstDigit = true;
            int currDigit = 0;
            while (num != 0)
            {  
                if (!firstDigit)
                {
                    if (currDigit > num % 10)
                        isAsc = false;
                    else if (currDigit < num % 10)
                        isDesc = false;
                }
                currDigit = num % 10;
                num /= 10;
                firstDigit = false;
            }
            return !isAsc && !isDesc;
        }
        public static void ManageAssignment9()
        {
            int chosesNum = Solution.Assignment9();
            Console.WriteLine(chosesNum);
        }     
    }
}
