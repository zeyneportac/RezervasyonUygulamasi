using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace RezervasyonUygulamasi
{
    class YolcuEkle
    {
        private string ad;
        private string soyad;
        private int sifre;
        private int tcno;

        public string Ad { get { return ad; } set { this.ad = value; } }
        public string Soyad { get { return soyad; } set { this.soyad = value; } }
        public int Sifre { get { return sifre; } set { this.sifre = value; } }
        public int TCNO { get { return tcno; } set { this.tcno = value; } }

        SqlConnection baglanti;

        public void YolcuKaydet()
        {
            VeriTabani vt = new VeriTabani(baglanti);
            vt.YolcuEkle(ad, soyad, tcno, sifre);
        }
    }
}
