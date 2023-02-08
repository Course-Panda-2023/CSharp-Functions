/*
 * TODO: Write code here
 */
void calculator(double firstNum, char op, double secondNum)
{
    double num = -1;
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
        default:
            return;
    }
    Console.WriteLine($"{firstNum} {op} {secondNum} = {num}");
}
//Console.WriteLine(calculator(10,'+',12))