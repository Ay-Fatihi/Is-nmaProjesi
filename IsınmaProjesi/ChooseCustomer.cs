using DataAccessLayer;
using IsınmaProjesiDAL.EXT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsınmaProjesi
{
    public partial class ChooseCustomer : Form
    {
        public ChooseCustomer()
        {
            InitializeComponent();
        }

        private void ChooseCustomer_Load(object sender, EventArgs e)
        {
            gridLoad();
        }
        private void gridLoad()
        {
            using (var df = new DBFactory())
            {
                var c = new Customers_EXT();
                c.dbFactory = df;

                GridCustomers.DataSource = c.GetCustomerInfo();
            }
        }
    }
}
