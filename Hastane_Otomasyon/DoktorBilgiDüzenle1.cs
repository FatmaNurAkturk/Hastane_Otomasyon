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
    public partial class DoktorBilgiDüzenle1 : Form
    {
        public DoktorBilgiDüzenle1()
        {
            InitializeComponent();
        }

        public string tcno1;
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void DoktorBilgiDüzenle1_Load(object sender, EventArgs e)
        {
            mskTc.Text = tcno1;
            SqlCommand komut = new SqlCommand("select * from Tablo_Doktor1 where DoktorTc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskTc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtAd.Text = dr[1].ToString();
                txtSoyad.Text = dr[2].ToString();
                cmbBrans.Text = dr[3].ToString();
                txtSifre.Text = dr[4].ToString();
            }
            bgl.baglanti().Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("update Tablo_Doktor1 set DoktorAd=@p1,DoktorSoyad=@p2,DoktorBrans=@p3,DoktorSifre=@p4 where DoktorTc=@p5", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", txtAd.Text);
            komut1.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut1.Parameters.AddWithValue("@p3", cmbBrans.Text);
            komut1.Parameters.AddWithValue("@p4", txtSifre.Text);
            komut1.Parameters.AddWithValue("@p5", mskTc.Text);
            komut1.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgileriniz Güncellenmiştir");
        }
    }
}
