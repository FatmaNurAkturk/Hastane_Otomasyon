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
    public partial class AsistanGiriş1 : Form
    {
        public AsistanGiriş1()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from Tablo_Asistan1 where AsistanTc = @p1 and AsistanSifre= @p2",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskTcNo.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);
            SqlDataReader da = komut.ExecuteReader();
            if (da.Read())
            {
                AsistanDetay1 frm = new AsistanDetay1();
                frm.TcNo = mskTcNo.Text;
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Şifre veya Tc Kimlik Numarası Girdiniz.");
            }
            bgl.baglanti().Close();
        }
    }
}
