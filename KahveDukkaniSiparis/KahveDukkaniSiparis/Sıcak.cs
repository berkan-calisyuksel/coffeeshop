using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveDukkaniSiparis
{
    class Sicak:Durum
    {
        public Icecek seciliMenu { get; set; }
        public short Miktar { get; set; }

        public void SicakHesapla()
        {
            GToplam = 0;
            GToplam += seciliMenu.Fiyat;
            GToplam *= Miktar;
        }
        public override string ToString()
        {
            return string.Format("{0} Menu, {1} Fiyat,{2:C2}Toplam ", seciliMenu.IcecekAdi, seciliMenu.Fiyat, GToplam);
        }
    }
}
