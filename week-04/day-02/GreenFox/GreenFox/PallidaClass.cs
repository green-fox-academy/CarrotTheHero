using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenFox
{
    class PallidaClass
    {        
        private string className;
        private List<Student> students;
        private List<Mentor> mentors;

        PallidaClass(string className)
        {
            this.className = className;
            students = new List<Student>();
            mentors = new List<Mentor>();

        }

        public void AddStudent(Student)
        {
            students.Add()
        }

        public void AddMentor(Mentor)
        {
            mentors.Add()
        }

        public void Info()
        {
            Console.WriteLine("Pallida " + className + " class has " + students.size + " students and " + mentors.size + " mentors.");
        }
    }
}
