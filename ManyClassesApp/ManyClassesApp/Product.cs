using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ManyClassesApp
{
    public class Product
    {
        private string name_;
        private double price_;

        // Метод установки имени товара
        public void SetName(string name)
        {
            name_ = name;
        }

        // Метод получения имени товара
        public string GetName()
        {
            return name_;
        }
        // Метод установки цены товара
        public void SetPrice(double price)
        {
            price_ = price;
        }

        // Метод получения цены товара
        public double GetPrice()
        {
            return price_;
        }
    }
}
