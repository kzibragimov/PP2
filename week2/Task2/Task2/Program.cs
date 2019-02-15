using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        public static bool IsPrime(int x) //создаем функцию
        {
            if (x == 1)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(x); i++) //если число не делится на числа меньше его квадрата корня оно прайм
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
            StreamReader s = new StreamReader("prime.txt"); //читаем содержимое с файла
            string a = s.ReadToEnd();
            string[] arr = a.Split(); //делим на массив
            s.Close(); //закрываем
            StreamWriter sw = new StreamWriter("output.txt"); //создаем другой файл
            for (int i = 0; i < arr.Count(); i++) //бежим циклом до конца
            {
                if (IsPrime(int.Parse(arr[i])) == true)
                {
                    sw.Write(arr[i] + " ");
                }
            }
            sw.Close();
        }
    }
}

