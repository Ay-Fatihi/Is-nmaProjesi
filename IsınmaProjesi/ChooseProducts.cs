using DataAccessLayer;
using IsınmaProjesiDAL.EXT;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class ChooseProducts : Form
    {
        public ChooseProducts()
        {
            InitializeComponent();
        }

        private void ChooseProducts_Load(object sender, EventArgs e)
        {

            Products_EXT p = new Products_EXT();
            p.dbFactory = new DBFactory();

            gridProductChoose.DataSource = p.ProductChoose();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Products_EXT p = new Products_EXT();

            p.dbFactory = new DBFactory();
            gridProductChoose.DataSource = p.ProductSearch(textBoxMA.Text, textBoxGUrun.Text);
        }
    }
}
