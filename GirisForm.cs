using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace RezervasyonUygulamasi
{
    public partial class GirisForm : Form
    {
        public GirisForm()
        {
            InitializeComponent();
        }

        SqlConnection baglanti;

        public void Kontrol()
        {
            int tcno = Convert.ToInt32(txt_tcno.Text);
            int sifre = Convert.ToInt32(txt_sifre.Text);

            if ((tcno == 11111) && (sifre == 123))//admin girişi
            {
                AdminForm af = new AdminForm();
                af.Show();
            }
            else //kontrolu yap. tcno ve şifre uyumlu ise ekrana geçiş yap.
            {
                VeriTabani vt = new VeriTabani(baglanti);
                vt.YolcuGiris(tcno, sifre);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_girisyap_Click(object sender, EventArgs e)
        {
            Kontrol();

        }

        private void GirisForm_Load(object sender, EventArgs e)
        {

        }
    }
}
