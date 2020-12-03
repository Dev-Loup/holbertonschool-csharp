using System;

namespace _6_print_comb2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int units = 0; units < 10; units++)
            {
                for (int tens = 0; tens < 10; tens++)
                {
                    if (units == 8 && tens == 9)
                    {
                        Console.WriteLine("{0}{1}",tens, units);
                    }
                    else if (tens < units)
                    {
                        Console.Write("{0}{1}, ",tens, units);
                    }
                }
            }
        }
    }
}
