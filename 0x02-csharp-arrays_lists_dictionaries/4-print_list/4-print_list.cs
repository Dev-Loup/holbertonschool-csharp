using System;
using System.Collections.Generic;

class List
{
    public static List<int> CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        List<int> num_list = new List<int>();
		for (int iter = 0; iter < size; iter++)
		{
			num_list.Add(iter);
			Console.Write(iter);
			if (iter < size - 1)
				Console.Write(' ');
		}
		Console.WriteLine();
		return num_list;
    }
}
