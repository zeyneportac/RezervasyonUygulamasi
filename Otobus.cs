using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RezervasyonUygulamasi
{
    public class Otobus : UlasimRez
    {
        public override string Ulasim()
        {
            return "Otobus";
        }
        public override string Konum()
        {
            string konum = "İzmir Şehirlerarası Otobüs Terminali";
            return konum;
        }

        public override string GidisTarihi()
        {
            string gidistarihi = "20.06.2022 15:30";
            return gidistarihi;
        }

        public override string Fiyat()
        {
            string fiyat = "260 TL";
            return fiyat;
        }
    }
}
