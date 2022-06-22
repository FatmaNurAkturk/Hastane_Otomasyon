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
    public partial class DoktorDetay1 : Form
    {
        public DoktorDetay1()
        {
            InitializeComponent();
        }

        public string tcno;
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void DoktorDetay1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'hastane_OtomasyonuDataSet.Tablo_Randevu' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tablo_RandevuTableAdapter.Fill(this.hastane_OtomasyonuDataSet.Tablo_Randevu);
            lblTc.Text = tcno;
            SqlCommand komut = new SqlCommand("Select DoktorAd,DoktorSoyad From Tablo_Doktor1 where DoktorTc = @p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lblTc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblAd.Text = dr[0].ToString();
                lblSoyad.Text = dr[1].ToString();
            }
            bgl.baglanti().Close();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tablo_Randevu1 where RandevuDoktor='" + lblTc.Text + "'", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnBilgiDüzenle_Click(object sender, EventArgs e)
        {
            DoktorBilgiDüzenle1 frm = new DoktorBilgiDüzenle1();
            frm.tcno1 = lblTc.Text;
            frm.Show();
        }

        private void BtnDuyurular_Click(object sender, EventArgs e)
        {
            Duyurular1 frm = new Duyurular1();
            frm.Show();
        }

        private void BtnCıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            rchşikayet.Text = dataGridView1.Rows[secilen].Cells[10].Value.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            rchşikayet.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }
    }
}
