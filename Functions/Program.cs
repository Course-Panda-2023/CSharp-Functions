﻿// See https://aka.ms/new-console-template for more information
using Basic;

Console.WriteLine("Assignment 1:");
int res;
Solution.Assignment1(10, 'a', out res);
Console.WriteLine($"The random number is: {res}");

Console.WriteLine("Assignment 3:");
Solution.Assignment3();

Console.WriteLine("Assignment 4:");
Helper.PrintArray(Solution.Assignment4(false, 29, 39, 0, 3, 2));

Console.WriteLine("Assignment 5:");
string str = "hello and fuck my life";
char[] chars = {'h', 'y', 'u', 'e'};
Solution.Assignment5(str, chars);

Console.WriteLine("Assignment 6:");
Console.WriteLine(Solution.Assignment6("aab''cBa"));

Console.WriteLine("Assignment 7:");
int[] nums = { 1, 2, 3, 3, 2, 1, 10 };
Console.WriteLine(Solution.Assignment7(nums));

Console.WriteLine("Assignment 8:");
bool[,] board = { { false, true, false }, { false, false, true }, { true, true, true }, { false, false, false } };
Solution.Assignment8(board, 4, 3);

Console.WriteLine("Assignment 9:");
Console.WriteLine(Solution.Assignment9());

Console.WriteLine("Bonus 1:");
Console.WriteLine(Solution.Bonus1());

Console.WriteLine("Bonus 2:");
Console.WriteLine(Solution.Bonus2(new uint[] {3, 2, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1}));
