using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haustiere
{
    class Program
    {
        static void Main(string[] args)
        {
            Haustier h1 = new Haustier(alt: 12, name: "Franz");
            Haustier h2 = new Haustier(alt: 13, name: "Katzi");

            Besitzer b1 = new Besitzer("Schatzi", "Stockerau");

            b1.haustierHinzufuegen(h1);
            b1.haustierHinzufuegen(h2);

            foreach(Haustier vieh in b1.getHaustiere())
            {
                Console.WriteLine(vieh.DatenAnzeigen());
            }

            b1.haustierLoeschen("az");

            Console.WriteLine("Neue Liste");

            foreach (Haustier vieh in b1.getHaustiere())
            {
                Console.WriteLine(vieh.DatenAnzeigen());
            }


            Console.ReadKey();

        }
    }
}
