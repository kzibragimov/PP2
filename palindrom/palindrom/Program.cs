using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader s = new StreamReader("palin.txt");
            string n = s.ReadToEnd();


            char[] m = n.ToCharArray();
            Array.Reverse(m);
            string b = new string(m);
            if (n.Equals(b))
            {
                Console.WriteLine("Palindrome zaibal");
            } else
            {
                Console.WriteLine("Paxa gandon");
            }
        }
    }
}
