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

            StreamReader s = new StreamReader("palin.txt");//даем название файла
            string n = s.ReadToEnd(); //читаем содержимое файла
            char[] m = n.ToCharArray();
            Array.Reverse(m); //реверсируем слово
            string b = new string(m);
            if (n.Equals(b)) //если реверс и обычное слово равны они палиндром
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            Console.ReadKey();

        }
    }
}
