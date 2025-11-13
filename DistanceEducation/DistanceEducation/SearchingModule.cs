using System;
using System.Collections.Generic;
using System.Xml.Schema;

namespace DistanceEducation
{
    public class SearchingModule
    {
        static public int AmountOfPeriod(DateTime beginDate, DateTime endDate, List<Day> allDays)
        {
            int generalAmount = 0;
            for (int i = beginDate.Day; i <= endDate.Day; i++)
            {
                for (int j = 0; j < allDays[i].countOfSell.Count; j++)
                {
                    generalAmount += allDays[i].countOfSell[j];
                }
            }

            return generalAmount;
        }
        static public (Phone, Phone) MostSellPhone(List<Phone> allPhones)
        {
            Phone maxPhone = new Phone();
            Phone minPhone = new Phone();
            int max = allPhones[0].countOfSell;
            int min = allPhones[0].countOfSell;
            string maxSellPhone = allPhones[0].name;
            string minSellPhone = allPhones[0].name;
            for (int i = 0; i < allPhones.Count; i++)
            {
                if (max < allPhones[i].countOfSell)
                {
                    maxSellPhone = allPhones[i].name;
                    max = allPhones[i].countOfSell;
                }
                if (min > allPhones[i].countOfSell)
                {
                    minSellPhone = allPhones[i].name;
                    min = allPhones[i].countOfSell;
                }
                maxPhone.name = maxSellPhone;
                minPhone.name = minSellPhone;
                maxPhone.countOfSell = max;
                minPhone.countOfSell = min;
            }
            return (maxPhone, minPhone);
        }
        static public (Phone, Phone) MaxTwoPricesPhone(List<Phone> allPhones)
        {
            int maxOne = 0;
            int maxTwo = 0;
            string maxOneNamePhone = "";
            string maxTwoNamePhone = "";
            foreach (var phone in allPhones)
            {
                int profit = phone.price * phone.countOfSell;
                if (profit > maxOne)
                {
                    maxTwo = maxOne;
                    maxTwoNamePhone = maxOneNamePhone;

                    maxOne = profit;
                    maxOneNamePhone = phone.name;
                }
                else if (profit > maxTwo)
                {
                    maxTwo = profit;
                    maxTwoNamePhone = phone.name;
                }
            }
            Phone maxPhone = new Phone();
            Phone maxTwoPhone = new Phone();
            maxPhone.name = maxOneNamePhone;
            maxPhone.maxSell = maxOne;
            maxTwoPhone.name = maxTwoNamePhone;
            maxTwoPhone.maxSell = maxTwo;
            return (maxPhone, maxTwoPhone);
        }
    }
}
