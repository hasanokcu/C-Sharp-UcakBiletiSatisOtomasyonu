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
    public partial class mesajlar : Form
    {
        public mesajlar() // açık ulaşılabilir mesajlar sınıfı
        {
            InitializeComponent(); // kontrollerin özellikleri değiştirilir
        }
        SqlConnection baglanti = new SqlConnection("Data Source=NIRVANA;Initial Catalog=UcakBiletiSatisDB;Integrated Security=True"); // sql bağlantısı
        private void mesajlar_Load(object sender, EventArgs e) // mesajlar
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from mesajlar ", baglanti); // mesajlar tablosundan ID sine göre soruyu al
            DataSet ds = new DataSet(); // veriyi al
            da.Fill(ds);
            dataGridViewMesaj.DataSource = ds.Tables[0];
        }
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e) // gridView
        {
            textBox1.Text = dataGridViewMesaj.CurrentRow.Cells[0].Value.ToString(); // mesajın ID sini yazdır
            richTextBox2.Text= dataGridViewMesaj.CurrentRow.Cells[8].Value.ToString(); // sorulan soruyu yazdır
        }
        private void button1_Click(object sender, EventArgs e) // cevapla butonu
        {
            baglanti.Open(); // bağlantı aç
            SqlCommand komut = new SqlCommand("update mesajlar set cevap='"+richTextBox1.Text+ "' where ID="+Convert.ToInt32(textBox1.Text)+"", baglanti); // ID sine göre verilen cevabı güncelle ve yazdır
            komut.ExecuteNonQuery(); // onay ver
            MessageBox.Show("mesaj gonderıldı"); // cevapla butonuna basılınca mesaj gönderildi bilgisini geç
            baglanti.Close(); // bağlantı kapat
        }
    }
}
