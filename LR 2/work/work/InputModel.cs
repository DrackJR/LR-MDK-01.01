using System;
using System.Collections.Generic;

namespace work
{
    public class InputModel
    {
        static public (List<string>[], List<int>[] ) InputServices()
        {
            List<string>[] services = new List<string>[3] { new List<string>(),
                                                                new List<string>(),
                                                                new List<string>()
            };
            List<int>[] count = new List<int>[3] { new List<int>(),
                                                                new List<int>(),
                                                                new List<int>()
            };

            services[0].Add("Стрижка");
            count[0].Add(3);

            services[1].Add("Массаж лица");
            count[1].Add(6);

            services[2].Add("Чистка лица");
            count[2].Add(5);

            return (services, count);
        }

        static public string InputUserQuery()
        {
            Console.Write("Введите, пожалуйста, услугу (Стрижка/Массаж лица/Чистка лица): ");
            return Console.ReadLine();
        }
    }
}