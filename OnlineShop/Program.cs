using System;
using System.Collections.Generic;
using OnlineShop.Models;
using OnlineShop.Repositories;

namespace OnlineShop
{
    class Program
    {
        static void Main(string[] args)
        {

            //Product Iphone = new("Iphone 5", 200);
            //Product Note = new("Note 2", 100);
            //Product Xphone = new("Xphone 5", 200);
            //Product Mac = new("Mac Pro", 200);
            //Product Mice = new("Mice", 200);
            //Product Keyboard = new("Keyboard", 200);
            //Product Camra = new("Camra", 200);

            Mobile iPhone5 = new("Iphone5", 1000);
            Mobile iPhone6 = new("Iphone6", 2000);
            Mobile iPhone7 = new("Iphone7", 3000);

            Computer Lenovo = new("Lenovo Computer", 1000);
            Computer MSI = new("MSI Computer", 2000);
            Computer Acer = new("Acer Computer", 3000);

            Accessories Keyboard = new("Keyboard", 100);
            Accessories Mouse = new("Mouse", 100);
            Accessories Mice = new("Mice", 100);

            Accessories Keyboard1 = new("Keyboard new", 100);
            Accessories Mouse2 = new("Mouse new", 100);
            Accessories Mice3 = new("Mice new", 100);



            Cart MyCart = new();
            MyCart.AddProduct(iPhone5);
            MyCart.AddProduct(iPhone6);
            MyCart.AddProduct(iPhone7);

            MyCart.AddProduct(Lenovo);
            MyCart.AddProduct(MSI);
            MyCart.AddProduct(Acer);

            MyCart.AddProduct(Keyboard);
            MyCart.AddProduct(Mouse);
            MyCart.AddProduct(Mice);

            MyCart.AddProduct(Keyboard1);
            MyCart.AddProduct(Mouse2);
            MyCart.AddProduct(Mice3);

            MyCart.DeleteProduct(Acer);


            Console.WriteLine("--- All Product in My Cart ---");
            List<Product> CartList = MyCart.GetMyCart();
            MyCart.TotalPrice();
            
            Console.WriteLine("--- Check for Discount ---");

            CheckForDiscount Discount = new();
            Discount.GetDiscount(CartList);

            //Discount discount = new Discount();
            //discount.DiccountTenPresent(CartList);
            //discount.Discount3for2(CartList);
            //Console.WriteLine("-------------");
            //discount.DiscountPlus5(CartList);


           

        }
    }
}

