using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class BiletOtomat:IBiletOtomat
    { 

        
        IDurumlar paravardurumu;
        IDurumlar parayokdurumu;
        IDurumlar mevcutdurum;
        IDurumlar biletverdurum;
        private int sayaç;

        public BiletOtomat(int sayaç)
        {
          //  paravardurumu = new ParaVar();
            parayokdurumu = new ParaYok();
          //  biletverdurum = new ÜrünVer();
            setsayac(sayaç);
        }

        public BiletOtomat()
        {
        }

        public void setsayac(int sayaç)
        {
            this.sayaç = sayaç;
            setdurum(parayokdurumu);
        }

        public IDurumlar getparayokdurum()
        {
            return paravardurumu;
        }

        public IDurumlar getparavardurum()
        {
            return paravardurumu;
        }
        public int getsayaç()
        {
            return sayaç;
        }

        public IDurumlar getbiletver()
        {
            return biletverdurum;
        }
        public void setdurum(IDurumlar durum)
        {
            mevcutdurum = durum;
        }

        internal void BiletAl()
        {
            throw new NotImplementedException();
        }

        public void ParaYükle()
        {
            mevcutdurum.ParaYükle();
        }
        public void Paraİade()
        {
            mevcutdurum.Paraİade();
        }
        public void DurumGöster()
        {
            mevcutdurum.DurumGoster();
        }

        bool IBiletOtomat.GirişYap()
        {
            throw new NotImplementedException();
        }
    }
}
