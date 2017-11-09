using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Instructor
    {
        private string Name;
        private string CourseName;

        public Instructor(string Name, string CourseName)
        {
            this.Name = Name;
            this.CourseName = CourseName;
        }

        public void SetStudentGrade(Student student, int Grade)
        {
            student.SetGrade(Grade);
        }

        public void Print()
        {
            System.Console.Write(this.CourseName);
            System.Console.Write(", which is lecutured by Professor ");
            System.Console.Write(this.Name);
            System.Console.Write(".");

        }

    }
}
