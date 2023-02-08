using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    internal class Solution
    {
        public static void Assignment2(double num1, double num2, char mathOp)
        {
            double result = 0;
            bool calcSuccess = true;
            switch (mathOp)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 == 0)
                    {
                        Console.WriteLine("Cannot divide by 0.");
                        calcSuccess = false;
                    }
                    result = num1 / num2;
                    break;
                case '^':
                    result = Math.Pow(num1, num2);
                    break;
                default:
                    Console.WriteLine("Operator not recognized");
                    calcSuccess = false;
                    break;
            }
            if (calcSuccess)
            {
                Console.WriteLine($"{num1} {mathOp} {num2} = {result}");
            }
        }
    }
}
