using System.Collections.Generic;

namespace StoreOfPhones
{
    public class SearchingModule
    {
        static public double SearchSumOfSellsInPeriod(List<Sell> sells)
        {
            double total = 0;
            for (int i = 0; i < sells.Count; i++)
            {
               total += sells[i].Cost;               
            }
            return total;
        }

        static public (string, double, string, double) SearhMaxAndMinSellPhone(List<Sell> sells, string[] name)
        {
            double max = 0;
            double min = 0;
            string nameMax = null;
            string nameMin = null;
            for (int i = 0; i < name.Length; i++)
            {
                double sum = 0;
                string namePhone = null;
                for (int j = 0; j < sells.Count; j++)
                {
                    if (name[i] == sells[j].ModelPhone)
                    {
                        sum += sells[j].Cost / sells[j].Price;
                        namePhone = name[i];
                    }
                }              
                if (sum > max)
                {
                    max = sum;
                    nameMax = namePhone;
                }
                if (sum < min)
                {
                    min = sum;
                    nameMin = namePhone;
                }
                if (min == 0)
                {
                    min = sum;
                    nameMin = namePhone;
                }
            }

            return (nameMax, max, nameMin, min);
        }

        static public (string, double, string, double) SearchMaxTwoProfitPhones(List<Sell> sells, string[] name)
        {
            double firstCost = 0;
            double secondCost = 0;
            string nameOne = null;
            string nameTwo = null;
            for (int i = 0; i < name.Length; i++)
            {
                double sum = 0;
                string namePhone = null;
                for (int j = 0; j < sells.Count; j++)
                {
                    if (name[i] == sells[j].ModelPhone)
                    {
                        sum += sells[j].Cost;
                        namePhone = name[i];
                    }
                }
                if (sum > firstCost)
                {
                    secondCost = firstCost;
                    nameTwo = nameOne;
                    firstCost = sum;
                    nameOne = namePhone;
                }
            }

            return (nameOne, firstCost, nameTwo, secondCost);
        }
    }
}
