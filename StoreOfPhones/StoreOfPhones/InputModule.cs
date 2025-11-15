using System;
using System.Collections.Generic;

namespace StoreOfPhones
{
    public class InputModule
    {
        static public (DateTime, DateTime) InputDate()
        {
            Console.Write("Введите день начала периода продаж: ");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите месяц начала периода продаж: ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите год начала периода продаж: ");
            int year = Convert.ToInt32(Console.ReadLine());
            DateTime dateOfBegin = new DateTime(year, month, day);

            Console.WriteLine();

            Console.Write("Введите день конца периода продаж: ");
            day = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите месяц конца периода продаж: ");
            month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите год конца периода продаж: ");
            year = Convert.ToInt32(Console.ReadLine());
            DateTime dateOfEnd = new DateTime(year, month, day);

            return (dateOfBegin, dateOfEnd);
        }
        static public List<Sell> InputSellInPeriod(DateTime dateOfBegin, DateTime dateOfEnd, string[] nameOfModel, int[] priceOfModel)
        {
            List<Sell> sells = new List<Sell>();
            Random random = new Random();
            for (int i = 0; dateOfBegin.AddDays(i) <= dateOfEnd; i++)
            {                
                int countOfSell = random.Next(1, 6);
                for (int j = 0; j < countOfSell; j++)
                {
                    int whichPhone = random.Next(0, 3);
                    int whichIsPhone = random.Next(3, 5);
                    sells.Add(new Sell
                    {
                        ModelPhone = nameOfModel[whichPhone],
                        Price = priceOfModel[whichPhone],
                        Cost = priceOfModel[whichPhone] * random.Next(1, 4),
                        Date = dateOfBegin.AddDays(i)
                    });

                    sells.Add(new Sell
                    {
                        ModelPhone = nameOfModel[whichIsPhone],
                        Price = priceOfModel[whichIsPhone],
                        Cost = priceOfModel[whichIsPhone] * random.Next(1, 4),
                        Date = dateOfBegin.AddDays(i)
                    });
                }

            }
            return sells;
        }
    }
}
