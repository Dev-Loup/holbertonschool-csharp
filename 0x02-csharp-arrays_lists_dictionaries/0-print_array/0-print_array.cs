using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        int[] num_array = new int[size];
        for(int iter = 0; iter < size; iter++)
        {
            num_array[iter] = iter;
            if (iter != 0)
            {
                Console.Write(" ");
            }
            Console.Write("{0}", iter);
        }
        Console.WriteLine();
        return num_array;
    }
}
