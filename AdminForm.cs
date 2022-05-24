using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RezervasyonUygulamasi
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            YolcuEkle ye = new YolcuEkle();
            ye.Ad = txt_ad.Text;
            ye.Soyad = txt_soyad.Text;
            ye.TCNO = Convert.ToInt32(txt_tcno.Text);
            ye.Sifre = Convert.ToInt32(txt_sifre.Text);

            ye.YolcuKaydet();
        }
    }
}
