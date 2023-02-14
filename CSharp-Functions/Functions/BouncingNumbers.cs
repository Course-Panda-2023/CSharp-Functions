﻿using System;

public class BouncingNumbers
{
    public static bool IsJumpingNumber(int num)
    {
        bool IsAscending = true;
        bool IsDescending = true;
        int tempNum = num;
        do
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
        while (tempNum / 10 > 0);
        return (IsAscending == false && IsDescending == false);
    }

}
