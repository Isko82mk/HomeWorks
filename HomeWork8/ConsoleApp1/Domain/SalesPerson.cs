using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
   public class SalesPerson : Employee
    {

        private double SuccessSaleRevenue { get; set; }
        //private double Salary { get; set; }
        //public Role Role { get; set; }

        public SalesPerson(string firstName, string lastName, Role Sales, double successSaleRevenue, double salary) : base(firstName, lastName, salary)
        {
            SuccessSaleRevenue = successSaleRevenue;
            Salary = 500;
            Role = Sales;

        }

        public double successSaleRevenue
        {
            get { return SuccessSaleRevenue; }
        }



    }
}
