using System;
using System.Collections.Generic;

namespace DistanceEducation
{
    public class InputModule
    {
        static public List<Phone> InputCharInPhone()
        {
            List<Phone> phones = new List<Phone>();

            Phone tp5 = new Phone();
            tp5.name = "Tecno Pova 5";
            tp5.price = 15000;
            phones.Add(tp5);

            Phone p7 = new Phone();
            p7.name = "Google Pixel 7";
            p7.price = 30000;
            phones.Add(p7);

            Phone n15 = new Phone();
            n15.name = "Xiaomi Readmi Note 15";
            n15.price = 31000;
            phones.Add(n15);

            Phone a55 = new Phone();
            a55.name = "Samsung Galaxy A55";
            a55.price = 35000;
            phones.Add(a55);

            Phone s24 = new Phone();
            s24.name = "Samsung Galaxy S24 FE";
            s24.price = 50000;
            phones.Add(s24);

            return phones;
        }

        static public List<Day> InputSellsInDay(List<Phone> phones)
        {
            List<Day> days = new List<Day>();
            DateTime dateTimeOfBegin = new DateTime(2025, 01, 1);
            int dayTimeOfEnd = 32;
            Random random = new Random();
            for (int i = 0; i < dayTimeOfEnd; i++)
            {
                List<Phone> dailyPhone = new List<Phone>();
                List<int> count = new List<int>();
                int maxCount = random.Next(1, phones.Count + 1);
                for (int j = 0; j < maxCount; j++)
                {
                    int countSell = random.Next(1, 8);
                    Phone phone = new Phone();
                    phone.name = phones[j].name;
                    phone.price = phones[j].price;
                    phone.countOfSell = phones[j].countOfSell + countSell;
                    phones[j] = phone;
                    dailyPhone.Add(phones[j]);
                    count.Add(countSell);
                }
                Day day = new Day();
                day.dateTtime = dateTimeOfBegin.AddDays(i);
                day.phones = dailyPhone;
                day.countOfSell = count;
                days.Add(day);
            }
            return days;
        }

        static public (DateTime, DateTime) UserQueryOfDate()
        {
            DateTime beginDate = new DateTime(2025, 1, 1);
            DateTime endDate = new DateTime(2025, 1, 1);
            Console.Write("Введите день начала продаж: ");
            int tempBeginDay = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите день конца продаж: ");
            int tempEndDay = Convert.ToInt32(Console.ReadLine());

            return (beginDate.AddDays(tempBeginDay - 1), endDate.AddDays(tempEndDay - 1));

        }
    }
}