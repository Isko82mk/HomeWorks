using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
   public class Employee
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Role Role { get; set; }
        protected double Salary { get; set; }

        public Employee()
        {
        }
        public Employee(string firstName, string lastName, double salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;

        }

        public double salary
        {
            get { return Salary; }

        }


    }
}
