using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
   public class EmployeeServices
    {
        public void PrintInfo(Employee employee)
        {
            Console.WriteLine($"{employee.FirstName} {employee.LastName}");
        }

        public double GetSalary(Employee employee)
        {
            return employee.salary;
        }


    }
}
