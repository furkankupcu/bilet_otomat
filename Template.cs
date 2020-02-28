using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    enum OdemeTipi
    {
        Pesin,Taksit
    }

    abstract class Template
    {
        protected string UrunAdi;
        protected OdemeTipi odemeTipi;
        void Baslat() => Console.WriteLine("Alışveriş Başladı");
        void Bitir() => Console.WriteLine("Alışveriş Bitti.{UrunAdi} {odemeTipi} yöntemiyle ödenmiştir");
        abstract public void Urun();
        abstract public void OdemeSekli();

        public void TemplateMethod()
        {
            Baslat();
            Urun();
            OdemeSekli();
            Bitir();
        }
    }
}