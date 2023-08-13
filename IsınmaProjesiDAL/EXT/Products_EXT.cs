using IsınmaProjesiDAL.BASE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace IsınmaProjesiDAL.EXT
{
    public class Products_EXT : Products
    {
        
        public DataTable ProductSearch(string MusteriAdi, string ÜrünAdi)
        {
            
            DataTable dt;
            this.dbFactory.sbSQL.Append("SELECT * FROM GelenÜrünBilg where 1=1");

            if (MusteriAdi.Length > 0)
            {
                this.dbFactory.sbSQL.Append(" and GetirenMüşteri = @Müşteri");
                this.dbFactory.SQLParams.Add(new SqlParameter("Müşteri", MusteriAdi));
            }
            if (ÜrünAdi.Length > 0)
            {
                this.dbFactory.sbSQL.Append(" and GelenÜrün = @Ürün");
                this.dbFactory.SQLParams.Add(new SqlParameter("Ürün", ÜrünAdi));
            }

            return this.dbFactory.ReturnDataTable();
        }

        public DataTable ProductChoose()
        { //Ürün Seç  sayfasına verileri gönderiyor
            DataTable dt;
            this.dbFactory.sbSQL.Append("SELECT * FROM GelenÜrünBilg WHERE 1=1 ");
            return this.dbFactory.ReturnDataTable();
        }
        public DataTable GetProductInfo()
        { //Anasayfa Yüklenirken GelenÜrünBilg tablosuna verileri getiriyor.
            DataTable dt;
            this.dbFactory.sbSQL.Append("SELECT * FROM GelenÜrünBilg WHERE 1=1 ");
            return this.dbFactory.ReturnDataTable();
        }
    }
}
