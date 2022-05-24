using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezervasyonUygulamasi
{
    public class Ucak : UlasimRez
    {
        public override string Ulasim()
        {
            return "Ucak";
        }
        public override string Konum()
        {
            string konum = "İzmir Adnan Menderes Havalimanı";
            return konum;
        }

        public override string GidisTarihi()
        {
            string gidistarihi = "20.06.2022 10:15";
            return gidistarihi;
        }

        public override string Fiyat()
        {
            string fiyat = "450 TL";
            return fiyat;
        }
    }
}
