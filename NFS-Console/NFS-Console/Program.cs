using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace NFS_Console
{
    class Program
    {
        static public void Print(Car car)
        {
            Console.WriteLine(car.GetModel());
        }
        static public void LadaVSMerc(List<Car> cars)
        {
            int cycles = 0;
            int finish = 100; 
            while (true)
            {                
                foreach (Car auto in cars)
                {                    
                  for (int i = 0; i < auto.GetSpeed() / 50 * cycles; i++)
                  {
                     Console.Write(" ");
                        if (auto.GetSpeed() / 50 * cycles >= finish)
                        {
                            Console.Clear();
                            Console.WriteLine("Победитель: " + auto.GetModel());
                            return;
                        }
                    }
                  Console.WriteLine(auto.GetModel());
                  Console.WriteLine("----------------------------------------------------------------------------------------------------");
                }
                Thread.Sleep(1500);
                Console.Clear();
                cycles++;
            }
        }
        static void Main()
        {
            Car auto = new Car();
            auto.SetModel("Лада");
            auto.SetSpeed(150);
            //Console.WriteLine(auto.GetModel());
            

            Car merc = new Car();
            merc.SetModel("Мерс");
            merc.SetSpeed(600);

            //Print(auto);
            //Print(merc);

            List<Car> cars = new List<Car>();
            cars.Add(auto);
            cars.Add(merc);

            LadaVSMerc(cars);
        }
    }
}
