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
    public partial class mail : Form
    {
        public mail() // açık ulaşılabilir mail sınıfı
        {
            InitializeComponent(); // kontrollerin özellikleri değiştirilir
        }
        SqlConnection baglanti = new SqlConnection("Data Source=NIRVANA;Initial Catalog=UcakBiletiSatisDB;Integrated Security=True"); // sql bağlantısı
        private void mail_Load(object sender, EventArgs e) // mail
        {
            SqlDataAdapter da = new SqlDataAdapter("select ID,ileti,cevap from mesajlar where kullanıcıid="+Convert.ToInt32(Giriş.id)+"", baglanti); // mesajlar tablosundan ID sine göre ilet ve cevabı al ve kaydet
            DataSet ds = new DataSet(); // veriyi al
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0]; // GridView e bilgiyi yazıdr
        }
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            richTextBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString(); // soruyu richTextBox1 e yazıdr
            richTextBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString(); // cevabı richTextBox2 ye yazıdr
        }
    
    }
}
