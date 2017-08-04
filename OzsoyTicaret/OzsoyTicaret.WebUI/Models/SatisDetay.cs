using System;
using System.Collections.Generic;

namespace OzsoyTicaret.WebUI.Models
{
    public partial class SatisDetay
    {
        public int SatisID { get; set; }
        public int UrunID { get; set; }
        public Nullable<int> Adet { get; set; }
        public Nullable<decimal> Fiyat { get; set; }
        public Nullable<double> Indirim { get; set; }
        public virtual Sati Sati { get; set; }
        public virtual Urun Urun { get; set; }
    }
}
