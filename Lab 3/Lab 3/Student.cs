namespace Lab_3
{
    class Student
    {
        private string Name;
        private int Grade;
        private Instructor Teacher; 

        public Student(string Name, Instructor Teacher)
        {
            this.Name = Name;
            this.Grade = 0;
            this.Teacher = Teacher;
        }
        
        public int SetGrade (int Grade)
        {
            return this.Grade = Grade;
        }

        public void StudentPrint() 
        {
            System.Console.Write(this.Name);
            System.Console.Write(" obtained a grade of ");
            System.Console.Write(this.Grade);
            System.Console.Write(" in ");
            Teacher.Print();
            System.Console.WriteLine("");
            System.Console.WriteLine("");
        }
    }
}