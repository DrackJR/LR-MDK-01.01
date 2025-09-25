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
            int[] array = new int[4000];
            Random randomValue = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = randomValue.Next(1, 5000);
            }

            foreach (int elementValue in array)
            {
                Console.Write(elementValue + ",");
            }
        }
    }
}
