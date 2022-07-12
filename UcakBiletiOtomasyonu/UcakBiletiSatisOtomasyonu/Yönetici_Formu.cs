using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UcakBiletiSatisOtomasyonu
{
    internal class Yönetici_Formu
    {
        SqlConnection baglanti = new SqlConnection("Data Source=NIRVANA;Initial Catalog=UcakBiletiSatisDB;Integrated Security=True"); // sql bağlantısı
        SqlCommand komut; // sorguları veri tabanı üzerinden almak için
        SqlDataReader read; // veriyi okumak için
        YöneticiPaneli yönetici = new YöneticiPaneli();

        public SqlDataReader yonetici(TextBox kullanıcıadı, TextBox şifre) // yönetici metodu 
        {
            baglanti.Open(); // bağlantı aç 
            komut = new SqlCommand(); // sorguları veritabanı üzerinden al
            komut.Connection = baglanti; // bağlantı al
            komut.CommandText = "select * from tbl_yonetici where kullanıcıadı='"+kullanıcıadı.Text+"'"; // sorgu yönetici tablosundan kullanıcı adı alıyor
            read = komut.ExecuteReader(); // veriyi oku
            if (read.Read()==true) // kullanıcı adı doğruysa
            {
                if (şifre.Text==read["sifre"].ToString()) // şifre.text veritabanındaki kayıtla uyuşuyorsa
                {
                    MessageBox.Show("Giriş Başarılı"); // mesaj bas
                    yönetici.ShowDialog(); // yönetici sayfasına at
                }
                else // değilse
                {
                    MessageBox.Show("Şifrenizi Kontrol Ediniz"); // mesaj bas
                }
            }
            baglanti.Close(); // bağlantı kapat
            return read; // döndür
        }
    }
}
