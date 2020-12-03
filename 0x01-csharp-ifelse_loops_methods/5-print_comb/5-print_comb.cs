using System;

namespace _5_print_comb
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int num = 0; num <= 99; num++)
            {
                if (num != 99)
                {
                    Console.Write("{0:00}, ", num);
                }
                else
                {
                    Console.WriteLine("{0:0}", num);
                }
            }
        }
    }
}
