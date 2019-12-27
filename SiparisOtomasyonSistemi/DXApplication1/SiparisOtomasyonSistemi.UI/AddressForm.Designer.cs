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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtAddress = new System.Windows.Forms.RichTextBox();
            this.btnGo = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(68, 133);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(43, 21);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Adres";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(68, 160);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(441, 147);
            this.txtAddress.TabIndex = 1;
            this.txtAddress.Text = "";
            // 
            // btnGo
            // 
            this.btnGo.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnGo.Appearance.Options.UseFont = true;
            this.btnGo.Location = new System.Drawing.Point(307, 348);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(202, 43);
            this.btnGo.TabIndex = 2;
            this.btnGo.Text = "Devam Et";
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // AddressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 422);
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
    }
}