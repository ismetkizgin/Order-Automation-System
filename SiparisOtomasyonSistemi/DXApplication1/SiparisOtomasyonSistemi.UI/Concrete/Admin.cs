using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace SiparisOtomasyonSistemi.UI.Concrete
{
    public class Admin
    {
        #region Property
        public int AdminId { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TcNo { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string AdminPassword { get; set; }
        #endregion

        #region Execute Error Control Message
        private void ExecuteState(int execute)
        {
            if (execute != -1)
                XtraMessageBox.Show("İşleminiz başarılı bir şekilde gerçekleşmiştir.", "İşleminiz Tamamlandı",
                    MessageBoxButtons.OK, MessageBoxIcon.None);
            else
                XtraMessageBox.Show("İşleminiz sırasında bir hata oluştu lütfen tekrar deneyiniz.", "HATA!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion

        #region Admin Table Operation
        public int AdminLogin(string userName, string password)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@UserName", SqlDbType.VarChar),
                new SqlParameter("@Password",SqlDbType.VarChar)
            };
            parameters[0].Value = userName;
            parameters[1].Value = password;
            return Convert.ToInt32(ConnectionDal.ExecuteScalar(
                "Select AdminId From Admins where UserName=@UserName and AdminPassword=@Password", parameters));
        }

        public Admin AdminGet(int adminId)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@AdminId", SqlDbType.Int)
            };
            parameters[0].Value = adminId;
            DataTable adminTable = ConnectionDal.ExecuteDataTable("Select * From Admins where AdminId=@AdminId", parameters);

            Admin costumer = new Admin()
            {
                AdminId = Convert.ToInt32(adminTable.Rows[0][0]),
                UserName = adminTable.Rows[0][1].ToString(),
                FirstName = adminTable.Rows[0][2].ToString(),
                LastName = adminTable.Rows[0][3].ToString(),
                TcNo = adminTable.Rows[0][4].ToString(),
                Phone = adminTable.Rows[0][5].ToString(),
                Email = adminTable.Rows[0][6].ToString(),
                City = adminTable.Rows[0][7].ToString(),
                District = adminTable.Rows[0][8].ToString(),
                AdminPassword = adminTable.Rows[0][9].ToString()
            };
            return costumer;
        }

        public List<Admin> GetList()
        {
            List<Admin> adminList = new List<Admin>();
            DataTable adminTable = ConnectionDal.ExecuteDataTable("Select * From Admins order by AdminId desc");
            for (int i = 0; i < adminTable.Rows.Count; i++)
            {
                Admin item = new Admin()
                {
                    AdminId = Convert.ToInt32(adminTable.Rows[i][0]),
                    UserName = adminTable.Rows[i][1].ToString(),
                    FirstName = adminTable.Rows[i][2].ToString(),
                    LastName = adminTable.Rows[i][3].ToString(),
                    TcNo = adminTable.Rows[i][4].ToString(),
                    Phone = adminTable.Rows[i][5].ToString(),
                    Email = adminTable.Rows[i][6].ToString(),
                    City = adminTable.Rows[i][7].ToString(),
                    District = adminTable.Rows[i][8].ToString(),
                    AdminPassword = adminTable.Rows[i][9].ToString()
                };
                adminList.Add(item);
            }
            return adminList;
        }

        public void Add()
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@UserName", SqlDbType.VarChar),
                new SqlParameter("@FirstName", SqlDbType.VarChar),
                new SqlParameter("@LastName",SqlDbType.VarChar),
                new SqlParameter("@TcNo",SqlDbType.Char),
                new SqlParameter("@Phone",SqlDbType.VarChar),
                new SqlParameter("@Email",SqlDbType.VarChar),
                new SqlParameter("@City",SqlDbType.VarChar),
                new SqlParameter("@District",SqlDbType.VarChar),
                new SqlParameter("@Password",SqlDbType.VarChar)
            };
            parameters[0].Value = UserName;
            parameters[1].Value = FirstName;
            parameters[2].Value = LastName;
            parameters[3].Value = TcNo;
            parameters[4].Value = Phone;
            parameters[5].Value = Email;
            parameters[6].Value = City;
            parameters[7].Value = District;
            parameters[8].Value = AdminPassword;

            int execute = ConnectionDal.ExecuteNonQuery(
                "Insert Into Admins (UserName, FirstName, LastName, TcNo, Phone, Email, City, District, AdminPassword) VALUES (@UserName, @FirstName, @LastName, @TcNo, @Phone, @Email, @City, @District, @Password)", parameters);
            ExecuteState(execute);
        }

        public void Update()
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@UserName", SqlDbType.VarChar),
                new SqlParameter("@FirstName", SqlDbType.VarChar),
                new SqlParameter("@LastName",SqlDbType.VarChar),
                new SqlParameter("@TcNo",SqlDbType.Char),
                new SqlParameter("@Phone",SqlDbType.VarChar),
                new SqlParameter("@Email",SqlDbType.VarChar),
                new SqlParameter("@City",SqlDbType.VarChar),
                new SqlParameter("@District",SqlDbType.VarChar),
                new SqlParameter("@Password",SqlDbType.VarChar),
                new SqlParameter("@AdminId", SqlDbType.Int)
            };
            parameters[0].Value = UserName;
            parameters[1].Value = FirstName;
            parameters[2].Value = LastName;
            parameters[3].Value = TcNo;
            parameters[4].Value = Phone;
            parameters[5].Value = Email;
            parameters[6].Value = City;
            parameters[7].Value = District;
            parameters[8].Value = AdminPassword;
            parameters[9].Value = Convert.ToInt32(AdminId);

            int execute = ConnectionDal.ExecuteNonQuery(
                "Update Admins Set UserName=@UserName, FirstName=@FirstName, LastName=@LastName, TcNo=@TcNo, Phone=@Phone, Email=@Email, City=@City, District=@District, AdminPassword=@Password where AdminId=@AdminId", parameters);
            ExecuteState(execute);
        }

        public void Delete(int userId)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@AdminId", SqlDbType.Int)
            };
            parameters[0].Value = userId;
            int execute = ConnectionDal.ExecuteNonQuery("Delete From Admins where AdminId=@AdminId", parameters);
            ExecuteState(execute);
        }
        #endregion
    }
}