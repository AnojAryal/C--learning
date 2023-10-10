using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_consoloapp
{
    internal class Week3_1
    {
    }

    enum Days { SUN, MON };

    struct struct1
    {
        public int num1;
        public int num2;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello I am FraNzY!!");
            //1. Data Types
            //a. Basic (bool, char,sbyte, byte, short, ushort, int, uint, ulong, float, double, decimal)
            //b. user defined

            //enum
            Days day1 = Days.SUN;
            day1 = Days.MON;
            Console.WriteLine(day1);

            //struct
            struct1 s1;
            s1.num1 = 9;
            s1.num2 = 10;
            Console.WriteLine("{0}, {1}", s1.num1, s1.num2);

        }
    }
}