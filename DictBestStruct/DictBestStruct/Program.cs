using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictBestStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
            dict.Add("Шутер", new List<string> {"csgo"});
            dict.Add("Приключение", new List<string> {"Uncharted 4", "The Last Of us"});
            dict.Add("Головоломки", new List<string> { "Machimarium", "Portal 2", "Patrick's Parabox" });

            Console.Write(string.Join(", ", dict.Keys));
        }
    }
}
