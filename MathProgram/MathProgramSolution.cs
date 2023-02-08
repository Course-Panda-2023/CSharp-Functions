using System;

namespace Basic
{
	internal class MathProgramSolution
	{
		public static double ComputeOperation(in int a, in int b, in char operation)
		{
			double result = 0;
			switch (operation)
			{
				case '+':
					result = a + b;
					break;
				case '-':
					result = a - b;
					break;
				case '*':
					result = a * b;
					break;
				case '/':
					result = a / b;
					break;
				case '^':
					//result = a + b;
					result = Math.Pow(a, b);
					break;
			}
			return result;
		} 
	}
}