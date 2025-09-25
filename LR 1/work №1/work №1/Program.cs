using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work__1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину массива");
            string s = Console.ReadLine();
            int temp = Convert.ToInt32(s);
            int[] array = new int[temp];

            for (int index = 0; index < array.Length; index++)
            {
                array[index] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Массив = ");
            foreach (int l in array)
            {
                Console.Write(l+" ");
            }
        }
    }
}
