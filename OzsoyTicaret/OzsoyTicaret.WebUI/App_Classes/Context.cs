using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OzsoyTicaret.WebUI.Models;

namespace OzsoyTicaret.WebUI.App_Classes
{
    public class Context
    {
        private static ozsoyETİCARETContext baglanti;

        public static ozsoyETİCARETContext Baglanti
        {
            get
            {if (baglanti == null)
                    baglanti = new ozsoyETİCARETContext();
                return baglanti; }


            set { baglanti = value; }
        }

    }
}