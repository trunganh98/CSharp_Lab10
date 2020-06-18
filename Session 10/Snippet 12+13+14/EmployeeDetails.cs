using System;
using System.Collections.Generic;
using System.Text;

namespace Snippet_12_13
{
    class EmployeeDetails
    {
        static void Main(string[] args)
        {
            Contact.Salary.SalaryDetalis objSal = new Contact.Salary.SalaryDetalis();
            objSal.EmpSalary = 1000.50;
            Console.WriteLine("Salary: " + objSal.EmpSalary);
        }
    }
}
