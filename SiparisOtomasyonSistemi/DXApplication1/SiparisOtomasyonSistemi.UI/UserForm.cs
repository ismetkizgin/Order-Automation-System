using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SiparisOtomasyonSistemi.UI.Concrete;

namespace SiparisOtomasyonSistemi.UI
{
    public partial class UserForm : XtraForm
    {
        private Admin _admin = new Admin();
        private Costumer _costumer = new Costumer();
        private readonly int _userId;
        private readonly bool _state;
        private readonly bool _status = true;

        public UserForm(bool state)
        {
            _state = state;
            InitializeComponent();
        }

        public UserForm(int userId, bool state)
        {
            _userId = userId;
            _status = false;
            _state = state;
            InitializeComponent();
        }

        private Costumer CostumerTextGet()
        {
            return new Costumer()
            {
                CostumerId = _userId,
                UserName = txtUserName.Text,
                TcNo = txtTC.Text,
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Phone = txtPhone.Text,
                City = txtCity.Text,
                District = txtDistrict.Text,
                Email = txtMail.Text,
                CostumerPassword = txtPassword.Text
            };
        }

        private Admin AdminTextGet()
        {
            return new Admin()
            {
                AdminId = _userId,
                UserName = txtUserName.Text,
                TcNo = txtTC.Text,
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Phone = txtPhone.Text,
                City = txtCity.Text,
                District = txtDistrict.Text,
                Email = txtMail.Text,
                AdminPassword = txtPassword.Text
            };
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            if (_status)
            {
                btnKullaniciSil.Visible = false;
                this.Text = _state ? @"Admin Ekleme" : @"Müşteri Kayıt";
            }
            else
            {
                if (_state)
                {
                    this.Text = @"Admin Bilgi Güncelleme";
                    Admin admin = _admin.AdminGet(_userId);
                    txtTC.Text = admin.TcNo;
                    txtFirstName.Text = admin.FirstName;
                    txtLastName.Text = admin.LastName;
                    txtPhone.Text = admin.Phone;
                    txtCity.Text = admin.City;
                    txtDistrict.Text = admin.District;
                    txtMail.Text = admin.Email;
                    txtUserName.Text = admin.UserName;
                    txtPassword.Text = admin.AdminPassword;
                }
                else
                {
                    this.Text = @"Müşteri Bilgi Güncelleme";
                    Costumer costumer = _costumer.CostumerGet(_userId);
                    txtTC.Text = costumer.TcNo;
                    txtFirstName.Text = costumer.FirstName;
                    txtLastName.Text = costumer.LastName;
                    txtPhone.Text = costumer.Phone;
                    txtCity.Text = costumer.City;
                    txtDistrict.Text = costumer.District;
                    txtMail.Text = costumer.Email;
                    txtUserName.Text = costumer.UserName;
                    txtPassword.Text = costumer.CostumerPassword;
                }
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (_status)
            {
                if (_state)
                {
                    _admin = AdminTextGet();
                    _admin.Add();
                }
                else
                {
                    _costumer = CostumerTextGet();
                    _costumer.Add();
                }
                this.Close();
            }
            else
            {
                if (_state)
                {
                    _admin = AdminTextGet();
                    _admin.Update();
                }
                else
                {
                    _costumer = CostumerTextGet();
                    _costumer.Update();
                }
            }
        }

        private void btnCik_Click(object sender, EventArgs e) => this.Close();

        private void btnKullaniciSil_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Silmek istediğinizden emin misiniz...", "Silme İşlemi",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (_state)
                    _admin.Delete(_userId);
                else
                    _costumer.Delete(_userId);
                if (_userId == AdminForm.UserId)
                    Application.Restart();
                this.Close();
            }
        }
    }
}