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

namespace uygulamalar1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=192.168.16.73,1433;Initial Catalog=PersonelVeri;User ID=sa;Password=123");
        private void Form3_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutg1 = new SqlCommand("select Persehir,count(*) from tbl_personel group by Persehir", baglanti);
            SqlDataReader dr1 = komutg1.ExecuteReader();
            while (dr1.Read())
            {
                chart1.Series["Sehirler"].Points.AddXY(dr1[0], dr1[1]);
            }

            baglanti.Close();
            baglanti.Open();
            SqlCommand komutg2 = new SqlCommand("select Permeslek,sum(Permaas) from tbl_personel group by Permeslek", baglanti);
            SqlDataReader dr2 = komutg2.ExecuteReader();
            while (dr2.Read())
            {
                chart2.Series["Meslek_Maas"].Points.AddXY(dr2[0], dr2[1]);
            }

            baglanti.Close();
        }
    }
}
