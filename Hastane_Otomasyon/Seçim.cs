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

namespace Hastane_Otomasyon
{
    public partial class Seçim : Form
    {
        public Seçim()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        private void Seçim_Load(object sender, EventArgs e)

        {
            MessageBox.Show("MUAYENE ÜCRETİ (120) TL DİR... DEVAM ETMEK İÇİN DEVAM ET BUTONUNA ANA SAYFAYA DÖNMEK İÇİN ANA SAYFA BUTONUNA TIKLAYINIZ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ÖzelHastaneGirişi frm = new ÖzelHastaneGirişi();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Anasayfa1 frm = new Anasayfa1();
            frm.Show();
            this.Hide();
        }
    }
}
