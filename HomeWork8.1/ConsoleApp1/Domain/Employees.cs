using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Employees
    {
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Role Role { get; set; }
        public int Hours { get; set; }
        public double Salary { get; set; }//perHour
        public bool OnHoliday { get; set; }


        public Employees()
        {

        }

        public Employees(int id, string firstName, string lastName, Role role, int hours, double salary)
        {
            Id = id;
            FirstName = FirstName;
            LastName = lastName;
            Role = role;
            Hours = hours;
            Salary = salary;
            OnHoliday = false;

        }

        public virtual string PrintInfo()
        {
            return $"Employee {FirstName} {LastName} is on {Salary} salary ";
        }

        public virtual double GetMontlySelary()
        {
            return Salary * Hours;
        }


        public void SetSalary(double salary)
        {
            Salary = salary;
            Console.WriteLine($"The selary of employeee is {FirstName}{LastName} {salary}");
        }

        public void OnHolyday()
        {
            OnHoliday = true;
            Console.WriteLine( $"Employee {FirstName}{LastName} is on holiday." );
        }







    }
}
