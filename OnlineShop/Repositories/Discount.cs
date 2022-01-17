using System;
using System.Collections.Generic;
using System.Linq;
using OnlineShop.Repositories;

namespace OnlineShop.Models
{
    public class Discount 
    {
        public Discount()
        {
        }

        public void DiccountTenPresent(List<Product> products)
        {
            double TotalPrice = 0.0;
            foreach (var item in products)
            {
                TotalPrice += item.Price;
            }
            if (TotalPrice > 500)
            {

                TotalPrice = TotalPrice - (TotalPrice / 10);
                Console.WriteLine($"Total Pice to pay after 10% discount: {TotalPrice} kr");

            }

        }

        public void Discount3for2(List<Product> products)
        {
            int TotatProducts = 0;
            double TotalPrice = 0.0;
            foreach (var item in products)
            {
                TotatProducts++;

                if (TotatProducts == 3)
                {
                    Console.WriteLine($"Total Pice to pay after 3 for 2 discount: {TotalPrice} kr");
                    return;
                }
                TotalPrice += item.Price;

            }


        }

        public void DiscountPlus5(List<Product> products)
        {
            int TotatProducts = 0;
            double TotalPrice = 0.0;
            double LastItemPrice = 0.0;

            products = products.OrderByDescending(item => item.Price).ToList();


            foreach (var item in products)
            {

                TotatProducts++;
                TotalPrice += item.Price;
                LastItemPrice = item.Price;
                Console.WriteLine($"Product: {item.Title} Price: {item.Price} kr");
            }
            if (TotatProducts > 4) TotalPrice = TotalPrice - LastItemPrice;
            Console.WriteLine($"Total Pice to pay after plus 5 products discount: {TotalPrice} kr");

        }
    }
}

