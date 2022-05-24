using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace RezervasyonUygulamasi
{
    class VeriTabani
    {
        SqlConnection Baglanti;
        SqlCommand komut;
        SqlDataReader dr;

        public VeriTabani(SqlConnection baglanti)
        {
            this.Baglanti = baglanti;
            Baglanti = new SqlConnection("Data Source=LAPTOP-ID1TD4G8;Initial Catalog=Rezervasyon;Integrated Security=True");
        }

    public void YolcuGiris(int TCNO, int SIFRE)
    {
        SqlCommand komut = new SqlCommand();
        komut.Connection = Baglanti;
        SqlDataReader dr;
        Baglanti.Open();

        komut.CommandText = "select TCNO,Sifre from Yolcu where TCNO=" + TCNO + " and Sifre=" + SIFRE + "";
        dr = komut.ExecuteReader();

        if (dr.Read())//Yolcu eğer varsa
        {
            System.Windows.Forms.MessageBox.Show("Giriş işlemi başarılı sayfanıza yönlendiriliyorsunuz.");
            RezervasyonForm rf = new RezervasyonForm();
            rf.tcno = TCNO;
            rf.Show();
        }
        Baglanti.Close();
    }

    public void YolcuEkle(string ad, string soyad, int tcno, int sifre)
    {
        int kayitlimi = 0;

        komut = new SqlCommand();
        komut.Connection = Baglanti;
        Baglanti.Open();
        komut.CommandText = "select TCNO,Sifre from Yolcu where TCNO=" + tcno + " AND  Sifre=" + sifre + "";
        dr = komut.ExecuteReader();

        if (dr.Read())//Yolcu bulunduysa kayıtlı demektir.
            kayitlimi = 1;

        Baglanti.Close();

        if (kayitlimi == 1)//1'e eşitse kayıtlı demektir.
        {
            System.Windows.Forms.MessageBox.Show("\\nKayıt etmek istediğiniz kullanıcı zaten kayıtlı.\\n");
        }
        else //Kayıtlı değilse kayıt et
        {
            komut = new SqlCommand();
            komut.Connection = Baglanti;
            Baglanti.Open();

            komut.CommandText = "insert into Yolcu(Ad,Soyad,TCNO,Sifre) values('" + ad + "','" + soyad + "', '" + tcno + "','" + sifre + "')";
            komut.ExecuteNonQuery();
            Baglanti.Close();

            System.Windows.Forms.MessageBox.Show("Kullanıcı kaydı başarıyla yapıldı.");
        }
    }

}
}