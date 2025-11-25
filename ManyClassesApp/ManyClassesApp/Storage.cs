using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyClassesApp
{
    public class Storage
    {        
        private int identifier_;
        private string location_;
        private Dictionary<Product, int> products_;

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
    }
}
