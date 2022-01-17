using System;
using System.Collections.Generic;
using OnlineShop.Models;

namespace OnlineShop.Repositories
{
	public interface ICart
	{
		void AddProduct(Product product);
		void DeleteProduct(Product product);
		void TotalPrice();
		List<Product> GetMyCart();

	}
}

