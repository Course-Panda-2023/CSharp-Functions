using System.Linq;
using System;
using System.IO;
using System.Text;

namespace Basic
{
    internal class Helper
    {
        public static string ReadValidNum()
        {
            string num;
            Console.WriteLine("Please, enter one number!");
            num = Console.ReadLine();
            bool isNumeric = int.TryParse(num, out _);
            while (!isNumeric)
            {
                Console.WriteLine("The input you entered is not valid!");
                Console.WriteLine("Please, try again...");
                num = Console.ReadLine();
                isNumeric = int.TryParse(num, out _);
            };
            return num;
        }
        public static char ReadValidOperation()
        {
            char num;
            Console.Write("Please, enter operation!");
            num = Console.ReadLine()[0];
            char[] legal_op = { '+', '-', '*', '/', '^' };
            while (!legal_op.Contains(num))
            {
                Console.WriteLine("The input you entered is not valid!");
                Console.WriteLine("Please, try again...");
                num = Console.ReadLine()[0];
            }
            return num;
        }
        /*public static double Power(in b, in n)
        {
            if (!b)
            {
                return b;
            }
            return P
        }*/
    }     
}