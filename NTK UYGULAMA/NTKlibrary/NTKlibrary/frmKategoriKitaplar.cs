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
    public partial class frmKategoriKitaplar : Form
    {
        public frmKategoriKitaplar()
        {
            InitializeComponent();
        }
        public string kategori;
        cAnaliz ana = new cAnaliz();
        private void frmKategoriKitaplar_Load(object sender, EventArgs e)
        {
            ana.KitapKategoriliGoster(listView1, label1, kategori);
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            frmKitapGoster frm = new frmKitapGoster();
            frm.kid = Convert.ToInt32(listView1.SelectedItems[0].SubItems[0].Text);
            frm.Show();
        }
    }
}
