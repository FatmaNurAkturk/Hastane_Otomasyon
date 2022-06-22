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
    public partial class BilgiGüncelleme : Form
    {
        public BilgiGüncelleme()
        {
            InitializeComponent();
        }

        public string TcNo;
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void BilgiGüncelleme_Load(object sender, EventArgs e)
        {
            mskTc.Text = TcNo;
            SqlCommand komut = new SqlCommand("select * From Tablo_Hasta where HastaTc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskTc.Text);
            SqlDataReader da = komut.ExecuteReader();
            while (da.Read())
            {
                TxtAd.Text = da[1].ToString();
                txtSoyad.Text = da[2].ToString();
                mskTel.Text = da[4].ToString();
                txtSifre.Text = da[5].ToString();
                cmbCinsiyet.Text = da[6].ToString();
            }
            bgl.baglanti().Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tablo_Hasta Set HastaAd=@p1,HastaSoyad=@p2,HastaTelefon=@p3,HastaSifre=@p4,HastaCinsiyet=@p5 where HastaTc=@p6", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", mskTel.Text);
            komut.Parameters.AddWithValue("@p4", txtSifre.Text);
            komut.Parameters.AddWithValue("@p5", cmbCinsiyet.Text);
            komut.Parameters.AddWithValue("@p6", mskTc.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti();
            MessageBox.Show("Bilgileriniz Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            bgl.baglanti().Close();
        }
    }
}
