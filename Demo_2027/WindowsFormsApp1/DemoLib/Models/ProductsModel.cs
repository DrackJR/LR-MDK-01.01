using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace DemoLib.Models
{
    public class ProductsModel : IProductsModel
    {
        private List<Product> data_ = new List<Product>();

        public ProductsModel()
        {
            data_.Add(new Product { Name = "abc", Category = "Мучные", Count = 10, Price = 100.0, Supplier = "Хлебзавод", ImagePath = "", Parts = "Мука, рис" });
            data_.Add(new Product { Name = "xyz", Category = "Колбасы", Count = 10000, Price = 500.0, Supplier = "Беларусь", ImagePath = "C:\\Users\\st53\\Pictures\\chyvak.png", Parts = "Хлеб, молоко"});
        }

        public List<Product> Load()
        {
            return data_;
        }

        public int GetCountProducts()
        {
            return data_.Count;
        }
    }
}
