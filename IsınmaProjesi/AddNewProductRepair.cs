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
    public partial class AddNewProductRepair : Form
    {
        public AddNewProductRepair()
        {
            InitializeComponent();
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            SavwNewProductRepair();
        }

        private void SavwNewProductRepair()
        {
            using (var df = new DBFactory())
            {
                var pr = new ProductRepair_EXT();
                pr.dbFactory = df;

                pr.GetirenMüşteri = txtbxMusAdi.Text;
                pr.TamirEdilenÜrün = txtboxGetUrun.Text;
                pr.Kategori = "";
                pr.Barkod = 0;
                pr.YapılanIşlem = textBoxYapılanİslem.Text;
                pr.OnarımBilgisi = comboBox1.Text;
                pr.KullanılanMalzemeler = textBoxKullMal.Text;
                pr.TeslimTarihi = dateTimePicker1.Value;
                pr.VerilenGarantiSüresi = textBoxGarantiSüresi.Text;

                string ud = ""; //ücret durumu
                if (checkBox1.Checked)
                {
                    ud = "Tahsil Edildi";
                }
                else
                {
                    ud = "Tahsil Edilmedi";
                }
                pr.ÜcretDurumu = ud;
                pr.TamirTarihi = dateTimePickerRepairTime.Value;

                pr.Kaydet();

                this.Close();
            }
        }

        private void buttonÜrünSeç_Click(object sender, EventArgs e)
        {
            ChooseProducts cp = new ChooseProducts();
            cp.ShowDialog();

        }
    }
}
