using System;
using System.Collections.Generic;
using System.Text;

namespace practiceC_
{
    internal class multi_dimensional_arrays
    {
        static void Main(string[] args)
        {
            int row, col;
            Console.WriteLine("Enter number of rows");
            row = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Enter number of cols");
            col = Convert.ToInt32(Console.ReadLine()); 
            int[,] arr = new int[row, col]; 
        
        for (int i = 0; i < row; i++) 
        {
                for (int j = 0; j < col; j++) 
                {
                    Console.WriteLine($"Enter element for {i}{j} index"); 
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
        }

        Console.WriteLine("Result is "); 

        for (int i = 0; i < row; i++) 
        {
                int s = 0; 
                for (int j = 0; j < col; j++) 
                {
                    s = s + arr[i, j]; 
                    Console.Write(arr[i, j] + " "); 
                }
                Console.WriteLine($"Sum of row: {i} is {s}");
        }
        }
    }
}
