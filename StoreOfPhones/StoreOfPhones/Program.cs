using System;
using System.Collections.Generic;


namespace StoreOfPhones
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] nameOfModel = new string[] { "Tecno Pova 5",  "Google Pixel 7", "Xiaomi Readmi Note 15", "Samsung Galaxy A55", "Samsung Galaxy S24 FE" };
            int[] priceOfModel = new int[] { 15000, 30000, 31000, 35000, 50000 };

            var (dateOfBegin, dateOfEnd) = InputModule.InputDate();

            List<Sell> sells = InputModule.InputSellInPeriod(dateOfBegin, dateOfEnd, nameOfModel, priceOfModel);

            Console.WriteLine();

            double maxSells = SearchingModule.SearchSumOfSellsInPeriod(sells);
            Console.WriteLine("Общая сумма проданного за выбранный вами период = " + maxSells);

            Console.WriteLine();

            var (nameMax, max, nameMin, min) = SearchingModule.SearhMaxAndMinSellPhone(sells, nameOfModel);
            Console.WriteLine("Самый продаваемый телефон " + nameMax + " в колличестве " + max);
            Console.WriteLine("Телефон с наименьшим фактом продаж  " + nameMin + " в колличестве " + min);

            Console.WriteLine();

            var (nameOne, firstCost, nameTwo, secondCost) = SearchingModule.SearchMaxTwoProfitPhones(sells, nameOfModel);
            Console.WriteLine("Первый телефон приносящий наибольшую прибыль " + nameOne + " с ценой " + firstCost);
            Console.WriteLine("Второй телефон приносящий наибольшую прибыль " + nameTwo + " с ценой " + secondCost);
        }
    }
}
