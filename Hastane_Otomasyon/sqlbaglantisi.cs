using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System .Data.SqlClient;

namespace Hastane_Otomasyon
{
    internal class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=LAPTOP-5DLF7RK0\\SQLEXPRESS;Initial Catalog=Hastane Otomasyonu;Integrated Security=True");
            baglan.Open();
            return baglan;
        }

    }
}
