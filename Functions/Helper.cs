using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    internal class Helper
    {
        public static double[] ReverseArr(double[] nums)
        {
            double[] reverseArr = new double[nums.Length];
            int counter = 0;
            int arrLength = nums.Length;
            while (arrLength > 0)
            {
                reverseArr[counter] = nums[arrLength - 1];
                arrLength--;
                counter++;
            }
            return reverseArr;
        }

        public static void PrintArr(double[] nums)
        {
            Console.Write('{');
            for (int i = 0; i < nums.Length; i++)
            {
                if (i == nums.Length - 1)
                    Console.Write(nums[i]);
                else
                    Console.Write(nums[i] + ", ");
            }
            Console.WriteLine('}');
        }
    }
}
