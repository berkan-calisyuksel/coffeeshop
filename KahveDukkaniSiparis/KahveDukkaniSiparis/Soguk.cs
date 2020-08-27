using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveDukkaniSiparis
{
    class Soguk:Durum
    {
        public Icecek seciliMenu { get; set; }
        public short Miktar { get; set; }

        public void SogukHesapla()
        {
            GToplam = 0;
            GToplam += seciliMenu.Fiyat;
            GToplam *= Miktar;
        }
        public override string ToString()
        {
            return string.Format("{0} Menu, Fiyat{1:C2},Toplam{2:C2  ", seciliMenu.IcecekAdi, seciliMenu.Fiyat, GToplam);
                
        }
    }
}
