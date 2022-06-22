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
    public partial class HastaDetay1 : Form
    {
        public HastaDetay1()
        {
            InitializeComponent();
        }

        public string Tc;
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void HastaDetay1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'hastane_OtomasyonuDataSet.Tablo_Randevu' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tablo_RandevuTableAdapter.Fill(this.hastane_OtomasyonuDataSet.Tablo_Randevu);
            lblTc.Text = Tc;
            SqlCommand komut = new SqlCommand("Select HastaAd,HastaSoyad from Tablo_Hasta1 where HastaTc = @p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lblTc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblAd.Text = dr[0].ToString();
                lblSoyad.Text = dr[1].ToString();
            }
            bgl.baglanti().Close();


            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tablo_Randevu1 where HastaTc="+Tc,bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            SqlCommand komut1 = new SqlCommand(" Select BransAd From Tablo_Brans1",bgl.baglanti());
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                cmbBrans.Items.Add(dr1[0]);

            }
            bgl.baglanti().Close();

        }

        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoktor.Items.Clear();
            SqlCommand komut = new SqlCommand("Select DoktorAd,DoktorSoyad from Tablo_Doktor1 where DoktorBrans =@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cmbBrans.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbDoktor.Items.Add(dr[0] + " " + dr[1]);
            }
            bgl.baglanti().Close();
        }

        private void cmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tablo_Randevu1 where RandevuBrans='" + cmbBrans.Text + "'" + "and RandevuDoktor='" + cmbDoktor.Text + "'and RandevuDurum=0", bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BilgiGüncelleme1 frm = new BilgiGüncelleme1();
            frm.Tcno = lblTc.Text;
            frm.Show();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            txtİd.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand(" Update Tablo_Randevu1 set RandevuDurum=1, HastaTc=@p1, HastaSikayet=@p2 where Randevuİd=@p3", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lblTc.Text);
            komut.Parameters.AddWithValue("@p2", rchşikayetii.Text);
            komut.Parameters.AddWithValue("@p3", txtİd.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Randevunuz Kaydedilmiştir.", "Randevu Al", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
