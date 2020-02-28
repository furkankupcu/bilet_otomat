using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ParaYok : IDurumlar
    {
        BiletOtomat otomat;
        public void BiletAl()
        {
            Console.WriteLine("Bilet almak için para yükleyiniz");
        }

        public void DurumGoster()
        {
            Console.WriteLine("Durum = Para Var");
        }

        public void ParaYükle()
        {
            Console.WriteLine("Para yüklendi");
            this.otomat.setdurum(this.otomat.getparavardurum());
            
        }

        public void Paraİade()
        {
            Console.WriteLine("işlem gerçekleştiremiyor! Para zaten yok! ");
        }
    }
}
