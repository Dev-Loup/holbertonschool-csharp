using System;

class Array
{
    public static int[] ReplaceElement(int[] array, int index, int n)
    {
        if (array.Length > index && index >= 0)
        {
            array[index] = n;
            return array;
        }
        Console.WriteLine("Index out of range");
        return array;
    }
}