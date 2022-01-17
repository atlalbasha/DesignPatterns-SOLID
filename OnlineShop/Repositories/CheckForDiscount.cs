using System;
using System.Collections.Generic;
using OnlineShop.Models;

namespace OnlineShop.Repositories
{
	public class CheckForDiscount : ICheckForDiscount
	{
		public CheckForDiscount()
		{
		}

        public void GetDiscount(List<Product> CartList)
        {
            Discount3for2 discount3For2 = new();
            DiscountTenPresent discountTenPresent = new();
            DiscountPlus5Item discountPlus5Item = new();



            discount3For2.Discount(CartList);
            discountTenPresent.Discount(CartList);
            discountPlus5Item.Discount(CartList);
        }

       

      
    }
}

