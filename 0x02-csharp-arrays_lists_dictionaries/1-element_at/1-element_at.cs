using System;

class Array
{
    public static int elementAt(int[] array, int index)
    {
        if (array.Length > index && index > 0)
        {
            return array[index];
        }
        return -1;
    }
}
