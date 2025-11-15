using System;
using System.Collections.Generic;

namespace LR22
{
    public class InputModule
    {
        static public (List<string>[], List<int>[]) InputClientByService()
        {
            List<string>[] clientsByServices = new List<string>[3] { new List<string>(),
                                                                     new List<string>(),
                                                                     new List<string>() };
            List<int>[] counts = new List<int>[3] { new List<int>(),
                                                    new List<int>(),
                                                    new List<int>(), };
            // Заполняем клиентов в услугу стрижка
            clientsByServices[0].Add("Беляева Ирина");
            counts[0].Add(4);
            clientsByServices[0].Add("Хомяков Иван");
            counts[0].Add(8);
            clientsByServices[0].Add("Ефимова Ярослава");
            counts[0].Add(3);
            clientsByServices[0].Add("Горшков Максим");
            counts[0].Add(7);
            clientsByServices[0].Add("Некрасова Елизавета");
            counts[0].Add(4);

            // Заполняем клиентов в услугу массаж лица
            clientsByServices[1].Add("Авдеев Никита");
            counts[1].Add(5);
            clientsByServices[1].Add("Овсянников Василий");
            counts[1].Add(2);
            clientsByServices[1].Add("Зайцева Арина");
            counts[1].Add(4);
            clientsByServices[1].Add("Соколова Алиса");
            counts[1].Add(7);
            clientsByServices[1].Add("Александрова Василиса");
            counts[1].Add(3);

            // Заполняем клиентов в услугу чистка лица
            clientsByServices[2].Add("Кондратьева София");
            counts[2].Add(4);
            clientsByServices[2].Add("Исаева Анна");
            counts[2].Add(3);
            clientsByServices[2].Add("Винокурова Вероника");
            counts[2].Add(2);
            clientsByServices[2].Add("Тихонова Дарья");
            counts[2].Add(1);
            clientsByServices[2].Add("Никулин Тимофей");
            counts[2].Add(6);

            return (clientsByServices, counts);
        }

        static public string InputUserQuery()
        {
            Console.Write("Введите, пожалуйста, услугу (стрижка/массаж лица/чистка лица): ");
            return Console.ReadLine();
        }
    }
}
