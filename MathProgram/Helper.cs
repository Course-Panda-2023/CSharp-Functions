using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    internal class Helper
    {
        public static void ManageAssignment()
        {
            double num1, num2;
            char mathOp;
            try
            {
                Console.WriteLine("Insert first number.");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Insert mathematical operator.");
                mathOp = Console.ReadKey().KeyChar;
                Console.WriteLine("Insert second number.");
                num2 = Convert.ToDouble(Console.ReadLine());
                Solution.Assignment2(num1, num2, mathOp);
            }
            catch(FormatException e)
            {
                Console.WriteLine($"Number entered is invalid.");
                Console.WriteLine($"Exception is {e}.");
                
            }
            
        }
    }
}
