using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NTKlibrary
{
    class cConnection
    {
        public SqlConnection connection()
        {
            //bir tane CONNEC aktif olması gerekir

            //SqlConnection connec = new SqlConnection(@"Data Source=192.168.0.13,1433;Network Library=DBMSSOCN;Initial Catalog=NTKOKULKART;User ID=sa;Password=123;");
            //Murat Hoca

            //SqlConnection connec = new SqlConnection(@"Data Source=192.168.16.73,1433;Network Library=DBMSSOCN;Initial Catalog=NTKOKULKART;User ID=sa;Password=123;");
            //Labarotuvar denemeler yaparken

            SqlConnection connec = new SqlConnection(@"Data Source=(local);Initial Catalog=NTKOKULKART;Integrated Security=True");
            //Evde PCnizde denemeler yaparken
            try
            {
                connec.Open();
            }
            catch (Exception)
            {
                //if (MessageBox.Show("Sunucu Hatası Mevcuttur.\nDüzeltip tekrardan deneyiniz\nHata: " + hata.Message.ToString(),"SİSTEM HATASI",MessageBoxButtons.OK,MessageBoxIcon.Error)==DialogResult.OK)
                //{
                //    Application.Exit();
                //    Environment.Exit(0);
                //}
            }
            return connec;
        }
    }
}
