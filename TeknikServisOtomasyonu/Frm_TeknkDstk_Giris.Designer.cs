namespace TeknikServisOtomasyonu
{
    partial class Frm_TeknkDstk_Giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_TeknkDstk_Giris));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chckbox_sifre = new System.Windows.Forms.CheckBox();
            this.bttn_teknik = new DevExpress.XtraEditors.SimpleButton();
            this.txtf_sifre = new System.Windows.Forms.TextBox();
            this.txtf_nickname = new System.Windows.Forms.TextBox();
            this.lbl_sifre = new System.Windows.Forms.Label();
            this.lbl_adi = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.chckbox_sifre);
            this.panel1.Controls.Add(this.bttn_teknik);
            this.panel1.Controls.Add(this.txtf_sifre);
            this.panel1.Controls.Add(this.txtf_nickname);
            this.panel1.Controls.Add(this.lbl_sifre);
            this.panel1.Controls.Add(this.lbl_adi);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(425, 452);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(147, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 18);
            this.label1.TabIndex = 28;
            this.label1.Text = "TEKNİKER GİRİŞ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(158, 115);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(120, 136);
            this.panel2.TabIndex = 27;
            // 
            // chckbox_sifre
            // 
            this.chckbox_sifre.AutoSize = true;
            this.chckbox_sifre.BackColor = System.Drawing.Color.Transparent;
            this.chckbox_sifre.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chckbox_sifre.ForeColor = System.Drawing.Color.Red;
            this.chckbox_sifre.Location = new System.Drawing.Point(288, 313);
            this.chckbox_sifre.Name = "chckbox_sifre";
            this.chckbox_sifre.Size = new System.Drawing.Size(108, 18);
            this.chckbox_sifre.TabIndex = 26;
            this.chckbox_sifre.Text = "Şifreyi Göster\r\n";
            this.chckbox_sifre.UseVisualStyleBackColor = false;
            this.chckbox_sifre.CheckedChanged += new System.EventHandler(this.chckbox_sifre_CheckedChanged_1);
            // 
            // bttn_teknik
            // 
            this.bttn_teknik.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttn_teknik.Appearance.Options.UseFont = true;
            this.bttn_teknik.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bttn_teknik.ImageOptions.Image")));
            this.bttn_teknik.Location = new System.Drawing.Point(158, 356);
            this.bttn_teknik.Name = "bttn_teknik";
            this.bttn_teknik.Size = new System.Drawing.Size(124, 35);
            this.bttn_teknik.TabIndex = 25;
            this.bttn_teknik.Text = "Giriş";
            this.bttn_teknik.Click += new System.EventHandler(this.bttn_teknik_Click_1);
            // 
            // txtf_sifre
            // 
            this.txtf_sifre.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtf_sifre.Location = new System.Drawing.Point(158, 310);
            this.txtf_sifre.Name = "txtf_sifre";
            this.txtf_sifre.PasswordChar = '•';
            this.txtf_sifre.Size = new System.Drawing.Size(124, 23);
            this.txtf_sifre.TabIndex = 24;
            // 
            // txtf_nickname
            // 
            this.txtf_nickname.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtf_nickname.Location = new System.Drawing.Point(158, 277);
            this.txtf_nickname.Name = "txtf_nickname";
            this.txtf_nickname.Size = new System.Drawing.Size(124, 23);
            this.txtf_nickname.TabIndex = 23;
            // 
            // lbl_sifre
            // 
            this.lbl_sifre.AutoSize = true;
            this.lbl_sifre.BackColor = System.Drawing.Color.Transparent;
            this.lbl_sifre.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sifre.ForeColor = System.Drawing.Color.White;
            this.lbl_sifre.Location = new System.Drawing.Point(23, 311);
            this.lbl_sifre.Name = "lbl_sifre";
            this.lbl_sifre.Size = new System.Drawing.Size(50, 18);
            this.lbl_sifre.TabIndex = 22;
            this.lbl_sifre.Text = "Şifre:";
            // 
            // lbl_adi
            // 
            this.lbl_adi.AutoSize = true;
            this.lbl_adi.BackColor = System.Drawing.Color.Transparent;
            this.lbl_adi.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_adi.ForeColor = System.Drawing.Color.White;
            this.lbl_adi.Location = new System.Drawing.Point(23, 278);
            this.lbl_adi.Name = "lbl_adi";
            this.lbl_adi.Size = new System.Drawing.Size(106, 18);
            this.lbl_adi.TabIndex = 21;
            this.lbl_adi.Text = "Kullanıcı Adı:";
            // 
            // Frm_TeknkDstk_Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 452);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_TeknkDstk_Giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kurt TECH V1.0";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox chckbox_sifre;
        private DevExpress.XtraEditors.SimpleButton bttn_teknik;
        private System.Windows.Forms.TextBox txtf_sifre;
        private System.Windows.Forms.TextBox txtf_nickname;
        private System.Windows.Forms.Label lbl_sifre;
        private System.Windows.Forms.Label lbl_adi;
        private System.Windows.Forms.Label label1;
    }
}