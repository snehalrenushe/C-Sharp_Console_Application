//2. Write a program using overloading class constructor.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2
{
    class Student
    {
        private double SubjectOne;
        private double SubjectTwo;
        string StudentName;
        public Student()
        {
            this.SubjectOne = 80;
        }
        public Student(double SubjectOne)
        {
            this.SubjectOne = SubjectOne;
        }
        public Student(string StudentName, double SubjectOne, double SubjectTwo)
        {
            this.SubjectOne = SubjectOne;
            this.SubjectTwo = SubjectTwo;
            this.StudentName = StudentName;
        }
        public double GetSubjectOneMarks()
        {
            return this.SubjectOne;
        }
        public double GetSubjectTwoMarks()
        {
            return this.SubjectTwo;
        }
        public string GetStudentName()
        {
            return this.StudentName;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            Student s2 = new Student(90);
            Student s3 = new Student("Amit", 88, 60);
            Console.WriteLine("One");
            Console.WriteLine("Subject One Marks: {0}", s1.GetSubjectOneMarks());
            Console.WriteLine();
            Console.WriteLine("Second");
            Console.WriteLine("Subject One Marks: {0}", s2.GetSubjectOneMarks());
            Console.WriteLine();
            Console.WriteLine("Third");
            Console.WriteLine("Student name: {0}", s3.GetStudentName());
            Console.WriteLine("Subject One Marks: {0}", s3.GetSubjectOneMarks());
            Console.WriteLine("Subject Two Marks: {0}", s3.GetSubjectTwoMarks());
            Console.ReadKey();
        }
    }
}
