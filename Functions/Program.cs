// See https://aka.ms/new-console-template for more information
using Basic;

int num;
Solution.Assignment1(105, 100, out num);
Console.WriteLine(num);

int[] arr = new int[] { 4, 1, 1, 2, 2 };
Console.WriteLine(Solution.Assignment7(arr));
char[] letters = { 'i', 'a' };

string str = "arrayAsSpan[i]";
Solution.Assignment5(str, letters);
Console.WriteLine(str);
Console.ReadLine();