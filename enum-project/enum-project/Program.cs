using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enum_project
{
    internal class Program
    {
        enum Season
        {
            Spring,
            Summer,
            Autumn,
            Winter
        }
        static void PrintMessage(Season season)
        {
            if (season == Season.Spring)
            {
                Console.WriteLine("Сейчас весна");
            }
            else if (season == Season.Summer)
            {
                Console.WriteLine("Сейчас лето");
            }
            else if (season == Season.Autumn)
            {
                Console.WriteLine("Сейчас oсень");
            }
            else
            {
                Console.WriteLine("Сейчас зима");
            }
        }
        static void Main(string[] args)
        {
            Season now = Season.Autumn;

            PrintMessage(now);
            PrintMessage(Season.Winter);
            PrintMessage(Season.Summer);
        }
    }
}
