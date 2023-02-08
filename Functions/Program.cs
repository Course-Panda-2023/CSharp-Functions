// See https://aka.ms/new-console-template for more information

using System.Linq.Expressions;
using System.Runtime.InteropServices;
using Basic;

int randomNum;
Solution.Assignment1(4, 10, out randomNum);
Console.WriteLine(randomNum);
Console.WriteLine(Solution.Assignment2(2, 6, Calculator.Operation.MULTIPLACTION));
Solution.Assignment3();

double[] res = Solution.Assignment4(true, 2, 5, 5, 2, 9, 9, 1, 1, 10);

res.ToList().ForEach(i => Console.Write($"{i}\t"));
Console.WriteLine();
Console.WriteLine(Solution.Assignment5("hello world!", new char[]{'i', 'o'}));
Console.WriteLine(Solution.Assignment6("A man, a plan, a canal: Panama"));
Console.WriteLine(Solution.Assignment6("race a car"));
Console.WriteLine(Solution.Assignment7(new int[] {2, 5, 5, 2, 9, 9, 1, 1, 10}));
bool[,] board = new bool[,]
{
    { false, true, false },
    { false, false, true },
    { true, true, true },
    { false, false, false }
};
Solution.Assignment8(board, 4, 3);
Helper.Print2DArray(board);
Console.WriteLine("------------");

Console.WriteLine(Solution.Assignment9());
Console.WriteLine(Solution.Bonus1());
