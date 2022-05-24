using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezervasyonUygulamasi
{
    public abstract class Rapor
    {
        protected RaporBilgisi raporbilgisi;
        public Rapor(RaporBilgisi rb)
        {
            this.raporbilgisi = rb;
        }
        public string CiktiOlustur()
        {
            string cikti = KisiBilgileriOlustur();
            cikti += SeyahatBilgileriOlustur();
            return cikti;
        }
        public string TerstenCiktiOlustur()
        {
            string cikti = SeyahatBilgileriOlustur();
            cikti += KisiBilgileriOlustur();
            return cikti;
        }
        public abstract string KisiBilgileriOlustur();
        public abstract string SeyahatBilgileriOlustur();
    }
}
