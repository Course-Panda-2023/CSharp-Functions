/*
 * TODO: Write code here
 */
void calculator(double firstNum, char op, double secondNum)
{
    int num;
    switch (op)
    {
        case '+':
            num = firstNum + secondNum;
            break;

        case '-':
            num = firstNum - secondNum;
            break;

        case '*':
            num = firstNum * secondNum;
            break;

        case '/':
            if (secondNum == 0)
            {
                Console.WriteLine("error");
                return;
            }
            else
                num = firstNum / secondNum;
            break;

        case '^':
            num = Math.Pow(firstNum, secondNum);
            break;
    }
    Console.WriteLine($"The result of the calculation is: {i}")
}
Console.WriteLine(calculator(10,'+',12))