﻿namespace P03_StudentSystem
{
    public class Student
    {
        public double Grade { get; private set; }

        public int Age { get; private set; }

        public string Name { get; private set; }

        public Student(string name, int age, double grade)
        {
            this.Name = name;
            this.Age = age;
            this.Grade = grade;
        }

        public override string ToString()
        {
            string studentInfo = $"{this.Name} is {this.Age} years old.";

            if (this.Grade >= 5.00)
            {
                studentInfo += " Excellent student.";
            }
            else if (this.Grade < 5.00 && this.Grade >= 3.50)
            {
                studentInfo += " Average student.";
            }
            else
            {
                studentInfo += " Very nice person.";
            }

            return studentInfo;
        }
    }
}