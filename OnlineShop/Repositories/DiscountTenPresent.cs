using System;
using System.Collections.Generic;
using OnlineShop.Models;

namespace OnlineShop.Repositories
{
	public class DiscountTenPresent : IDiscount
	{
		public DiscountTenPresent()
		{
		}

        public void Discount(List<Product> products)
        {
            double TotalPrice = 0.0;
            foreach (Product item in products)
            {
                TotalPrice += item.Price;
            }
            if (TotalPrice > 500)
            {

                TotalPrice -= TotalPrice / 10;
                Console.WriteLine($"Total Pice to pay after 10% discount: {TotalPrice} kr");

            }
        }
    }
}

