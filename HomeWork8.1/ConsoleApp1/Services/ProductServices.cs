using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class ProductServices
    {

        public Food CreateFood(int id, string nameOfProduct, TypeFED typeFED, double price, bool onPromotion, Taste taste, double calories)
        {
            Food newObject = new Food(id, nameOfProduct, typeFED, price, onPromotion, taste, calories);
            return newObject;
        }

        public Drink CreateDrink(int liters, bool isAlcohol, int id, string nameOfProduct, TypeFED typeFED, double price, bool onPromotion) {

            Drink newDrink = new Drink(liters,isAlcohol,id,nameOfProduct,typeFED,price,onPromotion);
            return newDrink;
        }

        public Electronics CreateElectronics(int id, string nameOfProduct, TypeFED typeFED, double price, bool onPromotion, int voltage)
        {
            Electronics newElectronics = new Electronics(id,nameOfProduct,typeFED,price,onPromotion,voltage);
            return newElectronics;

        }


        public Product[] GetProductsByType( Product[]products,TypeFED typeFED)
        {
            Product[]productByType = new Product[0];
            foreach (Product product in  products)
            {
                if (product.TypeFED == typeFED)
                {
                    Array.Resize(ref productByType, productByType.Length+1);
                    productByType[productByType.Length - 1] = product;
                }
            }
            return productByType;
        }



        //public void AddProduct(Product[] products, int id, string nameOfProduct, TypeFED typeFED, double price, bool onPromotion)
        //{

        //    Product newProduct = new Product(id,nameOfProduct,typeFED,price,onPromotion);

        //    Array.Resize(ref products,products.Length+1);
        //    products[products.Length - 1] = newProduct;


        //}

    }
}
