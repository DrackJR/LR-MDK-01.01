using OffesetLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Offset
{
    class Program
    {
        static void Main(string[] args)
        {
            Tractor mtz50 = new Tractor("mtz50", 950000, "MtzZavod");

            Console.WriteLine(mtz50.GetName());

            List<Tractor> allTractors = new List<Tractor>
            {
                new Tractor("Belarus", 450000, "BelarusZavod"),
                new Tractor("Zavodchanin", 150000, "ZukiyaZavod")
            };

            allTractors.Add(mtz50);

            Console.WriteLine("Название трактора: " + allTractors[0].GetName());

            List<Tractor> tractors = GetAllTractorMoreThanX(500000, allTractors);

            Console.WriteLine(tractors[0].GetName());

        }
        static public List<Tractor> GetAllTractorMoreThanX(double x, List<Tractor> allTractors)
        {
            List<Tractor> result = new List<Tractor>();
            foreach(Tractor t in allTractors)
            {
                if(t.GetPrice() > x)
                {
                    result.Add(t);
                }
            }

            return result;
        }
    }
}
