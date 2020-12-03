using System;
using System.Collections.Generic;

class List
{
    public static List<bool> DivisibleBy2(List<int> myList)
    {
        List<bool> report = new List<bool>();
        for (int i = 0; i < myList.Count; i++)
        {
            report.Add(myList[i] % 2 == 0);
        }
        return report;
    }
}
