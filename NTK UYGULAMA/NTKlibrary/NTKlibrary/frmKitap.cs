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
    public partial class frmKitap : Form
    {
        public frmKitap()
        {
            InitializeComponent();
        }
        cFonksiyon fonk = new cFonksiyon();
        string imgLocation;
        private void pictureEdit2_Click(object sender, EventArgs e)
        {
            txtBARKODKITAP.Focus();
        }
        void ilkYukleme()
        {
            grpKITAP.Visible = false;
            btnYENIKITAP.Visible = true;
            fonk.kitap_kategoriDoldur(lookUpEditKATEGORI);
            fonk.kitap_yazarDoldur(lookUpEditYAZAR);
            temizle();
        }
        private void btnGOZAT_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "jpg files(*.jpg)|*.jpg|png files(*.png)|*.png|jpeg files(*.jpeg)|*.jpeg";
            if (dialog.ShowDialog()==DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                picRESIM.ImageLocation = imgLocation;
            }
        }
        private void frmKitap_Load(object sender, EventArgs e)
        {
            fonk.kitap_kategoriDoldur(lookUpEditKATEGORI);
            fonk.kitap_yazarDoldur(lookUpEditYAZAR);
            fonk.kitapListeleARA(listView1, lblSAYI,txtARA.Text.Trim());
            grpKITAP.Visible = false;
            ilkYukleme();
        }

        private void textEdit4_Click(object sender, EventArgs e)
        {
            txtBARKOD.Text = "";
        }

        private void textEdit4_Leave(object sender, EventArgs e)
        {
            //txtBARKOD.Text = "Barkodu buraya okutunuz...";
        }

        private void btnYENIKITAP_Click(object sender, EventArgs e)
        {
            fonk.kitap_kategoriDoldur(lookUpEditKATEGORI);
            fonk.kitap_yazarDoldur(lookUpEditYAZAR);
            ilkYukleme();
            grpKITAP.Visible = true;
            btnYENIKITAP.Visible = false;
            grpKITAP.Text = "Yeni Kitap Bilgileri EKLE";
            btnSIL.Visible = false;
            txtIsım.Focus();
        }
        void temizle()
        {
            txtACIKLAMA.Text = "";
            txtBAGISLAYAN.Text = "";
            txtBARKOD.Text = "";
            txtDEMIRBAS.Text = "";
            txtIsım.Text = "";
            picRESIM.Image = null;
            lblID.Text = "";
            txtYAYINEVI.Text = "";
            nSayfa.ResetText();
            nAdet.ResetText();
            lookUpEditKATEGORI.EditValue = null;
            lookUpEditYAZAR.EditValue = null;
        }

        private void btnIPTAL_Click(object sender, EventArgs e)
        {
            ilkYukleme();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            temizle();
            btnYENIKITAP.Visible = true;
            grpKITAP.Visible = true;
            btnSIL.Visible = true;
            grpKITAP.Text = "Kitap Bilgilerini GÜNCELLE";
            lblID.Text = listView1.SelectedItems[0].SubItems[4].Text;
            fonk.kitapGoster(lblID, txtIsım, lookUpEditYAZAR, lookUpEditKATEGORI, nSayfa, nAdet, txtBARKOD, txtBAGISLAYAN, txtDEMIRBAS, txtACIKLAMA,txtYAYINEVI,picRESIM);

        }

        private void btnKAYDET_Click(object sender, EventArgs e)
        {
            fonk.kitapKaydet(lblID, txtIsım, lookUpEditYAZAR, lookUpEditKATEGORI, nSayfa, nAdet, txtBARKOD, txtBAGISLAYAN, txtDEMIRBAS, txtACIKLAMA, txtYAYINEVI, picRESIM);
            fonk.kitapListeleARA(listView1, lblSAYI,"");
            ilkYukleme();
        }

        private void btnSIL_Click(object sender, EventArgs e)
        {
            //silme
            ilkYukleme();
        }

        private void txtARA_EditValueChanged(object sender, EventArgs e)
        {
            fonk.kitapListeleARA(listView1, lblSAYI, txtARA.Text.Trim());
        }

        private void txtBARKODKITAP_Click(object sender, EventArgs e)
        {
            txtBARKODKITAP.Text = "";
        }

        private void txtBARKODKITAP_Leave(object sender, EventArgs e)
        {
            txtBARKODKITAP.Text = "Buraya Kitap barkodu okutunuz...";
        }

        private void txtBARKODKITAP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)Keys.Enter)
            {
                if (txtBARKODKITAP.Text.Length == 13)
                {
                    int kid = fonk.KitapBarkodKontrol(txtBARKODKITAP.Text.Trim());
                    //veritabanından kitap sorgulayacağım.
                    if ( kid != 0)
                    {//kitap var
                        temizle();
                        btnYENIKITAP.Visible = true;
                        grpKITAP.Visible = true;
                        btnSIL.Visible = true;
                        grpKITAP.Text = "Kitap Bilgilerini GÜNCELLE";
                        fonk.kitapGosterBarkod(kid, txtIsım, lookUpEditYAZAR, lookUpEditKATEGORI, nSayfa, nAdet, txtBARKOD, txtBAGISLAYAN, txtDEMIRBAS, txtACIKLAMA, txtYAYINEVI, picRESIM);
                    }
                    else
                    {
                        MessageBox.Show("Bu Kitap Kütüphanede kayıtlı değildir.");
                    }
                }
                else
                {
                    MessageBox.Show("Doğru Borkodu okutunuz..");
                }
                txtBARKODKITAP.Text = "";
                txtBARKODKITAP.Focus();
            }
        }

        private void txtBARKOD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)Keys.Enter)
            {
                if (txtBARKOD.Text.Length==13)
                {
                    int kitapid;
                    kitapid = fonk.kitapBarkodVarYokKontrol(txtBARKOD.Text.Trim());
                    if (kitapid != 0)
                    {
                        if (MessageBox.Show(fonk.kitapIDdenKitapIsimGetir(kitapid)+"\n isimli kitap sisteme kayıtlıdır.\nKitap sayısını 1 arttırmak isterseniz EVET butonuna tıklayınız.\nHAYIR derseniz SADECE kitap bilgileri ekranınıza getirilecektir.","Kitap Bilgi Uyarı Sistemi",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
	                    {
                            fonk.kitapAdet1arttirma(kitapid);
                            fonk.kitapListeleARA(listView1, lblSAYI, "");
                            ilkYukleme();
	                    }
                        else
                        {
                            temizle();
                            btnYENIKITAP.Visible = true;
                            grpKITAP.Visible = true;
                            btnSIL.Visible = true;
                            grpKITAP.Text = "Kitap Bilgilerini GÜNCELLE";
                            lblID.Text = kitapid.ToString();
                            fonk.kitapGoster(lblID, txtIsım, lookUpEditYAZAR, lookUpEditKATEGORI, nSayfa, nAdet, txtBARKOD, txtBAGISLAYAN, txtDEMIRBAS, txtACIKLAMA, txtYAYINEVI, picRESIM);
                        }
                    }
                }
            }
        }






    }
}
