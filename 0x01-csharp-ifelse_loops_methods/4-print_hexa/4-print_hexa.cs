﻿using System;

namespace _4_print_hexa
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int num = 0; num < 99; num++)
            {
                Console.Write("{0} = 0x{0:x}\n", num);
            }
        }
    }
}
