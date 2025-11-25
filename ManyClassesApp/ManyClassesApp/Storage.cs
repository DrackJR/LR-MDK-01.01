using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace ManyClassesApp
{
    public class Storage
    {        
        private int identifier_;
        private string location_;
        private Dictionary<Product, int> products_ = new Dictionary<Product, int>();

        // Метод установки идентификатора
        public void SetIndetifier(int identifier)
        {
            identifier_ = identifier;
        }

        // Метод установки местоположения
        public void SetLocation(string location)
        {
            location_ = location;
        }

        // Метод установки товара и его количества
        public void SetProductQuantity(Product product, int quantity)
        {
            products_.Add(product, quantity);
        }

        // Метод вывода на консоль всех товаров и их количества
        public void PrintAllProductsQuantity()
        {
            foreach(Product key in products_.Keys)
            {
                Console.WriteLine(key.GetName() + " " + products_[key] + " шт.");
            }
        }

        // Метод Вывода общего количества денег на консоль
        public double CalcAllMoneyInStorage()
        {
            double total = 0;
            foreach(Product key in products_.Keys)
            {
                double cost = key.GetPrice() * products_[key];
                total += cost;
            }
            return total;
        }
    }
}
