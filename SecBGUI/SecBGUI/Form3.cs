using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecBGUI
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                const int max = 5;

                int[] nums; //declare
                nums = new int[max];
                nums[0] = 5;
                nums[1] = 10;
                nums[2] = 15;
                //nums[5] = 40;
                nums[3] = 20;
                nums[4] = 30;
                Console.WriteLine(nums.Length);

                //sorting
                //searching
                //processing

                //Arrayprocessing using linq
                int[] nums2 = { 3, 4, 5, 6, 7, 8, 9, 13, 14 };

                //even numbers
                var evenNums = from n in nums2 where n % 2 == 0 select n;

                Console.WriteLine("Even numbers:");

                foreach (int num in evenNums)
                {
                    Console.Write(num + " ");
                }

                Console.ReadLine();

                //for odd numbers
                var oddNums = from n in nums2 where n % 2 != 0 select n;

                Console.WriteLine("Odd numbers:");

                foreach (int num in oddNums)
                {
                    Console.Write(num + " ");
                }

                Console.ReadLine();


                //numbers greater than 5
                var greaterNums = from n in nums2 where n > 5 select n;

                Console.WriteLine("Numbers greater than 5:");

                foreach (int num in greaterNums)
                {
                    Console.Write(num + " ");
                }

                Console.ReadLine();

                //getting numbers greater than 5 and less than 7
                var numbersInRange = nums2.Where(num => num > 5 && num < 7);

                Console.WriteLine("Numbers greater than 5 and less than 7:");

                foreach (int num in numbersInRange)
                {
                    Console.Write(num + " ");
                }

                Console.ReadLine();

                //getting sorted array -- ascending order
                var sortedArray = nums2.OrderBy(num => num).ToArray();

                Console.WriteLine("Sorted Array in Ascending Order:");

                foreach (int num in sortedArray)
                {
                    Console.Write(num + " ");
                }

                Console.ReadLine();

                //getting Max element of an array
                var result = (from n in nums2 orderby n descending select n).Take(1).Skip(0);
                foreach (int num in result)
                {
                    Console.WriteLine("Max :" + num);
                }
                Console.ReadLine();

                //getting sum of an elements
                var sum1 = (from n in nums2 select n).Sum();
                Console.WriteLine("sum :" + sum1);

                //getting number of elements
                var count1 = (from n in nums2 select n).Count();
                Console.WriteLine("Elements :" + count1);

                //getting distinct values form array elements
                int[] dist = { 3, 4, 5, 6, 7, 8, 9, 13, 14, 5, 6, 7 };

                var distinctValues = dist.Distinct();

                Console.WriteLine("Distinct Values from the Array:");

                foreach (int num in distinctValues)
                {
                    Console.Write(num + " ");
                }

                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
