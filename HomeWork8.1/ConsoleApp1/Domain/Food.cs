using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
   public class Food : Product
    {
        public Taste Taste { get; set; }
        public double Calories { get; set; }


       public Food(int id,string nameOfProduct, TypeFED typeFED, double price,bool onPromotion, Taste taste,double calories):base(id,nameOfProduct,typeFED,price,onPromotion)
        {
            Taste = taste;
            Calories = calories;
        }

        public override string PrintInfo()
        {
            return base.PrintInfo();
        }

        public override void SetPrice(double price)
        {
            base.SetPrice(price);
        }

        public double ShowCalories()
        {
            return Calories;
        }

    }
}
