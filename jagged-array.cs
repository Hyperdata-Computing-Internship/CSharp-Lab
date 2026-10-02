using System;
using System.Collections.Generic;
using System.Text;

namespace practiceC_
{
    internal class jagged_array
    {
        static void Main()
        {
            Console.WriteLine("Enter number of rows:");
            int rows = Convert.ToInt32(Console.ReadLine());

            int[][] arr = new int[rows][];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Enter number of columns for row {i}:");
                int cols = Convert.ToInt32(Console.ReadLine());

                arr[i] = new int[cols];

                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.WriteLine($"Enter element for row {i}, index {j}:");
                    arr[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("\n--- Output and Row Sums ---");

            for (int i = 0; i < arr.Length; i++)
            {
                int sum = 0;

                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + " ");
                    sum += arr[i][j]; 
                }

                Console.WriteLine($"-> Sum of row {i} is {sum}");
            }
        }
    }
}
