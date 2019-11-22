namespace P03_StudentSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StudentSystem
    {
        private List<Student> students;

        public StudentSystem()
        {
            this.students = new List<Student>();
        }
        
        public Student Get(string name)
        {
            return this.students.FirstOrDefault(x => x.Name == name);
        }

        public void Create(string name, int age, double grade)
        {
            if (this.students.All(x => x.Name != name))
            {
                Student student = new Student(name, age, grade);
                this.students.Add(student);
            }
        }
    }
}
