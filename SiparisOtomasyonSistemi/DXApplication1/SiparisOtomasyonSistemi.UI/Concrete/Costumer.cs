using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace SiparisOtomasyonSistemi.UI
{
    public class Costumer
    {
        #region Property
        public Costumer()
        {
            this.Orders = new List<Order>();
        }
        public int CostumerId { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TcNo { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string CostumerPassword { get; set; }
        public List<Order> Orders { get; set; }
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

        #region Costumer Table Operation
        public int CostumerLogin(string userName, string password)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@UserName", SqlDbType.VarChar),
                new SqlParameter("@Password",SqlDbType.VarChar)
            };
            parameters[0].Value = userName;
            parameters[1].Value = password;
            return Convert.ToInt32(ConnectionDal.ExecuteScalar(
                "Select CostumerId From Costumers where UserName=@UserName and CostumerPassword=@Password",
                parameters));
        }
        public Costumer CostumerGet(int costumerId)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@CostumerId", SqlDbType.Int)
            };
            parameters[0].Value = costumerId;
            DataTable costumerTable = ConnectionDal.ExecuteDataTable("Select * From Costumers where CostumerId=@CostumerId", parameters);

            Costumer costumer = new Costumer()
            {
                CostumerId = Convert.ToInt32(costumerTable.Rows[0][0]),
                UserName = costumerTable.Rows[0][1].ToString(),
                FirstName = costumerTable.Rows[0][2].ToString(),
                LastName = costumerTable.Rows[0][3].ToString(),
                TcNo = costumerTable.Rows[0][4].ToString(),
                Phone = costumerTable.Rows[0][5].ToString(),
                Email = costumerTable.Rows[0][6].ToString(),
                City = costumerTable.Rows[0][7].ToString(),
                District = costumerTable.Rows[0][8].ToString(),
                CostumerPassword = costumerTable.Rows[0][9].ToString()
            };
            return costumer;
        }
        public List<Costumer> GetList()
        {
            List<Costumer> costumerList = new List<Costumer>();
            DataTable customerTable = ConnectionDal.ExecuteDataTable("Select * From Costumers order by CostumerId desc");
            for (int i = 0; i < customerTable.Rows.Count; i++)
            {
                Costumer item = new Costumer()
                {
                    CostumerId = Convert.ToInt32(customerTable.Rows[i][0]),
                    UserName = customerTable.Rows[i][1].ToString(),
                    FirstName = customerTable.Rows[i][2].ToString(),
                    LastName = customerTable.Rows[i][3].ToString(),
                    TcNo = customerTable.Rows[i][4].ToString(),
                    Phone = customerTable.Rows[i][5].ToString(),
                    Email = customerTable.Rows[i][6].ToString(),
                    City = customerTable.Rows[i][7].ToString(),
                    District = customerTable.Rows[i][8].ToString(),
                    CostumerPassword = customerTable.Rows[i][9].ToString()
                };
                costumerList.Add(item);
            }
            return costumerList;
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
            parameters[8].Value = CostumerPassword;

            int execute = ConnectionDal.ExecuteNonQuery(
                "Insert Into Costumers (UserName, FirstName, LastName, TcNo, Phone, Email, City, District, CostumerPassword) VALUES (@UserName, @FirstName, @LastName, @TcNo, @Phone, @Email, @City, @District, @Password)", parameters);
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
                new SqlParameter("@CostumerId", SqlDbType.Int)
            };
            parameters[0].Value = UserName;
            parameters[1].Value = FirstName;
            parameters[2].Value = LastName;
            parameters[3].Value = TcNo;
            parameters[4].Value = Phone;
            parameters[5].Value = Email;
            parameters[6].Value = City;
            parameters[7].Value = District;
            parameters[8].Value = CostumerPassword;
            parameters[9].Value = CostumerId;

            int execute = ConnectionDal.ExecuteNonQuery(
                "Update Costumers Set UserName=@UserName, FirstName=@FirstName, LastName=@LastName, TcNo=@TcNo, Phone=@Phone, Email=@Email, City=@City, District=@District, CostumerPassword=@Password where CostumerId=@CostumerId", parameters);
            ExecuteState(execute);
        }
        public void Delete(int userId)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@CostumerId", SqlDbType.Int)
            };
            parameters[0].Value = userId;
            int execute = ConnectionDal.ExecuteNonQuery("Delete From Costumers where CostumerId=@CostumerId", parameters);
            ExecuteState(execute);
        }
        #endregion

        #region Order Operation 
        public void OrderAdd(Order order)
        {
            order.CostumerId = MainForm.UserId;
            
            SqlParameter[] orderParameters = new SqlParameter[]
            {
                new SqlParameter("@OrderDate",SqlDbType.Date),
                new SqlParameter("@OrderState",SqlDbType.VarChar),
                new SqlParameter("@Address",SqlDbType.VarChar),
                new SqlParameter("@OwnerName",SqlDbType.VarChar),
                new SqlParameter("@TotalAmount",SqlDbType.Decimal),
                new SqlParameter("@CostumerId",SqlDbType.Int)
            };
            orderParameters[0].Value = DateTime.Now.Date;
            orderParameters[1].Value = order.OrderState;
            orderParameters[2].Value = order.Address;
            orderParameters[3].Value = order.OwnerName;
            orderParameters[4].Value = order.TotalAmount;
            orderParameters[5].Value = order.CostumerId;

            order.OrderId = Convert.ToInt32(ConnectionDal.ExecuteScalar("Insert Into Orders (OrderDate, OrderState, Address, OwnerName, TotalAmount, CostumerId) values (@OrderDate, @OrderState, @Address, @OwnerName, @TotalAmount, @CostumerId); select @@IDENTITY", orderParameters));

            SqlParameter[] paymentParameters = new SqlParameter[]
            {
                new SqlParameter("@Total",SqlDbType.Decimal),
                new SqlParameter("@OrderId",SqlDbType.Int)
            };
            paymentParameters[0].Value = order.TotalAmount;
            paymentParameters[1].Value = order.OrderId;
            int paymentId = Convert.ToInt32(
                    ConnectionDal.ExecuteScalar("Insert Into Payment (Total, OrderId) values (@Total, @OrderId); select @@IDENTITY;",
                    paymentParameters));

            foreach (var item in order.OrderDetails)
            {
                SqlParameter[] orderDetailParameters = new SqlParameter[]
                {
                    new SqlParameter("@ProductId",SqlDbType.Int),
                    new SqlParameter("@OrderId",SqlDbType.Int),
                    new SqlParameter("@Quantity",SqlDbType.Int),
                };
                orderDetailParameters[0].Value = item.Product.ProductId;
                orderDetailParameters[1].Value = order.OrderId;
                orderDetailParameters[2].Value = item.Quantity;

                int execute = ConnectionDal.ExecuteNonQuery(
                    "Insert Into OrderDetails (ProductId, OrderId, Quantity) Values (@ProductId, @OrderId, @Quantity)",
                    orderDetailParameters);

                if (execute == -1)
                    XtraMessageBox.Show("İşlem sırasında bir hata oluştu...", "Hata !", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }


            foreach (var item in order.PaymentList.Where(x => x.PaymentMethod() == 1))
            {
                SqlParameter[] checkParameters = new SqlParameter[]
                {
                    new SqlParameter("@Bank",SqlDbType.VarChar),
                    new SqlParameter("@Branch",SqlDbType.VarChar),
                    new SqlParameter("@CheckHolder",SqlDbType.VarChar),
                    new SqlParameter("@AccountNo",SqlDbType.VarChar),
                    new SqlParameter("@Iban",SqlDbType.VarChar),
                    new SqlParameter("@CheckWhom",SqlDbType.VarChar),
                    new SqlParameter("@CheckDate",SqlDbType.Date),
                    new SqlParameter("@CheckNo",SqlDbType.VarChar),
                    new SqlParameter("@Amount",SqlDbType.Decimal),
                    new SqlParameter("@PaymentId",SqlDbType.Int)
                };
                checkParameters[0].Value = (item as Check)?.Bank;
                checkParameters[1].Value = (item as Check)?.Branch;
                checkParameters[2].Value = (item as Check)?.CheckHolder;
                checkParameters[3].Value = (item as Check)?.AccountNo;
                checkParameters[4].Value = (item as Check)?.Iban;
                checkParameters[5].Value = (item as Check)?.CheckWhom;
                checkParameters[6].Value = (item as Check)?.CheckDate;
                checkParameters[7].Value = (item as Check)?.CheckNo;
                checkParameters[8].Value = (item as Check)?.Amount;
                checkParameters[9].Value = paymentId;

                int execute = ConnectionDal.ExecuteNonQuery(
                    "Insert Into Checks (Bank, Branch, CheckHolder, AccountNo, Iban, CheckWhom, CheckDate, CheckNo, Amount, PaymentId) values (@Bank, @Branch, @CheckHolder, @AccountNo, @Iban, @CheckWhom, @CheckDate, @CheckNo, @Amount, @PaymentID)",
                    checkParameters);
                if (execute == -1)
                    XtraMessageBox.Show("İşlem sırasında bir hata oluştu...", "Hata !", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }


            foreach (var item in order.PaymentList.Where(x => x.PaymentMethod() == 0))
            {
                SqlParameter[] creditParameters = new SqlParameter[]
                {
                    new SqlParameter("@CartType",SqlDbType.VarChar),
                    new SqlParameter("@CartNo",SqlDbType.VarChar),
                    new SqlParameter("@CartMonth",SqlDbType.Int),
                    new SqlParameter("@CartYear",SqlDbType.Int),
                    new SqlParameter("@CartCVV",SqlDbType.Int),
                    new SqlParameter("@Amount",SqlDbType.Decimal),
                    new SqlParameter("@PaymentId",SqlDbType.Int)
                };
                creditParameters[0].Value = (item as Credit)?.CartType;
                creditParameters[1].Value = (item as Credit)?.CartNo;
                creditParameters[2].Value = (item as Credit)?.CartMonth;
                creditParameters[3].Value = (item as Credit)?.CartYear;
                creditParameters[4].Value = (item as Credit)?.CartCvv;
                creditParameters[5].Value = (item as Credit)?.Amount;
                creditParameters[6].Value = paymentId;

                int execute = ConnectionDal.ExecuteNonQuery(
                    "Insert Into Credit (CartType, CartNo, CartMonth, CartYear, CartCvv, Amount, PaymentId) Values (@CartType, @CartNo, @CartMonth, @CartYear, @CartCvv, @Amount, @PaymentId)",
                    creditParameters);
                if (execute == -1)
                    XtraMessageBox.Show("İşlem sırasında bir hata oluştu...", "Hata !", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }


            foreach (var item in order.PaymentList.Where(x => x.PaymentMethod() == 2))
            {
                SqlParameter[] cashParameters = new SqlParameter[]
                {
                    new SqlParameter("@Amount",SqlDbType.Decimal),
                    new SqlParameter("@PaymentId",SqlDbType.Int)
                };
                cashParameters[0].Value = (item as Cash)?.Amount;
                cashParameters[1].Value = paymentId;
                int execute =
                    ConnectionDal.ExecuteNonQuery("Insert Into Cash (Amount, PaymentId) Values (@Amount, @PaymentId)", cashParameters);
                if (execute == -1)
                    XtraMessageBox.Show("İşlem sırasında bir hata oluştu...", "Hata !", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }
        public List<Order> OrderGetAllList()
        {
            List<Order> orders = new List<Order>();
            DataTable orderTable = ConnectionDal.ExecuteDataTable("Select * From Orders order by OrderId DESC");
            for (int i = 0; i < orderTable.Rows.Count; i++)
            {
                Order item = new Order()
                {
                    OrderId = Convert.ToInt32(orderTable.Rows[i][0]),
                    OrderDate = Convert.ToDateTime(orderTable.Rows[i][1]),
                    OrderState = orderTable.Rows[i][2].ToString(),
                    Address = orderTable.Rows[i][3].ToString(),
                    OwnerName = orderTable.Rows[i][4].ToString(),
                    TotalAmount = Convert.ToDecimal(orderTable.Rows[i][5]),
                    CostumerId = Convert.ToInt32(orderTable.Rows[i][6])

                };
                item.OrderDetailGetList();
                orders.Add(item);

                SqlParameter[] cashParameter = new SqlParameter[]
                {
                    new SqlParameter("@OrderId", SqlDbType.Int)
                };
                cashParameter[0].Value = item.OrderId;
                DataTable cashTable = ConnectionDal.ExecuteDataTable("Select * From Cash C where PaymentId=(select PaymentId from Payment where OrderId=@OrderId)", cashParameter);
                for (int j = 0; j < cashTable.Rows.Count; j++)
                {
                    item.PaymentList.Add(new Cash()
                    {
                        Amount = Convert.ToInt32(cashTable.Rows[j]["Amount"])
                    });
                }

                SqlParameter[] creditParameters = new SqlParameter[]
                {
                    new SqlParameter("@OrderId", SqlDbType.Int)
                };
                creditParameters[0].Value = item.OrderId;
                DataTable creditTable = ConnectionDal.ExecuteDataTable(
                    "CreditList", creditParameters, CommandType.StoredProcedure);
                for (int j = 0; j < creditTable.Rows.Count; j++)
                {
                    item.PaymentList.Add(new Credit()
                    {
                        Amount = Convert.ToDecimal(creditTable.Rows[j][0]),
                        CartNo = creditTable.Rows[j][1].ToString(),
                        CartType = creditTable.Rows[j][2].ToString()
                    });
                }

                SqlParameter[] checkParameters = new SqlParameter[]
                {
                    new SqlParameter("@OrderId", SqlDbType.Int)
                };
                checkParameters[0].Value = item.OrderId;
                DataTable checkTable = ConnectionDal.ExecuteDataTable(
                    "Select * From Checks C where PaymentId=(select PaymentId from Payment where OrderId=@OrderId)", checkParameters);
                for (int j = 0; j < checkTable.Rows.Count; j++)
                {
                    item.PaymentList.Add(new Check()
                    {
                        Bank = checkTable.Rows[j]["Bank"].ToString(),
                        CheckWhom = checkTable.Rows[j]["CheckWhom"].ToString(),
                        CheckHolder = checkTable.Rows[j]["CheckHolder"].ToString(),
                        Amount = Convert.ToDecimal(checkTable.Rows[j]["Amount"])
                    });
                }
            }
            return orders;
        }
        public void OrderDelete(int orderId)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@OrderId",SqlDbType.Int) 
            };
            parameters[0].Value = orderId;
            int execute = ConnectionDal.ExecuteNonQuery("DeleteOrder", parameters, CommandType.StoredProcedure);
            ExecuteState(execute);
        }
        public void OrderStateUpdate(int id, string state)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@OrderId",SqlDbType.Int),
                new SqlParameter("@OrderState",SqlDbType.VarChar) 
            };
            parameters[0].Value = id;
            parameters[1].Value = state;

            int execute = ConnectionDal.ExecuteNonQuery("Update Orders Set OrderState=@OrderState where OrderId=@OrderId",parameters);
            ExecuteState(execute);
        }
        #endregion
    }
}