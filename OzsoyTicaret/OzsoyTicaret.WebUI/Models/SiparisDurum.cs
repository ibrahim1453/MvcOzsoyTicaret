using System;
using System.Collections.Generic;

namespace OzsoyTicaret.WebUI.Models
{
    public partial class SiparisDurum
    {
        public SiparisDurum()
        {
            this.Satis = new List<Sati>();
        }

        public int Id { get; set; }
        public string Adi { get; set; }
        public string Aciklam { get; set; }
        public virtual ICollection<Sati> Satis { get; set; }
    }
}
