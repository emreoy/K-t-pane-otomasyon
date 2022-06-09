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
    public partial class frmAnaEkran : Form
    {
        public frmAnaEkran()
        {
            InitializeComponent();
        }
        frmKategori frm;
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm==null || frm.IsDisposed)
            {
                frm = new frmKategori();
                frm.MdiParent = this;
                frm.Show();
            }
        }
        frmYazar frm1;
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm1 == null || frm1.IsDisposed)
            {
                frm1 = new frmYazar();
                frm1.MdiParent = this;
                frm1.Show();
            }
        }
        frmKitap frm2;
        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm2==null || frm2.IsDisposed)
            {
                frm2 = new frmKitap();
                frm2.MdiParent = this;
                frm2.Show();
            }
        }
        frmOgrenci frm3;
        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm3 == null || frm3.IsDisposed)
            {
                frm3 = new frmOgrenci();
                frm3.MdiParent = this;
                frm3.Show();
            }
        }
        frmKitapAl frm4;
        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm4 == null || frm4.IsDisposed)
            {
                frm4 = new frmKitapAl();
                frm4.MdiParent = this;
                frm4.Show();
            }
        }
        frmKitapVer frm5;
        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm5 == null || frm5.IsDisposed)
            {
                frm5 = new frmKitapVer();
                frm5.MdiParent = this;
                frm5.Show();
            }
        }
        frmAnaSayfa frm6;
        private void frmAnaEkran_Load(object sender, EventArgs e)
        {
            if (frm6 == null || frm6.IsDisposed)
            {
                frm6 = new frmAnaSayfa();
                frm6.MdiParent = this;
                frm6.Show();
            }
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm6 == null || frm6.IsDisposed)
            {
                frm6 = new frmAnaSayfa();
                frm6.MdiParent = this;
                frm6.Show();
            }
        }
        frmKategoriKitapSayi frm7;
        private void barButtonItem19_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm7 == null || frm7.IsDisposed)
            {
                frm7 = new frmKategoriKitapSayi();
                frm7.MdiParent = this;
                frm7.Show();
            }
        }
        frmKitapKaydiDusen frm8;
        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm8 == null || frm8.IsDisposed)
            {
                frm8 = new frmKitapKaydiDusen();
                frm8.MdiParent = this;
                frm8.Show();
            }
        }
        frmTeslimiGecikenKitaplar frm9;
        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm9 == null || frm9.IsDisposed)
            {
                frm9 = new frmTeslimiGecikenKitaplar();
                frm9.MdiParent = this;
                frm9.Show();
            }
        }
        frmOgrencideBulunanKitap frm10;
        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm10 == null || frm10.IsDisposed)
            {
                frm10 = new frmOgrencideBulunanKitap();
                frm10.MdiParent = this;
                frm10.Show();
            }
        }

      
    }
}
