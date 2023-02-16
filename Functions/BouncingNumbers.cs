using System;

public class BouncingNumbers
{
    public static bool IsAcending(int num)
    {
        while (num != 0)
        {
            int digit = num % 10;
            int tens = num % 100 / 10;
            if (tens < digit)
            {
                return false;
            }
            num /= 10;
        }
        return true;
    }

    public static bool IsDesending(int num)
    {
        int digit;
        while (num != 0)
        {
            digit = num % 10;
            if (num % 100 /10 > digit) { 
            return false;
            }
            num /= 10;
        }
        return true;
    }

    public static bool IsJumping(int num)
    {
        return !(IsAcending(num) || IsDesending(num));

    }

    public static int NumWithMostJumping()
    {
        double precent = 90;
        int amountOfJumping = 19602; //declared in question
        int currNumber = 21781; //declared in question

        while (precent  != 99)
        {
            if (IsJumping(currNumber))
            {
                amountOfJumping++;
                precent = (double)amountOfJumping / (double)currNumber * 100;
            }
            currNumber++;
        }
        return currNumber;
    }
}
