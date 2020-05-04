using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
   public class Manager : Employees
    {
       public Worker[] Workers { get; set; }
        public double Bonus { get; set; }

        //constructors

             
        public Manager() : base()
        {

        }

        public Manager(int id,string firstName, string lastName, Role role, int hours, double salary, Worker[] workers,double bonus) : base(id, firstName, lastName, role, hours, salary )
        {
            Workers = workers;
            Bonus = bonus;
        }


        public string GiveTaks(Worker worker)
        {
            return $"Menager {FirstName} {LastName} is givin task XY to {worker.FirstName}{worker.LastName}";
        }

        public override string PrintInfo()
        {
            return $"Manager {FirstName}  {LastName} have {Salary} dolars salary";
        }

        public override double GetMontlySelary()
        {
            return base.GetMontlySelary() + Bonus;
        }


    }
}
