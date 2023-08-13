using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsınmaProjesiDAL.BASE
{
    public class ProductRepair: DBRecord
    {
        public ProductRepair()
        {
            this.TabloAdi = "Hareket";

        }

        public string GetirenMüşteri { get; set; }
        public string TamirEdilenÜrün { get; set; }
        public string Kategori { get; set; }
        public int Barkod { get; set; }
        public string YapılanIşlem { get; set; }
        public string OnarımBilgisi { get; set; }
        public string ÜcretDurumu { get; set; }
        public string KullanılanMalzemeler { get; set; }
        public DateTime TamirTarihi { get; set; }
        public DateTime TeslimTarihi { get; set; }
        public string VerilenGarantiSüresi { get; set; }


    }
}
