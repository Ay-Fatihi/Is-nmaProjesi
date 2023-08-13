using DataAccessLayer;
using IsınmaProjesiDAL.BASE;
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
    public partial class AddNewStockProductSalecs : Form
    {
        public AddNewStockProductSalecs()
        {
            InitializeComponent();
        }

        private void btnProductSale_Click(object sender, EventArgs e)
        {
            sale();
        }

        private void sale()
        {

            using (var df = new DBFactory())
            {
                var s = new StockProductSale_EXT();
                s.dbFactory = df;

                s.SatılanStokÜrün = textBoxSatılanÜrünAdı.Text;
                s.UrunMarka = "";
                s.UrunModel = "";
                s.SatılanMusteri = textBoxSAMusteri.Text;
                s.ÜrünSeriNo = textBoxSeriNo.Text;
                s.Barkod = textBoxBarkod.Text;
                s.SatişTarihi = dateTimePicker1.Value;
                s.SatisFiyati = textBoxSatışFiyatı.Text;
                s.SatisAdedi = textBoxSAdedi.Text;
                s.GarantiSüresi = textBoxGarantiSüresi.Text;
                s.GarantiDurumu = textBoxGarantiDurumu.Text;


                s.Kaydet();

                this.Close();
            }

        }
    }
}
