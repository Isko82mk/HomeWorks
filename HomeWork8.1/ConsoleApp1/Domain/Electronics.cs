using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
   public class Electronics:Product
    {
        public int Volage { get; set; }

        public Electronics(int id, string nameOfProduct, TypeFED typeFED, double price, bool onPromotion,int voltage):base(id,nameOfProduct,typeFED,price,onPromotion)
        {
            Volage = voltage;
        }

        public override string PrintInfo()
        {
            return base.PrintInfo();
        }

        public override void SetPrice(double price)
        {
            base.SetPrice(price);
        }

        public string TurnOn()
        {
            return $"The {NameOfProduct} is turned on and working";
        }

    }
}
