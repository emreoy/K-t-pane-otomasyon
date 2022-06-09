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
    class cAnaliz
    {
        cConnection bgl = new cConnection();
        void kapat()
        {
            bgl.connection().Dispose();
            bgl.connection().Close();
        }
        public void kitapSayisi(LabelControl lbl)
        {
            SqlCommand komut = new SqlCommand("SELECT SUM(ADET) FROM K_KITAP", bgl.connection());
            lbl.Text = komut.ExecuteScalar().ToString();
            kapat();
        }
        public void ogrenciSayisi(LabelControl lbl)
        {
            SqlCommand komut = new SqlCommand("SELECT COUNT(ID) FROM OGRENCI WHERE DURUM=0", bgl.connection());
            lbl.Text = komut.ExecuteScalar().ToString();
            kapat();
        }
        public void ogrencideBulunanKitapSayisi(LabelControl lbl)
        {
            SqlCommand komut = new SqlCommand("SELECT COUNT(ID) FROM K_KITAP_HAREKET WHERE TESLIM=1", bgl.connection());
            lbl.Text = komut.ExecuteScalar().ToString();
            kapat();
        }
        public void teslimiGecikenKitapSayisi(LabelControl lbl)
        {
            SqlCommand komut = new SqlCommand("SELECT COUNT(ID) FROM K_KITAP_HAREKET WHERE TESLIM=1 AND TESLIMTARIHI < GETDATE()", bgl.connection());
            lbl.Text = komut.ExecuteScalar().ToString();
            kapat();
        }
        public void enAz1kitapAlanOgrenciSayisi(LabelControl lbl)
        {
            SqlCommand komut = new SqlCommand("SELECT COUNT(DISTINCT K_KITAP_HAREKET.OGRENCI) FROM K_KITAP_HAREKET INNER JOIN OGRENCI ON OGRENCI.ID=K_KITAP_HAREKET.OGRENCI WHERE OGRENCI.DURUM=0", bgl.connection());
            lbl.Text = komut.ExecuteScalar().ToString();
            kapat();
        }
        public void istatistikGUNkitapsayisi(LabelControl lbl)
        {
            SqlCommand komut = new SqlCommand("SELECT COUNT(*) AS GUNLUK FROM K_KITAP_HAREKET  WHERE DATEADD(DAY,-1,GETDATE())<KAYITTARIHI", bgl.connection());
            lbl.Text = komut.ExecuteScalar().ToString();
            kapat();
        }
        public void istatistikAYkitapsayisi(LabelControl lbl)
        {
            SqlCommand komut = new SqlCommand("SELECT COUNT(*) AS GUNLUK FROM K_KITAP_HAREKET  WHERE DATEADD(MONTH,-1,GETDATE())<KAYITTARIHI", bgl.connection());
            lbl.Text = komut.ExecuteScalar().ToString();
            kapat();
        }
        public void istatistikYILkitapsayisi(LabelControl lbl)
        {
            SqlCommand komut = new SqlCommand("SELECT COUNT(*) AS GUNLUK FROM K_KITAP_HAREKET  WHERE DATEADD(YEAR,-1,GETDATE())<KAYITTARIHI", bgl.connection());
            lbl.Text = komut.ExecuteScalar().ToString();
            kapat();
        }
        public void kategoriKitaSayisiListeleme(ListView liste)
        {
            liste.Items.Clear();
            SqlCommand komut = new SqlCommand("SELECT K_KATEGORI.ISIM,SUM(ADET) AS ADET  FROM K_KITAP INNER JOIN K_KATEGORI ON K_KITAP.KATEGORI=K_KATEGORI.ID GROUP BY K_KATEGORI.ISIM ORDER BY SUM(ADET) DESC", bgl.connection());
            SqlDataReader dr = komut.ExecuteReader();
            int sayac = liste.Items.Count;
            while(dr.Read())
            {
                liste.Items.Add(dr["ISIM"].ToString());
                liste.Items[sayac].SubItems.Add(dr["ADET"].ToString());
                sayac++;
            }
            dr.Close();
            kapat();
        }
        public void kaydiDusenKitaplar(ListView liste,Label lbl)
        {
            liste.Items.Clear();
            SqlCommand komut = new SqlCommand("SELECT K_KITAP.ID, K_KITAP.KATEGORI, K_KITAP.YAZAR, K_KITAP.ISIM, K_KATEGORI.ISIM AS KATEGORIISIM, K_YAZAR.ISIM AS YAZARISIM, K_KITAP.YAYINEVI, K_KITAP.SAYFASAYISI, K_KITAP.ADET FROM K_KATEGORI INNER JOIN K_KITAP ON K_KATEGORI.ID = K_KITAP.KATEGORI INNER JOIN K_YAZAR ON K_KITAP.YAZAR = K_YAZAR.ID WHERE DURUM=1", bgl.connection());
            SqlDataReader dr = komut.ExecuteReader();
            int sayac = liste.Items.Count;
            while (dr.Read())
            {
                liste.Items.Add(dr["ID"].ToString());
                liste.Items[sayac].SubItems.Add(dr["KATEGORI"].ToString());
                liste.Items[sayac].SubItems.Add(dr["YAZAR"].ToString());
                liste.Items[sayac].SubItems.Add(dr["ISIM"].ToString());
                liste.Items[sayac].SubItems.Add(dr["KATEGORIISIM"].ToString());
                liste.Items[sayac].SubItems.Add(dr["YAZARISIM"].ToString());
                liste.Items[sayac].SubItems.Add(dr["ADET"].ToString());
                liste.Items[sayac].SubItems.Add(dr["YAYINEVI"].ToString());
                liste.Items[sayac].SubItems.Add(dr["SAYFASAYISI"].ToString());
                sayac++;
            }
            lbl.Text = liste.Items.Count.ToString() + " adet Kaydı düşen Kitap bulunmaktadır.";
            dr.Close();
            kapat();
        }
        public void KitapKategoriliGoster(ListView liste, Label lbl,string kategori)
        {
            liste.Items.Clear();
            SqlCommand komut = new SqlCommand("SELECT K_KITAP.ID, K_KITAP.KATEGORI, K_KITAP.YAZAR, K_KITAP.ISIM, K_KATEGORI.ISIM AS KATEGORIISIM, K_YAZAR.ISIM AS YAZARISIM, K_KITAP.YAYINEVI, K_KITAP.SAYFASAYISI, K_KITAP.ADET FROM K_KATEGORI INNER JOIN K_KITAP ON K_KATEGORI.ID = K_KITAP.KATEGORI INNER JOIN K_YAZAR ON K_KITAP.YAZAR = K_YAZAR.ID WHERE K_KITAP.DURUM=0 AND K_KATEGORI.ISIM=@P1 ORDER BY K_KITAP.ISIM ASC", bgl.connection());
            komut.Parameters.AddWithValue("@P1", kategori);
            SqlDataReader dr = komut.ExecuteReader();
            int sayac = liste.Items.Count;
            while (dr.Read())
            {
                liste.Items.Add(dr["ID"].ToString());
                liste.Items[sayac].SubItems.Add(dr["KATEGORI"].ToString());
                liste.Items[sayac].SubItems.Add(dr["YAZAR"].ToString());
                liste.Items[sayac].SubItems.Add(dr["ISIM"].ToString());
                liste.Items[sayac].SubItems.Add(dr["KATEGORIISIM"].ToString());
                liste.Items[sayac].SubItems.Add(dr["YAZARISIM"].ToString());
                liste.Items[sayac].SubItems.Add(dr["ADET"].ToString());
                liste.Items[sayac].SubItems.Add(dr["YAYINEVI"].ToString());
                liste.Items[sayac].SubItems.Add(dr["SAYFASAYISI"].ToString());
                sayac++;
            }
            lbl.Text = liste.Items.Count.ToString() + " adet Kitap bulunmaktadır.";
            dr.Close();
            kapat();
        }
        public void gecikenListesi(ListView liste, Label lbl)
        {
            liste.Items.Clear();
            SqlCommand komut = new SqlCommand("EXEC GECIKENLER", bgl.connection());
            SqlDataReader dr = komut.ExecuteReader();
            int sayac = liste.Items.Count;
            while (dr.Read())
            {
                liste.Items.Add(dr["ID"].ToString());
                liste.Items[sayac].SubItems.Add(dr["KITAP"].ToString());
                liste.Items[sayac].SubItems.Add(dr["OGRENCI"].ToString());
                liste.Items[sayac].SubItems.Add(dr["ISIM"].ToString());
                liste.Items[sayac].SubItems.Add(dr["OGRENCIBILGI"].ToString());
                liste.Items[sayac].SubItems.Add(dr["GECIKENGUN"].ToString()+" gün");
                liste.Items[sayac].SubItems.Add(Convert.ToDateTime(dr["TESLIMTARIHI"].ToString()).ToLongDateString());
                liste.Items[sayac].SubItems.Add(dr["GUN"].ToString() + " gün");
                liste.Items[sayac].SubItems.Add(Convert.ToDateTime(dr["KAYITTARIHI"].ToString()).ToLongDateString());
                sayac++;
            }
            lbl.Text = liste.Items.Count.ToString() + " adet Geciken bulunmaktadır.";
            dr.Close();
            kapat();
        }
        public void ogrencideBulunanKitap(ListView liste, Label lbl)
        {
            liste.Items.Clear();
            SqlCommand komut = new SqlCommand("EXECUTE OGRENCIDEBULUNAN", bgl.connection());
            SqlDataReader dr = komut.ExecuteReader();
            int sayac = liste.Items.Count;
            while (dr.Read())
            {
                liste.Items.Add(dr["ID"].ToString());
                liste.Items[sayac].SubItems.Add(dr["KITAP"].ToString());
                liste.Items[sayac].SubItems.Add(dr["OGRENCI"].ToString());
                liste.Items[sayac].SubItems.Add(dr["ISIM"].ToString());
                liste.Items[sayac].SubItems.Add(dr["OGRENCIBILGI"].ToString());
                liste.Items[sayac].SubItems.Add(Convert.ToDateTime(dr["TESLIMTARIHI"].ToString()).ToLongDateString());
                liste.Items[sayac].SubItems.Add(dr["GUN"].ToString() + " gün");
                liste.Items[sayac].SubItems.Add(Convert.ToDateTime(dr["KAYITTARIHI"].ToString()).ToLongDateString());
                sayac++;
            }
            lbl.Text = liste.Items.Count.ToString() + " adet Kitap Öğrencide bulunmaktadır.";
            dr.Close();
            kapat();
        }
    }
}
