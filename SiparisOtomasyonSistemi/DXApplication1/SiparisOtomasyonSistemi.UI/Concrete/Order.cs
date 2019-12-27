using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using SiparisOtomasyonSistemi.UI.Concrete;

namespace SiparisOtomasyonSistemi.UI
{
    public class Order
    {
        #region Property
        public Order()
        {
            this.OrderState = "Onay Bekliyor.";
            this.OrderDetails = new List<OrderDetail>();
            this.PaymentList = new List<Payment>();
        }

        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderState { get; set; }
        public string Address { get; set; }
        public string OwnerName { get; set; }
        public decimal TotalAmount { get; set; }
        public int CostumerId { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
        public List<Payment> PaymentList = new List<Payment>();

        #endregion

        #region OrderDetail Operation
        public void OrderDetailGetList()
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@OrderId", SqlDbType.Int)
            };
            parameters[0].Value = OrderId;
            DataTable orderDetailTable =
                ConnectionDal.ExecuteDataTable(
                    "Select * From OrderDetails O inner join Products P on O.ProductId = P.ProductId and OrderId=@OrderId",
                    parameters);
            for (int i = 0; i < orderDetailTable.Rows.Count; i++)
            {
                Product productItem = new Product()
                {
                    ProductId = Convert.ToInt32(orderDetailTable.Rows[i][4]),
                    ProductName = orderDetailTable.Rows[i][5].ToString(),
                    UnitPrice = Convert.ToDecimal(orderDetailTable.Rows[i][6])
                };
                OrderDetail orderDetailItem = new OrderDetail()
                {
                    OrderDetailId = Convert.ToInt32(orderDetailTable.Rows[i][0]),
                    Quantity = Convert.ToInt32(orderDetailTable.Rows[i][1]),
                    ProductId = Convert.ToInt32(orderDetailTable.Rows[i][2]),
                    OrderId = Convert.ToInt32(orderDetailTable.Rows[i][3]),
                    Product = productItem
                };
                OrderDetails.Add(orderDetailItem);
            }
        }
        public void TotalAmountOperation()
        {
            decimal total = 0;
            foreach (var item in OrderDetails)
                total += item.Total;
            this.TotalAmount = total;
        }
        #endregion

        #region Product Operation
        public List<Product> ProductGetAllList()
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
        #endregion
    }
}