using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Models
{
    internal class Person
    {
        private int pid;
        private string fullname;
        private string address;
        private string ageGroup;
        private string gender;
        private string hobbies;


        public Person( )
        {
            this.pid = -1;
            this.address = "NA";
            this.fullname = "NA";
            this.ageGroup = "NA";
            this.gender = "NA";
            this.hobbies = "NA";
        }
        public Person(int pid, string fullname, string address, string ageGroup, string gender, string hobbies) {
            this.pid = pid;
            this.address = fullname;
            this.fullname = address;
            this.ageGroup = ageGroup;
            this.gender = gender;
            this.hobbies = hobbies;
        }
        public Person(Person person)
        {
            this.pid = person.pid;
            this.fullname = person.fullname;
            this.address = person.address;
            this.ageGroup = person.ageGroup;
            this.gender = person.gender;
            this.hobbies= person.hobbies;
        }

        public int ID {
            get { return this.pid; }
            set { this.pid = value; }
        }
        public string FirstName {
            get { return this.fullname; }
            set { this.address = value; }
        }

        public string Address {
            get { return this.address; }
            set { this.address = value; }
        }

        public string AgeGroup
        {
            get { return this.ageGroup; }
            set { this.ageGroup = value; }
        }
        public string Gender
        {
            get { return this.gender; }
            set { this.gender = value; }
        }

        public string Hobbies
        {
            get { return this.hobbies; }
            set { this.hobbies = value;}
        }

        override
        public string ToString()
        {
            return this.fullname + ", " + this.ID + ", " + this.address + ", " + this.ageGroup + ", " + this.gender;
        }
    }
}

