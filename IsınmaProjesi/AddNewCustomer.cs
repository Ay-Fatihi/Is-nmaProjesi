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
    public partial class AddNewCustomer : Form
    {
        public AddNewCustomer()
        {
            InitializeComponent();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SaveCustomer();
        }

        private void SaveCustomer()
        {
            using (var df = new DBFactory())
            {
                var c = new Customers();
                c.dbFactory = df;

                c.MusteriAdiSoyadi = textMusteriAdi.Text;
                c.FirmaAdi = txtFirmaAdi.Text;
                c.MusteriTelNo = textTelNo.Text;
                c.CepTelefonuNumarasi = textBoxCepTelNo.Text;
                c.IsTelefonu = txtİsTelNo.Text;
                c.MusteriAdresi = textAdresi.Text;
                c.MusteriMailAdresi = textMailAdresi.Text;
                c.MusteriTipi = comboBoxMüşteriTipi.Text;
                
                c.Kaydet();

                this.Close();
            }
        }
    }
}
