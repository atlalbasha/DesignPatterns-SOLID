using System;
using System.Collections.Generic;
using System.Linq;
using OnlineShop.Models;

namespace OnlineShop.Repositories
{
    public class Discount3for2 : IDiscount
    {
        public List<Product> MyCart = new List<Product>();

        public Discount3for2()
        {
        }

        public void Discount(List<Product> products)
        {
            double ProductsPrice = 0.0;
            double TotalPrice = 0.0;
            foreach (Product item in products)
            {
                if (item.GetType() == typeof(Accessories))
                {
                    MyCart.Add(item);

                    TotalPrice += item.Price;
                    ProductsPrice = item.Price;
                }

            }



            while (3 <= MyCart.Count)
            {
            
                double TotalDiscountPrice = TotalPrice -= ProductsPrice * (MyCart.Count / 3);
                Console.WriteLine($"Total Pice to pay after 3 for 2 discount for {MyCart.Count} items: {TotalDiscountPrice} kr");
               
                return;
            }
            Console.WriteLine($"Total Pice to pay after 3 for 2 discount for {MyCart.Count} item/s: {TotalPrice} kr");


        }
    }
}

