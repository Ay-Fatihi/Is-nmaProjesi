using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsınmaProjesiDAL.BASE
{
    public class StockProduct : DBRecord
    {
        public StockProduct()
        {
            this.TabloAdi = "ÜrünStokBilg";

        }

        public int ÜrünStokId { get; set; }
        public string ÜrünAdı { get; set; }
        public string Kategori { get; set; }
        public string ÜrünMarka { get; set; }
        public string ÜrünModel { get; set; }
        public string ÜrünKodu { get; set; }
        public string SeriNo { get; set; }
        public string Barkod { get; set; }
        public string ÜrününSatınAlındığıFirma { get; set; }
        public string ÜrünGelişFiyati { get; set; }
        public string ÜrünSatişFiyati { get; set; }
        public int ÜrünAdedi { get; set; }
        public string GarantiSüresi { get; set; }


    }
}
