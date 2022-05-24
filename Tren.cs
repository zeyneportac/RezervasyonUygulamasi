using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezervasyonUygulamasi
{
    public class Tren : UlasimRez
    {
        public override string Ulasim()
        {
            return "Tren";
        }
        public override string Konum()
        {
            string konum = "İzmir Alsancak Gar";
            return konum;
        }

        public override string GidisTarihi()
        {
            string gidistarihi = "21.06.2022 12:30";
            return gidistarihi;
        }

        public override string Fiyat()
        {
            string fiyat = "130 TL";
            return fiyat;
        }
    }
}
