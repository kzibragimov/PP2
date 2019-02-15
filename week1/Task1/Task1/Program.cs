using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program

    {
        public static bool IsPrime(int x)  //создаем функцию   
        {
            if (x == 1)     //если переменная равна 1, она будет прайм
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(x); i++)  //если число прайм он не будет делиться на корень квадрата заданного числа
            {
                if (x % i == 0)
                {
                    return false;
                }

            }
            return true;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());  //размер массива
            string s = Console.ReadLine();
            List<string> res = new List<string>(); //создаем вектор
            string[] arr = s.Split(); //создаем массив
            for (int i = 0; i < arr.Count(); i++) //пробегаемся от начала до конца массива
            {
                if (IsPrime(int.Parse(arr[i])) == true)
                    res.Add(arr[i]);
            }

            Console.WriteLine(res.Count); //выписываем число праймов
            foreach (string d in res)
            {
                Console.Write(d + " "); //затем сами праймы
            }
            Console.ReadKey();
        }
    }
}
