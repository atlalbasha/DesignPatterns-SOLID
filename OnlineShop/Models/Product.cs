using System;
using System.Collections.Generic;

namespace OnlineShop.Models
{
    public abstract class Product
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }

        public Product(string title, double price)
        {
            Id = Guid.NewGuid();
            Title = title;
            Price = price;
        }
    }
}

