using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Functions
{
    public class ListStringModule
    {
        static public List<string> FillTheList()
        {
            Console.WriteLine("Введите размер списка");
            int count = Convert.ToInt32(Console.ReadLine());
            List<string> list = new List<string>();
            for (int index = 0; index < count; index++)
            {
                Console.WriteLine($"Введите {index+1} элемент: ");
                list.Add(Console.ReadLine());
            }
            return list;
        }
    }
}
