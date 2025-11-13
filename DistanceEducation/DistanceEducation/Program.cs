using System;
using System.Collections.Generic;
using System.Data;

namespace DistanceEducation
{
    class Program
    {
        static void Main()
        {
            List<Phone> phones = InputModule.InputCharInPhone();
            List<Day> allDays = InputModule.InputSellsInDay(phones);
            var (beginDate, endDate) = InputModule.UserQueryOfDate();
            int amountOfPeriod = SearchingModule.AmountOfPeriod(beginDate, endDate, allDays);
            Console.WriteLine("За ваш период было продано " + amountOfPeriod + " телефона(ов)!");
            var (maxPhone, minPhone) = SearchingModule.MostSellPhone(phones);
            var (maxOneSell, maxTwoSell) = SearchingModule.MaxTwoPricesPhone(phones);

            Console.WriteLine("Самый продаваемый телефон " + maxPhone.name + " в колличестве = " + maxPhone.countOfSell);
            Console.WriteLine("Телефон с наименьшим фактом продаж " + minPhone.name + " в колличестве = " + minPhone.countOfSell);
            Console.WriteLine("Первый телефон приносящий наибольшую прибыль " + maxOneSell.name + " в колличестве = " + maxOneSell.maxSell);
            Console.WriteLine("Второй телефон приносящий наибольшую прибыль " + maxTwoSell.name + " в колличестве = " + maxTwoSell.maxSell);
        }
    }
}