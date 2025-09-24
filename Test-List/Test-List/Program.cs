using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> Text = new List<string>();
            Text.Add("One");
            Text.Add("Two");
            Text.Add("Three");
            Text.Add("Four");
            Text.Add("Five");

            Console.WriteLine("Введите текст: ");
            string input = Console.ReadLine();
            //Console.WriteLine(input);

            List<string> list = new List<string>();

            for (int i = 0; i < Text.Count; i++)
            {
                if (Text[i].Contains(input))
                {
                    list.Add(Text[i]);
                }
            }
            foreach (string element in list)
            {
                Console.WriteLine(element);
            }
        }
    }
}
