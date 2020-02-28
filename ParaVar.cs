using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ParaVar : IDurumlar
    {
        BiletOtomat otomat;
        public ParaVar(BiletOtomat otomat)
        {
            this.otomat = otomat;

        }
        public void BiletAl()
        {
            Console.WriteLine("Ürün veriliyor");
            otomat.setdurum(otomat.getbiletver());
        }

        public void DurumGoster()
        {
            Console.WriteLine("Para Var");
        }

        public void ParaYükle()
        {
            Console.WriteLine("İşlem gerçekleştirilemiyor! Para zaten var");
        }

        public void Paraİade()
        {
            Console.WriteLine("Para iade edildi");
            otomat.setdurum(otomat.getparayokdurum());

        }
    }
}
