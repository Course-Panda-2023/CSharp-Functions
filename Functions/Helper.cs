using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    internal class Helper
    {
        public static void desArray(double[] arr)
        {
            double temp;

            // traverse 0 to array length
            for (int i = 0; i < arr.Length - 1; i++)

                // traverse i+1 to array length
                for (int j = i + 1; j < arr.Length; j++)

                    // compare array element with
                    // all next element
                    if (arr[i] < arr[j])
                    {

                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }

        }

        public static void ascArray(double[] arr)
        {
            double temp;

            // traverse 0 to array length
            for (int i = 0; i < arr.Length - 1; i++)

                // traverse i+1 to array length
                for (int j = i + 1; j < arr.Length; j++)

                    // compare array element with
                    // all next element
                    if (arr[i] > arr[j])
                    {

                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }

        }

        public static bool isJumpingAsc(int num)
        {
            string numAsStr = num.ToString();
            int len = numAsStr.Length;
            for (int i = 0; i < len-1; i++){
                if ((int)numAsStr[i + 1] < (int)numAsStr[i])
                    return false;
            }
            return true;
        }

        public static bool isJumpingdes(int num)
        {
            string numAsStr = num.ToString();
            int len = numAsStr.Length;
            for (int i = 0; i < len-1; i++)
            {
                if ((int)numAsStr[i + 1] > (int)numAsStr[i])
                    return false;
            }
            return true;
        }
        
        ////public static void printTwoDArray(bool[,] try)
        ////{
        ////    foreach (bool[] b in try){
        ////            foreach (bool c in b)
        ////            {
        ////                Console.WriteLine(c);
        ////            }
        ////    }
        ////}

    }
}
