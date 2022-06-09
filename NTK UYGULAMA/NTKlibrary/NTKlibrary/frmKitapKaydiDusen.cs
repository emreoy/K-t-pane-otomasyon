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
    public partial class frmKitapKaydiDusen : Form
    {
        public frmKitapKaydiDusen()
        {
            InitializeComponent();
        }
        cAnaliz ana = new cAnaliz();
        private void frmKitapKaydiDusen_Load(object sender, EventArgs e)
        {
            ana.kaydiDusenKitaplar(listView1,label1);
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            frmKitapGoster frm = new frmKitapGoster();
            frm.kid = Convert.ToInt32(listView1.SelectedItems[0].SubItems[0].Text);
            frm.Show();
        }
    }
}
