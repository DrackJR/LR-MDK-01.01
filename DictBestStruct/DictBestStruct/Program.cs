using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictBestStruct
{
    class Program
    {
        static public void ShowCountElement(Dictionary<string, List <string>> dict)
        {
            Console.WriteLine("Укажите жанр игры (Шутер, Приключение, Головоломки): ");
            string userQuery = Console.ReadLine().ToLower();
            List<string> allKeys = new List<string>();
            foreach (string key in dict.Keys)
            {
                allKeys.Add(key.ToLower());
                if (allKeys.Contains(userQuery))
                {
                    List<string> value = dict[key];
                    Console.WriteLine("Число элементов: " + value.Count);
                    Console.Write(string.Join(", ", value));
                    return;
                }
            }
            if (!allKeys.Contains(userQuery))
            {
                Console.WriteLine("Ай-яй-яй, такого жанра нету");
            }
        }
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
            dict.Add("Шутер", new List<string> {"cs:go"});
            dict.Add("Приключение", new List<string> {"Uncharted 4", "The Last Of Us"});
            dict.Add("Головоломки", new List<string> {"Machinarium", "Portal 2", "Patrick's Parabox"});

            Console.Write(string.Join(", ", dict.Keys));
            Console.WriteLine();

            List<string> value = dict["Головоломки"];
            Console.Write(string.Join(", ", value));
            Console.WriteLine();
            ShowCountElement(dict);
        }
    }
}
