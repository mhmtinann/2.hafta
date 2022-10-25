using System;

namespace _2.hafta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(1,"Joey","Tribbiani");
            Employee employee1 = new Employee(2,"Chandler","Bing");
            

            EmployeeManager employeeManager = new EmployeeManager();

            employeeManager.Create(employee);
            employeeManager.Create(employee1);
            employeeManager.Delete(1);
            employeeManager.Delete(182);
            employeeManager.ReadList();

           

        }
    }
}
