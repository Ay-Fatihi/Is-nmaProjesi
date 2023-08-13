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
    public class StockProductSale_EXT : StockPorductSale
    {
        

        public DataTable GetSAleStockInfo()
        {
            DataTable dt;
            this.dbFactory.sbSQL.Append("SELECT * FROM ÜrünSatiş WHERE 1=1 ");
            return this.dbFactory.ReturnDataTable();
        }
    }
}
