namespace SiparisOtomasyonSistemi.UI
{
    partial class OrderAddControl
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
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.gcBasketList = new DevExpress.XtraGrid.GridControl();
            this.cmBasket = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cbtnComplateOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.cbtnRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.cbtnDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.gvBasketList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Quantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Total = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcProductList = new DevExpress.XtraGrid.GridControl();
            this.gvProductList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ProductId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcBasketList)).BeginInit();
            this.cmBasket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvBasketList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcProductList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProductList)).BeginInit();
            this.SuspendLayout();
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tablePanel1.Controls.Add(this.gcBasketList);
            this.tablePanel1.Controls.Add(this.gcProductList);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 417.2F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(1097, 739);
            this.tablePanel1.TabIndex = 7;
            // 
            // gcBasketList
            // 
            this.tablePanel1.SetColumn(this.gcBasketList, 0);
            this.gcBasketList.ContextMenuStrip = this.cmBasket;
            this.gcBasketList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcBasketList.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcBasketList.Location = new System.Drawing.Point(3, 525);
            this.gcBasketList.MainView = this.gvBasketList;
            this.gcBasketList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcBasketList.Name = "gcBasketList";
            this.tablePanel1.SetRow(this.gcBasketList, 1);
            this.gcBasketList.Size = new System.Drawing.Size(1091, 210);
            this.gcBasketList.TabIndex = 4;
            this.gcBasketList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvBasketList});
            // 
            // cmBasket
            // 
            this.cmBasket.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmBasket.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cbtnComplateOrder,
            this.cbtnRefresh,
            this.cbtnDelete});
            this.cmBasket.Name = "contextMenuStrip1";
            this.cmBasket.Size = new System.Drawing.Size(215, 110);
            // 
            // cbtnComplateOrder
            // 
            this.cbtnComplateOrder.Image = global::SiparisOtomasyonSistemi.UI.Properties.Resources.Basket;
            this.cbtnComplateOrder.Name = "cbtnComplateOrder";
            this.cbtnComplateOrder.Size = new System.Drawing.Size(214, 26);
            this.cbtnComplateOrder.Text = "Sipariş Tamamla";
            this.cbtnComplateOrder.Click += new System.EventHandler(this.cbtnComplateOrder_Click);
            // 
            // cbtnRefresh
            // 
            this.cbtnRefresh.Image = global::SiparisOtomasyonSistemi.UI.Properties.Resources.güncelle;
            this.cbtnRefresh.Name = "cbtnRefresh";
            this.cbtnRefresh.Size = new System.Drawing.Size(214, 26);
            this.cbtnRefresh.Text = "Yenile";
            this.cbtnRefresh.Click += new System.EventHandler(this.cbtnRefresh_Click);
            // 
            // cbtnDelete
            // 
            this.cbtnDelete.Image = global::SiparisOtomasyonSistemi.UI.Properties.Resources.Olumsuz;
            this.cbtnDelete.Name = "cbtnDelete";
            this.cbtnDelete.Size = new System.Drawing.Size(214, 26);
            this.cbtnDelete.Text = "Sil";
            this.cbtnDelete.Click += new System.EventHandler(this.cbtnDelete_Click);
            // 
            // gvBasketList
            // 
            this.gvBasketList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.Quantity,
            this.Total});
            this.gvBasketList.DetailHeight = 431;
            this.gvBasketList.GridControl = this.gcBasketList;
            this.gvBasketList.Name = "gvBasketList";
            this.gvBasketList.OptionsCustomization.AllowColumnMoving = false;
            this.gvBasketList.OptionsFilter.AllowColumnMRUFilterList = false;
            this.gvBasketList.OptionsFind.FindFilterColumns = "";
            this.gvBasketList.OptionsMenu.EnableColumnMenu = false;
            this.gvBasketList.OptionsView.ShowAutoFilterRow = true;
            this.gvBasketList.OptionsView.ShowFooter = true;
            this.gvBasketList.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Ürün Kodu";
            this.gridColumn1.FieldName = "Product.ProductId";
            this.gridColumn1.MinWidth = 23;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 67;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Ürün Adı";
            this.gridColumn2.FieldName = "Product.ProductName";
            this.gridColumn2.MinWidth = 23;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 515;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Birim Fiyatı";
            this.gridColumn3.FieldName = "Product.UnitPrice";
            this.gridColumn3.MinWidth = 23;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            this.gridColumn3.Width = 84;
            // 
            // Quantity
            // 
            this.Quantity.Caption = "Adet";
            this.Quantity.FieldName = "Quantity";
            this.Quantity.MinWidth = 25;
            this.Quantity.Name = "Quantity";
            this.Quantity.Visible = true;
            this.Quantity.VisibleIndex = 2;
            this.Quantity.Width = 94;
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
            this.Total.Width = 94;
            // 
            // gcProductList
            // 
            this.tablePanel1.SetColumn(this.gcProductList, 0);
            this.gcProductList.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcProductList.Location = new System.Drawing.Point(3, 4);
            this.gcProductList.MainView = this.gvProductList;
            this.gcProductList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcProductList.Name = "gcProductList";
            this.tablePanel1.SetRow(this.gcProductList, 0);
            this.gcProductList.Size = new System.Drawing.Size(1091, 513);
            this.gcProductList.TabIndex = 3;
            this.gcProductList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvProductList});
            // 
            // gvProductList
            // 
            this.gvProductList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ProductId,
            this.ProductName,
            this.UnitPrice});
            this.gvProductList.DetailHeight = 431;
            this.gvProductList.GridControl = this.gcProductList;
            this.gvProductList.Name = "gvProductList";
            this.gvProductList.OptionsCustomization.AllowColumnMoving = false;
            this.gvProductList.OptionsFilter.AllowColumnMRUFilterList = false;
            this.gvProductList.OptionsFind.FindFilterColumns = "";
            this.gvProductList.OptionsMenu.EnableColumnMenu = false;
            this.gvProductList.OptionsView.ShowAutoFilterRow = true;
            this.gvProductList.OptionsView.ShowFooter = true;
            this.gvProductList.OptionsView.ShowGroupPanel = false;
            this.gvProductList.DoubleClick += new System.EventHandler(this.gvProductList_DoubleClick);
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
            this.ProductId.Width = 67;
            // 
            // ProductName
            // 
            this.ProductName.Caption = "Ürün Adı";
            this.ProductName.FieldName = "ProductName";
            this.ProductName.MinWidth = 23;
            this.ProductName.Name = "ProductName";
            this.ProductName.OptionsColumn.AllowEdit = false;
            this.ProductName.Visible = true;
            this.ProductName.VisibleIndex = 1;
            this.ProductName.Width = 515;
            // 
            // UnitPrice
            // 
            this.UnitPrice.Caption = "Birim Fiyatı";
            this.UnitPrice.FieldName = "UnitPrice";
            this.UnitPrice.MinWidth = 23;
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.OptionsColumn.AllowEdit = false;
            this.UnitPrice.Visible = true;
            this.UnitPrice.VisibleIndex = 2;
            this.UnitPrice.Width = 84;
            // 
            // OrderAddControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tablePanel1);
            this.Name = "OrderAddControl";
            this.Size = new System.Drawing.Size(1097, 739);
            this.Load += new System.EventHandler(this.OrderAddControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcBasketList)).EndInit();
            this.cmBasket.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvBasketList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcProductList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProductList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private System.Windows.Forms.ContextMenuStrip cmBasket;
        private System.Windows.Forms.ToolStripMenuItem cbtnRefresh;
        private System.Windows.Forms.ToolStripMenuItem cbtnDelete;
        public DevExpress.XtraGrid.GridControl gcBasketList;
        private DevExpress.XtraGrid.Views.Grid.GridView gvBasketList;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        public DevExpress.XtraGrid.GridControl gcProductList;
        private DevExpress.XtraGrid.Views.Grid.GridView gvProductList;
        private DevExpress.XtraGrid.Columns.GridColumn ProductId;
        private new DevExpress.XtraGrid.Columns.GridColumn ProductName;
        private DevExpress.XtraGrid.Columns.GridColumn UnitPrice;
        private DevExpress.XtraGrid.Columns.GridColumn Quantity;
        private DevExpress.XtraGrid.Columns.GridColumn Total;
        private System.Windows.Forms.ToolStripMenuItem cbtnComplateOrder;
    }
}
