using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
using System.Drawing;

namespace NTKlibrary
{
    class cFonksiyon
    {
        cConnection bgl = new cConnection();
        void kapat()
        {
            bgl.connection().Dispose();
            bgl.connection().Close();
        }
        public byte[] pictureByteCevirme(PictureBox pictur)
        {
            byte[] pic = null;
            MemoryStream stream = new MemoryStream();
            pictur.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
            return pic = stream.ToArray();

        }
        public void kategoriListele(ListView liste, LabelControl lbl)
        {
            liste.Items.Clear();
            SqlCommand komut = new SqlCommand("SELECT * FROM K_KATEGORI ORDER BY ISIM ASC", bgl.connection());
            SqlDataReader dr = komut.ExecuteReader();
            int sayac = 0;
            while (dr.Read())
            {
                liste.Items.Add(dr["ID"].ToString());
                liste.Items[sayac].SubItems.Add(dr["ISIM"].ToString());
                sayac++;
            }
            lbl.Text = liste.Items.Count.ToString() + " adet kayıt vardır.";
            dr.Close();
            kapat();
        }
        public void kategoriKaydet(LabelControl lid, TextEdit tisim)
        {
            if (lid.Text != "")
            {
                try
                {
                    SqlCommand komut = new SqlCommand("UPDATE K_KATEGORI SET ISIM=@p1 WHERE ID=@p2", bgl.connection());
                    komut.Parameters.AddWithValue("@p1", tisim.Text);
                    komut.Parameters.AddWithValue("@p2", lid.Text);
                    komut.ExecuteNonQuery();
                    kapat();
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Verileri kontrol edip\nTekrar deneyiniz.\nHata: " + hata.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    SqlCommand komut = new SqlCommand("INSERT INTO K_KATEGORI VALUES(@p1)", bgl.connection());
                    komut.Parameters.AddWithValue("@p1", tisim.Text);
                    komut.ExecuteNonQuery();
                    kapat();
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Verileri kontrol edip\nTekrar deneyiniz.\nHata: " + hata.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void kategoriSil(LabelControl lid, TextEdit tisim)
        {
            if (MessageBox.Show(tisim.Text + " isimli Kategoriyi\nSilmek istiyor musunuz ?", "KATEGORI SİLME", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    SqlCommand komut = new SqlCommand("DELETE FROM K_KATEGORI WHERE ID=@p1", bgl.connection());
                    komut.Parameters.AddWithValue("@p1", lid.Text);
                    komut.ExecuteNonQuery();
                    kapat();
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Verileri kontrol edip\nTekrar deneyiniz.\nHata: " + hata.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void yazarListele(ListView liste, LabelControl lbl)
        {
            liste.Items.Clear();
            SqlCommand komut = new SqlCommand("SELECT Oyunlar.Isim AS Oyunİsmi, Oyunlar.Yapımcı AS Yapımcıİsmi, Oyunlar.Katagöri AS Katagöriİsim, Oyunlar.Adet, Oyunlar.ID AS KitapID FROM Oyunlar WHERE Oyunlar.Isim LIKE '%" + metin + "%' OR Oyunlar.Yapımcı LIKE '%" + metin + "%' OR Oyunlar.Katagöri LIKE '%" + metin + "%' OR Oyunlar.Katagöri LIKE '%" + metin + "%' OR Oyunlar.platformlar LIKE '%" + metin + "%' ORDER BY Oyunlar.Isim ASC", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            int sayac = 0;
            while (dr.Read())
            {
                liste.Items.Add(dr["Oyunİsmi"].ToString());
                liste.Items[sayac].SubItems.Add(dr["Yapımcıİsmi"].ToString());
                liste.Items[sayac].SubItems.Add(dr["Katagöriİsim"].ToString());
                liste.Items[sayac].SubItems.Add(dr["Adet"].ToString());
                liste.Items[sayac].SubItems.Add(dr["KitapID"].ToString());
                sayac++;
            }
            lbl.Text = liste.Items.Count.ToString() + " adet kayıt vardır.";
            dr.Close();
        }
        public void yazarKaydet(LabelControl lid, TextEdit tisim)
        {
            if (lid.Text != "")
            {
                try
                {
                    SqlCommand komut = new SqlCommand("UPDATE K_YAZAR SET ISIM=@p1 WHERE ID=@p2", bgl.connection());
                    komut.Parameters.AddWithValue("@p1", tisim.Text);
                    komut.Parameters.AddWithValue("@p2", lid.Text);
                    komut.ExecuteNonQuery();
                    kapat();
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Verileri kontrol edip\nTekrar deneyiniz.\nHata: " + hata.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    SqlCommand komut = new SqlCommand("INSERT INTO K_YAZAR VALUES(@p1)", bgl.connection());
                    komut.Parameters.AddWithValue("@p1", tisim.Text);
                    komut.ExecuteNonQuery();
                    kapat();
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Verileri kontrol edip\nTekrar deneyiniz.\nHata: " + hata.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void yazarSil(LabelControl lid, TextEdit tisim)
        {
            if (MessageBox.Show(tisim.Text + " isimli Yazarı\nSilmek istiyor musunuz ?", "YAZAR SİLME", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    SqlCommand komut = new SqlCommand("DELETE FROM K_YAZAR WHERE ID=@p1", bgl.connection());
                    komut.Parameters.AddWithValue("@p1", lid.Text);
                    komut.ExecuteNonQuery();
                    kapat();
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Verileri kontrol edip\nTekrar deneyiniz.\nHata: " + hata.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void ogrenciListeleARA(ListView liste, string arama, LabelControl lbl)
        {
            liste.Items.Clear();
            SqlCommand komut = new SqlCommand("SELECT OGRENCI.OGRENCINO, OGRENCI.ISIM, SINIF.SINIF, ALAN.ALAN, OGRENCI.ID FROM ALAN INNER JOIN SINIF ON ALAN.ID = SINIF.ALAN INNER JOIN OGRENCI ON SINIF.ID = OGRENCI.SINIF WHERE OGRENCI.DURUM=0 AND (OGRENCI.OGRENCINO LIKE '%" + arama + "%' OR OGRENCI.ISIM LIKE '%" + arama + "%' OR SINIF.SINIF LIKE '%" + arama + "%' OR ALAN.ALAN LIKE '%" + arama + "%') ORDER BY SINIF.SINIF,OGRENCI.OGRENCINO", bgl.connection());
            SqlDataReader dr = komut.ExecuteReader();
            int sayac = 0;
            while (dr.Read())
            {
                liste.Items.Add(dr["OGRENCINO"].ToString());
                liste.Items[sayac].SubItems.Add(dr["ISIM"].ToString());
                liste.Items[sayac].SubItems.Add(dr["SINIF"].ToString());
                liste.Items[sayac].SubItems.Add(dr["ALAN"].ToString());
                liste.Items[sayac].SubItems.Add(dr["ID"].ToString());
                sayac++;
            }
            lbl.Text = liste.Items.Count.ToString() + " ögrenci listelenmiştir.";
            dr.Close();
            kapat();
        }
        public void ogrenciBilgiGetir(int id, PictureEdit pic, LabelControl lisim, LabelControl lno, LabelControl lsinif, LabelControl lalan, LabelControl lcins, LabelControl ltelanne, LabelControl ltelbaba, LabelControl lcep, RichTextBox tadres, GroupControl ganne, GroupControl gbaba)
        {
            SqlCommand komut = new SqlCommand("SELECT ALAN.ALAN AS ALANISIM,SINIF.SINIF AS SINIFISIM,* FROM ALAN INNER JOIN SINIF ON ALAN.ID = SINIF.ALAN INNER JOIN OGRENCI ON SINIF.ID = OGRENCI.SINIF WHERE OGRENCI.ID=@P1", bgl.connection());
            komut.Parameters.AddWithValue("@P1", id);
            SqlDataReader dr = komut.ExecuteReader();
            byte[] myData = new byte[0];
            while (dr.Read())
            {
                if (dr["RESIM_G"].ToString() != "")
                {
                    myData = (byte[])dr["RESIM_G"];
                    MemoryStream stream = new MemoryStream(myData);
                    pic.Image = Image.FromStream(stream);
                }
                lisim.Text = dr["ISIM"].ToString();
                lno.Text = dr["OGRENCINO"].ToString();
                lsinif.Text = dr["SINIFISIM"].ToString();
                lalan.Text = dr["ALANISIM"].ToString();
                if (Convert.ToBoolean(dr["CINSIYET"]))
                {
                    lcins.Text = "Erkek";
                }
                else
                {
                    lcins.Text = "Kız";
                }
                ganne.Text = dr["ANNE"].ToString();
                gbaba.Text = dr["BABA"].ToString();
                ltelanne.Text = dr["ANNETEL"].ToString();
                ltelbaba.Text = dr["BABATEL"].ToString();
                lcep.Text = dr["CEP"].ToString();
                tadres.Text = dr["ADRES"].ToString();
            }
            dr.Close();
            kapat();
        }
        public void ogrenciBilgiGetirRFID(TextEdit txtID, PictureEdit pic, LabelControl lisim, LabelControl lno, LabelControl lsinif, LabelControl lalan, LabelControl lcins, LabelControl ltelanne, LabelControl ltelbaba, LabelControl lcep, RichTextBox tadres, GroupControl ganne, GroupControl gbaba)
        {
            SqlCommand komut = new SqlCommand("SELECT ALAN.ALAN AS ALANISIM,SINIF.SINIF AS SINIFISIM,* FROM ALAN INNER JOIN SINIF ON ALAN.ID = SINIF.ALAN INNER JOIN OGRENCI ON SINIF.ID = OGRENCI.SINIF WHERE OGRENCI.KARTNO=@P1", bgl.connection());
            int id = Convert.ToInt32(txtID.Text);
            string metinID = id.ToString();
            komut.Parameters.AddWithValue("@P1", metinID);
            SqlDataReader dr = komut.ExecuteReader();
            byte[] myData = new byte[0];
            while (dr.Read())
            {
                if (dr["RESIM_G"].ToString() != "")
                {
                    myData = (byte[])dr["RESIM_G"];
                    MemoryStream stream = new MemoryStream(myData);
                    pic.Image = Image.FromStream(stream);
                }
                lisim.Text = dr["ISIM"].ToString();
                lno.Text = dr["OGRENCINO"].ToString();
                lsinif.Text = dr["SINIFISIM"].ToString();
                lalan.Text = dr["ALANISIM"].ToString();
                if (Convert.ToBoolean(dr["CINSIYET"]))
                {
                    lcins.Text = "Erkek";
                }
                else
                {
                    lcins.Text = "Kız";
                }
                ganne.Text = dr["ANNE"].ToString();
                gbaba.Text = dr["BABA"].ToString();
                ltelanne.Text = dr["ANNETEL"].ToString();
                ltelbaba.Text = dr["BABATEL"].ToString();
                lcep.Text = dr["CEP"].ToString();
                tadres.Text = dr["ADRES"].ToString();
            }
            dr.Close();
            kapat();
        }
        public void ogrenciBilgiGetirKitapAl(int id, PictureEdit pic, LabelControl lisim, LabelControl lno, LabelControl lsinif, LabelControl lalan, LabelControl lcins, LabelControl lcep, RichTextBox tadres)
        {
            SqlCommand komut = new SqlCommand("SELECT ALAN.ALAN AS ALANISIM,SINIF.SINIF AS SINIFISIM,* FROM ALAN INNER JOIN SINIF ON ALAN.ID = SINIF.ALAN INNER JOIN OGRENCI ON SINIF.ID = OGRENCI.SINIF WHERE OGRENCI.ID=@P1", bgl.connection());
            komut.Parameters.AddWithValue("@P1", id);
            SqlDataReader dr = komut.ExecuteReader();
            byte[] myData = new byte[0];
            while (dr.Read())
            {
                if (dr["RESIM_G"].ToString() != "")
                {
                    myData = (byte[])dr["RESIM_G"];
                    MemoryStream stream = new MemoryStream(myData);
                    pic.Image = Image.FromStream(stream);
                }
                lisim.Text = dr["ISIM"].ToString();
                lno.Text = dr["OGRENCINO"].ToString();
                lsinif.Text = dr["SINIFISIM"].ToString();
                lalan.Text = dr["ALANISIM"].ToString();
                if (Convert.ToBoolean(dr["CINSIYET"]))
                {
                    lcins.Text = "Erkek";
                }
                else
                {
                    lcins.Text = "Kız";
                }
                lcep.Text = dr["CEP"].ToString();
                tadres.Text = dr["ADRES"].ToString();
            }
            dr.Close();
            kapat();
        }
        public void kitap_kategoriDoldur(LookUpEdit look)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT ID,ISIM FROM K_KATEGORI ORDER BY ISIM ASC", bgl.connection());
            da.Fill(dt);
            look.Properties.NullText = "Lütfen Kategori Seçiniz";
            look.Properties.ValueMember = "ID";
            look.Properties.DisplayMember = "ISIM";
            look.Properties.DataSource = dt;
        }
        public void kitap_yazarDoldur(LookUpEdit look)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT ID,ISIM FROM K_YAZAR ORDER BY ISIM ASC", bgl.connection());
            da.Fill(dt);
            look.Properties.NullText = "Lütfen Yazar Seçiniz";
            look.Properties.ValueMember = "ID";
            look.Properties.DisplayMember = "ISIM";
            look.Properties.DataSource = dt;
        }
        public void kitapListeleARA(ListView liste, LabelControl lbl, string metin)
        {
            liste.Items.Clear();
            SqlCommand komut = new SqlCommand("SELECT K_KITAP.ISIM AS KITAPISIM, K_YAZAR.ISIM AS YAZARISIM, K_KATEGORI.ISIM AS KATISIM, K_KITAP.ADET, K_KITAP.ID AS KITAPID FROM K_KITAP INNER JOIN K_YAZAR ON K_KITAP.YAZAR = K_YAZAR.ID INNER JOIN K_KATEGORI ON K_KITAP.KATEGORI = K_KATEGORI.ID WHERE K_KITAP.DURUM=0 AND K_KITAP.ISIM LIKE '%" + metin + "%' OR K_KITAP.YAYINEVI LIKE '%" + metin + "%' OR K_KITAP.BARKOD LIKE '%" + metin + "%' OR K_KATEGORI.ISIM LIKE '%" + metin + "%' OR K_YAZAR.ISIM LIKE '%" + metin + "%' ORDER BY K_KITAP.ISIM ASC", bgl.connection());
            SqlDataReader dr = komut.ExecuteReader();
            int sayac = 0;
            while (dr.Read())
            {
                liste.Items.Add(dr["KITAPISIM"].ToString());
                liste.Items[sayac].SubItems.Add(dr["YAZARISIM"].ToString());
                liste.Items[sayac].SubItems.Add(dr["KATISIM"].ToString());
                liste.Items[sayac].SubItems.Add(dr["ADET"].ToString());
                liste.Items[sayac].SubItems.Add(dr["KITAPID"].ToString());
                sayac++;
            }
            lbl.Text = liste.Items.Count.ToString() + " adet kayıt vardır.";
            dr.Close();
            kapat();
        }
        public void kitapGoster(LabelControl lid, TextEdit tisim, LookUpEdit lyazar, LookUpEdit lkate, NumericUpDown nsayfa, NumericUpDown nadet, TextEdit tbarkod, TextEdit tbagis, TextEdit tdemirbas, TextEdit taciklama, TextEdit tyayinevi, PictureBox pictur)
        {
            SqlCommand komut = new SqlCommand("SELECT K_KITAP.ID, K_KITAP.ISIM, K_KITAP.YAZAR, K_KITAP.KATEGORI, K_KITAP.YAYINEVI, K_KITAP.SAYFASAYISI, K_KITAP.ADET, K_KITAP.BAGISLAYAN,K_KITAP.DEMIRBAS, K_KITAP.RESIM, K_KITAP.DURUM, K_KITAP.ACIKLAMA,K_KITAP.BARKOD, K_KITAP.KAYITTARIHI, K_KATEGORI.ISIM AS KATEGORIISIM, K_YAZAR.ISIM AS YAZARISIM FROM K_KATEGORI INNER JOIN K_KITAP ON K_KATEGORI.ID = K_KITAP.KATEGORI INNER JOIN K_YAZAR ON K_KITAP.YAZAR =K_YAZAR.ID WHERE K_KITAP.ID=@P1", bgl.connection());
            komut.Parameters.AddWithValue("@P1", lid.Text);
            SqlDataReader dr = komut.ExecuteReader();
            byte[] myData = new byte[0];
            while (dr.Read())
            {
                tisim.Text = dr["ISIM"].ToString();
                lyazar.EditValue = lyazar.Properties.GetKeyValueByDisplayText(dr["YAZARISIM"].ToString());
                lkate.EditValue = lkate.Properties.GetKeyValueByDisplayText(dr["KATEGORIISIM"].ToString());
                nsayfa.Value = Convert.ToDecimal(dr["SAYFASAYISI"].ToString());
                nadet.Value = Convert.ToDecimal(dr["ADET"].ToString());
                tbarkod.Text = dr["BARKOD"].ToString();
                tbagis.Text = dr["BAGISLAYAN"].ToString();
                tdemirbas.Text = dr["DEMIRBAS"].ToString();
                taciklama.Text = dr["ACIKLAMA"].ToString();
                tyayinevi.Text = dr["YAYINEVI"].ToString();
                if (dr["RESIM"].ToString() != "")
                {
                    myData = (byte[])dr["RESIM"];
                    MemoryStream stream = new MemoryStream(myData);
                    pictur.Image = Image.FromStream(stream);
                }
            }
            dr.Close();
            kapat();
        }
        public void kitapGosterKitapAL(int id, TextEdit tisim, LookUpEdit lyazar, LookUpEdit lkate, NumericUpDown nsayfa, NumericUpDown nadet, TextEdit tyayinevi, PictureBox pictur)
        {
            SqlCommand komut = new SqlCommand("SELECT K_KITAP.ID, K_KITAP.ISIM, K_KITAP.YAZAR, K_KITAP.KATEGORI, K_KITAP.YAYINEVI, K_KITAP.SAYFASAYISI, K_KITAP.ADET, K_KITAP.BAGISLAYAN,K_KITAP.DEMIRBAS, K_KITAP.RESIM, K_KITAP.DURUM, K_KITAP.ACIKLAMA,K_KITAP.BARKOD, K_KITAP.KAYITTARIHI, K_KATEGORI.ISIM AS KATEGORIISIM, K_YAZAR.ISIM AS YAZARISIM FROM K_KATEGORI INNER JOIN K_KITAP ON K_KATEGORI.ID = K_KITAP.KATEGORI INNER JOIN K_YAZAR ON K_KITAP.YAZAR =K_YAZAR.ID WHERE K_KITAP.ID=@P1", bgl.connection());
            komut.Parameters.AddWithValue("@P1", id);
            SqlDataReader dr = komut.ExecuteReader();
            byte[] myData = new byte[0];
            while (dr.Read())
            {
                tisim.Text = dr["ISIM"].ToString();
                lyazar.EditValue = lyazar.Properties.GetKeyValueByDisplayText(dr["YAZARISIM"].ToString());
                lkate.EditValue = lkate.Properties.GetKeyValueByDisplayText(dr["KATEGORIISIM"].ToString());
                nsayfa.Value = Convert.ToDecimal(dr["SAYFASAYISI"].ToString());
                nadet.Value = Convert.ToDecimal(dr["ADET"].ToString());
                tyayinevi.Text = dr["YAYINEVI"].ToString();
                if (dr["RESIM"].ToString() != "")
                {
                    myData = (byte[])dr["RESIM"];
                    MemoryStream stream = new MemoryStream(myData);
                    pictur.Image = Image.FromStream(stream);
                }
            }
            dr.Close();
            kapat();
        }
        public void kitapKaydet(LabelControl lid, TextEdit tisim, LookUpEdit lyazar, LookUpEdit lkate, NumericUpDown nsayfa, NumericUpDown nadet, TextEdit tbarkod, TextEdit tbagis, TextEdit tdemirbas, TextEdit taciklama, TextEdit tyayinevi, PictureBox pictur)
        {
            if (lid.Text != "")
            {
                try
                {
                    SqlCommand komut = new SqlCommand("UPDATE K_KITAP SET ISIM=@p2,YAZAR=@p3,KATEGORI=@p4,YAYINEVI=@p5,SAYFASAYISI=@p6,ADET=@p7,ADETTESLIM=@p7,BAGISLAYAN=@p8,DEMIRBAS=@p9,RESIM=@p10,ACIKLAMA=@p11,BARKOD=@p12 WHERE ID=@p1", bgl.connection());
                    komut.Parameters.AddWithValue("@p1", lid.Text);
                    komut.Parameters.AddWithValue("@p2", tisim.Text);
                    komut.Parameters.AddWithValue("@p3", lyazar.EditValue);
                    komut.Parameters.AddWithValue("@p4", lkate.EditValue);
                    komut.Parameters.AddWithValue("@p5", tyayinevi.Text);
                    komut.Parameters.AddWithValue("@p6", nsayfa.Value);
                    komut.Parameters.AddWithValue("@p7", nadet.Value);
                    komut.Parameters.AddWithValue("@p8", tbagis.Text);
                    komut.Parameters.AddWithValue("@p9", tdemirbas.Text);
                    komut.Parameters.AddWithValue("@p10", pictureByteCevirme(pictur));
                    komut.Parameters.AddWithValue("@p11", taciklama.Text);
                    komut.Parameters.AddWithValue("@p12", tbarkod.Text);
                    komut.ExecuteNonQuery();
                    kapat();
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Verileri kontrol edip\nTekrar deneyiniz.\nHata: " + hata.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    SqlCommand komut = new SqlCommand("INSERT INTO K_KITAP(ISIM,YAZAR,KATEGORI,YAYINEVI,SAYFASAYISI,ADET,BAGISLAYAN,DEMIRBAS,RESIM,ACIKLAMA,BARKOD,ADETTESLIM) VALUES(@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p7)", bgl.connection());
                    komut.Parameters.AddWithValue("@p2", tisim.Text);
                    komut.Parameters.AddWithValue("@p3", lyazar.EditValue);
                    komut.Parameters.AddWithValue("@p4", lkate.EditValue);
                    komut.Parameters.AddWithValue("@p5", tyayinevi.Text);
                    komut.Parameters.AddWithValue("@p6", nsayfa.Value);
                    komut.Parameters.AddWithValue("@p7", nadet.Value);
                    komut.Parameters.AddWithValue("@p8", tbagis.Text);
                    komut.Parameters.AddWithValue("@p9", tdemirbas.Text);
                    komut.Parameters.AddWithValue("@p10", pictureByteCevirme(pictur));
                    komut.Parameters.AddWithValue("@p11", taciklama.Text);
                    komut.Parameters.AddWithValue("@p12", tbarkod.Text);
                    komut.ExecuteNonQuery();
                    kapat();
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Verileri kontrol edip\nTekrar deneyiniz.\nHata: " + hata.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void kitapSil(LabelControl lid, TextEdit tisim)
        {
            if (MessageBox.Show(tisim.Text + " isimli Kategoriyi\nSilmek istiyor musunuz ?", "KATEGORI SİLME", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    SqlCommand komut = new SqlCommand("DELETE FROM K_KATEGORI WHERE ID=@p1", bgl.connection());
                    komut.Parameters.AddWithValue("@p1", lid.Text);
                    komut.ExecuteNonQuery();
                    kapat();
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Verileri kontrol edip\nTekrar deneyiniz.\nHata: " + hata.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public int KitapBarkodKontrol(string barkod)
        {
            int id = 0;
            SqlCommand komut = new SqlCommand("SELECT ID FROM K_KITAP WHERE BARKOD=@p1", bgl.connection());
            komut.Parameters.AddWithValue("@p1", barkod);
            id = Convert.ToInt32(komut.ExecuteScalar());
            kapat();
            return id;
        }
        public void kitapGosterBarkod(int id, TextEdit tisim, LookUpEdit lyazar, LookUpEdit lkate, NumericUpDown nsayfa, NumericUpDown nadet, TextEdit tbarkod, TextEdit tbagis, TextEdit tdemirbas, TextEdit taciklama, TextEdit tyayinevi, PictureBox pictur)
        {
            SqlCommand komut = new SqlCommand("SELECT K_KITAP.ID, K_KITAP.ISIM, K_KITAP.YAZAR, K_KITAP.KATEGORI, K_KITAP.YAYINEVI, K_KITAP.SAYFASAYISI, K_KITAP.ADET, K_KITAP.BAGISLAYAN,K_KITAP.DEMIRBAS, K_KITAP.RESIM, K_KITAP.DURUM, K_KITAP.ACIKLAMA,K_KITAP.BARKOD, K_KITAP.KAYITTARIHI, K_KATEGORI.ISIM AS KATEGORIISIM, K_YAZAR.ISIM AS YAZARISIM FROM K_KATEGORI INNER JOIN K_KITAP ON K_KATEGORI.ID = K_KITAP.KATEGORI INNER JOIN K_YAZAR ON K_KITAP.YAZAR =K_YAZAR.ID WHERE K_KITAP.DURUM=0 AND K_KITAP.ID=@P1", bgl.connection());
            komut.Parameters.AddWithValue("@P1", id);
            SqlDataReader dr = komut.ExecuteReader();
            byte[] myData = new byte[0];
            while (dr.Read())
            {
                tisim.Text = dr["ISIM"].ToString();
                lyazar.EditValue = lyazar.Properties.GetKeyValueByDisplayText(dr["YAZARISIM"].ToString());
                lkate.EditValue = lkate.Properties.GetKeyValueByDisplayText(dr["KATEGORIISIM"].ToString());
                nsayfa.Value = Convert.ToInt32(dr["SAYFASAYISI"].ToString());
                nadet.Value = Convert.ToInt32(dr["ADET"].ToString());
                tbarkod.Text = dr["BARKOD"].ToString();
                tbagis.Text = dr["BAGISLAYAN"].ToString();
                tdemirbas.Text = dr["DEMIRBAS"].ToString();
                taciklama.Text = dr["ACIKLAMA"].ToString();
                tyayinevi.Text = dr["YAYINEVI"].ToString();
                if (dr["RESIM"].ToString() != "")
                {
                    myData = (byte[])dr["RESIM"];
                    MemoryStream stream = new MemoryStream(myData);
                    pictur.Image = Image.FromStream(stream);
                }
            }
            dr.Close();
            kapat();
        }
        public int kitapBarkodVarYokKontrol(string barkod)
        {
            int id = 0;
            SqlCommand komut = new SqlCommand("SELECT ID FROM K_KITAP WHERE BARKOD=@p1", bgl.connection());
            komut.Parameters.AddWithValue("@p1", barkod);
            id = Convert.ToInt32(komut.ExecuteScalar());
            kapat();
            return id;
        }
        public string kitapIDdenKitapIsimGetir(int id)
        {
            string name;
            SqlCommand komut = new SqlCommand("SELECT ISIM FROM K_KITAP WHERE ID=@p1", bgl.connection());
            komut.Parameters.AddWithValue("@p1", id);
            name = Convert.ToString(komut.ExecuteScalar());
            kapat();
            return name;
        }
        public int ogrenciKartAraIDgetir(string kartno)
        {
            int id = 0;
            SqlCommand komut = new SqlCommand("SELECT ID FROM OGRENCI WHERE KARTNO=@p1 AND DURUM=0", bgl.connection());
            komut.Parameters.AddWithValue("@p1", kartno);
            id = Convert.ToInt32(komut.ExecuteScalar());
            kapat();
            return id;
        }
        public bool ogrenciKitapTeslimKontrol(int id)
        {
            bool durum = false;
            SqlCommand komut = new SqlCommand("SELECT ID FROM K_KITAP_HAREKET WHERE OGRENCI=@p1 AND TESLIM=1", bgl.connection());
            komut.Parameters.AddWithValue("@p1", id);
            durum = Convert.ToBoolean(komut.ExecuteScalar());
            kapat();
            return durum;
        }
        public string ogrenciIDdenIsimGetir(int id)
        {
            string name;
            SqlCommand komut = new SqlCommand("SELECT CAST(OGRENCINO AS VARCHAR)+' nolu '+ISIM FROM OGRENCI WHERE ID=@p1", bgl.connection());
            komut.Parameters.AddWithValue("@p1", id);
            name = Convert.ToString(komut.ExecuteScalar());
            kapat();
            return name;
        }
        public void kitapAdet1arttirma(int id)
        {
            SqlCommand komut = new SqlCommand("UPDATE K_KITAP SET ADET=ADET+1, ADETTESLIM=ADETTESLIM+1 WHERE ID=@p1", bgl.connection());
            komut.Parameters.AddWithValue("@p1", id);
            komut.ExecuteNonQuery();
            kapat();
        }
        public int kitapBarkodAraIDgetir(string barkod)
        {
            int id = 0;
            SqlCommand komut = new SqlCommand("SELECT ID FROM K_KITAP WHERE BARKOD=@p1 AND DURUM=0", bgl.connection());
            komut.Parameters.AddWithValue("@p1", barkod);
            id = Convert.ToInt32(komut.ExecuteScalar());
            kapat();
            return id;
        }
        public bool kitapAdetKontrol(int id)
        {
            bool durum = false;
            SqlCommand komut = new SqlCommand("SELECT ID FROM K_KITAP WHERE ADETTESLIM>0 AND ID=@p1", bgl.connection());
            komut.Parameters.AddWithValue("@p1", id);
            durum = Convert.ToBoolean(komut.ExecuteScalar());
            kapat();
            return durum;
        }
        public bool kitapAlTamamla(int ogid, int kid, int gun)
        {
            bool durum = false;
            SqlCommand komut = new SqlCommand("INSERT K_KITAP_HAREKET (OGRENCI,KITAP,GUN,TESLIMTARIHI) values (@P1,@P2,@P3,DATEADD(DAY,@P3,getdate())) ", bgl.connection());
            SqlCommand komut1 = new SqlCommand("UPDATE K_KITAP SET ADETTESLIM=ADETTESLIM-1 WHERE ID=@P8", bgl.connection());
            komut.Parameters.AddWithValue("@P1", ogid);
            komut.Parameters.AddWithValue("@P2", kid);
            komut.Parameters.AddWithValue("@P3", gun);
            komut1.Parameters.AddWithValue("@P8", kid);
            durum = Convert.ToBoolean(komut.ExecuteNonQuery());
            komut1.ExecuteNonQuery();
            kapat();
            return durum;
        }
        public int haftaninGunu(int dayplus)
        {
            int gun;
            gun = Convert.ToInt32(DateTime.Now.AddDays(dayplus).DayOfWeek);
            if (DateTime.Now.AddDays(dayplus).DayOfWeek == DayOfWeek.Saturday)
            {
                gun = 6;
            }
            if (DateTime.Now.AddDays(dayplus).DayOfWeek == DayOfWeek.Sunday)
            {
                gun = 7;
            }
            return gun;
        }
        public int ogrenciAktifKitapKontrol(int ogid)
        {
            int id = 0;
            SqlCommand komut = new SqlCommand("SELECT ID FROM K_KITAP_HAREKET WHERE OGRENCI=@P1 AND TESLIM=1", bgl.connection());
            komut.Parameters.AddWithValue("@P1", ogid);
            id = Convert.ToInt32(komut.ExecuteScalar());
            kapat();
            return id;
        }
        public int kitapHarekettenKitapIDgetir(int khid)
        {
            int id = 0;
            SqlCommand komut = new SqlCommand("SELECT KITAP FROM K_KITAP_HAREKET WHERE ID=@P1", bgl.connection());
            komut.Parameters.AddWithValue("@P1", khid);
            id = Convert.ToInt32(komut.ExecuteScalar());
            kapat();
            return id;
        }
        public void kitapHareketTatihGetir(int khid, LabelControl ltarih, LabelControl lgun, LabelControl lteslim)
        {
            SqlCommand komut = new SqlCommand("SELECT * FROM K_KITAP_HAREKET WHERE ID=@P1", bgl.connection());
            komut.Parameters.AddWithValue("@P1", khid);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                ltarih.Text = dr["KAYITTARIHI"].ToString();
                lgun.Text = dr["GUN"].ToString();
                lteslim.Text = dr["TESLIMTARIHI"].ToString();
            }
            dr.Close();
            kapat();
        }
        public string ogrenciEmanetKitapIsimGetir(int ogid)
        {
            string name;
            SqlCommand komut = new SqlCommand("SELECT UPPER(K_KITAP.ISIM) FROM K_KITAP INNER JOIN K_KITAP_HAREKET ON K_KITAP.ID=K_KITAP_HAREKET.KITAP WHERE TESLIM=1 AND K_KITAP_HAREKET.OGRENCI=@P1", bgl.connection());
            komut.Parameters.AddWithValue("@P1", ogid);
            name = Convert.ToString(komut.ExecuteScalar());
            kapat();
            return name;
        }
        public void kitapTeslimTamamlama(int kid,int khid)
        {
            SqlCommand komut = new SqlCommand("UPDATE K_KITAP_HAREKET SET TESLIM=0,GUNK=DATEDIFF(DAY,KAYITTARIHI,GETDATE()),IADETARIHI=GETDATE() WHERE ID=@P1", bgl.connection());
            SqlCommand komut1 = new SqlCommand("UPDATE K_KITAP SET ADETTESLIM=ADETTESLIM+1 WHERE ID=@P1", bgl.connection());
            komut.Parameters.AddWithValue("@P1", khid);
            komut1.Parameters.AddWithValue("@P1", kid);
            komut.ExecuteNonQuery();
            komut1.ExecuteNonQuery();
            kapat();
        }

    }
}




