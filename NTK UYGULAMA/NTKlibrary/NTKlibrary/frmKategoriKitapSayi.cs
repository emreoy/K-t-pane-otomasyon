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
    public partial class frmKategoriKitapSayi : Form
    {
        public frmKategoriKitapSayi()
        {
            InitializeComponent();
        }
        cAnaliz ana = new cAnaliz();
        private void frmKategoriKitapSayi_Load(object sender, EventArgs e)
        {
            ana.kategoriKitaSayisiListeleme(listView1);
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            frmKategoriKitaplar frm = new frmKategoriKitaplar();
            frm.kategori = listView1.SelectedItems[0].SubItems[0].Text;
            frm.Show();
        }
    }
}
