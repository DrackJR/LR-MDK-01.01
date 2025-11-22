using System;
using System.Collections.Generic;

namespace NFS_Console
{
    class Program
    {
        static public void Print(Car car)
        {
            Console.WriteLine(car.GetModel());
        }
        static void Main()
        {
            Car auto = new Car();
            auto.SetModel("Лада");
            auto.SetSpeed(150);
            Console.WriteLine(auto.GetModel());
            

            Car merc = new Car();
            merc.SetModel("Мерс");
            merc.SetSpeed(300);

            Print(auto);
            Print(merc);

            List<Car> cars = new List<Car>();
            cars.Add(auto);
            cars.Add(merc);
        }
    }
}
