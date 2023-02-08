using System;

public class BouncingNumbers
{
    public static int AmountOfBouncingNums(int num)
    {
        int counter = 0;
        for (int i = 0; i < num + 1; i++)
        {
            if (IsJumpingNumber(i))
                counter++;
        }
        return counter;
    }

    public static bool IsJumpingNumber(int num)
    {
        const int SingleDigit = 9;

        bool IsAscending = true;
        bool IsDescending = true;
        int tempNum = num;


        while (tempNum > SingleDigit)
        {
            int lastDig = tempNum % 10;
            int beforeLastDig = tempNum % 100;
            beforeLastDig /= 10;

            if (lastDig < beforeLastDig)
                IsAscending = false;
            else if (lastDig > beforeLastDig)
                IsDescending = false;

            tempNum /= 10;
        }
        if (IsAscending == false && IsDescending == false)
            return true;
        return false;
    }

    public static int Half(int num1, int num2)
    {
        double half = (num1 + num2) / 2;
        return (int)half;
    }

}
