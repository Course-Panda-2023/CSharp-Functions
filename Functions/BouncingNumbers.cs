using System;

public class BouncingNumbers
{
    /*
	 * TODO: Write helper function for 'BouncingNumbers'
	 */
	public static bool up(int num)
    {

        string str = num.ToString();
        for (int i = str.Length - 1; i > 0; i--)
        {
            bool h = (int)str[i] >= (int)str[i - 1];
            if (!h)
            {
                return false;
            }
        }
        return true;
    }
    public static bool down(int num)
    {
        string str = num.ToString();
        for (int i = 0; i < str.Length - 1; i++)
        {
            bool h = (int)str[i] >= (int)str[i + 1];
            if (!h)
            {
                return false;
            }
        }
        return true;
    }
}
