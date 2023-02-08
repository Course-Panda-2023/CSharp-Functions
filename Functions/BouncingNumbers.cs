using System;

public class BouncingNumbers
{
    public static Boolean checkIfIncreasing(int n)
    {
        string check = n.ToString();
        for (int i = 0; i < check.Length - 1; i++)
        {
            if (Convert.ToInt32(check[i + 1]) < Convert.ToInt32(check[i]))
            {
                return false;
            }
        }
        return true;
    }

    public static Boolean checkIfDecreasing(int n)
    {
        string check = n.ToString();
        for (int i = 0; i < check.Length - 1; i++)
        {
            if (Convert.ToInt32(check[i + 1]) > Convert.ToInt32(check[i]))
            {
                return false;
            }
        }
        return true;
    }

    public static Boolean isBouncy(int n)
    {
        if (!(checkIfIncreasing(n)) && !(checkIfDecreasing(n))) {
            return true;
        }
        return false;
    }


}
