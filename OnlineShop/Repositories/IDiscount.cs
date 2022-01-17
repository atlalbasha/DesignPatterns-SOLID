using System;
using System.Collections.Generic;
using OnlineShop.Models;

namespace OnlineShop.Repositories
{
	public interface IDiscount
	{

        void Discount(List<Product> products);
        //void Discount3for2(List<Product> products);
        //void DiccountTenPresent(List<Product> products);
        //void DiscountPlus5(List<Product> products);

    }
}

