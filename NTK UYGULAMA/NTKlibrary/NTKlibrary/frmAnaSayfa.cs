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
    public partial class frmAnaSayfa : Form
    {
        public frmAnaSayfa()
        {
            InitializeComponent();
        }
        void yukle()
        {
            lblKitapSayısıM.Text = "Kitap\nSayısı";
            lblOgrenciSayisiM.Text = "Ögrenci\nSayısı";
            lblOgrencideKitapSayisiM.Text = "Ögrencide bulunan\nKitap Sayısı";
            lblTeslimiGecikenKitapSayisiM.Text = "Teslimi Geciken\nKitap Sayısı";
            lblenAz1kitapAlanOgrenciSayisiM.Text = "En Az 1 Adet Kitap\nAlan Ögrenci Sayısı";
            lblKitapAlmayanOgrenciSayisiM.Text = "Hiç Kitap Almayan\nÖgrenci Sayısı";
            ana.kitapSayisi(lblKitapSayısı);
            ana.ogrenciSayisi(lblOgrenciSayisi);
            ana.ogrencideBulunanKitapSayisi(lblOgrencideKitapSayisi);
            ana.teslimiGecikenKitapSayisi(lblTeslimiGecikenKitapSayisi);
            ana.enAz1kitapAlanOgrenciSayisi(lblenAz1kitapAlanOgrenciSayisi);
            lblKitapAlmayanOgrenciSayisi.Text = (Convert.ToInt32(lblOgrenciSayisi.Text) - Convert.ToInt32(lblenAz1kitapAlanOgrenciSayisi.Text)).ToString();
            lblISTlbl.Text = "AlışVeriş Yapılan\nKitap Sayısı";
            ana.istatistikGUNkitapsayisi(lblISTgun);
            ana.istatistikAYkitapsayisi(lblISTay);
            ana.istatistikYILkitapsayisi(lblISTyıl);
        }
        cAnaliz ana=new cAnaliz();
        private void frmAnaSayfa_Load(object sender, EventArgs e)
        {
            yukle();
            kitaplarGrafik();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            yukle();
        }
        cConnection bgl = new cConnection();
        void kapat()
        {
            bgl.connection().Dispose();
            bgl.connection().Close();
        }
        public void kitaplarGrafik()
        {
            SqlCommand komut = new SqlCommand("SELECT TOP 6 K_KATEGORI.ISIM,SUM(ADET) AS ADET  FROM K_KITAP INNER JOIN K_KATEGORI ON K_KITAP.KATEGORI=K_KATEGORI.ID GROUP BY K_KATEGORI.ISIM ORDER BY SUM(ADET) DESC", bgl.connection());
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                chartControl1.Series["Series 1"].Points.(dr[0], dr[1]);
                //chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(dr[0]), Convert.ToInt32(dr[1].ToString()));
            }
            kapat();
        }
    }
}
