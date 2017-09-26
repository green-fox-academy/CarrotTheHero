using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenFox
{
    class Student : Person
    {
        private string previousOrganization;

        private int skippedDays;
        private int numberOfDays;

        public Student(string name, int age, string gender,string previousOrganization, int skippedDays)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.previousOrganization = previousOrganization;
            this.skippedDays = 0;
        }

        public Student()
        {
            name = "Jane Doe";
            age = 30;
            gender = "female";
            previousOrganization = "The School of Life";
            skippedDays = 0;
        }

        public new void GetGoal()
        {
            Console.WriteLine("Be a junior software developer.");
        }

        public new void Introduce()
        {
            Console.WriteLine("Hi, I'm " + name + ", a " + age +  "year old " + gender +
                "from " + previousOrganization + "who skipped " +
                skippedDays + "days from the course already.");
        }

        public int SkipDays(int numberOfDays)
        {
            return skippedDays + numberOfDays;
        }
    }
}
