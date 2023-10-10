using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3demo.W1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int num1 = 6;
            Console.WriteLine(num1); //value
            unsafe
            {
                int* p1;
                p1 = &num1;
                Console.WriteLine(*p1); //pointed value
                Console.WriteLine((int)p1); //pointed address
              
            }
        

        }
    }
    internal class DataTypes3
    {

    }
}
