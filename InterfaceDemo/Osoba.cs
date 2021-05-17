using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    class Osoba:IPisi,IComparable
    {
        public string Ime { get; set; }

        public Osoba(string ime)
        {
            Ime = ime;
        }

        public void PisiPoKonzoli(string s)
        {
            Console.WriteLine($"{Ime} piše: {s}");
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
