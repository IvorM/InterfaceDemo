using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    class Auto : IPisi
    {
        public void PisiPoKonzoli(string s)
        {
            Console.WriteLine($"Ja sam auto {s}");
        }
    }
}
