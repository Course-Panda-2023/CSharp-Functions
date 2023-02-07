using System;

public class BouncingNumbers
{
    public static bool IsBouncingNum(int num)
    {
        int copyNum = num;
        int digit;
        int tmpAsc = 0;
        while (copyNum > 0)
        {
            digit = copyNum % 10;
            if (digit >= tmpAsc)
            {
                tmpAsc = digit;
            }
            else
            {
                break;
            }

            copyNum /= 10;
        }
        if (copyNum == 0)
        {
            return false;
        }

        copyNum = num;
        int tmpDsc = 10;
        while (copyNum > 0)
        {
            digit = copyNum % 10;
            if (digit <= tmpDsc)
            {
                tmpDsc = digit;
            }
            else
            {
                break;
            }

            copyNum /= 10;
        }
        if (copyNum == 0)
        {
            return false;
        }
        return true;

    }
}
