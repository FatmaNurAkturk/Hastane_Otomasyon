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
    public partial class AsistanDetay1 : Form
    {
        public AsistanDetay1()
        {
            InitializeComponent();
        }

        public string TcNo;
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void AsistanDetay1_Load(object sender, EventArgs e)
        {
            lblTcsi.Text = TcNo;
            SqlCommand komut = new SqlCommand("Select AsistanAd ,AsistanSoyad From Tablo_Asistan1 where AsistanTc=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lblTcsi.Text);
            SqlDataReader da = komut.ExecuteReader();
            while (da.Read())
            {
                lblAdd.Text = da[0].ToString();
                lblSoyad.Text = da[1].ToString();
            }
            bgl.baglanti().Close();

            DataTable dt = new DataTable();
            SqlDataAdapter dr = new SqlDataAdapter("Select * From Tablo_Brans1",bgl.baglanti());
            dr.Fill(dt);
            dataGridView1.DataSource = dt;

            DataTable dt1 = new DataTable();
            SqlDataAdapter dr1 = new SqlDataAdapter("select (DoktorAd + ' ' + DoktorSoyad) as 'Doktor', DoktorBrans From Tablo_Doktor1", bgl.baglanti());
            dr.Fill(dt1);
            dataGridView2.DataSource = dt1;

            SqlCommand komut1 = new SqlCommand("select BransAd From Tablo_Brans ", bgl.baglanti());
            SqlDataReader dt2 = komut1.ExecuteReader();
            while (dt2.Read())
            {
                cmbBranş.Items.Add(dt2[0]);
            }
            bgl.baglanti().Close();


        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komutkaydet = new SqlCommand("insert into Tablo_Randevu1 (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor) values (@p1,@p2,@p3,@p4)", bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@p1", mskTarih.Text);
            komutkaydet.Parameters.AddWithValue("@p2", mskSaat.Text);
            komutkaydet.Parameters.AddWithValue("@p3", cmbBranş.Text);
            komutkaydet.Parameters.AddWithValue("@p4", cmbDoktor.Text);
            komutkaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevunuz Oluşturulmuştur");

            SqlCommand komut1 = new SqlCommand(" Select BransAd from Tablo_Brans1", bgl.baglanti());
            SqlDataReader dr2 = komut1.ExecuteReader();
            while (dr2.Read())
            {
                cmbBranş.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();

        }

        private void cmbBranş_SelectedIndexChanged(object sender, EventArgs e)
        {

            cmbDoktor.Items.Clear();
            SqlCommand komut = new SqlCommand("select DoktorAd, DoktorSoyad From Tablo_Doktor1 Where DoktorBrans = @p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cmbBranş.Text);
            SqlDataReader da = komut.ExecuteReader();
            while (da.Read())
            {
                cmbDoktor.Items.Add(da[0] + " " + da[1]);
            }
            bgl.baglanti().Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tablo_Duyuru1 values (@d1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", richTextBox1.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Duyurunuz Eklenmiştir.");
        }

        private void btnBilgiDüzenle_Click(object sender, EventArgs e)
        {
            DoktorPanel1 frm = new DoktorPanel1();
            frm.Show();
        }

        private void BtnDuyurular_Click(object sender, EventArgs e)
        {
            Brans frm = new Brans();
            frm.Show();
        }

        private void BtnCıkıs_Click(object sender, EventArgs e)
        {
            RandevuListesi frm = new RandevuListesi();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Duyurular1 frm = new Duyurular1();
            frm.Show();
        }
    }
}
