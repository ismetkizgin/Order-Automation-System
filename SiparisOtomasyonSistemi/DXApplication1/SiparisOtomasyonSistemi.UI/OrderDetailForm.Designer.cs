namespace SiparisOtomasyonSistemi.UI
{
    partial class OrderDetailForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.gcProductList = new DevExpress.XtraGrid.GridControl();
            this.gvProductList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ProductId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcProductList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProductList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tablePanel1.Controls.Add(this.gridControl1);
            this.tablePanel1.Controls.Add(this.gcProductList);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 305.9998F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(876, 592);
            this.tablePanel1.TabIndex = 2;
            // 
            // gcProductList
            // 
            this.tablePanel1.SetColumn(this.gcProductList, 0);
            this.gcProductList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcProductList.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcProductList.Location = new System.Drawing.Point(3, 4);
            this.gcProductList.MainView = this.gvProductList;
            this.gcProductList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcProductList.Name = "gcProductList";
            this.tablePanel1.SetRow(this.gcProductList, 0);
            this.gcProductList.Size = new System.Drawing.Size(870, 374);
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
            // gridControl1
            // 
            this.tablePanel1.SetColumn(this.gridControl1, 0);
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControl1.Location = new System.Drawing.Point(3, 386);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControl1.Name = "gridControl1";
            this.tablePanel1.SetRow(this.gridControl1, 1);
            this.gridControl1.Size = new System.Drawing.Size(870, 202);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gridView1.DetailHeight = 431;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsCustomization.AllowColumnMoving = false;
            this.gridView1.OptionsFilter.AllowColumnMRUFilterList = false;
            this.gridView1.OptionsFind.FindFilterColumns = "";
            this.gridView1.OptionsMenu.EnableColumnMenu = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Ürün Kodu";
            this.gridColumn1.FieldName = "ProductId";
            this.gridColumn1.MinWidth = 23;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Width = 67;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Ürün Adı";
            this.gridColumn2.FieldName = "ProductName";
            this.gridColumn2.MinWidth = 23;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Width = 515;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Birim Fiyatı";
            this.gridColumn3.FieldName = "UnitPrice";
            this.gridColumn3.MinWidth = 23;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Width = 84;
            // 
            // OrderDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 592);
            this.Controls.Add(this.tablePanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderDetailForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sipariş Detayı";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.OrderDetailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcProductList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProductList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        public DevExpress.XtraGrid.GridControl gcProductList;
        private DevExpress.XtraGrid.Views.Grid.GridView gvProductList;
        private DevExpress.XtraGrid.Columns.GridColumn ProductId;
        private new DevExpress.XtraGrid.Columns.GridColumn ProductName;
        private DevExpress.XtraGrid.Columns.GridColumn UnitPrice;
        public DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
    }
}