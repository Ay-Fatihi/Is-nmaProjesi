using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsınmaProjesiDAL.BASE
{
    public class Customers : DBRecord
    {

        public Customers() 
        {
            this.TabloAdi = "MusteriBilg";
            this.ID_AlanAdi = "MusteriId";
        }

        public string MusteriAdiSoyadi { get; set; }
        public string FirmaAdi { get; set; }
        public string MusteriTelNo { get; set; }
        public string CepTelefonuNumarasi { get; set; }
        public string IsTelefonu { get; set; }
        public string MusteriMailAdresi { get; set; }
        public string MusteriAdresi { get; set; }
        public string MusteriTipi { get; set; }

    }
}
