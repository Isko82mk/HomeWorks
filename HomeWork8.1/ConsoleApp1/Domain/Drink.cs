using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Drink:Product
    {
        public int Liters { get; set; }
        bool IsAlcohol { get; set; }



        public Drink(int liters,bool isAlcohol,int id, string nameOfProduct, TypeFED typeFED,double price,bool onPromotion) :base(id, nameOfProduct, typeFED, price, onPromotion)
        {
            Liters = liters;
            IsAlcohol = isAlcohol;
        }

        public override string PrintInfo()
        {
            return base.PrintInfo();
        }

        public override void SetPrice(double price)
        {
            base.SetPrice(price);
        }


    }
}
