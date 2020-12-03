using System;

class Array
{
    public static void Reverse(int[] array)
    {
        if (array != null)
        {
            for (int iter = array.Length - 1; iter >= 0; iter--)
            {
                if (iter != (array.Length - 1))
                {
                    Console.Write(" ");
                }
                Console.Write("{0}", array[iter]);
            }
        }
        Console.WriteLine();
    }
}
