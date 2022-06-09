using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTKlibrary
{
    public partial class frmKategoriEkleDuzenle : Form
    {
        public frmKategoriEkleDuzenle()
        {
            InitializeComponent();
        }
        void ilkYukleme()
        {
            groupBox1.Visible = false;
            btnEkle.Visible = true;
            txtIsım.Clear();
            lblID.Text = "";
        }
        private void frmKategoriEkleDuzenle_Load(object sender, EventArgs e)
        {
            ilkYukleme();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            btnEkle.Visible = false;
            groupBox1.Text = "Kitap Kategorisi EKLE";
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            ilkYukleme();
        }
    }
}
