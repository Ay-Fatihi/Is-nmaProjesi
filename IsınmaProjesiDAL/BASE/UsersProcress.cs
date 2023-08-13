using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace IsınmaProjesiDAL.BASE
{
    public class UsersProcress : DBRecord
    {
        public UsersProcress() 
        {
            this.TabloAdi = "GirisBilgileri";

        }

        public string KullaniciAdi { get; set; }
        public int GirisSifre { get; set; }
    }
}
