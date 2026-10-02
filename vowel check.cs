using System;
using System.Collections.Generic;
using System.Text;

namespace practiceC_
{
    internal class vowel_check
    {
        static void Main()
        {
            String[] country = { "india", "japan", "malasia", "usa", "unitedkingdom" };

            foreach (String x in country)
            {
                Console.WriteLine($"Country:{x}");
                char[] arr = x.ToCharArray();
                int countvowel = 0;
                int countcons = 0;
                foreach (char ch in arr)
                {
                    switch (ch)
                    {
                        case 'a':
                        case 'e':
                        case 'i':
                        case 'o':
                        case 'u':
                            countvowel++;
                            break;
                        default:
                            countcons++;
                            break;
                    }
                }
                Console.WriteLine("Total Vowel is {0}", countvowel);
                Console.WriteLine("Total Consonant is {0}", countcons);
            }
        }
    }
}
