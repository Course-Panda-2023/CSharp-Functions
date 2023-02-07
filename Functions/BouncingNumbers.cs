using System;

public class BouncingNumbers
{
    public static bool CheckIfNumberIsBouncing(int num)
    {
        bool flag = true;
        string str = num.ToString();
        char[] chars = str.ToCharArray();
        chars = chars.OrderBy(c => c).ToArray();
        string ascSorted = new string(chars);
        if (str == ascSorted)
            flag = false;
        char[] c = str.ToCharArray();
        c = c.OrderByDescending(c => c).ToArray();
        string decSorted = new string(c);
        if (str == decSorted)
            flag = false;
        return flag;
    }
}
