using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace RezervasyonUygulamasi
{
    public class JsonRapor : Rapor
    {
        public class KisiselBilgiler
        {
            //Kisi Bilgileri
            public string Ad;
            public string Soyad;
            public int TCNO;
        }
        public class SeyahatBilgileri
        {
            //Hastalık Bilgileri

            public string Konaklama;
            public string Ulasim;
            public string Konum;
            public string GidisTarihi;
            public string Fiyat;
        }
        public JsonRapor(RaporBilgisi rb) : base(rb)
        { }
        public override string KisiBilgileriOlustur()
        {
            KisiselBilgiler kb = new KisiselBilgiler();

            kb.Ad = this.raporbilgisi.Ad;
            kb.Soyad = this.raporbilgisi.Soyad;
            kb.TCNO = this.raporbilgisi.TCNO;

            string stringjson = JsonConvert.SerializeObject(kb);
            return stringjson;
        }
        public override string SeyahatBilgileriOlustur()
        {
            SeyahatBilgileri db = new SeyahatBilgileri();

            db.Konaklama = this.raporbilgisi.Konaklama;
            db.Ulasim = this.raporbilgisi.Ulasim;
            db.Konum = this.raporbilgisi.Konum;
            db.GidisTarihi = this.raporbilgisi.GidisTarihi;
            db.Fiyat = this.raporbilgisi.Fiyat;

            string stringjson = JsonConvert.SerializeObject(db);
            return stringjson;
        }
    }
}
