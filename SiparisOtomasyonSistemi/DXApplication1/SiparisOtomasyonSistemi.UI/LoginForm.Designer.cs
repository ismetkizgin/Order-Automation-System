namespace SiparisOtomasyonSistemi.UI
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.txtUserName = new DevExpress.XtraEditors.TextEdit();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblExit = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.rbtnYonetici = new System.Windows.Forms.RadioButton();
            this.rbtnMusteri = new System.Windows.Forms.RadioButton();
            this.btnSingUp = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUserName
            // 
            this.txtUserName.EditValue = "ismetkizgin";
            this.txtUserName.Location = new System.Drawing.Point(52, 126);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.txtUserName.Size = new System.Drawing.Size(277, 22);
            this.txtUserName.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.EditValue = "ismet";
            this.txtPassword.Location = new System.Drawing.Point(52, 179);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.txtPassword.Properties.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(277, 22);
            this.txtPassword.TabIndex = 2;
            // 
            // btnLogin
            // 
            this.btnLogin.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.ImageOptions.Image")));
            this.btnLogin.Location = new System.Drawing.Point(190, 248);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(139, 48);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Giriş Yap";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DodgerBlue;
            this.groupBox1.Controls.Add(this.lblExit);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Location = new System.Drawing.Point(-4, -13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 104);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // lblExit
            // 
            this.lblExit.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblExit.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblExit.Appearance.Options.UseFont = true;
            this.lblExit.Appearance.Options.UseForeColor = true;
            this.lblExit.Location = new System.Drawing.Point(357, 22);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(10, 21);
            this.lblExit.TabIndex = 7;
            this.lblExit.Text = "X";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(139, 50);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(114, 30);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Giriş Yap";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(52, 104);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(68, 16);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Kullanıcı Adı";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(52, 157);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(27, 16);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Şifre";
            // 
            // rbtnYonetici
            // 
            this.rbtnYonetici.AutoSize = true;
            this.rbtnYonetici.Checked = true;
            this.rbtnYonetici.Location = new System.Drawing.Point(70, 216);
            this.rbtnYonetici.Name = "rbtnYonetici";
            this.rbtnYonetici.Size = new System.Drawing.Size(106, 21);
            this.rbtnYonetici.TabIndex = 7;
            this.rbtnYonetici.TabStop = true;
            this.rbtnYonetici.Text = "Yönetici Girişi";
            this.rbtnYonetici.UseVisualStyleBackColor = true;
            // 
            // rbtnMusteri
            // 
            this.rbtnMusteri.AutoSize = true;
            this.rbtnMusteri.Location = new System.Drawing.Point(205, 216);
            this.rbtnMusteri.Name = "rbtnMusteri";
            this.rbtnMusteri.Size = new System.Drawing.Size(102, 21);
            this.rbtnMusteri.TabIndex = 8;
            this.rbtnMusteri.Text = "Müşteri Girişi";
            this.rbtnMusteri.UseVisualStyleBackColor = true;
            // 
            // btnSingUp
            // 
            this.btnSingUp.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btnSingUp.Appearance.Options.UseFont = true;
            this.btnSingUp.Location = new System.Drawing.Point(12, 291);
            this.btnSingUp.Name = "btnSingUp";
            this.btnSingUp.Size = new System.Drawing.Size(40, 16);
            this.btnSingUp.TabIndex = 9;
            this.btnSingUp.Text = "Üye Ol";
            this.btnSingUp.Click += new System.EventHandler(this.btnSingUp_Click);
            // 
            // LoginForm
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 319);
            this.Controls.Add(this.btnSingUp);
            this.Controls.Add(this.rbtnMusteri);
            this.Controls.Add(this.rbtnYonetici);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit txtUserName;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl lblExit;
        private System.Windows.Forms.RadioButton rbtnYonetici;
        private System.Windows.Forms.RadioButton rbtnMusteri;
        private DevExpress.XtraEditors.LabelControl btnSingUp;
    }
}

