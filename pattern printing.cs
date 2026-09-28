using System;
using System.Collections.Generic;
using System.Text;

namespace practiceC_
{
    internal class pattern_printing
    {
        static void Main()
        {
            for (int i = 0; i <= 5; i++)
            {
                for (int j = 5; j >= i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}

