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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=192.168.16.73,1433;Initial Catalog=PersonelVeri;User ID=sa;Password=123");
        private void Form2_Load(object sender, EventArgs e)
        {//toplam kayıt sayısı
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select count(*) from tbl_personel", baglanti);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                label7.Text = dr1[0].ToString();
            }
            baglanti.Close();
            //evli sayısı
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select count(*) from tbl_personel where Perdurum=1", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                label8.Text = dr2[0].ToString();
            }
            baglanti.Close();
            //bekar sayısı
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select count(*) from tbl_personel where Perdurum=0", baglanti);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                label9.Text = dr3[0].ToString();
            }
            baglanti.Close();
            // Şehir sayısı
             baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select count(distinct(Persehir)) from tbl_personel", baglanti);
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                label10.Text = dr4[0].ToString();
            }
            baglanti.Close();
            // toplam Maaş sayısı
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("select sum(Permaas) from tbl_personel", baglanti);
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                label11.Text = dr5[0].ToString();
            }
            baglanti.Close();
            // Ortalama Maaş sayısı
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select avg(Permaas) from tbl_personel", baglanti);
            SqlDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            {
                label12.Text = dr6[0].ToString();
            }
            baglanti.Close();

        }
    }
}
