using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
   public class EmployeeService
    {
        public Employees CreateEmployee(int id, string firstName, string lastName, Role role, int hours, double salary)
        {
            Employees newEmpoyee = new Employees(id, firstName, lastName, role, hours, salary);

            return newEmpoyee;
           
        }

        public Employees[] GetEmployeesByRole(Employees[] employees, Role role)
        {

            Employees[] byRoleEmploye = new Employees[0];

           
            foreach (Employees employe in byRoleEmploye)
            {

                if (employe.Role == role)
                {
                    Array.Resize(ref byRoleEmploye, byRoleEmploye.Length+1);
                    byRoleEmploye[byRoleEmploye.Length-1]= employe;
                }

            }

            return byRoleEmploye;

        }


    }
}
