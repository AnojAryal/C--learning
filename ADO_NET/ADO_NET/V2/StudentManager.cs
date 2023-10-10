using ADO_NET.V2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_NETv1.V2
{
    internal class StudentManager
    {
        private Student student;
        public StudentManager(Student student)
        {
            this.student = student;
        }
        public Student STUDENT
        {
            get { return this.student; }
            set { this.student = value; }
        }
        public void Calculatetotal()
        {
            this.student.Total = this.student.Sub1 + this.student.Sub2;
        }
        public void CalculateAverage()
        {
            this.student.Average = this.student.Total / 2;

        }
        public void CalculateResult()
        {
            if (this.student.Sub1 >= 40 && this.student.Sub2 >= 40)
            {
                this.student.Result = "Pass";
            }
            else
            {
                this.student.Result = "Fail";
            }

        }
    }
}