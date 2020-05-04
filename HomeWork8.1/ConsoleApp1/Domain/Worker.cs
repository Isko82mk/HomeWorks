using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;



namespace Domain
{
    public class Worker : Employees
    {

         public Manager Manager { get; set; }


        public Worker():base()
        {

        }

        public Worker(int id, string firstName, string lastName, Role role, int hours, double salary, Manager manager) : base(id,firstName,lastName,role,hours,salary)
        {
            Manager=manager;
        }

        public string DoTaska()
        {
            return $"Task is done";

        }

        public override string PrintInfo()
        {
            return $"{FirstName}{LastName} have {Salary} and his manager is {Manager}";
        }




    }

    
}
