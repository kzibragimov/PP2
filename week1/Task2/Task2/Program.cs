using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task2
{
    class Student

    {
        public string Name, ID;
        public int year;

        public Student(string Name, string ID)//создаем констрруктор, который вводит два параметра
        {
            this.Name = Name;
            this.ID = ID;
            this.year = 1;
        }

        public string getName()
        {
            return this.Name;
        }
        public string getID()
        {
            return this.ID;
        }

        public void Increment()
        {
            this.year++;
        }

        public override string ToString()
        {
            return this.Name + " " + this.ID + " " + this.year;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("Aibar", "18BD110838");//испльзуем конструктор, придаем значения каждому параметру
            s.Increment();
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}