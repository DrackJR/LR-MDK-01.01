using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyClassesApp
{
    public class Program
    {
        static void Main()
        {
            // Создал новый "в разработке"!
            Storage storage = new Storage(); 
            storage.SetIndetifier(123);
            storage.SetLocation("г. Торжок, Студенческая 3");

            // Создал экземпляр объекта Product и заполнил его данными
            Product mercedeceBenz = new Product();
            mercedeceBenz.SetName("Мерседес Бенз");
            mercedeceBenz.SetPrice(1000000);

            storage.SetProductQuantity(mercedeceBenz, 2);

            // Создал экземпляр объекта Product и заполнил его данными
            Product uaz = new Product();
            uaz.SetName("Уазик");
            uaz.SetPrice(10000000);

            // Добавление 2-х Товара в склад
            storage.SetProductQuantity(uaz, 5);

            // Вывод продуктов и их количество
            storage.PrintAllProductsQuantity();

            // Вывод общего количества денег на складе
            double total = storage.CalcAllMoneyInStorage();
        }
    }
}
