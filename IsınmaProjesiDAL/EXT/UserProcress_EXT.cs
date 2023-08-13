using DataAccessLayer;
using IsınmaProjesiDAL.BASE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static IsınmaProjesiDAL.BASE.Tools;

namespace IsınmaProjesiDAL.EXT
{
    public class UserProcress_EXT : UsersProcress
    {

        public Tools.UserControl Login(string kullaniciAdi, int Password)
        {
            //DBFactory dbFactory = new DBFactory();

            DataTable dt;
            object retval;

            this.dbFactory.sbSQL.Append("select * from dbo.GirisBilgileri where KullaniciAdi=@sUserName");

            this.dbFactory.SQLParams.Add(new SqlParameter("sUserName", kullaniciAdi));

            dt = this.dbFactory.ReturnDataTable();

            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["KullaniciAdi"].ToString() == kullaniciAdi.ToString())
                {
                    if (dt.Rows[0]["GirisSifre"].ToString() == Password.ToString())
                    {

                        return UserControl.Gecerli;
                    }
                    else
                    {
                        return UserControl.PasswordHatali;
                    }
                }
                else
                {
                    return UserControl.UserNameHatali;
                }
            }
            else
            {
                return UserControl.Gecersiz;
            }
            
        }
    }
}
