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
    public partial class frmKitapVer : Form
    {
        public frmKitapVer()
        {
            InitializeComponent();
        }
        void basla()
        {
            lblBilgi.Visible = false;
            grpOBILGI.Visible = false;
            grpOKART.Visible = true;
            grpKOKUT.Visible = false;
            grpKKITAP.Visible = false;
            grpEMANET.Visible = false;
            txtOGRENCI.Text = ""; txtKitap.Text = "";
            txtOGRENCI.Focus();
            ogid = 0; kid = 0; gun = 0; okid = 0; khid = 0;
        }
        int ogid, kid, gun, okid , khid;
        cFonksiyon fonk = new cFonksiyon();
        void kalip_ogrenci()
        {
            txtOGRENCI.Text = "";
            txtOGRENCI.Focus();
        }
        void kalip_kitap()
        {
            txtKitap.Text = "";
            txtKitap.Focus();
        }
        private void frmKitapVer_Load(object sender, EventArgs e)
        {
            basla();
        }

        private void txtOGRENCI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtOGRENCI.Text.Trim().Length == 10)
                {
                    int kartid = Convert.ToInt32(txtOGRENCI.Text.Trim());
                    txtOGRENCI.Text = "";
                    string ogrenci = kartid.ToString();
                    //OGRENCİ ARAMA YAPACAĞIZ
                    ogid = fonk.ogrenciKartAraIDgetir(ogrenci);
                    if (ogid != 0)
                    {//ogrenci var
                        khid = fonk.ogrenciAktifKitapKontrol(ogid);
                        if ( khid == 0 )
                        {
                            MessageBox.Show(fonk.ogrenciIDdenIsimGetir(ogid) + "\nüzerinize Herhangi bir Kitap bulunmamaktadır.\nKitap Almak istiyorsanız Formu açınız.", "Aktif Kitap Yok Durumu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            kalip_ogrenci();
                        }
                        else
                        {//ogrenci sorunsuz geldi

                            grpOKART.Visible = false; grpOBILGI.Visible = true; grpKOKUT.Visible = true; grpKKITAP.Visible = true; grpEMANET.Visible = true; lblBilgi.Visible = true; txtKitap.Focus();
                            fonk.ogrenciBilgiGetirKitapAl(ogid, picRESIM, lblISIM, lblNO, lblSINIF, lblALAN, lblCINSIYET, lblCEP, txtADRES);
                            kid = fonk.kitapHarekettenKitapIDgetir(khid);
                            fonk.kitapGosterKitapAL(kid, txtIsım, lookUpEditYAZAR, lookUpEditKATEGORI, nSayfa, nAdet, txtYAYINEVI, picKITAP);
                            fonk.kitapHareketTatihGetir(khid, lblKitapAlTarih, lblKitapGunSayisi, lblKitapTeslimTarih);

                        }
                    }
                    else
                    {//ogrenci yok
                        MessageBox.Show("Bu kart sistemde kayıtlı değildir.\nOkul idaresine danışınız.", "Tanımsız Kart", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        kalip_ogrenci();
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen Ögrenci kartı okutunuz.", "Kart Okuma Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    kalip_ogrenci();
                }
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            basla();
        }

        private void btnIptalKitap_Click(object sender, EventArgs e)
        {
            basla();
        }

        private void txtKitap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtKitap.Text.Trim().Length == 13)
                {
                    okid = fonk.kitapBarkodAraIDgetir(txtKitap.Text.Trim());
                    txtKitap.Text = "";
                    if (okid != 0)
                    {//kitap var
                        if (kid==okid)
                        {
                            fonk.kitapTeslimTamamlama(kid, khid);
                            MessageBox.Show(txtIsım.Text+" adlı ögrencinin\n"+lblISIM.Text+"kitabı\nTeslimi Gerçekleştirilmiştir.", "Kitap Teslimi Tamamla", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            basla();

                        }
                        else
                        {
                            txtKitap.Text = "";
                            MessageBox.Show("Teslim edeceğiniz\n"+txtIsım.Text+ "  isimli kitabın\nBarkodunu okutunuz.","Yanlış Kitap Barkodu Okutma Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtKitap.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bu Kitap sistemde kayıtlı değildir.\nOkul idaresine danışınız.", "Kitap Okuma Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        kalip_kitap();
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen kitap barkodu okutunuz.", "Kitap Okuma Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    kalip_kitap();
                }
            }
        }
    }
}
