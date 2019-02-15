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
            string path = "C:/Users/Acer/Desktop/PP2/week2/Task4/che tam"; //приравниваем к стрингу путь до папки
            string file = "madik.txt"; //название файла
            path = System.IO.Path.Combine(path, file); //создаем файл

            System.IO.File.WriteAllText(path, "che tam"); //пишем что либо

            string path1 = "C:/User/Acer/Desktop/PP2/week2/Task4/tiwina"; //путь к другой папке
            string newfile = System.IO.Path.Combine(path1, file); //создаем новый файл
            System.IO.File.Copy(path, newfile, true); //копируем текст

            File.Delete(path); //удаляем первый файл
        }
    }
}
