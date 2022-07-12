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
namespace UcakBiletiSatisOtomasyonu
{
    public partial class BiletListele : Form
    {
        public BiletListele() // açık ulaşılabilir listele sınıfı
        {
            InitializeComponent(); // kontrollerin özellikleri değiştirilir
        }
        SqlConnection baglanti = new SqlConnection("Data Source=NIRVANA;Initial Catalog=UcakBiletiSatisDB;Integrated Security=True"); // sql bağlantısı
        SqlCommand komut; // sorguları veri tabanı üzerinden almak için
        SqlDataAdapter da; // verileri almak ve kaydetmek için 
        private void BiletListele_Load(object sender, EventArgs e) // bilet listele
        {
            MusteriGetir(); // müşteri çağır
        }
        void MusteriGetir() // fonksiyonu çağır
        {
            baglanti = new SqlConnection("Data Source=NIRVANA;Initial Catalog=UcakBiletiSatisDB; Integrated Security = True"); // sql bağlantısı
            baglanti.Open(); // bağlantı aç
            da = new SqlDataAdapter("SELECT * FROM satılan_bilet", baglanti); // satılan bilet tablosundan veri al ve kaydet
            DataTable tablo = new DataTable(); // bellek içi verilerden oluşan tablo
            da.Fill(tablo); // veriler eşleşir
            biletTablo.DataSource = tablo;
            baglanti.Close(); // bağlantı kapat

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtTC_TextChanged(object sender, EventArgs e) // txtTC
        {
            baglanti.Open(); // bağlantı aç
            da = new SqlDataAdapter("SELECT * FROM satılan_bilet where ad like '%"+txtAdTc.Text+"%' or tcno like '%"+txtAdTc.Text+"%'", baglanti); // satılan bilet tablosunda ki Ad ve Tc bilgisine göre verileri çek. Ad ve Tc içinde ki karakterler bulunuyorsa direk veriyi çek
            DataTable tablo2 = new DataTable();
            da.Fill(tablo2);
            biletTablo.DataSource = tablo2; // dataGridView e tabloyu çek
            baglanti.Close(); // bağlantı kapat
        }
    }
}
