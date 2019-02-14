using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program

    {
        public static bool IsPrime(int x)
        {
            if (x == 1)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(x); i++)
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
            int n = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            List<string> res = new List<string>();
            string[] arr = s.Split();
            for (int i = 0; i < arr.Count(); i++)
            {
                if (IsPrime(int.Parse(arr[i])) == true)
                    res.Add(arr[i]);
            }

            Console.WriteLine(res.Count);
            foreach (string d in res)
            {
                Console.Write(d + " ");
            }
            Console.ReadKey();
        }
    }
}
