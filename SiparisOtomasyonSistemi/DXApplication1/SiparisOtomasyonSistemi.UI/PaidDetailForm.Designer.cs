namespace SiparisOtomasyonSistemi.UI
{
    partial class PaidDetailForm
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
            this.gcCreditDetail = new DevExpress.XtraGrid.GridControl();
            this.gvCreditDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CartType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CartNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Amountt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCheckDetail = new DevExpress.XtraGrid.GridControl();
            this.gvCheckDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Bank = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CheckWhom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CheckHolder = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Amounttt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCashDetail = new DevExpress.XtraGrid.GridControl();
            this.gvCashDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Amount = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcCreditDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCreditDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCheckDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCheckDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCashDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCashDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tablePanel1.Controls.Add(this.gcCreditDetail);
            this.tablePanel1.Controls.Add(this.gcCheckDetail);
            this.tablePanel1.Controls.Add(this.gcCashDetail);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 201.1999F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 178.0001F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(1034, 694);
            this.tablePanel1.TabIndex = 0;
            // 
            // gcCreditDetail
            // 
            this.tablePanel1.SetColumn(this.gcCreditDetail, 0);
            this.gcCreditDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCreditDetail.Location = new System.Drawing.Point(3, 477);
            this.gcCreditDetail.MainView = this.gvCreditDetail;
            this.gcCreditDetail.Name = "gcCreditDetail";
            this.tablePanel1.SetRow(this.gcCreditDetail, 2);
            this.gcCreditDetail.Size = new System.Drawing.Size(1028, 214);
            this.gcCreditDetail.TabIndex = 2;
            this.gcCreditDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCreditDetail});
            // 
            // gvCreditDetail
            // 
            this.gvCreditDetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.CartType,
            this.CartNo,
            this.Amountt});
            this.gvCreditDetail.GridControl = this.gcCreditDetail;
            this.gvCreditDetail.Name = "gvCreditDetail";
            this.gvCreditDetail.OptionsView.ShowGroupPanel = false;
            // 
            // CartType
            // 
            this.CartType.Caption = "Kart Tipi";
            this.CartType.FieldName = "CartType";
            this.CartType.MinWidth = 25;
            this.CartType.Name = "CartType";
            this.CartType.OptionsColumn.AllowEdit = false;
            this.CartType.Visible = true;
            this.CartType.VisibleIndex = 0;
            this.CartType.Width = 94;
            // 
            // CartNo
            // 
            this.CartNo.Caption = "Kart No";
            this.CartNo.FieldName = "CartNo";
            this.CartNo.MinWidth = 25;
            this.CartNo.Name = "CartNo";
            this.CartNo.OptionsColumn.AllowEdit = false;
            this.CartNo.Visible = true;
            this.CartNo.VisibleIndex = 1;
            this.CartNo.Width = 94;
            // 
            // Amountt
            // 
            this.Amountt.Caption = "Tutar";
            this.Amountt.FieldName = "Amount";
            this.Amountt.MinWidth = 25;
            this.Amountt.Name = "Amountt";
            this.Amountt.OptionsColumn.AllowEdit = false;
            this.Amountt.Visible = true;
            this.Amountt.VisibleIndex = 2;
            this.Amountt.Width = 94;
            // 
            // gcCheckDetail
            // 
            this.tablePanel1.SetColumn(this.gcCheckDetail, 0);
            this.gcCheckDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCheckDetail.Location = new System.Drawing.Point(3, 254);
            this.gcCheckDetail.MainView = this.gvCheckDetail;
            this.gcCheckDetail.Name = "gcCheckDetail";
            this.tablePanel1.SetRow(this.gcCheckDetail, 1);
            this.gcCheckDetail.Size = new System.Drawing.Size(1028, 217);
            this.gcCheckDetail.TabIndex = 1;
            this.gcCheckDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCheckDetail});
            // 
            // gvCheckDetail
            // 
            this.gvCheckDetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Bank,
            this.CheckWhom,
            this.CheckHolder,
            this.Amounttt});
            this.gvCheckDetail.GridControl = this.gcCheckDetail;
            this.gvCheckDetail.Name = "gvCheckDetail";
            this.gvCheckDetail.OptionsView.ShowGroupPanel = false;
            // 
            // Bank
            // 
            this.Bank.Caption = "Banka";
            this.Bank.FieldName = "Bank";
            this.Bank.MinWidth = 25;
            this.Bank.Name = "Bank";
            this.Bank.OptionsColumn.AllowEdit = false;
            this.Bank.Visible = true;
            this.Bank.VisibleIndex = 0;
            this.Bank.Width = 94;
            // 
            // CheckWhom
            // 
            this.CheckWhom.Caption = "Çek Kime";
            this.CheckWhom.FieldName = "CheckWhom";
            this.CheckWhom.MinWidth = 25;
            this.CheckWhom.Name = "CheckWhom";
            this.CheckWhom.OptionsColumn.AllowEdit = false;
            this.CheckWhom.Visible = true;
            this.CheckWhom.VisibleIndex = 1;
            this.CheckWhom.Width = 94;
            // 
            // CheckHolder
            // 
            this.CheckHolder.Caption = "Çek Sahibi";
            this.CheckHolder.FieldName = "CheckHolder";
            this.CheckHolder.MinWidth = 25;
            this.CheckHolder.Name = "CheckHolder";
            this.CheckHolder.OptionsColumn.AllowEdit = false;
            this.CheckHolder.Visible = true;
            this.CheckHolder.VisibleIndex = 2;
            this.CheckHolder.Width = 94;
            // 
            // Amounttt
            // 
            this.Amounttt.Caption = "Tutar";
            this.Amounttt.FieldName = "Amount";
            this.Amounttt.MinWidth = 25;
            this.Amounttt.Name = "Amounttt";
            this.Amounttt.OptionsColumn.AllowEdit = false;
            this.Amounttt.Visible = true;
            this.Amounttt.VisibleIndex = 3;
            this.Amounttt.Width = 94;
            // 
            // gcCashDetail
            // 
            this.tablePanel1.SetColumn(this.gcCashDetail, 0);
            this.gcCashDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCashDetail.Location = new System.Drawing.Point(3, 3);
            this.gcCashDetail.MainView = this.gvCashDetail;
            this.gcCashDetail.Name = "gcCashDetail";
            this.tablePanel1.SetRow(this.gcCashDetail, 0);
            this.gcCashDetail.Size = new System.Drawing.Size(1028, 245);
            this.gcCashDetail.TabIndex = 0;
            this.gcCashDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCashDetail});
            // 
            // gvCashDetail
            // 
            this.gvCashDetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Amount});
            this.gvCashDetail.GridControl = this.gcCashDetail;
            this.gvCashDetail.Name = "gvCashDetail";
            this.gvCashDetail.OptionsView.ShowGroupPanel = false;
            // 
            // Amount
            // 
            this.Amount.Caption = "Tutar";
            this.Amount.FieldName = "Amount";
            this.Amount.MinWidth = 25;
            this.Amount.Name = "Amount";
            this.Amount.OptionsColumn.AllowEdit = false;
            this.Amount.Visible = true;
            this.Amount.VisibleIndex = 0;
            this.Amount.Width = 525;
            // 
            // PaidDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 694);
            this.Controls.Add(this.tablePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PaidDetailForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ödemeler";
            this.Load += new System.EventHandler(this.PaidDetailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcCreditDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCreditDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCheckDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCheckDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCashDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCashDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraGrid.GridControl gcCreditDetail;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCreditDetail;
        private DevExpress.XtraGrid.GridControl gcCheckDetail;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCheckDetail;
        private DevExpress.XtraGrid.GridControl gcCashDetail;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCashDetail;
        private DevExpress.XtraGrid.Columns.GridColumn Bank;
        private DevExpress.XtraGrid.Columns.GridColumn CheckWhom;
        private DevExpress.XtraGrid.Columns.GridColumn Amounttt;
        private DevExpress.XtraGrid.Columns.GridColumn Amount;
        private DevExpress.XtraGrid.Columns.GridColumn CheckHolder;
        private DevExpress.XtraGrid.Columns.GridColumn CartType;
        private DevExpress.XtraGrid.Columns.GridColumn CartNo;
        protected DevExpress.XtraGrid.Columns.GridColumn Amountt;
    }
}