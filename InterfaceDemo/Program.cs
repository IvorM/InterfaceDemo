using System;

namespace InterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Osoba o = new Osoba("Marko");
            //IPisi pisi = new Osoba("Ivor");
            //IPisi auto = new Auto();
            //auto.PisiPoKonzoli("Audi");
            //pisi.PisiPoKonzoli("Test2");

            CrudOperacije crudOperacije = new CrudOperacije(new DatotekaRepo());
            crudOperacije.Create();
            crudOperacije.SetInterface(new BazaRepo());
            crudOperacije.Create();
            crudOperacije.SetInterface(new FtpServer());
            crudOperacije.Create();

            //o.PisiPoKonzoli("test");
        }
    }
}
