using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _2.hafta
{
    internal class EmployeeManager
    {
        List<Employee> employees;

        public EmployeeManager()
        {
            employees = new List<Employee>();
        }

        public void Create(Employee employee)
        {
            employees.Add(employee);
            Console.WriteLine("Employee eklendi");
        }

        public void Delete(int id)
        {
            var deleteEmp = employees.FirstOrDefault(x => x._id == id);

            if (deleteEmp == null)
            {
                Console.WriteLine("Employee bulunamadi");

            }




            else
            {
                employees.Remove(deleteEmp);
                Console.WriteLine(id+" id'li Employee silindi");
            }




        }

        public void ReadList()
        {
            foreach (var emp in employees)
            {
                Console.WriteLine("id: "+emp._id);
            }
        }

    }
}
