using System;

public class BouncingNumbers
{
    public static bool IsSpecialNumber(int num, bool rising)
    {
        bool res = true;
        int prevDigit, currDigit;
        
        if (num < 0) { num = -1 * num; }

        prevDigit = num % 10;
        num = num / 10;

        while (num > 0)
        {
            currDigit = num % 10;
            num = num / 10;

            if (prevDigit == -1) { continue; }

            if (rising)
            {
                if (currDigit < prevDigit)
                {
                    return false;
                }
            }
            else
            {
                if (currDigit > prevDigit)
                {
                    return false;
                }
            }

            prevDigit = currDigit;
        }

        return true;
    }
    public static bool IsNumberBouncing(int num)
    {
        return ((!IsSpecialNumber(num, true)) & (!IsSpecialNumber(num, false)));
    }
}
