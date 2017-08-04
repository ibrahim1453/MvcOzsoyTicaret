using System;
using System.Collections.Generic;

namespace OzsoyTicaret.WebUI.Models
{
    public partial class MusteriAdre
    {
        public int Id { get; set; }
        public System.Guid MusteriId { get; set; }
        public string Adres { get; set; }
        public string Adi { get; set; }
        public virtual Musteri Musteri { get; set; }
    }
}
