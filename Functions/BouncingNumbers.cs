using System;

public class BouncingNumbers
{
    public bool IsBouncingNumber(long number)
    {
        string bouncingString = number.ToString();
        int[] arr = bouncingString.Select(x => Convert.ToInt32(x.ToString())).ToArray();
        bool isGoingUp = IsAlwaysGoingUp(arr);
        bool isReverseGoingDown = IsAlwaysGoingDown(arr);
        return !(isGoingUp || isReverseGoingDown);
    }

    private bool IsAlwaysGoingUp(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; ++i)
        {
            if (arr[i] > arr[i + 1])
            {
                return false;
            }
        }
        return true;
    }

    private bool IsAlwaysGoingDown(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; ++i)
        {
            if (arr[i] < arr[i + 1])
            {
                return false;
            }
        }
        return true;
    }
}
