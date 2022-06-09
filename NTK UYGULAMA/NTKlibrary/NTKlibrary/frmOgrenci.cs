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
    public partial class frmOgrenci : Form
    {
        public frmOgrenci()
        {
            InitializeComponent();
        }
        cFonksiyon fonk = new cFonksiyon();
        private void frmOgrenci_Load(object sender, EventArgs e)
        {
            fonk.ogrenciListeleARA(listView1, txtARA.Text.Trim(), lblSAYI);
            groupControl1.Visible = false;
            txtKARTID.Focus();
        }

        private void txtARA_EditValueChanged(object sender, EventArgs e)
        {
            fonk.ogrenciListeleARA(listView1, txtARA.Text.Trim(), lblSAYI);
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            groupControl1.Text = listView1.SelectedItems[0].SubItems[1].Text + " - öğrenci bilgileri";
            groupControl1.Visible = true;
            fonk.ogrenciBilgiGetir(Convert.ToInt32(listView1.SelectedItems[0].SubItems[4].Text), picRESIM, lblISIM, lblNO, lblSINIF, lblALAN, lblCINSIYET, lblTELANNE, lblTELBABA, lblCEP, txtADRES, grbANNE, grbBABA);
        }

        private void pictureEdit2_Click(object sender, EventArgs e)
        {
            txtKARTID.Focus();
        }

        private void txtKARTID_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtKARTID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtKARTID.Text.Length == 10)
            {
                fonk.ogrenciBilgiGetirRFID(txtKARTID, picRESIM, lblISIM, lblNO, lblSINIF, lblALAN, lblCINSIYET, lblTELANNE, lblTELBABA, lblCEP, txtADRES, grbANNE, grbBABA);
                groupControl1.Visible = true;
                txtKARTID.Text = "";
                txtKARTID.Focus();
            }
        }
        
    }
}
