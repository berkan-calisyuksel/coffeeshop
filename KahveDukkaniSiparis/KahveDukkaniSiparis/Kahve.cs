using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveDukkaniSiparis
{
    class Kahve:Durum
    {
        public Icecek seciliMenu { get; set; }
        public List<ExtraMalzeme>EkMalzeme { get; set; }
        public short Miktar { get; set; }
        public Boyut Buyukluk { get; set; }
        public void KahveHesapla()
        {
            GToplam = 0;
            GToplam += seciliMenu.Fiyat;
            switch (Buyukluk)
            {
                case Boyut.Kucuk:
                    GToplam += 1;
                    break;
                case Boyut.Orta:
                    GToplam += 2;
                    break;
                case Boyut.Buyuk:
                    GToplam += 3;
                    break;
                default:
                    break;

            }
            foreach (ExtraMalzeme item in EkMalzeme)
            {
                GToplam += item.Fiyat;
            }
            GToplam *= Miktar;
        }
        public override string ToString()
        {
            if(EkMalzeme.Count < 1)
            {
                return string.Format("Menu:{0} ,Boy:{1}, Adet:{2}, Toplam={3:C2}",seciliMenu.IcecekAdi,Buyukluk,Miktar,GToplam);
            }
            else
            {
                string malzemesi = null;
                foreach(ExtraMalzeme item in EkMalzeme)
                {
                    malzemesi += item.IcecekAdi + ",";
                }
                malzemesi = malzemesi.TrimEnd(',');

                return string.Format("Menu:{0}, Boy:{1},Adet:{2},Ek Malzemesi:({3}),Toplam={4:C2}", seciliMenu.IcecekAdi, Buyukluk, Miktar, malzemesi, GToplam);
            }
        }
    }
}
