using DevExpress.XtraEditors;
using SiparisOtomasyonSistemi.UI.Concrete;
using System;
using System.Windows.Forms;

namespace SiparisOtomasyonSistemi.UI
{
    public partial class LoginForm : XtraForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void lblExit_Click(object sender, EventArgs e) =>
            Application.Exit();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int id;
            bool state;
            if (rbtnMusteri.Checked)
            {
                Costumer costumerManager = new Costumer();
                id = costumerManager.CostumerLogin(txtUserName.Text, txtPassword.Text);
                state = false;
            }
            else
            {
                Admin adminManager = new Admin();
                id = adminManager.AdminLogin(txtUserName.Text, txtPassword.Text);
                state = true;
            }


            if (id != 0)
            {
                AdminForm adminForm = new AdminForm(id, state);
                adminForm.Show();
                this.Hide();
            }
            else
                XtraMessageBox.Show("Kullanıcı adını ve şifrenizi doğru girdiğinizden emin olunuz !", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnSingUp_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm(false);
            userForm.ShowDialog();
        }
    }
}