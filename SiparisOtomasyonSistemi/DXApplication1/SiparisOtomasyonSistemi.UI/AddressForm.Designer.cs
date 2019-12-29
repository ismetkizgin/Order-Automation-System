namespace SiparisOtomasyonSistemi.UI
{
    partial class AddressForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddressForm));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtAddress = new System.Windows.Forms.RichTextBox();
            this.btnGo = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lblOwnerName = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lblOrderDate = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.lblTotalAmount = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 101);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(43, 21);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Adres";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(12, 128);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(506, 147);
            this.txtAddress.TabIndex = 1;
            this.txtAddress.Text = "";
            // 
            // btnGo
            // 
            this.btnGo.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnGo.Appearance.Options.UseFont = true;
            this.btnGo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGo.ImageOptions.Image")));
            this.btnGo.Location = new System.Drawing.Point(266, 281);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(252, 58);
            this.btnGo.TabIndex = 2;
            this.btnGo.Text = "Devam Et";
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnClose
            // 
            this.btnClose.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnClose.Location = new System.Drawing.Point(12, 281);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(238, 58);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "İptal";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(12, 11);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(75, 21);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Ad Soyad:";
            // 
            // lblOwnerName
            // 
            this.lblOwnerName.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblOwnerName.Appearance.Options.UseFont = true;
            this.lblOwnerName.Location = new System.Drawing.Point(130, 11);
            this.lblOwnerName.Name = "lblOwnerName";
            this.lblOwnerName.Size = new System.Drawing.Size(109, 21);
            this.lblOwnerName.TabIndex = 5;
            this.lblOwnerName.Text = "lblOwnerName";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(12, 52);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(102, 21);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Sipariş Tarihi:";
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblOrderDate.Appearance.Options.UseFont = true;
            this.lblOrderDate.Location = new System.Drawing.Point(130, 52);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(95, 21);
            this.lblOrderDate.TabIndex = 7;
            this.lblOrderDate.Text = "lblOrderDate";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(270, 101);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(106, 21);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Toplam Tutar:";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblTotalAmount.Appearance.ForeColor = System.Drawing.Color.Lime;
            this.lblTotalAmount.Appearance.Options.UseFont = true;
            this.lblTotalAmount.Appearance.Options.UseForeColor = true;
            this.lblTotalAmount.Location = new System.Drawing.Point(382, 101);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(113, 21);
            this.lblTotalAmount.TabIndex = 9;
            this.lblTotalAmount.Text = "lblTotalAmount";
            // 
            // AddressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 353);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.lblOrderDate);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.lblOwnerName);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddressForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adres Bilgileri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.RichTextBox txtAddress;
        private DevExpress.XtraEditors.SimpleButton btnGo;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lblOwnerName;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl lblOrderDate;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl lblTotalAmount;
    }
}