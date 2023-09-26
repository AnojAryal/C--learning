using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3demo.W2
{
    internal class ClassAndObject
    {
    }

    class Employee
    {
        string name { get; set; } = "";
        int age { get; set; } = default;
        string position { get; set; } = "";



        Employee(string name, int age, string position)
        {
            this.name = name;
            this.age = age;
            this.position = position;
        }



        class Program
        {
            public static void Main(string[] args)
            {
                Employee emp = new Employee("Ram", 24, "Staff");

            }
        }
    }

}