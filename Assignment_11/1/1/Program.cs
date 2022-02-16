//1. Construct a class using any methods for employee details using its parameters and print Output.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1
{
    class Program
    {
        public Program()
	    {
            Console.WriteLine("Inside Default Constructor .....");
	    }

	    private int employeeIdVar;
	    private string employeeNameVar;

	    public int EmployeeId
	    {
		    get 
		    { 
			    return employeeIdVar; 
		    }
		    set 
		    { 
			    employeeIdVar = value; 
		    }
	    }

	    public string EmployeeName
	    {
		    get 
		    { 
			    return employeeNameVar; 
		    }
		    set 
		    { 
			    employeeNameVar = value; 
		    }
	    }

        static void Main(string[] args)
        {
            Program employee1 = new Program();
            employee1.EmployeeId = 1;
            employee1.EmployeeName = "Mugambo";
            Console.WriteLine("Employee ID is {0}", employee1.EmployeeId);
            Console.WriteLine("Employee Name is {0}", employee1.EmployeeName);

            Console.ReadKey();
        }
    }
}
