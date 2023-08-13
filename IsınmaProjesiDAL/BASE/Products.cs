using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsınmaProjesiDAL.BASE
{
    public class Products : DBRecord
    {
        public Products() 
        {
            this.TabloAdi = "GelenÜrünBilg";
            this.ID_AlanAdi = "GelenÜrünId";
        }

        public string GetirenMüşteri { get; set; }
        public string GelenÜrün { get; set; }
        public string ÜrünKategori { get; set; }
        public string ÜrünMarka { get; set; }
        public string ÜrünModel { get; set; }
        public string ÜrünSeriNo { get; set; }
        public string Barkod { get; set; }
        public string ÜrünArizasi { get; set; }
        public string VerilenFiyat { get; set; }
        public string VerilenFiyatDurumu { get; set; }
        public string ÜrünYanındakiMalzemeler { get; set; }
        public DateTime ÜrünGelisTarihi { get; set; }

    }
}
