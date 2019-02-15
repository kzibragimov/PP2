using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task3
{
    class Program
    {
        static void Printspace(int space)
        {
            for (int i = 0; i < space; i++)
                Console.Write(" ");
        }
        static void task(DirectoryInfo directory, int space)
        {
            FileInfo[] files = directory.GetFiles();
            DirectoryInfo[] directories = directory.GetDirectories();
            foreach(FileInfo file in files)
            {
                Printspace(space);
                Console.WriteLine(file.Name);
            }
            foreach(DirectoryInfo d in directories)
            {
                Printspace(space);
                Console.WriteLine(d.Name);
                task(d, space + 1);
            }
        }
        static void Main(string[] args)
        {
            DirectoryInfo d = new DirectoryInfo("/Users/Acer/Desktop/PP2");
            task(d, 1);

        }
        

        }
        
        }
    

