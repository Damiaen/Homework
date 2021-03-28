using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5
{
    class Student
    {
        private string name;
        private int age;
        private int monthlyIncome;

        public Student(string name, int age, int monthlyIncome)
        {
            this.name = name;
            this.age = age;
            this.monthlyIncome = monthlyIncome;
        }

        public void Print()
        {
            Console.WriteLine(name,age,monthlyIncome);
        }
    }
}
