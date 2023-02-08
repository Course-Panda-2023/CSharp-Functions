using System;
using System.Reflection.Metadata.Ecma335;

public class BouncingNumbers
{
	public static int GiveNum()
	{
		int number = 0, num_counter = 0;
		double density = 0;
		while(true) 
		{
			if (number > 21780 && density >= 99)
			{
				return number;
			}
			if (NumIsBouncing(number))
			{
				num_counter++;
            }
			number++;
			density= num_counter/number + 1;
		}
	}
	public static bool NumIsBouncing(in int num)
	{
		if(num < 10) { return true; }
		int temp_num = num;
		List<int> temp_list = new List<int>();        
		bool status = false;		
		bool incr = false;
        while (true)
		{
			if(temp_num < 10)
			{
                temp_list.Add(temp_num);
				break;
            }
			temp_list.Add(temp_num % 10);
			temp_num= temp_num / 10;
		}
		/*foreach(int i in temp_list)
		{
			Console.WriteLine(i);
		}*/
        //Console.WriteLine();
		int incr_counter = 0, descr_counter = 0;
        for (int i = 0; i<temp_list.Count - 1; i++)
		{
			if (temp_list[i+1] >= temp_list[i])
			{
                //Console.WriteLine($"{incr_counter},{temp_list[i + 1]}, {temp_list[i]}");
                incr_counter++;
			}
        }
        for (int i = 0; i < temp_list.Count - 1; i++)
        {
			//console.WriteLine($"{temp_list[i+1]},{temp_list[i]}");

            if (temp_list[i+1] <= temp_list[i])
            {
                //Console.WriteLine("HERE!!!");
                
                //Console.WriteLine($"{descr_counter},{temp_list[i + 1]}, {temp_list[i]}");
                descr_counter++;
            }
        }
        //Console.WriteLine($"{descr_counter},{incr_counter},{temp_list.Count}");
        if (incr_counter == temp_list.Count - 1 || descr_counter == temp_list.Count - 1) { status = true; }
        return status;
    }
	
}
