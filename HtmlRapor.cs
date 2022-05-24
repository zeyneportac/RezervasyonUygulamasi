using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezervasyonUygulamasi
{
    public class HtmlRapor : Rapor
    {
        public HtmlRapor(RaporBilgisi rb) : base(rb)
        { }
        public override string KisiBilgileriOlustur()
        {
            // veri tabanından kisisel bilgileri getir 
            // string bir değişkene aktar
            // değişkeni döndür
            string metin = string.Format("<h1>Kişi Bilgileri</h1>");

            metin += string.Format("<h3>Ad : {0}</h3>", this.raporbilgisi.Ad);
            metin += string.Format("<h3>Soyad : {0}</h3>", this.raporbilgisi.Soyad);
            metin += string.Format("<h3>TC Kimlik Numarası : {0}</h3>", this.raporbilgisi.TCNO);

            return metin;
        }
        public override string SeyahatBilgileriOlustur()
        {
            // veri tabanından diyet bilgileri getir 
            // string bir değişkene aktar
            // değişkeni döndür

            string metin = string.Format("<h1>Hastalık Bilgileri</h1>");

            metin += string.Format("<h3>Konaklama : {0}</h3>", this.raporbilgisi.Konaklama);
            metin += string.Format("<h3>Ulasim : {0}</h3>", this.raporbilgisi.Ulasim);
            metin += string.Format("<h3>Konum : <br>{0}</h3>", this.raporbilgisi.Konum);
            metin += string.Format("<h3>Gidiş Tarihi : <br>{0}</h3>", this.raporbilgisi.GidisTarihi);
            metin += string.Format("<h3>Fiyat : <br>{0}</h3>", this.raporbilgisi.Fiyat);

            return metin;
        }
    }
}
