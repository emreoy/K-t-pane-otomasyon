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
    public partial class frmYazar : Form
    {
        public frmYazar()
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
        private void frmYazarEkleDuzenle_Load(object sender, EventArgs e)
        {
            ilkYukleme();
            fonk.yazarListele(listView1, lblSAYI);
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            btnEkle.Visible = false;
            groupBox1.Text = "YAZAR EKLE";
            btnSIL.Visible = false;
            txtIsım.Focus();
            btnKAYDET.Text = "EKLE";
        }
        private void btnIptal_Click(object sender, EventArgs e)
        {
            ilkYukleme();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            fonk.yazarKaydet(lblID, txtIsım);
            fonk.yazarListele(listView1, lblSAYI);
            ilkYukleme();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            btnEkle.Visible = true;
            groupBox1.Text = "YAZAR GÜNCELLE";
            lblID.Text = listView1.SelectedItems[0].SubItems[0].Text;
            txtIsım.Text = listView1.SelectedItems[0].SubItems[1].Text;
            btnSIL.Visible = true;
            btnKAYDET.Text = "GÜNCELLE";
        }
        private void btnSIL_Click(object sender, EventArgs e)
        {
            fonk.yazarSil(lblID, txtIsım);
            fonk.yazarListele(listView1, lblSAYI);
            ilkYukleme();
        }

        private void txtIsım_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)Keys.Enter)
            {
                btnKAYDET.PerformClick();
            }
        }
    }
}
