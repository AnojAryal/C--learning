using System;

namespace Week3demo.W1
{
   /* internal class DataTypes2
    {
    }

    // Reference Type
    // 1. System Defined
    // 2. User defined
    // a. Class
    // b. Interface
    // c. Delegate
    // d. record
    class Person
    {
        int pid;
        string name;

        public Person(int pid, string name)
        {
            this.pid = pid;
            this.name = name;
        }

        public override string ToString()
        {
            return this.pid + " , " + this.name;
        }
    }

    interface Inf1
    {
        void f1(); //abstract method 
    }

    class DataTypes3 : Inf1
    {
        //implements Inf1
        public void f1()
        {
            Console.WriteLine("Hello from f1 of class1");
        }
    }

    class Class2 : Inf1
    {
        //implements Inf1
        public void f1()
        {
            Console.WriteLine("Hello from f1 of class2");
        }
    }

    delegate int DelegateFunction(int x, int y);

    internal class DelegateTest
    {
        public int Sum(int x, int y)
        {
            return x + y;
        }

        public int Prd(int x, int y)
        {
            return x * y;
        }
    }

    public class OldStudent
    {
        public int sid;
        public string name;

        public OldStudent(int sid, string name)
        {
            this.sid = sid;
            this.name = name;
        }
    }

    public record class NewStudent
    {
        public int sid { get; set; } = default;

        public string name { get; set; } = "";

        public NewStudent(int sid, string name)
        {
            this.sid = sid;
            this.name = name;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");

            // 1. System Defined
            // string

            string str1 = "Hello i am a good boy.";
            Console.WriteLine(str1);

            string str2 = "Hi my friends ";

            object obj1 = new object();
            obj1 = str1;
            Console.WriteLine(obj1);
            Console.WriteLine(str2);
            Console.WriteLine(str1);

            // 2. User Defined
            // a. Class

            Person p1;
            p1 = new Person(1, "Aryal ji");
            Console.WriteLine(p1); // call ToString

            DataTypes3 obj2 = new DataTypes3();
            Class2 obj3 = new Class2();
            obj2.f1();
            obj2.f1();

            new Class2().f1();
            new DataTypes3().f1();

            DelegateFunction df1 = new DelegateTest().Sum;
            int result = df1(8, 7);
            Console.WriteLine(result);

            df1 = new DelegateTest().Prd;
            result = df1(2, 3);
            Console.WriteLine(result);

            OldStudent s01 = new OldStudent(1, "hari");
            OldStudent s02 = new OldStudent(1, "hari");

            bool result1 = (s01 == s02);
            Console.WriteLine(result1);

            NewStudent s03 = new NewStudent(1, "hari");
            NewStudent s04 = new NewStudent(1, "hari");

            bool result2 = (s03 == s04);
            Console.WriteLine(result2);

        }
    }*/
}
