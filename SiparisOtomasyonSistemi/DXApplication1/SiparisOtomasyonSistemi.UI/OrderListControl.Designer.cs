namespace SiparisOtomasyonSistemi.UI
{
    partial class OrderListControl
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cbtnRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.cbtnPaidDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.cbtnDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.gcOrderDetailList = new DevExpress.XtraGrid.GridControl();
            this.gvOrderDetailList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ProductId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Quantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Total = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcOrderList = new DevExpress.XtraGrid.GridControl();
            this.gvOrderList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.OrderId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.OwnerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Address = new DevExpress.XtraGrid.Columns.GridColumn();
            this.OrderState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.OrderDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TotalAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.siparişDurumuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cST = new System.Windows.Forms.ToolStripMenuItem();
            this.cK = new System.Windows.Forms.ToolStripMenuItem();
            this.cHA = new System.Windows.Forms.ToolStripMenuItem();
            this.cOB = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcOrderDetailList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrderDetailList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcOrderList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrderList)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cbtnRefresh,
            this.cbtnPaidDetail,
            this.cbtnDelete,
            this.siparişDurumuToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(215, 136);
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
            // cbtnDelete
            // 
            this.cbtnDelete.Image = global::SiparisOtomasyonSistemi.UI.Properties.Resources.Olumsuz;
            this.cbtnDelete.Name = "cbtnDelete";
            this.cbtnDelete.Size = new System.Drawing.Size(214, 26);
            this.cbtnDelete.Text = "Sil";
            this.cbtnDelete.Click += new System.EventHandler(this.cbtnDelete_Click);
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
            this.tablePanel1.Size = new System.Drawing.Size(876, 691);
            this.tablePanel1.TabIndex = 6;
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
            this.gcOrderDetailList.Size = new System.Drawing.Size(870, 177);
            this.gcOrderDetailList.TabIndex = 8;
            this.gcOrderDetailList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvOrderDetailList});
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
            this.gcOrderList.Size = new System.Drawing.Size(870, 498);
            this.gcOrderList.TabIndex = 7;
            this.gcOrderList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvOrderList});
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
            // siparişDurumuToolStripMenuItem
            // 
            this.siparişDurumuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cST,
            this.cK,
            this.cHA,
            this.cOB});
            this.siparişDurumuToolStripMenuItem.Name = "siparişDurumuToolStripMenuItem";
            this.siparişDurumuToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.siparişDurumuToolStripMenuItem.Text = "Sipariş Durumu";
            // 
            // cST
            // 
            this.cST.Name = "cST";
            this.cST.Size = new System.Drawing.Size(226, 26);
            this.cST.Text = "Sipariş Tamamlandı";
            this.cST.Click += new System.EventHandler(this.cST_Click);
            // 
            // cK
            // 
            this.cK.Name = "cK";
            this.cK.Size = new System.Drawing.Size(226, 26);
            this.cK.Text = "Kargo da";
            this.cK.Click += new System.EventHandler(this.cK_Click);
            // 
            // cHA
            // 
            this.cHA.Name = "cHA";
            this.cHA.Size = new System.Drawing.Size(226, 26);
            this.cHA.Text = "Hazırlık Aşamasında";
            this.cHA.Click += new System.EventHandler(this.cHA_Click);
            // 
            // cOB
            // 
            this.cOB.Name = "cOB";
            this.cOB.Size = new System.Drawing.Size(226, 26);
            this.cOB.Text = "Onay Bekliyor";
            this.cOB.Click += new System.EventHandler(this.cOB_Click);
            // 
            // OrderListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tablePanel1);
            this.Name = "OrderListControl";
            this.Size = new System.Drawing.Size(876, 691);
            this.Load += new System.EventHandler(this.OrderListControl_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcOrderDetailList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrderDetailList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcOrderList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrderList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cbtnRefresh;
        private System.Windows.Forms.ToolStripMenuItem cbtnDelete;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private System.Windows.Forms.ToolStripMenuItem cbtnPaidDetail;
        public DevExpress.XtraGrid.GridControl gcOrderList;
        private DevExpress.XtraGrid.Views.Grid.GridView gvOrderList;
        private DevExpress.XtraGrid.Columns.GridColumn OrderId;
        private DevExpress.XtraGrid.Columns.GridColumn OwnerName;
        private DevExpress.XtraGrid.Columns.GridColumn Address;
        private DevExpress.XtraGrid.Columns.GridColumn OrderState;
        private DevExpress.XtraGrid.Columns.GridColumn OrderDate;
        public DevExpress.XtraGrid.GridControl gcOrderDetailList;
        private DevExpress.XtraGrid.Views.Grid.GridView gvOrderDetailList;
        private DevExpress.XtraGrid.Columns.GridColumn ProductId;
        private new DevExpress.XtraGrid.Columns.GridColumn ProductName;
        private DevExpress.XtraGrid.Columns.GridColumn UnitPrice;
        private DevExpress.XtraGrid.Columns.GridColumn Quantity;
        private DevExpress.XtraGrid.Columns.GridColumn Total;
        private DevExpress.XtraGrid.Columns.GridColumn TotalAmount;
        private System.Windows.Forms.ToolStripMenuItem siparişDurumuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cST;
        private System.Windows.Forms.ToolStripMenuItem cK;
        private System.Windows.Forms.ToolStripMenuItem cHA;
        private System.Windows.Forms.ToolStripMenuItem cOB;
    }
}
