using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace RezervasyonUygulamasi
{
    public class Otel : KonaklamaRezAbstraction
    {
        SqlConnection baglanti;
        SqlCommand komut;
        public override void Konaklama()
        {
            komut = new SqlCommand();
            baglanti = new SqlConnection("Data Source=LAPTOP-ID1TD4G8;Initial Catalog=Rezervasyon;Integrated Security=True");
            komut.Connection = baglanti;

            int deger = base.KullaniciKontrol();
            if (deger == 0)
            {
                komut.CommandText = "insert into Yolcu(Ad,Soyad,TCNO,Konaklama,Ulasim,Konum,GidisTarihi,Fiyat) values('" + base.Ad + "','" + base.Soyad + "','" + base.TCNO + "','Otel','" + ulasim.Ulasim() + "','" + ulasim.Konum() + "','" + ulasim.GidisTarihi() + "','" + ulasim.Fiyat() + "')";

                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();

                System.Windows.Forms.MessageBox.Show("Yolcu Kaydedildi.");
            }
            else if (deger == 1)
            {
                komut.CommandText = "update Yolcu set Konaklama='Otel',Ulasim='" + ulasim.Ulasim() + "',Konum='" + ulasim.Konum() + "',GidisTarihi='" + ulasim.GidisTarihi() + "',Fiyat='" + ulasim.Fiyat() + "' where TCNO=" + base.TCNO + "";

                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();

                System.Windows.Forms.MessageBox.Show("Yolcu Bilgileri Güncellendi.");
            }
        }
    }
}
