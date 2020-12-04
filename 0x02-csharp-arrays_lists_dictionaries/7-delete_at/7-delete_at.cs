﻿using System;
using System.Collections.Generic;

class List
{
    public static List<int> DeleteAt(List<int> myList, int index)
    {
        if (index >= myList.Count)
        {
            Console.WriteLine("Index is out of range");
        }
        else if (index >= 0)
        {
            myList.Remove(myList[index]);
        }
        return myList;
    }
}
