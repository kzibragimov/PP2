using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++) //цикл который бегает по рядам
            {
                for (int j = 0; j < i + 1; j++) //цикл который бегает по звездочкам
                {
                    Console.Write("[*]");
                }
                Console.WriteLine();
            }


        }
    }
}

