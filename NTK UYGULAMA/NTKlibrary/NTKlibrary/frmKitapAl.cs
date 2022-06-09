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
    public partial class frmKitapAl : Form
    {
        public frmKitapAl()
        {
            InitializeComponent();
        }
        void basla()
        {
            grpOBILGI.Visible = false;
            grpOKART.Visible = true;
            grpKOKUT.Visible = false;
            grpKKITAP.Visible = false;
            grpTAMAMLA.Visible = false;
            txtOGRENCI.Text = ""; txtKitap.Text = "";
            txtOGRENCI.Focus();
            ogid = 0; kid = 0; gun = 0;
        }
        int ogid, kid, gun;
        private void frmKitapAl_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 31; i++)
            {
                comboBoxEdit1.Properties.Items.Add(i.ToString());
            }
            basla();
        }
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
                        if (fonk.ogrenciKitapTeslimKontrol(ogid))
                        {
                            MessageBox.Show(fonk.ogrenciIDdenIsimGetir(ogid) + " isimli ögrenci üzerinde\n" + fonk.ogrenciEmanetKitapIsimGetir(ogid)+ " isimli emanet kitap bulunmaktadır.\nKitabı Teslim edip, tekrardan deneyiniz.", "Emanet Kitap Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            kalip_ogrenci();
                        }
                        else
                        {//ogrenci sorunsuz geldi
                            grpOKART.Visible = false; grpOBILGI.Visible = true; grpKOKUT.Visible = true; txtKitap.Focus();
                            fonk.ogrenciBilgiGetirKitapAl(ogid, picRESIM, lblISIM, lblNO, lblSINIF, lblALAN, lblCINSIYET, lblCEP, txtADRES);

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

        private void txtKitap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtKitap.Text.Trim().Length == 13)
                {
                    kid = fonk.kitapBarkodAraIDgetir(txtKitap.Text.Trim());
                    txtKitap.Text = "";
                    if (kid != 0)
                    {//kitap var
                        if (fonk.kitapAdetKontrol(kid))
                        {//kitap getir
                            grpKOKUT.Visible = false; grpKKITAP.Visible = true; grpTAMAMLA.Visible = true;
                            fonk.kitapGosterKitapAL(kid, txtIsım, lookUpEditYAZAR, lookUpEditKATEGORI, nSayfa, nAdet, txtYAYINEVI, picKITAP);
                        }
                        else
                        {
                            MessageBox.Show("Bu Kitap kütüphaneye teslim edilmediği için gözükmemektedir.\nKitabın Teslimini sağlayıp, tekrardan deneyiniz.", "Teslim Edilmeyen Kitap Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            kalip_kitap();
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

        private void btnIptalKitap_Click(object sender, EventArgs e)
        {
            grpKOKUT.Visible = true; grpKKITAP.Visible = false; grpTAMAMLA.Visible = false; txtKitap.Focus();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            lblGUN.Text = "3 gün"; gun = 3; lblTeslimTarihi.Text = DateTime.Now.AddDays(gun).ToLongDateString(); 
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            lblGUN.Text = "5 gün"; gun = 5; lblTeslimTarihi.Text = DateTime.Now.AddDays(gun).ToLongDateString();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            lblGUN.Text = "7 gün"; gun = 7; lblTeslimTarihi.Text = DateTime.Now.AddDays(gun).ToLongDateString(); 
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            lblGUN.Text = "9 gün"; gun = 9; lblTeslimTarihi.Text = DateTime.Now.AddDays(gun).ToLongDateString();
        }
        private void simpleButton6_Click(object sender, EventArgs e)
        {
            lblGUN.Text = "12 gün"; gun = 12; lblTeslimTarihi.Text = DateTime.Now.AddDays(gun).ToLongDateString();
        }
        private void simpleButton5_Click(object sender, EventArgs e)
        {
            lblGUN.Text = "15 gün"; gun = 15; lblTeslimTarihi.Text = DateTime.Now.AddDays(gun).ToLongDateString();
        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxEdit1.Text != "")
            {
                lblGUN.Text = comboBoxEdit1.Text + " gün"; gun = Convert.ToInt32(comboBoxEdit1.Text); lblTeslimTarihi.Text = DateTime.Now.AddDays(gun).ToLongDateString();
            }
        }

        private void btnTAMAM_Click(object sender, EventArgs e)
        {
            if (gun != 0)
            {
                if (fonk.haftaninGunu(gun) != 6 && fonk.haftaninGunu(gun) != 7 ) 
                {
                    if (MessageBox.Show(lblISIM.Text + " isimli öğrenci,\n " + txtIsım.Text + "adlı kitabı,\n" + gun.ToString() + " gün ödünç almak işlemini onaylıyor musunuz?", "Kitap Alma İşlemini Tamamlama", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (fonk.kitapAlTamamla(ogid, kid, gun))
                        {
                            MessageBox.Show("Kitap Alma işlemi Başarılıdır.\n" + DateTime.Now.AddDays(gun).ToLongDateString() + " günü kitabı teslim ediniz.", "Kitap Al Tamamla", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            basla();
                        }
                        else
                        {
                            MessageBox.Show("Kitap Alma işlemi Başarısızdır.\nLütfen tekrar deneyiniz.", "Kitap Al Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            basla();
                        }
                    }
                }
                else
                {
                    MessageBox.Show(DateTime.Now.AddDays(gun).ToLongDateString() + " günü\nhafta sonuna geldiği için lütfen başka bir gün seçiniz ?", "Kitap Al Hatası", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Lütfen ödünç günü seçiniz!", "Kitap Al Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
