using System;
using System.Collections.Generic;
using OnlineShop.Repositories;

namespace OnlineShop.Models
{
    public class Cart : ICart
    {
        public List<Product> MyCart = new List<Product>();


        public Cart() { }


        public List<Product> GetMyCart() { return MyCart; }


        public void AddProduct(Product product) { MyCart.Add(product); }


        public void DeleteProduct(Product product)
        {
            Product ProductToDelete = MyCart.Find(item => item == product);
            MyCart.Remove(ProductToDelete);
        }


        public void TotalPrice()
        {
            double TotalPrice = 0.0;
            foreach (Product item in MyCart)
            {
                Console.WriteLine($"Product: {item.Title} Price: {item.Price} kr");

                TotalPrice += item.Price;

            }
            Console.WriteLine($"*** Total Pice: {TotalPrice} kr ***");
        }

    }
}

