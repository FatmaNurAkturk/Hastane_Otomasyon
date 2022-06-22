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
    public partial class DoktorDetay : Form
    {
        public DoktorDetay()
        {
            InitializeComponent();
        }
        public String tc;

        sqlbaglantisi bgl = new sqlbaglantisi();
        private void DoktorDetay_Load(object sender, EventArgs e)
        {
            
            lblTc.Text = tc;
            SqlCommand komut = new SqlCommand("Select DoktorAd,DoktorSoyad From Tablo_Doktor where DoktorTc = @p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lblTc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                lblAd.Text = dr[0].ToString();
                lblSoyad.Text = dr[1].ToString();
            }
            bgl.baglanti().Close();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tablo_Randevu where RandevuDoktor='"+lblTc.Text+"'" , bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnBilgiDüzenle_Click(object sender, EventArgs e)
        {
            DoktorBilgiDüzenle frm = new DoktorBilgiDüzenle();
            frm.Tcno = lblTc.Text;
            frm.Show();
        }

        private void BtnDuyurular_Click(object sender, EventArgs e)
        {
            Duyurular frm = new Duyurular();
            frm.Show();
        }

        private void BtnCıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            rchşikayet.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
