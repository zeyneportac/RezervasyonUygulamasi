
namespace RezervasyonUygulamasi
{
    partial class RezervasyonForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_tc = new System.Windows.Forms.Label();
            this.lbl_ad = new System.Windows.Forms.Label();
            this.lbl_soyad = new System.Windows.Forms.Label();
            this.lbl_konaklama = new System.Windows.Forms.Label();
            this.lbl_ulasim = new System.Windows.Forms.Label();
            this.txt_tc = new System.Windows.Forms.TextBox();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.cmb_konaklama = new System.Windows.Forms.ComboBox();
            this.cmb_ulasim = new System.Windows.Forms.ComboBox();
            this.btn_onayla = new System.Windows.Forms.Button();
            this.gb_raporal = new System.Windows.Forms.GroupBox();
            this.lbl_raportc = new System.Windows.Forms.Label();
            this.lbl_RaporCesidi = new System.Windows.Forms.Label();
            this.lbl_raporonceligi = new System.Windows.Forms.Label();
            this.txt_raportc = new System.Windows.Forms.TextBox();
            this.cmb_raporcesidi = new System.Windows.Forms.ComboBox();
            this.cmb_raporgosterimi = new System.Windows.Forms.ComboBox();
            this.btn_RaporAl = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gb_raporal.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_onayla);
            this.groupBox1.Controls.Add(this.cmb_ulasim);
            this.groupBox1.Controls.Add(this.cmb_konaklama);
            this.groupBox1.Controls.Add(this.txt_soyad);
            this.groupBox1.Controls.Add(this.txt_ad);
            this.groupBox1.Controls.Add(this.txt_tc);
            this.groupBox1.Controls.Add(this.lbl_ulasim);
            this.groupBox1.Controls.Add(this.lbl_konaklama);
            this.groupBox1.Controls.Add(this.lbl_soyad);
            this.groupBox1.Controls.Add(this.lbl_ad);
            this.groupBox1.Controls.Add(this.lbl_tc);
            this.groupBox1.Location = new System.Drawing.Point(100, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(638, 189);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rezervasyon Yap";
            // 
            // lbl_tc
            // 
            this.lbl_tc.AutoSize = true;
            this.lbl_tc.Location = new System.Drawing.Point(30, 42);
            this.lbl_tc.Name = "lbl_tc";
            this.lbl_tc.Size = new System.Drawing.Size(30, 17);
            this.lbl_tc.TabIndex = 0;
            this.lbl_tc.Text = "TC:";
            this.lbl_tc.Click += new System.EventHandler(this.lbl_tc_Click);
            // 
            // lbl_ad
            // 
            this.lbl_ad.AutoSize = true;
            this.lbl_ad.Location = new System.Drawing.Point(33, 84);
            this.lbl_ad.Name = "lbl_ad";
            this.lbl_ad.Size = new System.Drawing.Size(29, 17);
            this.lbl_ad.TabIndex = 1;
            this.lbl_ad.Text = "Ad:";
            // 
            // lbl_soyad
            // 
            this.lbl_soyad.AutoSize = true;
            this.lbl_soyad.Location = new System.Drawing.Point(33, 123);
            this.lbl_soyad.Name = "lbl_soyad";
            this.lbl_soyad.Size = new System.Drawing.Size(52, 17);
            this.lbl_soyad.TabIndex = 2;
            this.lbl_soyad.Text = "Soyad:";
            // 
            // lbl_konaklama
            // 
            this.lbl_konaklama.AutoSize = true;
            this.lbl_konaklama.Location = new System.Drawing.Point(345, 41);
            this.lbl_konaklama.Name = "lbl_konaklama";
            this.lbl_konaklama.Size = new System.Drawing.Size(82, 17);
            this.lbl_konaklama.TabIndex = 3;
            this.lbl_konaklama.Text = "Konaklama:";
            // 
            // lbl_ulasim
            // 
            this.lbl_ulasim.AutoSize = true;
            this.lbl_ulasim.Location = new System.Drawing.Point(345, 86);
            this.lbl_ulasim.Name = "lbl_ulasim";
            this.lbl_ulasim.Size = new System.Drawing.Size(54, 17);
            this.lbl_ulasim.TabIndex = 4;
            this.lbl_ulasim.Text = "Ulaşım:";
            // 
            // txt_tc
            // 
            this.txt_tc.Location = new System.Drawing.Point(108, 36);
            this.txt_tc.Name = "txt_tc";
            this.txt_tc.Size = new System.Drawing.Size(181, 22);
            this.txt_tc.TabIndex = 5;
            this.txt_tc.TextChanged += new System.EventHandler(this.txt_tc_TextChanged);
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(108, 81);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(181, 22);
            this.txt_ad.TabIndex = 6;
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(108, 123);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(181, 22);
            this.txt_soyad.TabIndex = 7;
            // 
            // cmb_konaklama
            // 
            this.cmb_konaklama.FormattingEnabled = true;
            this.cmb_konaklama.Items.AddRange(new object[] {
            "Otel",
            "Çadır",
            "Ev"});
            this.cmb_konaklama.Location = new System.Drawing.Point(442, 38);
            this.cmb_konaklama.Name = "cmb_konaklama";
            this.cmb_konaklama.Size = new System.Drawing.Size(163, 24);
            this.cmb_konaklama.TabIndex = 8;
            // 
            // cmb_ulasim
            // 
            this.cmb_ulasim.FormattingEnabled = true;
            this.cmb_ulasim.Items.AddRange(new object[] {
            "Uçak",
            "Otobüs",
            "Tren"});
            this.cmb_ulasim.Location = new System.Drawing.Point(442, 86);
            this.cmb_ulasim.Name = "cmb_ulasim";
            this.cmb_ulasim.Size = new System.Drawing.Size(163, 24);
            this.cmb_ulasim.TabIndex = 9;
            // 
            // btn_onayla
            // 
            this.btn_onayla.Location = new System.Drawing.Point(375, 135);
            this.btn_onayla.Name = "btn_onayla";
            this.btn_onayla.Size = new System.Drawing.Size(213, 34);
            this.btn_onayla.TabIndex = 10;
            this.btn_onayla.Text = "Rezervasyon Onayla";
            this.btn_onayla.UseVisualStyleBackColor = true;
            this.btn_onayla.Click += new System.EventHandler(this.btn_onayla_Click);
            // 
            // gb_raporal
            // 
            this.gb_raporal.Controls.Add(this.btn_RaporAl);
            this.gb_raporal.Controls.Add(this.cmb_raporgosterimi);
            this.gb_raporal.Controls.Add(this.cmb_raporcesidi);
            this.gb_raporal.Controls.Add(this.txt_raportc);
            this.gb_raporal.Controls.Add(this.lbl_raporonceligi);
            this.gb_raporal.Controls.Add(this.lbl_RaporCesidi);
            this.gb_raporal.Controls.Add(this.lbl_raportc);
            this.gb_raporal.Location = new System.Drawing.Point(100, 334);
            this.gb_raporal.Name = "gb_raporal";
            this.gb_raporal.Size = new System.Drawing.Size(638, 189);
            this.gb_raporal.TabIndex = 1;
            this.gb_raporal.TabStop = false;
            this.gb_raporal.Text = "RaporAl";
            // 
            // lbl_raportc
            // 
            this.lbl_raportc.AutoSize = true;
            this.lbl_raportc.Location = new System.Drawing.Point(33, 51);
            this.lbl_raportc.Name = "lbl_raportc";
            this.lbl_raportc.Size = new System.Drawing.Size(69, 17);
            this.lbl_raportc.TabIndex = 0;
            this.lbl_raportc.Text = "Yolcu TC:";
            // 
            // lbl_RaporCesidi
            // 
            this.lbl_RaporCesidi.AutoSize = true;
            this.lbl_RaporCesidi.Location = new System.Drawing.Point(33, 93);
            this.lbl_RaporCesidi.Name = "lbl_RaporCesidi";
            this.lbl_RaporCesidi.Size = new System.Drawing.Size(93, 17);
            this.lbl_RaporCesidi.TabIndex = 1;
            this.lbl_RaporCesidi.Text = "Rapor Çeşidi:";
            // 
            // lbl_raporonceligi
            // 
            this.lbl_raporonceligi.AutoSize = true;
            this.lbl_raporonceligi.Location = new System.Drawing.Point(33, 140);
            this.lbl_raporonceligi.Name = "lbl_raporonceligi";
            this.lbl_raporonceligi.Size = new System.Drawing.Size(106, 17);
            this.lbl_raporonceligi.TabIndex = 2;
            this.lbl_raporonceligi.Text = "Rapor Önceliği:";
            // 
            // txt_raportc
            // 
            this.txt_raportc.Location = new System.Drawing.Point(167, 46);
            this.txt_raportc.Name = "txt_raportc";
            this.txt_raportc.Size = new System.Drawing.Size(181, 22);
            this.txt_raportc.TabIndex = 3;
            this.txt_raportc.TextChanged += new System.EventHandler(this.txt_raportc_TextChanged);
            // 
            // cmb_raporcesidi
            // 
            this.cmb_raporcesidi.FormattingEnabled = true;
            this.cmb_raporcesidi.Items.AddRange(new object[] {
            "HTML",
            "JSON"});
            this.cmb_raporcesidi.Location = new System.Drawing.Point(167, 86);
            this.cmb_raporcesidi.Name = "cmb_raporcesidi";
            this.cmb_raporcesidi.Size = new System.Drawing.Size(181, 24);
            this.cmb_raporcesidi.TabIndex = 4;
            // 
            // cmb_raporgosterimi
            // 
            this.cmb_raporgosterimi.FormattingEnabled = true;
            this.cmb_raporgosterimi.Items.AddRange(new object[] {
            "Kişi Bilgileri Öncelikli",
            "Seyahat Bilgileri Öncelikli"});
            this.cmb_raporgosterimi.Location = new System.Drawing.Point(167, 137);
            this.cmb_raporgosterimi.Name = "cmb_raporgosterimi";
            this.cmb_raporgosterimi.Size = new System.Drawing.Size(181, 24);
            this.cmb_raporgosterimi.TabIndex = 5;
            // 
            // btn_RaporAl
            // 
            this.btn_RaporAl.Location = new System.Drawing.Point(442, 75);
            this.btn_RaporAl.Name = "btn_RaporAl";
            this.btn_RaporAl.Size = new System.Drawing.Size(127, 53);
            this.btn_RaporAl.TabIndex = 6;
            this.btn_RaporAl.Text = "Rapor Oluştur";
            this.btn_RaporAl.UseVisualStyleBackColor = true;
            this.btn_RaporAl.Click += new System.EventHandler(this.btn_RaporAl_Click);
            // 
            // RezervasyonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(863, 601);
            this.Controls.Add(this.gb_raporal);
            this.Controls.Add(this.groupBox1);
            this.Name = "RezervasyonForm";
            this.Text = "RezervasyonForm";
            this.Load += new System.EventHandler(this.RezervasyonForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gb_raporal.ResumeLayout(false);
            this.gb_raporal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_onayla;
        private System.Windows.Forms.ComboBox cmb_ulasim;
        private System.Windows.Forms.ComboBox cmb_konaklama;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.TextBox txt_tc;
        private System.Windows.Forms.Label lbl_ulasim;
        private System.Windows.Forms.Label lbl_konaklama;
        private System.Windows.Forms.Label lbl_soyad;
        private System.Windows.Forms.Label lbl_ad;
        private System.Windows.Forms.Label lbl_tc;
        private System.Windows.Forms.GroupBox gb_raporal;
        private System.Windows.Forms.Button btn_RaporAl;
        private System.Windows.Forms.ComboBox cmb_raporgosterimi;
        private System.Windows.Forms.ComboBox cmb_raporcesidi;
        private System.Windows.Forms.TextBox txt_raportc;
        private System.Windows.Forms.Label lbl_raporonceligi;
        private System.Windows.Forms.Label lbl_RaporCesidi;
        private System.Windows.Forms.Label lbl_raportc;
    }
}