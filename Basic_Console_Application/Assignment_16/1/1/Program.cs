//1. Write a program to show the use of public Access Modifier in c#
//Ex:
//Input :
//Details of student
//Studentid , StudentName
//Output :
//Studentid: 101
//StudentName: "santhi"

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1
{
    class Program
    {
        public int Studentid;
        public string StudentName;

        public Program(int id, string name)
        {
            Studentid = id;
            StudentName = name;
        }

        public int getid()
        {
            return Studentid;
        }
        public string getName()
        {
            return StudentName;
        }

        static void Main(string[] args)
        {
            Program obj = new Program(1,"Snehal");

            Console.WriteLine("Student ID: {0}", obj.Studentid);
            Console.WriteLine("Student Name: {0}", obj.StudentName);

            Console.ReadKey();
        }
    }
}
