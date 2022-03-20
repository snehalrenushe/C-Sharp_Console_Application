//1. Write a program on illustrating the read-only property by taking as class Employee in c#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1
{
    class Employee
    {
        private string name;
 
        public string Name
        {
          get {
                return name;
              }
 
          set {
                name = value;
              }
        }
 
        public Employee(string name)
        {
            this.name = name;
        }
 
    }
    public class Programs
    {  
        public static void Main(string[] args)
        {
            Employee employee = new Employee("Shekh Ali");

            string name = employee.Name;

            Console.WriteLine($"Name : {name}");
 
            employee.Name = "Mark Adams";
            Console.WriteLine($ +"Name : {employee.Name}");
 
            Console.ReadLine();         
        }
    }
}
