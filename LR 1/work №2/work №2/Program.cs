using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work__2
{
    class Program
    {
        static void Main(string[] args)
        {
            //вариант 6
            int[] array = new int[4000];
            Random randomValue = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = randomValue.Next(1, 5001);
            }

            foreach (int elementValue in array)
            {
                Console.Write(elementValue + ",");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            int[] arrayShow = new int[2000];

            for (int i = 0; i < array.Length; i = i + 2)
            {
                int j = i + 2;
                arrayShow[i] = array[i] + array[j];
            }

            foreach (int elementValue in arrayShow)
            {
                Console.Write(elementValue + ",");
            }
        }
    }
}
