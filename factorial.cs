using System;
using System.Collections.Generic;
using System.Text;

namespace practiceC_
{
    internal class factorial
    {
        public static void fact()
        {
            Console.Write("enter a number to calculatee its factorial");
            int num = Convert.ToInt32(Console.ReadLine());
            int ans=num;
            for (int i = num-1; i > 0; i--) {
                ans *= i;
            }
            Console.WriteLine(ans);
        }
    }
}
