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

            Console.Write("[");

            for (int i = 0; i < array.Length - 1; i++)
            {
                Console.Write(array[i] + ",");
            }

            Console.WriteLine(array[array.Length - 1] + "]");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            List<int> listShow = new List<int>();
            int leftBorder = 0;
            int rightBorder = 2;

            do
            {
                listShow.Add(array[leftBorder] + array[rightBorder]);
                leftBorder = rightBorder;
                rightBorder += 2;
            } while (rightBorder < array.Length);

            Console.Write("[");

            for (int i = 0; i < listShow.Count - 1; i++)
            {
                Console.Write(listShow[i] + ",");
            }

            Console.WriteLine(listShow.Last() + "]");
        }
    }
}
