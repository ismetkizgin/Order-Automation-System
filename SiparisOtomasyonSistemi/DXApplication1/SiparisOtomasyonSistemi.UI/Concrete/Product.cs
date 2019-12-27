using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace SiparisOtomasyonSistemi.UI.Concrete
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }

        private void ExecuteState(int execute)
        {
            if (execute != -1)
                XtraMessageBox.Show("İşleminiz başarılı bir şekilde gerçekleşmiştir.", "İşleminiz Tamamlandı",
                    MessageBoxButtons.OK, MessageBoxIcon.None);
            else
                XtraMessageBox.Show("İşleminiz sırasında bir hata oluştu lütfen tekrar deneyiniz.", "HATA!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public List<Product> GetList()
        {
            List<Product> productsList = new List<Product>();
            DataTable tableProduct = ConnectionDal.ExecuteDataTable("Select * From Products order by ProductName ASC");
            for (int i = 0; i < tableProduct.Rows.Count; i++)
            {
                Product item = new Product()
                {
                    ProductId = Convert.ToInt32(tableProduct.Rows[i][0]),
                    ProductName = tableProduct.Rows[i][1].ToString(),
                    UnitPrice = Convert.ToDecimal(tableProduct.Rows[i][2])
                };
                productsList.Add(item);
            }
            return productsList;
        }

        public void Add()
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@ProductName",SqlDbType.VarChar),
                new SqlParameter("@UnitPrice",SqlDbType.Decimal)
            };

            parameters[0].Value = ProductName;
            parameters[1].Value = UnitPrice;

            int execute = ConnectionDal.ExecuteNonQuery(
                "Insert Into Products (ProductName, UnitPrice) Values (@ProductName, @UnitPrice)", parameters);
            ExecuteState(execute);
        }

        public void Update()
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@ProductName",SqlDbType.VarChar),
                new SqlParameter("@UnitPrice",SqlDbType.Decimal),
                new SqlParameter("@ProductId",SqlDbType.Int)
            };

            parameters[0].Value = ProductName;
            parameters[1].Value = UnitPrice;
            parameters[2].Value = ProductId;

            int execute = ConnectionDal.ExecuteNonQuery(
                "Update Products Set ProductName=@ProductName, UnitPrice=@UnitPrice where ProductId=@ProductId", parameters);
            ExecuteState(execute);
        }

        public void Delete(int productId)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@ProductId",SqlDbType.Int)
            };
            parameters[0].Value = productId;

            int execute = ConnectionDal.ExecuteNonQuery("Delete From Products where ProductId=@ProductId", parameters);
            ExecuteState(execute);
        }
    }
}