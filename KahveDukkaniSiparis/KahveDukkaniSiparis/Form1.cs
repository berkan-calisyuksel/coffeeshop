using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KahveDukkaniSiparis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            List<Icecek> Kahve = new List<Icecek>()
         {
            new Icecek{IcecekAdi="Amerikan Expresso >>",Fiyat=10},
            new Icecek{IcecekAdi="Latte >>",Fiyat=10},
            new Icecek{IcecekAdi="Cappuccino >>",Fiyat=10},
         };
            foreach (var item in Kahve)
            {
                cbKahve.Items.Add(item);
            }
            List<Icecek> Soguk = new List<Icecek>()
            {
                new Icecek{IcecekAdi="Coco Cola >>",Fiyat=10 },
                new Icecek{IcecekAdi="Soda >>",Fiyat=25 },
                new Icecek{IcecekAdi="Limonata >>",Fiyat=30 },

            };
            foreach (var item in Soguk)
            {
                cbSoguk.Items.Add(item);
            }
            List<Icecek> Sicak = new List<Icecek>()
            {
                new Icecek{IcecekAdi="Çay >>",Fiyat=5},
                new Icecek{IcecekAdi="Ihlamur >>",Fiyat=7},
                new Icecek{IcecekAdi="Oralet >>",Fiyat=5},
            };
            foreach (var item in Sicak)
            {
                cbSicak.Items.Add(item);
            }
        }
        Kahve KahveEkle = new Kahve();

        void KahveSec()
        {
            KahveEkle.seciliMenu = cbKahve.SelectedItem as Icecek;
            KahveEkle.Miktar = Convert.ToInt16(nmKahve.Value); //tekrar dön

            if (chBuyuk.Checked) KahveEkle.Buyukluk = Boyut.Buyuk;
            else if (chOrta.Checked) KahveEkle.Buyukluk = Boyut.Orta;

            else KahveEkle.Buyukluk = Boyut.Kucuk ;
            KahveEkle.EkMalzeme = new List<ExtraMalzeme>();
            foreach (CheckBox item in gpExtra.Controls)
            {
                if (item.Checked)
                {
                    ExtraMalzeme eks = new ExtraMalzeme();
                    eks.IcecekAdi = item.Text;
                    eks.Fiyat = 0.50m;
                    KahveEkle.EkMalzeme.Add(eks);
                }
            }
            KahveEkle.KahveHesapla();
            lstSiparis.Items.Add(KahveEkle);
        }
        void SogukSec()
        {
            Soguk SogukEkle = new Soguk();
            SogukEkle.seciliMenu = cbSoguk.SelectedItem as Icecek;
            SogukEkle.Miktar = Convert.ToInt16(nmSoguk.Value);

            SogukEkle.SogukHesapla();

        }
        void SicakSec()
        {
            Sicak SicakEkle = new Sicak();
            SicakEkle.seciliMenu = cbSicak.SelectedItem as Icecek;
            SicakEkle.Miktar = Convert.ToInt16(nmSicak.Value);

            SicakEkle.SicakHesapla();
            lstSiparis.Items.Add(SicakEkle);
        }

        private void CbKahve_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbKahve.Text != null)
            {
                gpExtra.Enabled = true;
                gpBoyut.Enabled = true;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if(cbKahve.SelectedItem != null)
            {
                KahveSec();

            }
            if(cbSicak.SelectedItem != null)
            {
                SicakSec();
                    
            }
            if (cbSoguk.SelectedItem != null)
            {
                SogukSec();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            decimal ttutar = 0;

            foreach (Durum item in lstSiparis.Items)
            {
                ttutar += item.GToplam;
            }
            Durum dr = new Durum();
            dr.Isim = textBox1.Text;
            
        }
    }
}
