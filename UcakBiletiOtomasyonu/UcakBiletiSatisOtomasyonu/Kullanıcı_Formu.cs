using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UcakBiletiSatisOtomasyonu
{
    internal class Kullanıcı_Formu
    {
        SqlConnection baglanti = new SqlConnection("Data Source=NIRVANA;Initial Catalog=UcakBiletiSatisDB;Integrated Security=True"); // sql bağlantısı
        SqlCommand komut; // sorguları veri tabanı üzerinden almak için
        SqlDataReader read; // veriyi okumak için
        AnaSayfa anaSayfa = new AnaSayfa();
        public SqlDataReader kullanıcı(TextBox kullanıcıadı,TextBox şifre) // kullanıcı metodu ile çağırılacak kullanıcı adı ve şifre doğru ise giriş yapılacak burdan textboxlara gelecek kullanıcı adı ve şifreyi tanımladık
        {
            baglanti.Open(); // bağlantı aç
            komut = new SqlCommand(); // sorguları veritabanı üzerinden al
            komut.Connection = baglanti; // bağlantı al
            komut.CommandText = "select * from tbl_kullanici where kullanıcıadı='"+kullanıcıadı.Text+"'"; // sorguyu yazdım kullanıcı tablosundan kullanıcıadını alıyor
            read = komut.ExecuteReader(); // veriyi oku
            if (read.Read()==true) // kullanıcı adı doğruysa
            {
                if (şifre.Text==read["sifre"].ToString()) // şifre.text veritabanındaki kayıtla uyuşuyorsa
                {
                    MessageBox.Show("Giriş Başarılı"); // mesajı bas
                    anaSayfa.ShowDialog(); // ana sayfaya at
                }
                else // değilse
                {
                    MessageBox.Show("Şifrenizi Kontrol Ediniz"); // mesajı bas
                }
            }
            
            baglanti.Close(); // bağlantıyı kapat
            return read; // döndür
        }
        public void yenikullanıcı(TextBox adsoyad,TextBox kullanıcıadı,TextBox şifre,TextBox şifretekrar,TextBox soru,TextBox cevap,GroupBox grup) // yeni kullanıcı kaydetmek için yeni kullanıcı metodu tanımlıyoruz
        {
            if (şifre.Text==şifretekrar.Text) // şifre ve şifretekrar uyuşuyorsa
            {
                baglanti.Open(); // bağlantı aç
                komut = new SqlCommand(); // sql bağlantısı
                komut.Connection=baglanti; // bağlantıyı baglanti ye eşitle
                komut.CommandText="insert into tbl_kullanici values('"+adsoyad.Text+"','"+kullanıcıadı.Text+"','"+şifre.Text+"','"+soru.Text+"','"+cevap.Text+"')"; // sorguyu command text ile yazdım
                komut.ExecuteNonQuery(); // işlemi onaylıyorum
                baglanti.Close(); // bağlantıyı kapat
                MessageBox.Show("Yeni Kayıt Oluşturuldu"); // şifre şifretekrar ile uyuşuyorsa yeni kullanıcı ekle
                foreach (Control item in grup.Controls) if (item is TextBox) item.Text = ""; // işlemden sonra textbox ları siler
            }
            else // şifre ve şifretekrar uyuşmuyorsa
            {
                MessageBox.Show("Şifreler Uyuşmuyor"); // mesaj bas
            }
        }
        public void şifre(TextBox adsoyad,TextBox kullanıcıadı,TextBox şifre,TextBox şifretekrar,TextBox soru,TextBox cevap,GroupBox grup) // şifreyi yenilemek güncelleme işlemleri yapmak için yeni bir metod oluşturdum
        {
            if (şifre.Text==şifretekrar.Text) // şifre ve şifretekrar aynı ise 
            {
                baglanti.Open(); // bağlantı aç
                komut = new SqlCommand("select * from tbl_kullanici where kullanıcıadı='"+kullanıcıadı.Text+"'", baglanti); // sorguyu yazıyorum
                read = komut.ExecuteReader(); // veriyi oku
                if (read.Read()==true) // kullanıcı adı doğruysa
                {
                    if (soru.Text==read["soru"].ToString() && cevap.Text==read["cevap"].ToString()) // soru ve cevap veri tabanı ile uyuşuyorsa
                    {
                        baglanti.Close(); // bağlantı kapa
                        baglanti.Open(); // bağlantı aç
                        komut = new SqlCommand("update tbl_kullanici set adsoyad='"+adsoyad.Text+"',sifre='"+şifre.Text+"' where kullanıcıadı='"+kullanıcıadı.Text+"'",baglanti); // sorguyu yazıyorum adsoyad ve şifre kullanıcı adına göre update sorgusu ile değişecek
                        komut.ExecuteNonQuery(); // işlemi onayla
                        baglanti.Close(); // bağlantı kapa
                        MessageBox.Show("İşlem başarılı"); // mesaj bas
                        foreach (Control item in grup.Controls) if (item is TextBox) item.Text = ""; // temizle
                    }
                    else // değilse
                    {
                        MessageBox.Show("Kullanıcı adı hariç diğer bilgilerinizi kontrol ediniz"); // mesaj bas
                    }
                }
                else // kullanıcı adı yanlış ise
                {
                    MessageBox.Show("Bilgilerinizi kontrol ediniz"); // mesaj bas

                }
                baglanti.Close(); // bağlantı kapa
            }
            else // değilse
            {
                MessageBox.Show("Şifreler uyuşmuyor"); // şifreler uyuşmuyor mesajını yazdır
            }
        }
    }
}
