using Basic;
using System.Runtime.CompilerServices;
/*
* TODO: Write code here
*/
Console.WriteLine("Hello!");

int a,b;
char op;
char temp_a;
double result = 0;

a = Convert.ToInt32(Helper.ReadValidNum());
b = Convert.ToInt32(Helper.ReadValidNum());
op = Helper.ReadValidOperation();
result = MathProgramSolution.ComputeOperation(a, b, op);
Console.WriteLine($"The result of {a} {op} {b} is {result}");
Console.ReadLine();