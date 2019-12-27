namespace SiparisOtomasyonSistemi.UI
{
    partial class CustomerListControl
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
            this.gcCustomerList = new DevExpress.XtraGrid.GridControl();
            this.gvCustomerList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CostumerId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TcNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Phone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Email = new DevExpress.XtraGrid.Columns.GridColumn();
            this.City = new DevExpress.XtraGrid.Columns.GridColumn();
            this.District = new DevExpress.XtraGrid.Columns.GridColumn();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcCustomerList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCustomerList)).BeginInit();
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
            this.cbtnAdd.Image = global::SiparisOtomasyonSistemi.UI.Properties.Resources.eklee1;
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
            // gcCustomerList
            // 
            this.gcCustomerList.ContextMenuStrip = this.contextMenuStrip1;
            this.gcCustomerList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCustomerList.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcCustomerList.Location = new System.Drawing.Point(0, 0);
            this.gcCustomerList.MainView = this.gvCustomerList;
            this.gcCustomerList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcCustomerList.Name = "gcCustomerList";
            this.gcCustomerList.Size = new System.Drawing.Size(588, 504);
            this.gcCustomerList.TabIndex = 3;
            this.gcCustomerList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCustomerList});
            // 
            // gvCustomerList
            // 
            this.gvCustomerList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.CostumerId,
            this.UserName,
            this.FirstName,
            this.LastName,
            this.TcNo,
            this.Phone,
            this.Email,
            this.City,
            this.District});
            this.gvCustomerList.DetailHeight = 431;
            this.gvCustomerList.GridControl = this.gcCustomerList;
            this.gvCustomerList.Name = "gvCustomerList";
            this.gvCustomerList.OptionsCustomization.AllowColumnMoving = false;
            this.gvCustomerList.OptionsFilter.AllowColumnMRUFilterList = false;
            this.gvCustomerList.OptionsFind.FindFilterColumns = "";
            this.gvCustomerList.OptionsMenu.EnableColumnMenu = false;
            this.gvCustomerList.OptionsView.ShowAutoFilterRow = true;
            this.gvCustomerList.OptionsView.ShowFooter = true;
            this.gvCustomerList.OptionsView.ShowGroupPanel = false;
            // 
            // CostumerId
            // 
            this.CostumerId.Caption = "Müşteri Kodu";
            this.CostumerId.FieldName = "CostumerId";
            this.CostumerId.MinWidth = 23;
            this.CostumerId.Name = "CostumerId";
            this.CostumerId.OptionsColumn.AllowEdit = false;
            this.CostumerId.Visible = true;
            this.CostumerId.VisibleIndex = 0;
            this.CostumerId.Width = 36;
            // 
            // UserName
            // 
            this.UserName.Caption = "Kullanıcı Adı";
            this.UserName.FieldName = "UserName";
            this.UserName.MinWidth = 25;
            this.UserName.Name = "UserName";
            this.UserName.OptionsColumn.AllowEdit = false;
            this.UserName.Visible = true;
            this.UserName.VisibleIndex = 1;
            this.UserName.Width = 80;
            // 
            // FirstName
            // 
            this.FirstName.Caption = "Ad";
            this.FirstName.FieldName = "FirstName";
            this.FirstName.MinWidth = 23;
            this.FirstName.Name = "FirstName";
            this.FirstName.OptionsColumn.AllowEdit = false;
            this.FirstName.Visible = true;
            this.FirstName.VisibleIndex = 2;
            this.FirstName.Width = 103;
            // 
            // LastName
            // 
            this.LastName.Caption = "Soyad";
            this.LastName.FieldName = "LastName";
            this.LastName.MinWidth = 23;
            this.LastName.Name = "LastName";
            this.LastName.OptionsColumn.AllowEdit = false;
            this.LastName.Visible = true;
            this.LastName.VisibleIndex = 3;
            this.LastName.Width = 141;
            // 
            // TcNo
            // 
            this.TcNo.Caption = "TC";
            this.TcNo.FieldName = "TcNo";
            this.TcNo.MinWidth = 25;
            this.TcNo.Name = "TcNo";
            this.TcNo.OptionsColumn.AllowEdit = false;
            this.TcNo.Visible = true;
            this.TcNo.VisibleIndex = 4;
            this.TcNo.Width = 40;
            // 
            // Phone
            // 
            this.Phone.Caption = "Telefon";
            this.Phone.FieldName = "Phone";
            this.Phone.MinWidth = 25;
            this.Phone.Name = "Phone";
            this.Phone.OptionsColumn.AllowEdit = false;
            this.Phone.Visible = true;
            this.Phone.VisibleIndex = 5;
            this.Phone.Width = 45;
            // 
            // Email
            // 
            this.Email.Caption = "E-Mail";
            this.Email.FieldName = "Email";
            this.Email.MinWidth = 25;
            this.Email.Name = "Email";
            this.Email.OptionsColumn.AllowEdit = false;
            this.Email.Visible = true;
            this.Email.VisibleIndex = 6;
            this.Email.Width = 34;
            // 
            // City
            // 
            this.City.Caption = "İl";
            this.City.FieldName = "City";
            this.City.MinWidth = 25;
            this.City.Name = "City";
            this.City.OptionsColumn.AllowEdit = false;
            this.City.Visible = true;
            this.City.VisibleIndex = 7;
            this.City.Width = 28;
            // 
            // District
            // 
            this.District.Caption = "İlçe";
            this.District.FieldName = "District";
            this.District.MinWidth = 25;
            this.District.Name = "District";
            this.District.OptionsColumn.AllowEdit = false;
            this.District.Visible = true;
            this.District.VisibleIndex = 8;
            this.District.Width = 58;
            // 
            // CustomerListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcCustomerList);
            this.Name = "CustomerListControl";
            this.Size = new System.Drawing.Size(588, 504);
            this.Load += new System.EventHandler(this.CustomerListControl_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcCustomerList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCustomerList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cbtnRefresh;
        private System.Windows.Forms.ToolStripMenuItem cbtnUpdate;
        private System.Windows.Forms.ToolStripMenuItem cbtnDelete;
        public DevExpress.XtraGrid.GridControl gcCustomerList;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCustomerList;
        private DevExpress.XtraGrid.Columns.GridColumn CostumerId;
        private DevExpress.XtraGrid.Columns.GridColumn UserName;
        private DevExpress.XtraGrid.Columns.GridColumn FirstName;
        private DevExpress.XtraGrid.Columns.GridColumn LastName;
        private DevExpress.XtraGrid.Columns.GridColumn TcNo;
        private DevExpress.XtraGrid.Columns.GridColumn Phone;
        private DevExpress.XtraGrid.Columns.GridColumn Email;
        private DevExpress.XtraGrid.Columns.GridColumn City;
        private DevExpress.XtraGrid.Columns.GridColumn District;
        private System.Windows.Forms.ToolStripMenuItem cbtnAdd;
    }
}
