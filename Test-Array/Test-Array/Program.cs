using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = new string[3];
            array[0] = "one";
            array[1] = "two";
            array[2] = "three";

            array[1] = "four";

            foreach (string show in array)
            {
                Console.WriteLine(show);
            }

            string[] massiv = new string[3];
            massiv[0] = array[2];
            massiv[1] = array[1];
            massiv[2] = array[0];
        }
    }
}
