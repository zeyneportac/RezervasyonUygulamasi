
namespace RezervasyonUygulamasi
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
            this.lbl_ad = new System.Windows.Forms.Label();
            this.lbl_soyad = new System.Windows.Forms.Label();
            this.lbl_tcno = new System.Windows.Forms.Label();
            this.lbl_sifre = new System.Windows.Forms.Label();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.txt_tcno = new System.Windows.Forms.TextBox();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_ad
            // 
            this.lbl_ad.AutoSize = true;
            this.lbl_ad.Location = new System.Drawing.Point(134, 98);
            this.lbl_ad.Name = "lbl_ad";
            this.lbl_ad.Size = new System.Drawing.Size(29, 17);
            this.lbl_ad.TabIndex = 0;
            this.lbl_ad.Text = "Ad:";
            // 
            // lbl_soyad
            // 
            this.lbl_soyad.AutoSize = true;
            this.lbl_soyad.Location = new System.Drawing.Point(134, 141);
            this.lbl_soyad.Name = "lbl_soyad";
            this.lbl_soyad.Size = new System.Drawing.Size(52, 17);
            this.lbl_soyad.TabIndex = 1;
            this.lbl_soyad.Text = "Soyad:";
            // 
            // lbl_tcno
            // 
            this.lbl_tcno.AutoSize = true;
            this.lbl_tcno.Location = new System.Drawing.Point(134, 193);
            this.lbl_tcno.Name = "lbl_tcno";
            this.lbl_tcno.Size = new System.Drawing.Size(51, 17);
            this.lbl_tcno.TabIndex = 2;
            this.lbl_tcno.Text = "TCNO:";
            // 
            // lbl_sifre
            // 
            this.lbl_sifre.AutoSize = true;
            this.lbl_sifre.Location = new System.Drawing.Point(134, 237);
            this.lbl_sifre.Name = "lbl_sifre";
            this.lbl_sifre.Size = new System.Drawing.Size(41, 17);
            this.lbl_sifre.TabIndex = 3;
            this.lbl_sifre.Text = "Şifre:";
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(242, 93);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(184, 22);
            this.txt_ad.TabIndex = 4;
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(242, 237);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(184, 22);
            this.txt_sifre.TabIndex = 5;
            // 
            // txt_tcno
            // 
            this.txt_tcno.Location = new System.Drawing.Point(242, 186);
            this.txt_tcno.Name = "txt_tcno";
            this.txt_tcno.Size = new System.Drawing.Size(184, 22);
            this.txt_tcno.TabIndex = 6;
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(242, 136);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(184, 22);
            this.txt_soyad.TabIndex = 7;
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(223, 327);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(115, 43);
            this.btn_kaydet.TabIndex = 8;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(572, 438);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.txt_soyad);
            this.Controls.Add(this.txt_tcno);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.lbl_sifre);
            this.Controls.Add(this.lbl_tcno);
            this.Controls.Add(this.lbl_soyad);
            this.Controls.Add(this.lbl_ad);
            this.Name = "AdminForm";
            this.Text = "Admin Ekranı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ad;
        private System.Windows.Forms.Label lbl_soyad;
        private System.Windows.Forms.Label lbl_tcno;
        private System.Windows.Forms.Label lbl_sifre;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.TextBox txt_tcno;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.Button btn_kaydet;
    }
}