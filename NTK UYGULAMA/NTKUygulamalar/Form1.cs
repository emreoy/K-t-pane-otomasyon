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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=192.168.16.73,1433;Initial Catalog=PersonelVeri;User ID=sa;Password=123");
        void temizle()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox2.Focus();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personelVeriDataSet1.tbl_personel' table. You can move, or remove it, as needed.
            this.tbl_personelTableAdapter1.Fill(this.personelVeriDataSet1.tbl_personel);
           
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.tbl_personelTableAdapter1.Fill(this.personelVeriDataSet1.tbl_personel);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into tbl_personel(Perad,Persoyad,Persehir,Permaas,Permeslek,Perdurum) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            komut.Parameters.AddWithValue("@p1",textBox2.Text);
            komut.Parameters.AddWithValue("@p2", textBox3.Text);
            komut.Parameters.AddWithValue("@p3", textBox4.Text);
            komut.Parameters.AddWithValue("@p4", textBox5.Text);
            komut.Parameters.AddWithValue("@p5", textBox6.Text);
            komut.Parameters.AddWithValue("@p6", label8.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt eklendi");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            { label8.Text = "True"; }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            label8.Text = "False";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            label8.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label8_TextChanged(object sender, EventArgs e)
        {
            if (label8.Text == "True")
            { radioButton1.Checked = true; }
            if (label8.Text == "False")
            { radioButton2.Checked = true; }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutsil = new SqlCommand("Delete from tbl_personel where Perid=@k1", baglanti);
            komutsil.Parameters.AddWithValue("@k1",textBox1.Text);
            komutsil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kaydınız Silindi");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutguncelle = new SqlCommand("Update tbl_personel set Perad=@a1,Persoyad=@a2,Persehir=@a3,Permaas=@a4,Perdurum=@a5,Permeslek=@a6 where Perid=@a7", baglanti);
            komutguncelle.Parameters.AddWithValue("@a1",textBox2.Text);
            komutguncelle.Parameters.AddWithValue("@a2", textBox3.Text);
            komutguncelle.Parameters.AddWithValue("@a3", textBox4.Text);
            komutguncelle.Parameters.AddWithValue("@a4", textBox5.Text);
            komutguncelle.Parameters.AddWithValue("@a5", label8.Text);
            komutguncelle.Parameters.AddWithValue("@a6", textBox6.Text);
            komutguncelle.Parameters.AddWithValue("@a7", textBox1.Text);
            komutguncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt güncellendi.");

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 fr =new Form2();
            fr.Show();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form3 fr2 = new Form3();
            fr2.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form5 fr5 = new Form5();
            fr5.Show();
        }

    
       }
}
