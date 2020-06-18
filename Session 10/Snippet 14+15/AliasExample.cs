using IO = System.Console;
using Emp = Bank.Accounts.EmployeeDetails;

class AliasExample
{
    static void Main(string[] args)
    {
        Emp.Employee objEmp = new Emp.Employee();
        objEmp.EmpName = "Peter";
        IO.WriteLine("Employee Name: " + objEmp.EmpName);
    }
}