using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
   public class Product 
    {
        public int Id { get; set; }
        public string NameOfProduct { get; set; }
        public TypeFED TypeFED { get; set; }
        public double Price { get; set; }
        public bool OnPromotioin { get; set; }


        public Product()
        {

        }

        public Product(int id, string nameOfProduct, TypeFED typeFED, double  price, bool onPromotion)
        {
            Id = id; 
            NameOfProduct = nameOfProduct;
            TypeFED = typeFED;
            Price = price;
            OnPromotioin = onPromotion;
        }


        public virtual string PrintInfo()
        {
            return $"Product {NameOfProduct} is of type {TypeFED} and costs {Price} den";
        }

        public double GetPrice()
        {
            return Price;
        }

        public virtual void SetPrice(double price)
        {
            Price = price;
            Console.WriteLine($"The new price of the {NameOfProduct} is {price}");
        }


    }
}
