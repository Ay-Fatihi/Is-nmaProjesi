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
    public partial class AddNewProduct : Form
    {
        public AddNewProduct()
        {
            InitializeComponent();
        }

        private void buttonYeniMüşteriEkle_Click(object sender, EventArgs e)
        {
            SaveNewProduct();
        }
        private void SaveNewProduct()
        {
            using (var df = new DBFactory())
            {
                var p = new Products();
                p.dbFactory = new DBFactory(); 

                p.GelenÜrün = textBoxÜrünAdı.Text;
                p.GetirenMüşteri = textBox2.Text;
                p.ÜrünKategori = comboBoxKategori.SelectedItem.ToString();
                p.ÜrünMarka = textBoxÜrünMarkası.Text;
                p.ÜrünModel = textBoxÜrünModeli.Text;
                p.ÜrünSeriNo = textBoxSeriNo.Text;
                p.Barkod = textBoxBarkod.Text;
                p.ÜrünArizasi = textBoxArıza.Text;
                p.VerilenFiyat = textBoxVerilenFiyat.Text;
                p.VerilenFiyatDurumu = comboBoxFiyatDurumu.SelectedItem.ToString();
                p.ÜrünGelisTarihi = dateTimePickerGelişTarihi.Value;

                string YaMalz = "";

                if (checkBoxMause.Checked)
                {
                    YaMalz += "Mause,";
                }
                if (checkBoxFlashBellek.Checked)
                {
                    YaMalz += " Flash Bellek,";
                }
                if (checkBoxÇanta.Checked)
                {
                    YaMalz += " Çanta,";
                }
                if (checkBoxBatarya.Checked)
                {
                    YaMalz += " Batarya,";

                }
                if (checkBoxHariciDisk.Checked)
                {
                    YaMalz += " Harici Disk,";
                }
                if (checkBoxAdaptör.Checked)
                {
                    YaMalz += " Adaptör";
                }
                p.ÜrünYanındakiMalzemeler = YaMalz;

                p.Kaydet();
                

            }
        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            ChooseCustomer cc = new ChooseCustomer();
            cc.ShowDialog();

        }
    }
}
