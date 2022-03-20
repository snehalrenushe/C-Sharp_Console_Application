//4. Create an object for the above EmployeeModel and assign the values to all properties and print each property on console

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4
{
    class EmployeeModel
    {
        int EmpId;
        string EmpName, EmailId;
        float Salary;
        bool IsEmployeeActive = true;

        public void setValue(int eid, string ename, string emailid, float sal, bool emp)
        {
            EmpId = eid;
            EmpName = ename;
            EmailId = emailid;
            Salary = sal;
            IsEmployeeActive = emp;
        }

        public void getValue()
        {
            Console.WriteLine(EmpId);
            Console.WriteLine(EmpName);
            Console.WriteLine(EmailId);
            Console.WriteLine(Salary);
            Console.WriteLine(IsEmployeeActive);
        }

        static void Main(string[] args)
        {
            EmployeeModel obj1 = new EmployeeModel();
            obj1.setValue(101,"Snehal","Snehal15@gmail.com",45000,true);
            obj1.getValue();

            Console.ReadKey();
        }
    }
}
