﻿//See https://aka.ms/new-console-template for more information
using Basic;


Solution.Assignment1(1, 100, out int res);
Console.WriteLine(res);
Solution.Assignment1(100, 1, out int res1);
Console.WriteLine(res1);


Solution.Assignment3();


Helper.PrintArr(Solution.Assignment4(false, 87, 0, 3, 67, 1, 90));


char[] c = { 'a', 'p', 'z' };
string str = "applez";
Console.WriteLine(str);
Solution.Assignment5(ref str, c);
Console.WriteLine(str);


string str1 = "A man, a plan, a canal: Panama";
Console.WriteLine(Solution.Assignment6(str1));


int[] arr = { 4, 1, 2, 1, 2 };
Console.WriteLine(Solution.Assignment7(arr));


bool[,] board = {
                {false,true,false},
                {false,false,true},
                {true,true,true},
                {false,false,false}
            };

Solution.Assignment8(board, 4, 3);


Console.WriteLine(Solution.Assignment9());


Console.WriteLine(Solution.Bonus1());


uint[] map = { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };
Console.WriteLine(Solution.Bonus2(map));
