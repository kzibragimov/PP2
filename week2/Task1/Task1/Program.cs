using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
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
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

        }
    }
}
