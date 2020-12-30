using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListeZad9
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> gradovi = new Dictionary<string, int>()
            {
                 {"Beograd", 2000000},
                 {"Nis", 1400000 },
                 {"Kraljevo", 400000 }
            };
            Console.WriteLine(gradovi.Remove("Nis"));
            foreach (KeyValuePair<string, int> grad in gradovi)
                Console.WriteLine(grad.Key + " - " + grad.Value);
            Console.WriteLine("=====================================");

            //pokusaj uklanjanja nepostojeceg elementa
            Console.WriteLine(gradovi.Remove("Novi Sad"));
            foreach (KeyValuePair<string, int> grad in gradovi)
                Console.WriteLine(grad.Key + " - " + grad.Value);
            Console.WriteLine("=====================================");

            Console.ReadLine();
        }
    }
}
