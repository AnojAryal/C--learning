using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_NETv1.V2
{
    internal class Student
    {
        private int sid;
        private string fullname;
        private string level;
        private string section;
        private double sub1;
        private double sub2;
        private double total;
        private double average;
        private string result;

        public Student()
        {
            this.sid = 0;
            this.fullname = "";
            this.level = "";
            this.section = "";
            this.sub1 = 0;
            this.sub2 = 0;
            this.total = 0;
            this.average = 0;
            this.result = "";

        }
        public Student(int sid, string fullname, string section, double sub1, double sub2)
        {


            this.sid = 0;
            this.fullname = fullname;
            this.level = level;
            this.section = section;
            this.sub1 = sub1;
            this.sub2 = sub2;
            this.total = 0;
            this.average = 0;
            this.result = "";

        }
        public Student(Student student)
        {


            this.sid = student.sid;
            this.fullname = student.fullname;
            this.level = student.level;
            this.section = student.section;
            this.sub1 = student.sub1;
            this.sub2 = student.sub2;
            this.total = student.total;
            this.average = student.average;
            this.result = student.result;

        }
        public int SID
        {
            get { return sid; }
            set { sid = value; }
        }
        public string FullName
        {
            get { return fullname; }
            set { this.fullname = value; }
        }
        public string Level
        {
            get { return level; }
            set { this.level = value; }
        }
        public string Section
        {
            get { return section; }
            set { this.section = value; }
        }
        public double Sub1
        {
            get { return sub1; }
            set { sub1 = value; }
        }
        public double Sub2
        {
            get { return sub2; }
            set { sub2 = value; }
        }
        public double Total
        {
            get { return total; }
            set { total = value; }
        }
        public double Average
        {
            get { return average; }
            set { average = value; }
        }
        public string Result
        {
            get { return result; }
            set { result = value; }
        }
        override
            public string ToString()
        { return this.sid + "," + this.fullname + "," + this.level + "," + this.section + "," + this.sub1 + "," + this.sub2 + "," + this.total + "," + this.average + "," + this.result; }
    }
}
