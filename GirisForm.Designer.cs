
namespace RezervasyonUygulamasi
{
    partial class GirisForm
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
            this.lbl_tcno = new System.Windows.Forms.Label();
            this.lbl_sifre = new System.Windows.Forms.Label();
            this.txt_tcno = new System.Windows.Forms.TextBox();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.btn_girisyap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_tcno
            // 
            this.lbl_tcno.AutoSize = true;
            this.lbl_tcno.Location = new System.Drawing.Point(110, 92);
            this.lbl_tcno.Name = "lbl_tcno";
            this.lbl_tcno.Size = new System.Drawing.Size(51, 17);
            this.lbl_tcno.TabIndex = 0;
            this.lbl_tcno.Text = "TCNO:";
            this.lbl_tcno.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_sifre
            // 
            this.lbl_sifre.AutoSize = true;
            this.lbl_sifre.Location = new System.Drawing.Point(110, 140);
            this.lbl_sifre.Name = "lbl_sifre";
            this.lbl_sifre.Size = new System.Drawing.Size(41, 17);
            this.lbl_sifre.TabIndex = 1;
            this.lbl_sifre.Text = "Şifre:";
            // 
            // txt_tcno
            // 
            this.txt_tcno.Location = new System.Drawing.Point(184, 92);
            this.txt_tcno.Name = "txt_tcno";
            this.txt_tcno.Size = new System.Drawing.Size(153, 22);
            this.txt_tcno.TabIndex = 2;
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(184, 140);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(153, 22);
            this.txt_sifre.TabIndex = 3;
            // 
            // btn_girisyap
            // 
            this.btn_girisyap.Location = new System.Drawing.Point(160, 210);
            this.btn_girisyap.Name = "btn_girisyap";
            this.btn_girisyap.Size = new System.Drawing.Size(116, 33);
            this.btn_girisyap.TabIndex = 4;
            this.btn_girisyap.Text = "Giriş Yap";
            this.btn_girisyap.UseVisualStyleBackColor = true;
            this.btn_girisyap.Click += new System.EventHandler(this.btn_girisyap_Click);
            // 
            // GirisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(443, 305);
            this.Controls.Add(this.btn_girisyap);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.txt_tcno);
            this.Controls.Add(this.lbl_sifre);
            this.Controls.Add(this.lbl_tcno);
            this.Name = "GirisForm";
            this.Text = "Giriş Ekranı";
            this.Load += new System.EventHandler(this.GirisForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_tcno;
        private System.Windows.Forms.Label lbl_sifre;
        private System.Windows.Forms.TextBox txt_tcno;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.Button btn_girisyap;
    }
}

