using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsınmaProjesiDAL.BASE
{
    public class Tools
    {
        public enum UserControl
        {
            Gecerli = 1,
            UserNameHatali = 2,
            PasswordHatali = 3,
            Gecersiz = 4
            
        }
    }
}
