namespace SiparisOtomasyonSistemi.UI
{
    partial class ProductListControl
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
            this.cbtnUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.cbtnAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.cbtnDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.gvProductList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ProductId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcProductList = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvProductList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcProductList)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cbtnRefresh,
            this.cbtnUpdate,
            this.cbtnAdd,
            this.cbtnDelete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(147, 108);
            // 
            // cbtnRefresh
            // 
            this.cbtnRefresh.Image = global::SiparisOtomasyonSistemi.UI.Properties.Resources.güncelle;
            this.cbtnRefresh.Name = "cbtnRefresh";
            this.cbtnRefresh.Size = new System.Drawing.Size(146, 26);
            this.cbtnRefresh.Text = "Yenile";
            this.cbtnRefresh.Click += new System.EventHandler(this.cbtnRefresh_Click);
            // 
            // cbtnUpdate
            // 
            this.cbtnUpdate.Image = global::SiparisOtomasyonSistemi.UI.Properties.Resources.update;
            this.cbtnUpdate.Name = "cbtnUpdate";
            this.cbtnUpdate.Size = new System.Drawing.Size(146, 26);
            this.cbtnUpdate.Text = "Güncelle";
            this.cbtnUpdate.Click += new System.EventHandler(this.cbtnUpdate_Click);
            // 
            // cbtnAdd
            // 
            this.cbtnAdd.Image = global::SiparisOtomasyonSistemi.UI.Properties.Resources.eklee;
            this.cbtnAdd.Name = "cbtnAdd";
            this.cbtnAdd.Size = new System.Drawing.Size(146, 26);
            this.cbtnAdd.Text = "Yeni Kayıt";
            this.cbtnAdd.Click += new System.EventHandler(this.cbtnAdd_Click);
            // 
            // cbtnDelete
            // 
            this.cbtnDelete.Image = global::SiparisOtomasyonSistemi.UI.Properties.Resources.Olumsuz;
            this.cbtnDelete.Name = "cbtnDelete";
            this.cbtnDelete.Size = new System.Drawing.Size(146, 26);
            this.cbtnDelete.Text = "Sil";
            this.cbtnDelete.Click += new System.EventHandler(this.cbtnDelete_Click);
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
            // gcProductList
            // 
            this.gcProductList.ContextMenuStrip = this.contextMenuStrip1;
            this.gcProductList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcProductList.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcProductList.Location = new System.Drawing.Point(0, 0);
            this.gcProductList.MainView = this.gvProductList;
            this.gcProductList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcProductList.Name = "gcProductList";
            this.gcProductList.Size = new System.Drawing.Size(689, 623);
            this.gcProductList.TabIndex = 2;
            this.gcProductList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvProductList});
            // 
            // ProductListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcProductList);
            this.Name = "ProductListControl";
            this.Size = new System.Drawing.Size(689, 623);
            this.Load += new System.EventHandler(this.ProductListControl_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvProductList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcProductList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cbtnRefresh;
        private System.Windows.Forms.ToolStripMenuItem cbtnUpdate;
        private System.Windows.Forms.ToolStripMenuItem cbtnDelete;
        private DevExpress.XtraGrid.Views.Grid.GridView gvProductList;
        private DevExpress.XtraGrid.Columns.GridColumn ProductId;
        private new DevExpress.XtraGrid.Columns.GridColumn ProductName;
        private DevExpress.XtraGrid.Columns.GridColumn UnitPrice;
        public DevExpress.XtraGrid.GridControl gcProductList;
        private System.Windows.Forms.ToolStripMenuItem cbtnAdd;
    }
}
