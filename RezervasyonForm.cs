using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;


namespace RezervasyonUygulamasi
{
    public partial class RezervasyonForm : Form
    {
        public RezervasyonForm()
        {
            InitializeComponent();
        }

        public int tcno;

        private void btn_onayla_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_konaklama.Text == "Otel")
                {
                    KonaklamaRezAbstraction konaklamaRez = new Otel();

                    konaklamaRez.Ad = txt_ad.Text;
                    konaklamaRez.Soyad = txt_soyad.Text;
                    konaklamaRez.TCNO = Convert.ToInt32(txt_tc.Text);

                    if (cmb_ulasim.Text == "Uçak")
                    {
                        konaklamaRez.ulasim = new Ucak();
                        konaklamaRez.Konaklama();
                    }
                    else if (cmb_ulasim.Text == "Otobüs")
                    {
                        konaklamaRez.ulasim = new Otobus();
                        konaklamaRez.Konaklama();
                    }
                    else if (cmb_ulasim.Text == "Tren")
                    {
                        konaklamaRez.ulasim = new Tren();
                        konaklamaRez.Konaklama();
                    }
                    else
                    {
                        MessageBox.Show("Bir Ulaşım Seçiniz.");
                    }
                }
                else if (cmb_konaklama.Text == "Çadır")
                {
                    KonaklamaRezAbstraction konaklamaRez = new Cadir();

                    konaklamaRez.Ad = txt_ad.Text;
                    konaklamaRez.Soyad = txt_soyad.Text;
                    konaklamaRez.TCNO = Convert.ToInt32(txt_tc.Text);

                    if (cmb_ulasim.Text == "Uçak")
                    {
                        konaklamaRez.ulasim = new Ucak();
                        konaklamaRez.Konaklama();
                    }
                    else if (cmb_ulasim.Text == "Otobüs")
                    {
                        konaklamaRez.ulasim = new Otobus();
                        konaklamaRez.Konaklama();
                    }
                    else if (cmb_ulasim.Text == "Tren")
                    {
                        konaklamaRez.ulasim = new Tren();
                        konaklamaRez.Konaklama();
                    }
                    else
                    {
                        MessageBox.Show("Bir Ulaşım Seçiniz.");
                    }
                }
                else if (cmb_konaklama.Text == "Ev")
                {
                    KonaklamaRezAbstraction konaklamaRez = new Ev();

                    konaklamaRez.Ad = txt_ad.Text;
                    konaklamaRez.Soyad = txt_soyad.Text;
                    konaklamaRez.TCNO = Convert.ToInt32(txt_tc.Text);

                    if (cmb_ulasim.Text == "Uçak")
                    {
                        konaklamaRez.ulasim = new Ucak();
                        konaklamaRez.Konaklama();
                    }
                    else if (cmb_ulasim.Text == "Otobüs")
                    {
                        konaklamaRez.ulasim = new Otobus();
                        konaklamaRez.Konaklama();
                    }
                    else if (cmb_ulasim.Text == "Tren")
                    {
                        konaklamaRez.ulasim = new Tren();
                        konaklamaRez.Konaklama();
                    }
                    else
                    {
                        MessageBox.Show("Bir Ulaşım Seçiniz.");
                    }
                }
                else
                {
                    MessageBox.Show("Konaklama Seçiniz..");
                }
            }

            catch (Exception hata)
            {
                MessageBox.Show("Bir Hata Meydana Geldi.\nLütfen Sonra Tekrar Deneyiniz." + hata.Message);
            }
        }

        private void btn_RaporAl_Click(object sender, EventArgs e)
        {
            //dosya işlemleri için
            StreamWriter sw;
            string dosya = "";
            string metin = "";

            string raporcesidi = cmb_raporcesidi.Text;
            string raporonceligi = cmb_raporgosterimi.Text;
            SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-ID1TD4G8;Initial Catalog=Rezervasyon;Integrated Security=True");
            SqlCommand komut = new SqlCommand();
            SqlDataReader dr;
            komut.Connection = baglanti;

            //raporu alınacak yolcunun tcno numarasını gönder.
            int tcno = Convert.ToInt32(txt_raportc.Text);

            RaporBilgisi rb = new RaporBilgisi();

            baglanti.Open();
            komut.CommandText = "select * from Yolcu where TCNO=" + tcno + "";
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                //kişisel bilgiler
                rb.Ad = dr[1].ToString();
                rb.Soyad = dr[2].ToString();
                rb.TCNO = Convert.ToInt32(dr[3]);

                //Konaklama bilgileri
                rb.Konaklama = dr[4].ToString();
                rb.Ulasim = dr[5].ToString();
                rb.Konum = dr[6].ToString();
                rb.GidisTarihi = dr[7].ToString();
                rb.Fiyat = dr[8].ToString();
            }
            baglanti.Close();

            if (raporcesidi == "HTML")
            {
                Rapor rapor = new HtmlRapor(rb);
                RaporYonetimi raporyonetimi = new RaporYonetimi(rapor);
                if (raporonceligi == "Kişi Bilgileri Öncelikli")
                {
                    metin = raporyonetimi.Olustur();
                    dosya = @"C:\Users\PC\Desktop\RezervasyonUygulamasi/HtmlRapor.html";
                }
                else if (raporonceligi == "Seyahat Bilgileri Öncelikli")
                {
                    metin = raporyonetimi.TerstenOlustur();
                    dosya = @"C:\Users\PC\Desktop\RezervasyonUygulamasi/HtmlRapor.html";
                }
                else
                {
                    MessageBox.Show("Hiçbir Alan Boş Bırakılamaz...");
                }
            }
            else if (raporcesidi == "JSON")
            {
                Rapor rapor = new JsonRapor(rb);
                RaporYonetimi raporyonetimi = new RaporYonetimi(rapor);
                if (raporonceligi == "Kişi Bilgileri Öncelikli")
                {
                    metin = raporyonetimi.Olustur();
                    dosya = @"C:\Users\PC\Desktop\RezervasyonUygulamasi/JSONRapor.json";
                }
                else if (raporonceligi == "Seyahat Bilgileri Öncelikli")
                {
                    metin = raporyonetimi.TerstenOlustur();
                    dosya = @"C:\Users\PC\Desktop\RezervasyonUygulamasi/JSONRapor.json";
                }
                else
                {
                    MessageBox.Show("Hiçbir Alan Boş Bırakılamaz...");
                }
            }
            else
            {
                MessageBox.Show("Hiçbir Alan Boş Bırakılamaz...");
            }

            sw = new StreamWriter(dosya);
            sw.WriteLine(metin);
            sw.Close();

            MessageBox.Show("Rapor Oluşturuldu Klasorün İçine Bakınız..");
        }

        private void txt_raportc_TextChanged(object sender, EventArgs e)
        {
            btn_RaporAl.Enabled = true;
        }

        private void RezervasyonForm_Load(object sender, EventArgs e)
        {

        }

        private void lbl_tc_Click(object sender, EventArgs e)
        {

        }

        private void txt_tc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
