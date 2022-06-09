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
    public partial class frmKitapGoster : Form
    {
        public frmKitapGoster()
        {
            InitializeComponent();
        }
        public int kid;
        cFonksiyon fonk = new cFonksiyon();
        private void frmKitapGoster_Load(object sender, EventArgs e)
        {
            fonk.kitap_kategoriDoldur(lookUpEditKATEGORI);
            fonk.kitap_yazarDoldur(lookUpEditYAZAR);
            lblID.Text = kid.ToString();
            fonk.kitapGoster(lblID, txtIsım, lookUpEditYAZAR, lookUpEditKATEGORI, nSayfa, nAdet, txtBARKOD, txtBAGISLAYAN, txtDEMIRBAS, txtACIKLAMA, txtYAYINEVI, picRESIM);
        }
    }
}
