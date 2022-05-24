using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace RezervasyonUygulamasi
{
    public abstract class KonaklamaRezAbstraction
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataReader dr;

        private string ad;
        private string soyad;
        private int tcno;

        public string Ad { get { return ad; } set { this.ad = value; } }
        public string Soyad { get { return soyad; } set { this.soyad = value; } }
        public int TCNO { get { return tcno; } set { this.tcno = value; } }

        public UlasimRez ulasim;

        public abstract void Konaklama();
        protected int KullaniciKontrol()
        {
            //Veritabanında girilen kullanıcı adı var mı diye kontrol et varsa 1 yoksa 0 döndür
            int deger = 0;
            baglanti = new SqlConnection("Data Source=LAPTOP-ID1TD4G8;Initial Catalog=Rezervasyon;Integrated Security=True");
            komut = new SqlCommand();
            komut.Connection = baglanti;
            baglanti.Open();

            komut.CommandText = "select * from Yolcu where TCNO=" + TCNO + "";

            dr = komut.ExecuteReader();
            if (dr.Read())
                deger = 1;

            baglanti.Close();
            return deger;
        }
    }
}
