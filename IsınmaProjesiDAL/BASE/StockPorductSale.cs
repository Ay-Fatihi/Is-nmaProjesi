using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsınmaProjesiDAL.BASE
{
    public class StockPorductSale : DBRecord
    {

        public StockPorductSale()
        {
            this.TabloAdi = "ÜrünSatiş";

        }

        public string SatılanStokÜrün { get; set; }
        public string UrunMarka { get; set; }
        public string UrunModel { get; set; }
        public string SatılanMusteri { get; set; }
        public string ÜrünSeriNo { get; set; }
        public string Barkod { get; set; }
        public DateTime SatişTarihi { get; set; }
        public string SatisAdedi { get; set; }
        public string SatisFiyati { get; set; }
        public string GarantiSüresi { get; set; }
        public string GarantiDurumu { get; set; }
        
    }
}
