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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IsınmaProjesi
{
    public partial class AddNewStockProduct : Form
    {
        public AddNewStockProduct()
        {
            InitializeComponent();
        }

        private void btnSaveStockProduct_Click(object sender, EventArgs e)
        {
            saveStockProduct();

        }

        private void saveStockProduct()
        {
            using (var df = new DBFactory())
            {
                var s = new StockProduct_EXT();
                s.dbFactory = df;

                s.ÜrünAdı = textBoxÜrünAdı.Text;
                s.Kategori = comboBoxKategori.Text;
                s.ÜrünMarka = textBoxÜrünMarkası.Text;
                s.ÜrünModel = textBoxÜrünModeli.Text;
                s.ÜrünKodu = textBoxÜrünKodu.Text;
                s.SeriNo = textBoxÜrünSeriNo.Text;
                s.Barkod = textBoxBarkod.Text;
                s.ÜrününSatınAlındığıFirma = textBoxSatınAlınanFirma.Text;
                s.ÜrünGelişFiyati = textBoxGelişFiyati.Text;
                s.ÜrünSatişFiyati = textBoxSatışFiyatı.Text;
                s.ÜrünAdedi = Convert.ToInt16(textBoxÜrünAdedi.Text);
                s.GarantiSüresi = textBoxGarantiSüresi.Text;


                s.Kaydet();

                this.Close();
            }
        }
    }
}
