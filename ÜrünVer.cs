using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ÜrünVer : IDurumlar
    {
        BiletOtomat otomat;
        public ÜrünVer(BiletOtomat otomat)
        {
            this.otomat = otomat;
        }

        public void BiletAl()
        {
            if (otomat.getsayaç() > 0)
            {
                Console.WriteLine("Bilet veriliyor");
                int sayaç = otomat.getsayaç();
                sayaç--;
                otomat.setsayac(sayaç);
                otomat.setdurum(otomat.getparayokdurum());
            }
            else
            {
                Console.WriteLine("Bilet Tükendi");
                otomat.setdurum(otomat.getparayokdurum());
                otomat.Paraİade();
            }
        }

        public void DurumGoster()
        {
            Console.WriteLine(" Durum : Ürün Ver");
        }

        public void ParaYükle()
        {
            Console.WriteLine("İşlem Gerçekleştirilemiyor! Para zaten var!");
        }

        public void Paraİade()
        {
            Console.WriteLine("İşlem gerçekleştirilemiyor! Ürün veriliyor");
        }
    }
}
