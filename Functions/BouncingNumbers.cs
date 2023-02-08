using System;
using System.Globalization;
public class BouncingNumbers
{
    public static bool IsAscending(int num)
    {
        int temp = num;
        int digit = temp % 10;
        temp = temp / 10;
        if (temp > 0)
        {
            while (temp > 0)
            {
                //Console.WriteLine(digit + " " + temp % 10);
                if (digit < temp % 10)
                {
                    return false;
                }
                digit = temp % 10;
                temp = temp / 10;
            }
            return true;
        }
        else
        {
            return true;
        }
    }
    public static bool IsBouncing(int num)
    {
        int temp = num;
        int reverse = 0;
        while (temp > 0)
        {
            int remainder = temp % 10;
            reverse = (reverse * 10) + remainder;
            temp = temp / 10;
        }

        if ((!IsAscending(num)) && (!IsAscending(reverse)))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
