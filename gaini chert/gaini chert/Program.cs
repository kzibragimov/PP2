using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gaini_chert
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] arr = n.Split();
            for(int i = 0; i < n; i++)
            {
                Console.Write(i + i);
            }
        }
    }
}

