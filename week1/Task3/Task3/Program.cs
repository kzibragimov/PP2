﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //размер массива
            string s = Console.ReadLine();
            string[] arr = s.Split();
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < 2; j++) //цикл внутри цикла который создает копию цифры
                {
                    Console.Write(arr[i]);
                }
            }
        }
    }
}
