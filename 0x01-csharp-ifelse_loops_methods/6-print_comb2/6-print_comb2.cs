using System;

namespace _6_print_comb2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int tens = 0; tens < 10; tens++)
            {
                for (int units = 0; units < 10; units++)
                {
                    if (tens == 8 && units == 9)
                    {
                        Console.WriteLine("{0}{1}",tens, units);
                    }
                    else if (units < tens)
                    {
                        Console.Write("{0}{1}, ",tens, units);
                    }
                }
            }
        }
    }
}
