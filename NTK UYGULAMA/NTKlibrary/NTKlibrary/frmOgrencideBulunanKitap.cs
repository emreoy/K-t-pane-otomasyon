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
    public partial class frmOgrencideBulunanKitap : Form
    {
        public frmOgrencideBulunanKitap()
        {
            InitializeComponent();
        }
        cAnaliz ana = new cAnaliz();
        private void frmOgrencideBulunanKitap_Load(object sender, EventArgs e)
        {
            ana.ogrencideBulunanKitap(listView1, label1);
            label2.Text = "Bugün: " + DateTime.Now.ToLongDateString();
        }
    }
}
