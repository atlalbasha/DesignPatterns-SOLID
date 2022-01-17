using System;
using System.Collections.Generic;
using OnlineShop.Models;

namespace OnlineShop.Repositories
{
	public interface ICheckForDiscount
	{
		void GetDiscount(List<Product> CartList);
	}
}

