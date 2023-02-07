/*
 * TODO: Write code here
 */

int num1, num2;
char op;
Console.WriteLine("Enter a number");
string str;

str = Console.ReadLine();
num1 = Convert.ToInt32(str);

Console.WriteLine("Enter an operator, i.e. : +, -, *, /");
str = Console.ReadLine();

op = (char)str[0];

Console.WriteLine("Enter a second number");
str = Console.ReadLine();
num2 = Convert.ToInt32(str);

double result = 0;
const int ROUND = 2;
switch (op)
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
        result = Math.Round((double) (num1) / num2, ROUND);
        break;
}

Console.WriteLine($"{num1} {op} {num2} is {result}");
Console.ReadKey();