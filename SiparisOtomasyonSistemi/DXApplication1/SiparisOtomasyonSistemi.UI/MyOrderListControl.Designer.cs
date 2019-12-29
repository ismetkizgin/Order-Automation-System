namespace SiparisOtomasyonSistemi.UI
{
    partial class MyOrderListControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TotalAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.OrderState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Address = new DevExpress.XtraGrid.Columns.GridColumn();
            this.OwnerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.OrderId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvOrderList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.OrderDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcOrderList = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cbtnRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.cbtnPaidDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.Total = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Quantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ProductId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvOrderDetailList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcOrderDetailList = new DevExpress.XtraGrid.GridControl();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrderList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcOrderList)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrderDetailList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcOrderDetailList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TotalAmount
            // 
            this.TotalAmount.Caption = "Sipariş Tutarı";
            this.TotalAmount.FieldName = "TotalAmount";
            this.TotalAmount.MinWidth = 25;
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.OptionsColumn.AllowEdit = false;
            this.TotalAmount.Visible = true;
            this.TotalAmount.VisibleIndex = 5;
            this.TotalAmount.Width = 101;
            // 
            // OrderState
            // 
            this.OrderState.Caption = "Sipariş Durumu";
            this.OrderState.FieldName = "OrderState";
            this.OrderState.MinWidth = 25;
            this.OrderState.Name = "OrderState";
            this.OrderState.OptionsColumn.AllowEdit = false;
            this.OrderState.Visible = true;
            this.OrderState.VisibleIndex = 2;
            this.OrderState.Width = 81;
            // 
            // Address
            // 
            this.Address.Caption = "Adres";
            this.Address.FieldName = "Address";
            this.Address.MinWidth = 23;
            this.Address.Name = "Address";
            this.Address.OptionsColumn.AllowEdit = false;
            this.Address.Visible = true;
            this.Address.VisibleIndex = 3;
            this.Address.Width = 74;
            // 
            // OwnerName
            // 
            this.OwnerName.Caption = "Sipariş Sahibi";
            this.OwnerName.FieldName = "OwnerName";
            this.OwnerName.MinWidth = 25;
            this.OwnerName.Name = "OwnerName";
            this.OwnerName.OptionsColumn.AllowEdit = false;
            this.OwnerName.Visible = true;
            this.OwnerName.VisibleIndex = 1;
            this.OwnerName.Width = 392;
            // 
            // OrderId
            // 
            this.OrderId.Caption = "Sipariş Kodu";
            this.OrderId.FieldName = "OrderId";
            this.OrderId.MinWidth = 23;
            this.OrderId.Name = "OrderId";
            this.OrderId.OptionsColumn.AllowEdit = false;
            this.OrderId.Visible = true;
            this.OrderId.VisibleIndex = 0;
            this.OrderId.Width = 90;
            // 
            // gvOrderList
            // 
            this.gvOrderList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.OrderId,
            this.OwnerName,
            this.Address,
            this.OrderState,
            this.OrderDate,
            this.TotalAmount});
            this.gvOrderList.DetailHeight = 431;
            this.gvOrderList.GridControl = this.gcOrderList;
            this.gvOrderList.Name = "gvOrderList";
            this.gvOrderList.OptionsCustomization.AllowColumnMoving = false;
            this.gvOrderList.OptionsFilter.AllowColumnMRUFilterList = false;
            this.gvOrderList.OptionsFind.FindFilterColumns = "";
            this.gvOrderList.OptionsMenu.EnableColumnMenu = false;
            this.gvOrderList.OptionsView.ShowAutoFilterRow = true;
            this.gvOrderList.OptionsView.ShowDetailButtons = false;
            this.gvOrderList.OptionsView.ShowGroupPanel = false;
            this.gvOrderList.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvOrderList_RowClick);
            // 
            // OrderDate
            // 
            this.OrderDate.Caption = "Sipariş Tarihi";
            this.OrderDate.FieldName = "OrderDate";
            this.OrderDate.MinWidth = 25;
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.OptionsColumn.AllowEdit = false;
            this.OrderDate.Visible = true;
            this.OrderDate.VisibleIndex = 4;
            this.OrderDate.Width = 109;
            // 
            // gcOrderList
            // 
            this.tablePanel1.SetColumn(this.gcOrderList, 0);
            this.gcOrderList.ContextMenuStrip = this.contextMenuStrip1;
            this.gcOrderList.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcOrderList.Location = new System.Drawing.Point(3, 4);
            this.gcOrderList.MainView = this.gvOrderList;
            this.gcOrderList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcOrderList.Name = "gcOrderList";
            this.tablePanel1.SetRow(this.gcOrderList, 0);
            this.gcOrderList.Size = new System.Drawing.Size(813, 498);
            this.gcOrderList.TabIndex = 7;
            this.gcOrderList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvOrderList});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cbtnRefresh,
            this.cbtnPaidDetail});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(215, 84);
            // 
            // cbtnRefresh
            // 
            this.cbtnRefresh.Image = global::SiparisOtomasyonSistemi.UI.Properties.Resources.güncelle;
            this.cbtnRefresh.Name = "cbtnRefresh";
            this.cbtnRefresh.Size = new System.Drawing.Size(214, 26);
            this.cbtnRefresh.Text = "Yenile";
            this.cbtnRefresh.Click += new System.EventHandler(this.cbtnRefresh_Click);
            // 
            // cbtnPaidDetail
            // 
            this.cbtnPaidDetail.Image = global::SiparisOtomasyonSistemi.UI.Properties.Resources.ödeme;
            this.cbtnPaidDetail.Name = "cbtnPaidDetail";
            this.cbtnPaidDetail.Size = new System.Drawing.Size(214, 26);
            this.cbtnPaidDetail.Text = "Ödeme İnceleme";
            this.cbtnPaidDetail.Click += new System.EventHandler(this.cbtnPaidDetail_Click);
            // 
            // Total
            // 
            this.Total.Caption = "Toplam Tutar";
            this.Total.FieldName = "Total";
            this.Total.MinWidth = 25;
            this.Total.Name = "Total";
            this.Total.OptionsColumn.AllowEdit = false;
            this.Total.Visible = true;
            this.Total.VisibleIndex = 4;
            this.Total.Width = 114;
            // 
            // Quantity
            // 
            this.Quantity.Caption = "Adet";
            this.Quantity.FieldName = "Quantity";
            this.Quantity.MinWidth = 25;
            this.Quantity.Name = "Quantity";
            this.Quantity.OptionsColumn.AllowEdit = false;
            this.Quantity.Visible = true;
            this.Quantity.VisibleIndex = 2;
            this.Quantity.Width = 54;
            // 
            // UnitPrice
            // 
            this.UnitPrice.Caption = "Birim Fiyatı";
            this.UnitPrice.FieldName = "Product.UnitPrice";
            this.UnitPrice.MinWidth = 23;
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.OptionsColumn.AllowEdit = false;
            this.UnitPrice.Visible = true;
            this.UnitPrice.VisibleIndex = 3;
            this.UnitPrice.Width = 77;
            // 
            // ProductName
            // 
            this.ProductName.Caption = "Ürün Adı";
            this.ProductName.FieldName = "Product.ProductName";
            this.ProductName.MinWidth = 25;
            this.ProductName.Name = "ProductName";
            this.ProductName.OptionsColumn.AllowEdit = false;
            this.ProductName.Visible = true;
            this.ProductName.VisibleIndex = 1;
            this.ProductName.Width = 502;
            // 
            // ProductId
            // 
            this.ProductId.Caption = "Ürün Kodu";
            this.ProductId.FieldName = "ProductId";
            this.ProductId.MinWidth = 23;
            this.ProductId.Name = "ProductId";
            this.ProductId.OptionsColumn.AllowEdit = false;
            this.ProductId.Visible = true;
            this.ProductId.VisibleIndex = 0;
            this.ProductId.Width = 100;
            // 
            // gvOrderDetailList
            // 
            this.gvOrderDetailList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ProductId,
            this.ProductName,
            this.UnitPrice,
            this.Quantity,
            this.Total});
            this.gvOrderDetailList.DetailHeight = 431;
            this.gvOrderDetailList.GridControl = this.gcOrderDetailList;
            this.gvOrderDetailList.Name = "gvOrderDetailList";
            this.gvOrderDetailList.OptionsCustomization.AllowColumnMoving = false;
            this.gvOrderDetailList.OptionsFilter.AllowColumnMRUFilterList = false;
            this.gvOrderDetailList.OptionsFind.FindFilterColumns = "";
            this.gvOrderDetailList.OptionsMenu.EnableColumnMenu = false;
            this.gvOrderDetailList.OptionsView.ShowAutoFilterRow = true;
            this.gvOrderDetailList.OptionsView.ShowFooter = true;
            this.gvOrderDetailList.OptionsView.ShowGroupPanel = false;
            // 
            // gcOrderDetailList
            // 
            this.tablePanel1.SetColumn(this.gcOrderDetailList, 0);
            this.gcOrderDetailList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcOrderDetailList.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcOrderDetailList.Location = new System.Drawing.Point(3, 510);
            this.gcOrderDetailList.MainView = this.gvOrderDetailList;
            this.gcOrderDetailList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcOrderDetailList.Name = "gcOrderDetailList";
            this.tablePanel1.SetRow(this.gcOrderDetailList, 1);
            this.gcOrderDetailList.Size = new System.Drawing.Size(813, 120);
            this.gcOrderDetailList.TabIndex = 8;
            this.gcOrderDetailList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvOrderDetailList});
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tablePanel1.Controls.Add(this.gcOrderDetailList);
            this.tablePanel1.Controls.Add(this.gcOrderList);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 417.2F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(819, 634);
            this.tablePanel1.TabIndex = 7;
            // 
            // MyOrderListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tablePanel1);
            this.Name = "MyOrderListControl";
            this.Size = new System.Drawing.Size(819, 634);
            ((System.ComponentModel.ISupportInitialize)(this.gvOrderList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcOrderList)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvOrderDetailList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcOrderDetailList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn TotalAmount;
        private DevExpress.XtraGrid.Columns.GridColumn OrderState;
        private DevExpress.XtraGrid.Columns.GridColumn Address;
        private DevExpress.XtraGrid.Columns.GridColumn OwnerName;
        private DevExpress.XtraGrid.Columns.GridColumn OrderId;
        private DevExpress.XtraGrid.Views.Grid.GridView gvOrderList;
        private DevExpress.XtraGrid.Columns.GridColumn OrderDate;
        public DevExpress.XtraGrid.GridControl gcOrderList;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        public DevExpress.XtraGrid.GridControl gcOrderDetailList;
        private DevExpress.XtraGrid.Views.Grid.GridView gvOrderDetailList;
        private DevExpress.XtraGrid.Columns.GridColumn ProductId;
        private new DevExpress.XtraGrid.Columns.GridColumn ProductName;
        private DevExpress.XtraGrid.Columns.GridColumn UnitPrice;
        private DevExpress.XtraGrid.Columns.GridColumn Quantity;
        private DevExpress.XtraGrid.Columns.GridColumn Total;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cbtnRefresh;
        private System.Windows.Forms.ToolStripMenuItem cbtnPaidDetail;
    }
}
