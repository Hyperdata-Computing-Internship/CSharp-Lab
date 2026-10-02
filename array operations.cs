using System;
using System.Collections.Generic;
using System.Text;

namespace practiceC_
{
    internal class array_operations
    {
        static void Main()
        {
            // int[] x = { 10, 20, 40, 60, 70, 12 };
            Console.WriteLine("Enter Size of array");
            int size = Convert.ToInt16(Console.ReadLine());
            int[] x = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Enter element for {i} index");
                x[i] = Convert.ToInt16(Console.ReadLine());
            }

            int mx = 0;
            foreach (int item in x)
            {
                if (mx < item) //89 < 11
                {
                    mx = item; //89
                }
            }
            Console.WriteLine($"Max element is {mx}");
        }
    }
}
