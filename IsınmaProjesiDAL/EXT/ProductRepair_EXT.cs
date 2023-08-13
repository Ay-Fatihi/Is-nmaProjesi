using IsınmaProjesiDAL.BASE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsınmaProjesiDAL.EXT
{
    public class ProductRepair_EXT : ProductRepair
    {
        

        public DataTable GetHareketInfo()
        {
            DataTable dt;
            this.dbFactory.sbSQL.Append("SELECT * FROM Hareket WHERE 1=1 ");
            return this.dbFactory.ReturnDataTable();
        }

        public DataTable ProductRepairSearch(string GetirenMusteri, string TamirEdilenUrun, string Barkod)
        {
            DataTable dt;
            this.dbFactory.sbSQL.Append("SELECT * FROM Hareket WHERE 1=1 ");

            if (GetirenMusteri.Length > 0)
            {
                this.dbFactory.sbSQL.Append(" and GetirenMüşteri = @Musteri");
                this.dbFactory.SQLParams.Add(new SqlParameter("@Musteri", GetirenMusteri));
            }
            if (TamirEdilenUrun.Length > 0)
            {
                this.dbFactory.sbSQL.Append(" and TamirEdilenÜrün = @Ürün");
                this.dbFactory.SQLParams.Add(new SqlParameter("@Ürün", TamirEdilenUrun));
            }
            if (Barkod.Length > 0)
            {
                this.dbFactory.sbSQL.Append(" and Barkod = @Barkod");
                this.dbFactory.SQLParams.Add(new SqlParameter("@Barkod", Barkod));
            }

            return this.dbFactory.ReturnDataTable();
        }
    }
}
