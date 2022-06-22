using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_Otomasyon
{
    public partial class DevletHastaneGiriş : Form
    {
        public DevletHastaneGiriş()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HastaGirişii frm = new HastaGirişii();
            frm.Show();
            this.Hide();
        }

        private void btnDoktorGiris_Click(object sender, EventArgs e)
        {
            DoktorGirişi frm = new DoktorGirişi();
            frm.Show();
            this.Hide();
        }

        private void btnAsistanGiris_Click(object sender, EventArgs e)
        {
            AsistanGiriş frm = new AsistanGiriş();
            frm.Show();
            this.Hide();
        }

        private void DevletHastaneGiriş_Load(object sender, EventArgs e)
        {
           /* HastaGirişii frm = new HastaGirişii();
            frm.Show();
            this.Hide();*/
        }
    }
}
