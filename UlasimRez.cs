using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezervasyonUygulamasi
{
    public abstract class UlasimRez
    {
        public abstract string Ulasim();
        public abstract string Konum();
        public abstract string GidisTarihi();
        public abstract string Fiyat();
    }
}
