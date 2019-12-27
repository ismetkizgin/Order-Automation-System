namespace SiparisOtomasyonSistemi.UI
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.container = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.btnAccount = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btndProductOparation = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnItemList = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnProductAdd = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btndUserOparation = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnAdminList = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnAdminAdd = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnCostumerList = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnCustomerAdd = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnOrderAllList = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btndOrderOperation = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnMyOrderList = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnOrderAdd = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.btnExit = new DevExpress.XtraBars.BarButtonItem();
            this.btnRestart = new DevExpress.XtraBars.BarButtonItem();
            this.skinDropDownButtonItem1 = new DevExpress.XtraBars.SkinDropDownButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(260, 35);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(738, 670);
            this.container.TabIndex = 0;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btnAccount,
            this.btndProductOparation,
            this.btndUserOparation,
            this.btnOrderAllList,
            this.btndOrderOperation});
            this.accordionControl1.Location = new System.Drawing.Point(0, 35);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(260, 670);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // btnAccount
            // 
            this.btnAccount.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAccount.ImageOptions.Image")));
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnAccount.Text = "Hesabım";
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // btndProductOparation
            // 
            this.btndProductOparation.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btnItemList,
            this.btnProductAdd});
            this.btndProductOparation.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btndProductOparation.ImageOptions.Image")));
            this.btndProductOparation.Name = "btndProductOparation";
            this.btndProductOparation.Text = "Ürün İşlemleri";
            // 
            // btnItemList
            // 
            this.btnItemList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnItemList.ImageOptions.Image")));
            this.btnItemList.Name = "btnItemList";
            this.btnItemList.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnItemList.Text = "Ürün Listesi";
            this.btnItemList.Click += new System.EventHandler(this.btnItemList_Click);
            // 
            // btnProductAdd
            // 
            this.btnProductAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnProductAdd.ImageOptions.Image")));
            this.btnProductAdd.Name = "btnProductAdd";
            this.btnProductAdd.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnProductAdd.Text = "Ürün Ekle";
            this.btnProductAdd.Click += new System.EventHandler(this.btnProductAdd_Click);
            // 
            // btndUserOparation
            // 
            this.btndUserOparation.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btnAdminList,
            this.btnAdminAdd,
            this.btnCostumerList,
            this.btnCustomerAdd});
            this.btndUserOparation.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btndUserOparation.ImageOptions.Image")));
            this.btndUserOparation.Name = "btndUserOparation";
            this.btndUserOparation.Text = "Kullanıcı İşlemleri";
            // 
            // btnAdminList
            // 
            this.btnAdminList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdminList.ImageOptions.Image")));
            this.btnAdminList.Name = "btnAdminList";
            this.btnAdminList.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnAdminList.Text = "Admin Listesi";
            this.btnAdminList.Click += new System.EventHandler(this.btnAdminList_Click);
            // 
            // btnAdminAdd
            // 
            this.btnAdminAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdminAdd.ImageOptions.Image")));
            this.btnAdminAdd.Name = "btnAdminAdd";
            this.btnAdminAdd.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnAdminAdd.Text = "Admin Ekle";
            this.btnAdminAdd.Click += new System.EventHandler(this.btnAdminAdd_Click);
            // 
            // btnCostumerList
            // 
            this.btnCostumerList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCostumerList.ImageOptions.Image")));
            this.btnCostumerList.Name = "btnCostumerList";
            this.btnCostumerList.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnCostumerList.Text = "Müşteri Listesi";
            this.btnCostumerList.Click += new System.EventHandler(this.btnCostumerList_Click);
            // 
            // btnCustomerAdd
            // 
            this.btnCustomerAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomerAdd.ImageOptions.Image")));
            this.btnCustomerAdd.Name = "btnCustomerAdd";
            this.btnCustomerAdd.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnCustomerAdd.Text = "Müşteri Ekle";
            this.btnCustomerAdd.Click += new System.EventHandler(this.btnCustomerAdd_Click);
            // 
            // btnOrderAllList
            // 
            this.btnOrderAllList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOrderAllList.ImageOptions.Image")));
            this.btnOrderAllList.Name = "btnOrderAllList";
            this.btnOrderAllList.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnOrderAllList.Text = "Sipariş Listesi";
            this.btnOrderAllList.Click += new System.EventHandler(this.btnOrderAllList_Click);
            // 
            // btndOrderOperation
            // 
            this.btndOrderOperation.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btnMyOrderList,
            this.btnOrderAdd});
            this.btndOrderOperation.Expanded = true;
            this.btndOrderOperation.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btndOrderOperation.ImageOptions.Image")));
            this.btndOrderOperation.Name = "btndOrderOperation";
            this.btndOrderOperation.Text = "Sipariş İşlemleri";
            // 
            // btnMyOrderList
            // 
            this.btnMyOrderList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMyOrderList.ImageOptions.Image")));
            this.btnMyOrderList.Name = "btnMyOrderList";
            this.btnMyOrderList.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnMyOrderList.Text = "Sipariş Listem";
            this.btnMyOrderList.Click += new System.EventHandler(this.btnMyOrderList_Click);
            // 
            // btnOrderAdd
            // 
            this.btnOrderAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOrderAdd.ImageOptions.Image")));
            this.btnOrderAdd.Name = "btnOrderAdd";
            this.btnOrderAdd.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnOrderAdd.Text = "Sipariş Ver";
            this.btnOrderAdd.Click += new System.EventHandler(this.btnOrderAdd_Click);
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barSubItem1,
            this.btnExit,
            this.btnRestart,
            this.skinDropDownButtonItem1});
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(998, 35);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            this.fluentDesignFormControl1.TitleItemLinks.Add(this.barSubItem1);
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "Ayarlar";
            this.barSubItem1.Id = 0;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnExit),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRestart),
            new DevExpress.XtraBars.LinkPersistInfo(this.skinDropDownButtonItem1)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // btnExit
            // 
            this.btnExit.Caption = "Güvenli Çıkış";
            this.btnExit.Id = 1;
            this.btnExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageOptions.Image")));
            this.btnExit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageOptions.LargeImage")));
            this.btnExit.Name = "btnExit";
            this.btnExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExit_ItemClick);
            // 
            // btnRestart
            // 
            this.btnRestart.Caption = "Yeniden Başlat";
            this.btnRestart.Id = 2;
            this.btnRestart.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRestart.ImageOptions.Image")));
            this.btnRestart.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRestart.ImageOptions.LargeImage")));
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRestart_ItemClick);
            // 
            // skinDropDownButtonItem1
            // 
            this.skinDropDownButtonItem1.Id = 3;
            this.skinDropDownButtonItem1.Name = "skinDropDownButtonItem1";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 705);
            this.ControlContainer = this.container;
            this.Controls.Add(this.container);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Name = "AdminForm";
            this.NavigationControl = this.accordionControl1;
            this.ShowIcon = false;
            this.Text = "Admin Paneli";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer container;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnAccount;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btndProductOparation;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnItemList;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnProductAdd;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btndUserOparation;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnCostumerList;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnCustomerAdd;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnAdminAdd;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnAdminList;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btndOrderOperation;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnOrderAllList;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnOrderAdd;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnMyOrderList;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem btnExit;
        private DevExpress.XtraBars.BarButtonItem btnRestart;
        private DevExpress.XtraBars.SkinDropDownButtonItem skinDropDownButtonItem1;
    }
}