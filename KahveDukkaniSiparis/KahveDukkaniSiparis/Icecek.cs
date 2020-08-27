using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveDukkaniSiparis
{
    class Icecek:Durum
    {
        public override string ToString()
        {
            return string.Format("{0} Menu {1:c2}", IcecekAdi, Fiyat);
        }
    }
}
