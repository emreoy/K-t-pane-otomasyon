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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=192.168.16.73,1433;Initial Catalog=PersonelVeri;User ID=sa;Password=123");

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from tbl_yonetici where kullanici=@p1 and sifre=@p2",baglanti);
            komut.Parameters.AddWithValue("@p1",textBox1.Text);
            komut.Parameters.AddWithValue("@p2",textBox2.Text);
            SqlDataReader dr=komut.ExecuteReader();
            if (dr.Read())
	{
		 Form1 frm = new Form1();
         frm.Show();
         this.Hide();
	}
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı Ya Da Şifre");
            }
            baglanti.Close();

        }
    }
}
