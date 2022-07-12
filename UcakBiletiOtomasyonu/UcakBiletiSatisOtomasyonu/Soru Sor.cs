using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UcakBiletiSatisOtomasyonu
{
    public partial class Soru_Sor : Form
    {  
        public Soru_Sor() // açık ulaşılabilir Soru Sor sınıfı
        {
            InitializeComponent(); // kontrollerin özellikleri değiştirilir
        }
        static public string eposta; // public e posta tanımı
        SqlConnection baglanti = new SqlConnection("Data Source=NIRVANA;Initial Catalog=UcakBiletiSatisDB;Integrated Security=True"); // sql bağlantısı
        private void button1_Click(object sender, EventArgs e) // button1
        {
            baglanti.Open(); // bağlantı aç
            SqlCommand komut = new SqlCommand("insert into mesajlar(ad,kullanıcıid,soyad,telefon,eposta,adres,konu,ileti) values('" + textBox_ad.Text + "',"+Convert.ToInt32(Giriş.id)+",'" + textBox_soyad.Text + "','" + textBox_tel.Text + "','" + textBox_eposta.Text + "','" + richTextBox_adres.Text + "','" + richTextBox_konu.Text + "','" + richTextBox_ileti.Text + "')", baglanti); // ad, kullanıcıid, soyad, telefon, e posta, adres, konu ve ileti bilgilerini database e yazdır. Giriş Id i int tipine çevir
            komut.ExecuteNonQuery(); // işlemi onayla
            baglanti.Close(); // bağlantı kapat
            eposta = textBox_eposta.Text; // e posta bilgisini al
            MessageBox.Show("MESAJINIZ ALINDI"); // gönder butonuna tıklandı ise mesajı yazdır
        }

        private void Soru_Sor_Load(object sender, EventArgs e)
        {

        }
        
    }
}
