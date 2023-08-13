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
    public partial class TeknikServisHomePage : Form
    {
        public TeknikServisHomePage()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddNewCustomer customer = new AddNewCustomer();

            //Yeni Müşteri Ekle Butonu...

            customer.ShowDialog();

        }

        private void buttonYeniMüşteriEkle_Click(object sender, EventArgs e)
        {
            AddNewProduct nProduct = new AddNewProduct();
            nProduct.ShowDialog();
        }

        private void btnStockProductAdd_Click(object sender, EventArgs e)
        {
            AddNewStockProduct stock = new AddNewStockProduct();
            stock.ShowDialog();
        }

        private void btnNewProductRepair_Click(object sender, EventArgs e)
        {
            AddNewProductRepair pr = new AddNewProductRepair();
            pr.ShowDialog();

        }

        private void btnNewStockSale_Click(object sender, EventArgs e)
        {
            AddNewStockProductSalecs a = new AddNewStockProductSalecs();
            a.ShowDialog();

        }

        private void TeknikServisHomePage_Load(object sender, EventArgs e)
        {

            Customers_EXT c = new Customers_EXT();

            c.dbFactory = new DBFactory();

            dataGridViewMusteri.DataSource = c.GetCustomerInfo();

            ProductRepair_EXT pr = new ProductRepair_EXT();
            pr.dbFactory = new DBFactory();

            dataGridViewHareket.DataSource = pr.GetHareketInfo();

            Products_EXT p = new Products_EXT();
            p.dbFactory = new DBFactory();

            dataGridView1.DataSource = p.GetProductInfo();

            StockProductSale_EXT sp = new StockProductSale_EXT();
            sp.dbFactory = new DBFactory();

            dataGridView3.DataSource = sp.GetSAleStockInfo();

            StockProduct_EXT s = new StockProduct_EXT();
            s.dbFactory = new DBFactory();

            dataGridView2.DataSource = s.GetStockProductInfo();

        }

        private void btnStockProductSearch_Click(object sender, EventArgs e)
        {
            StockProduct_EXT stp = new StockProduct_EXT();
            stp.dbFactory = new DBFactory();

            dataGridView2.DataSource = stp.StockProductSearch(textBoxUAdı.Text, comboBox1.Text, textBoxUMarka.Text, textBoxUBarkod.Text);
        }

        private void btnHareketAra_Click(object sender, EventArgs e)
        {
            ProductRepair_EXT prr = new ProductRepair_EXT();
            prr.dbFactory = new DBFactory();

            dataGridViewHareket.DataSource = prr.ProductRepairSearch(textBoxGMusteri.Text, textBoxTEUrun.Text, textBoxUrunBarkod.Text);
        }

        private void buttonMAra_Click(object sender, EventArgs e)
        {
            Customers_EXT prr = new Customers_EXT();
            prr.dbFactory = new DBFactory();

            dataGridViewMusteri.DataSource = prr.CustomerSearch(textBoxMuAdi.Text);
        }
    }
}
