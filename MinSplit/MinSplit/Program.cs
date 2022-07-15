using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinSplitt
{
    internal class Program
    {
        static int MinSplit(int amount)
        {
            int count = 0;
            int[] coins = new int[] {1, 5, 10, 20, 50};
            for (int i = 4; i >=0; i--)
            {
                count += amount / coins[i];
                amount %= coins[i];
                if (amount == 0) break;
            }

            return count;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(MinSplit(int.Parse(Console.ReadLine())));
            Console.ReadLine();
        }
    }
}
