using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsProperlly
{
    internal class Program
    {
        static bool IsProperly(string sequence)
        {
            int beginning=0, end=0;
            for(int i=0; i<sequence.Length; i++)
            {
                if(sequence[i] == '(') beginning++;
                else end++;

                if (beginning < end) return false;
            }
            if (beginning != end) return false;
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(IsProperly(Console.ReadLine()));
            Console.ReadLine();
        }
    }
}
