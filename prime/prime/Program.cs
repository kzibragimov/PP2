using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace prime
{
    class Program
       
    {
        public static bool IsPrime(int x)
        {
            if(x == 1)
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
            StreamReader s = new StreamReader("prime.txt");
            string a = s.ReadToEnd();
            string[] arr = a.Split();
            s.Close();
            StreamWriter sw = new StreamWriter("output.txt");
            for (int i = 0; i < arr.Count(); i++)
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
             
