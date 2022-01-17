using System;
using System.Collections.Generic;
using System.Linq;
using OnlineShop.Models;

namespace OnlineShop.Repositories
{
    public class DiscountPlus5Item : IDiscount
	{
		public DiscountPlus5Item()
		{
		}

        public void Discount(List<Product> products)
        {
           
            double TotalPrice = 0.0;
            double LastItemPrice = 0.0;

            products = products.OrderByDescending(item => item.Price).ToList();


            foreach (Product item in products)
            {

               
                TotalPrice += item.Price;
                LastItemPrice = item.Price;
               
            }
            if (products.Count > 4) TotalPrice -= LastItemPrice;
            Console.WriteLine($"Total Pice to pay after plus 5 products discount: {TotalPrice} kr");

        

    }
    }
}

