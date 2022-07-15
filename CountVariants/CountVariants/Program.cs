using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountVariantss
{
    internal class Program
    {
        static int CountVariants(int stairCount)
        {
            int last = 2, secondToLast = 1, current = 0;

            if (stairCount < 3) return stairCount;

            for(int i = 3; i <= stairCount; i++)
            {
                current = last + secondToLast;
                secondToLast = last;
                last = current; 
            }
            return current;

        }
        static void Main(string[] args)
        {
            Console.WriteLine(CountVariants(int.Parse(Console.ReadLine())));
            Console.ReadLine();
        }
    }
}
