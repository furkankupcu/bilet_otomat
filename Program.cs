using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    //Kullanıcı adı : furkan  şifre:1234
    class Program
    {
        static void Main(string[] args)
        {

            string KullaniciAdi = "", Sifre = "";
            while (true)
            {
                Console.WriteLine("Lütfen kullanıcı adınızı giriniz.");
                KullaniciAdi = Console.ReadLine();

                Console.WriteLine("Lütfen şifrenizi giriniz.");
                Sifre = Console.ReadLine();

                int seçim, seçim2;

                IBiletOtomat otomat1 = new Proxy(KullaniciAdi, Sifre);


                Console.WriteLine("************");

                
                Console.WriteLine("*1 Para Yükle");
                Console.WriteLine("*2 Para İade");
                Console.WriteLine("*3 Ürün Ver");
                Console.WriteLine("*4 Durum Göster");



                seçim = Convert.ToInt32(Console.ReadLine());

                BiletOtomat otomat = new BiletOtomat(100);

                if (seçim == 1)
                {
                    otomat.ParaYükle();

                }
                else if (seçim == 2)
                {
                    otomat.Paraİade();
                }
                else if (seçim == 3)
                {
                    otomat.BiletAl();
                }

                else if (seçim == 4)
                {
                    otomat.DurumGöster();
                }
                
                Template a1 = new Bilet();
                a1.TemplateMethod();
                Console.WriteLine("***********");
            }
        }
    }
}
