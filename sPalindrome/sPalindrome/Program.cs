using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPalindrome
{
    internal class Program
    {
        static bool sPalindrome(string text)
        {
            for (int i = 0; i < text.Length/2; i++)
            {
                if(text[i] != text[text.Length - 1 - i]) return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Console.WriteLine(sPalindrome(text));
            Console.ReadLine();
        }
    }
}
