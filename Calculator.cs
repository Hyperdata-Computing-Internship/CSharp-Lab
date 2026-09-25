using System;
using System.Collections.Generic;
using System.Text;

namespace practiceC_
{
    internal class Calculator
    {
        public static void calc()
        {
            Console.WriteLine("press 1 to add");
            Console.WriteLine("press 2 to subtract");
            Console.WriteLine("press 3 to multiply");
            Console.WriteLine("press 4 to divide");
            int choice = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("enter first number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    Console.WriteLine(a + b);
                    break;
                case 2:
                    Console.WriteLine(a - b);
                    break;
                case 3:
                    Console.WriteLine(a * b);
                    break;
                case 4:
                    Console.WriteLine(a / b);
                    break;
                default: 
                    Console.WriteLine("invalid choice!");
                    break;

            }


        }
    }
}
