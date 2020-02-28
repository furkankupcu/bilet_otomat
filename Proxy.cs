using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Proxy : IBiletOtomat
    {
        BiletOtomat otomat1;
        bool Login;
        string KullanıcıAdı, Sifre;
        public Proxy(string KullanıcıAdı, string Sifre)
        {
            this.KullanıcıAdı = KullanıcıAdı;
            this.Sifre = Sifre;
        }

        public bool GirişYap()
        {
            if (KullanıcıAdı.Equals("furkan") && Sifre.Equals("1997"))
            {
                otomat1 = new BiletOtomat();
                Login = true;
                Console.WriteLine("Hesaba giriş yapıldı");
                return true;
            }
            else Console.WriteLine("Lütfen Kullanıcı Adı ve Şifrenizi Doğru Giriniz");

            Login = false;
            return false;
        }
    }
}
