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
    public class StockProduct_EXT : StockProduct
    {
       

        public DataTable GetStockProductInfo()
        {
            DataTable dt;
            this.dbFactory.sbSQL.Append("SELECT * FROM ÜrünStokBilg WHERE 1=1");
            return this.dbFactory.ReturnDataTable();
        }

        public DataTable StockProductSearch(string UrunAdi, string Kategori, string Marka, string Barkod)
        {
            DataTable dt;
            this.dbFactory.sbSQL.Append("SELECT * FROM ÜrünStokBilg WHERE 1=1 ");

            if (UrunAdi.Length > 0)
            {
                this.dbFactory.sbSQL.Append("and ÜrünAdı = @Ürün");
                this.dbFactory.SQLParams.Add(new SqlParameter("@Ürün", UrunAdi));
            }
            if (Kategori.Length > 0)
            {
                this.dbFactory.sbSQL.Append(" and Kategori = @Kategori");
                this.dbFactory.SQLParams.Add(new SqlParameter("@Kategori", Kategori));
            }
            if (Marka.Length > 0)
            {
                this.dbFactory.sbSQL.Append(" and ÜrünMarkası = @Marka");
                this.dbFactory.SQLParams.Add(new SqlParameter("@Marka", Marka));
            }
            if (Barkod.Length > 0 )
            {
                this.dbFactory.sbSQL.Append(" and Barkod = @Barkod");
                this.dbFactory.SQLParams.Add(new SqlParameter("@Barkod", Barkod));
            }
            return this.dbFactory.ReturnDataTable();
        }
    }
}
