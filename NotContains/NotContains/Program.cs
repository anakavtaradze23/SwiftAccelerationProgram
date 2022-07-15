using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotContainss
{
    internal class Program
    {
        static int NotContains(int[] array)
        {
            int min = 1;
            Array.Sort(array);
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == min) min++;
            }
            return min;
        }
        static void Main(string[] args)
        {
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(NotContains(array));
            Console.ReadLine();
        }
    }
}
