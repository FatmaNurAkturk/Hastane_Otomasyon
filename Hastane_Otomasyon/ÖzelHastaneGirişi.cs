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
    public partial class ÖzelHastaneGirişi : Form
    {
        public ÖzelHastaneGirişi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HastaGiriş1 fr = new HastaGiriş1();
            fr.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DoktorGiris1 fr = new DoktorGiris1();
            fr.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AsistanGiriş1 fr = new AsistanGiriş1();
            fr.Show();
            this.Hide();
        }
    }
}
