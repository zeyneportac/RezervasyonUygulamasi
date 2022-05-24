using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezervasyonUygulamasi
{
    public class RaporBilgisi
    {
        //kişisel bilgiler
        private string ad;
        private string soyad;
        private int tcno;

        //hastalik bilgileri
        private string konaklama;
        private string ulasim;
        private string konum;
        private string gidistarihi;
        private string fiyat;

        //Kisi Bilgileri
        public string Ad { get { return ad; } set { this.ad = value; } }
        public string Soyad { get { return soyad; } set { this.soyad = value; } }
        public int TCNO { get { return tcno; } set { this.tcno = value; } }

        //Hastalık Bilgileri

        public string Konaklama { get { return konaklama; } set { this.konaklama = value; } }
        public string Ulasim { get { return ulasim; } set { this.ulasim = value; } }
        public string Konum { get { return konum; } set { this.konum = value; } }
        public string GidisTarihi { get { return gidistarihi; } set { this.gidistarihi = value; } }
        public string Fiyat { get { return fiyat; } set { this.fiyat = value; } }


    }
}
