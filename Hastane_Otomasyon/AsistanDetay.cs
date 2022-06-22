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
    public partial class AsistanDetay : Form
    {
        public AsistanDetay()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        public string TcNo;
        private void AsistanDetay_Load(object sender, EventArgs e)
        {

            lblTcsi.Text = TcNo;
            SqlCommand komut = new SqlCommand("Select AsistanAd , AsistanSoyad From Tablo_Asistan where AsistanTc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lblTcsi.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblAdd.Text = dr[0].ToString();
                lblSoyad.Text = dr[1].ToString();
            }
            bgl.baglanti().Close();


            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tablo_Brans",bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            DataTable dt1=new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("select (DoktorAd + ' ' + DoktorSoyad) as 'Doktor', DoktorBrans From Tablo_Doktor", bgl.baglanti());
            da1.Fill(dt1);
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
            SqlCommand komutkaydet = new SqlCommand("insert into Tablo_Randevu(RandevuTarih, RandevuSaat, RandevuBrans, RandevuDoktor) values (@p1, @p2, @p3, @p4)", bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@p1", mskTarih.Text);
            komutkaydet.Parameters.AddWithValue("@p2", mskSaat.Text);
            komutkaydet.Parameters.AddWithValue("@p3", cmbBranş.Text);
            komutkaydet.Parameters.AddWithValue("@p4",cmbDoktor.Text);
            komutkaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevunuz Oluşturulmuştur");


        }

        private void cmbBranş_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoktor.Items.Clear();
            SqlCommand komut = new SqlCommand("select DoktorAd, DoktorSoyad From Tablo_Doktor Where DoktorBrans = @p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cmbBranş.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbDoktor.Items.Add(dr[0] + " " + dr[1]);
            }
            bgl.baglanti().Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tablo_Duyuru values (@d1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", richTextBox1.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Duyurunuz Eklenmiştir.");

        }

        private void btnBilgiDüzenle_Click(object sender, EventArgs e)
        {
            DoktorPaneli drp = new DoktorPaneli();
            drp.Show();

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
            Duyurular frm = new Duyurular();
            frm.Show();
        }
    }
      
}
