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

namespace NTKlibrary
{
    public partial class frmKategori : Form
    {
        public frmKategori()
        {
            InitializeComponent();
        }
        cConnection bgl = new cConnection();
        cFonksiyon fonk = new cFonksiyon();
        void ilkYukleme()
        {
            groupBox1.Visible = false;
            btnEkle.Visible = true;
            txtIsım.Text = "";
            lblID.Text = "";
        }

        private void frmKategoriEkleDuzenle_Load(object sender, EventArgs e)
        {
            ilkYukleme();
            fonk.kategoriListele(listView1,lblSAYI);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            btnEkle.Visible = false;
            groupBox1.Text = "Kitap Kategorisi EKLE";
            btnSIL.Visible=false;
            txtIsım.Focus();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            ilkYukleme();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            fonk.kategoriKaydet(lblID, txtIsım);
            fonk.kategoriListele(listView1, lblSAYI);
            ilkYukleme();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            btnEkle.Visible = true;
            groupBox1.Text = "Kitap Kategorisi GÜNCELLE";
            lblID.Text = listView1.SelectedItems[0].SubItems[0].Text;
            txtIsım.Text = listView1.SelectedItems[0].SubItems[1].Text;
            btnSIL.Visible = true;
        }

        private void btnSIL_Click(object sender, EventArgs e)
        {
            fonk.kategoriSil(lblID, txtIsım);
            fonk.kategoriListele(listView1, lblSAYI);
            ilkYukleme();
        }

        private void txtIsım_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)Keys.Enter)
            {
                btnKAYDET.PerformClick();
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //private void listView1_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (e.KeyChar==(char)Keys.Delete)
        //    {
        //        if (MessageBox.Show(listView1.SelectedItems[0].SubItems[1].Text + " isimli Kategoriyi\nSilmek istiyor musunuz ?", "KATEGORI SİLME", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        //        {
        //            try
        //            {
        //                SqlCommand komut = new SqlCommand("DELETE FROM K_KATEGORI WHERE ID=@p1", bgl.connection());
        //                komut.Parameters.AddWithValue("@p1", listView1.SelectedItems[0].SubItems[0].Text);
        //                komut.ExecuteNonQuery();
        //                kapat();
        //                ilkYukleme();
        //                listele(listView1);
        //            }
        //            catch (Exception hata)
        //            {
        //                MessageBox.Show("Verileri kontrol edip\nTekrar deneyiniz.\nHata: " + hata.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            }
        //        }
        //    }
        //}
    }
}
