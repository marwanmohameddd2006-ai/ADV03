using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_3_ADV
{
    internal class ConsolHelper
    {
        public static void PrintHashSet<T>( HashSet<T> hashSet)
        {
            if (hashSet is not null && hashSet.Count > 0)
            {
                
                Console.WriteLine(string.Join(" ,", hashSet));
            }
        }
    }
}
