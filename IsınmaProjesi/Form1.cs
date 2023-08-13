using DataAccessLayer;
using IsınmaProjesiDAL.BASE;
using IsınmaProjesiDAL.EXT;
using System.Net.Http.Headers;

namespace IsınmaProjesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxUserName.Text))
            {
                MessageBox.Show("Lütfen Kullanıcı Adınızı Yazınız !");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtBoxUserPassword.Text))
            {
                MessageBox.Show("Lütfen Şifrenizi Yazınız !");
                return;
            }


            using (UserProcress_EXT user = new UserProcress_EXT())
            {
                user.dbFactory = new DBFactory();

                Tools.UserControl userControlResult = user.Login(txtBoxUserName.Text, Convert.ToInt32(txtBoxUserPassword.Text));

                if (userControlResult == Tools.UserControl.Gecerli)
                {
                    TeknikServisHomePage anasayfa = new TeknikServisHomePage();
                    this.Hide();
                    anasayfa.ShowDialog();

                }
                else if (userControlResult == Tools.UserControl.PasswordHatali)
                {
                    // Parola hatalıysa yapılacak işlemler
                    MessageBox.Show("Şifre Hatalı. Lütfen Tekrar Deneyiniz");
                }
                else if (userControlResult == Tools.UserControl.UserNameHatali)
                {
                    // Kullanıcı adı hatalıysa yapılacak işlemler
                }
            }


            using (var df = new DBFactory())
            {
                var user = new UserProcress_EXT();
                user.dbFactory = df;

                Tools.UserControl userControlResult = user.Login(txtBoxUserName.Text, Convert.ToInt32(txtBoxUserPassword.Text));
                
                if (userControlResult == Tools.UserControl.Gecerli)
                {
                    TeknikServisHomePage anasayfa = new TeknikServisHomePage();
                    this.Hide();
                    anasayfa.ShowDialog();

                }
                else if (userControlResult == Tools.UserControl.PasswordHatali)
                {
                    // Parola hatalıysa yapılacak işlemler
                    MessageBox.Show("Şifre Hatalı. Lütfen Tekrar Deneyiniz");
                }
                else if (userControlResult == Tools.UserControl.UserNameHatali)
                {
                    // Kullanıcı adı hatalıysa yapılacak işlemler
                }
            }

        }
    }
}