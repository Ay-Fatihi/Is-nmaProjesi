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
    public class Customers_EXT : Customers
    {
        
        

        public DataTable GetCustomerInfo()
        {
            DataTable dt;
            this.dbFactory.sbSQL.Append("SELECT * FROM MusteriBilg WHERE 1=1 ");
            return this.dbFactory.ReturnDataTable();
        }

        public DataTable CustomerSearch(string MusteriAdi)
        {
            DataTable dt;
            this.dbFactory.sbSQL.Append("SELECT * FROM MusteriBilg WHERE 1=1 ");

            if (MusteriAdi.Length > 0)
            {
                this.dbFactory.sbSQL.Append(" and MusteriAdiSoyadi = @Musteri");
                this.dbFactory.SQLParams.Add(new SqlParameter("@Musteri", MusteriAdi));
            }
            return this.dbFactory.ReturnDataTable();
        }
    }
}
