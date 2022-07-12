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
    public partial class BiletAl : Form
    {
        SqlConnection baglanti; // sql bağlantısı
        SqlCommand komut; // sorguları veri tabanından almak için
        SqlDataAdapter da; // veri almak ve verileri kaydetmek için
        string cinsiyetdb; // cinsiyet tanımlaması
        String koltukNo2; // koltukNo2 tanımlaması
        public BiletAl()
        {
            InitializeComponent(); // kontrollerin özellikleri değiştirilir
        }
        void MusteriGetir() // müşteri çağır fonksiyonu
        {
            baglanti = new SqlConnection("Data Source=NIRVANA;Initial Catalog=UcakBiletiSatisDB; Integrated Security = True"); // sql bağlantısı
            baglanti.Open(); // bağlantı aç
            da = new SqlDataAdapter("SELECT * FROM satılan_bilet", baglanti); // satılan_bilet tablosundan veri al ve kaydet
            DataTable tablo = new DataTable(); // bellek içi verilerden oluşan tablo
            da.Fill(tablo); // veriler eşleşir
            dataGridView1.DataSource = tablo; // GridView e çek
            baglanti.Close(); // bağlantı kapat

        }

        private void txtNereden_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtNereye_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtHavayolu_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click_1(object sender, EventArgs e) // btnKaydet
        {
            this.DialogResult = DialogResult.OK;

            string sorgu = "INSERT INTO satılan_bilet(BiletId,ad,soyad,telefon_no,cinsiyet,tcno,nereden,nereye,koltuk_no,tarih,fiyat,havayolu) VALUES" +
                " (@BiletId,@ad,@soyad,@telefon_no,@cinsiyet,@tcno,@nereden,@nereye,@koltuk_no,@tarih,@fiyat,@havayolu)"; // sorguyu yazıyorum
            komut = new SqlCommand(sorgu, baglanti); // sorgu tanımlanır
            komut.Parameters.AddWithValue("@BiletId", txtBiletId.Text); // txtBiletId
            komut.Parameters.AddWithValue("@ad", txtAd.Text); // txtAd a db verisi çek
            komut.Parameters.AddWithValue("@soyad", txtSoyad.Text); // txtSoyad a db verisi çek
            komut.Parameters.AddWithValue("@telefon_no", txtTelefon.Text); // txtTelefon a db verisi çek
            komut.Parameters.AddWithValue("@cinsiyet", cinsiyetdb); // cinsiyetdb ye db verisi çek
            komut.Parameters.AddWithValue("@tcno", txtTCNO.Text); // txtTCNO ya db verisi çek
            komut.Parameters.AddWithValue("@nereden", cmbNereden.Text); // cmbNereden e db verisi çek
            komut.Parameters.AddWithValue("@nereye", cmbNereye.Text); // cmbNereye ye db verisi çek
            komut.Parameters.AddWithValue("@koltuk_no", koltukNo2); // koltukNo2 ye db verisi çek
            komut.Parameters.AddWithValue("@tarih", dtpTarih.Value); // dtpTarih e db verisi çek
            komut.Parameters.AddWithValue("@fiyat", txtFiyat.Text); // txtFiyat a db verisi çek
            komut.Parameters.AddWithValue("@havayolu", cmbHavayolu.Text); // cmbHavayolu na db verisi çek
            baglanti.Open(); // bağlantı aç
            komut.ExecuteNonQuery(); // işlemi onaylıyorum
            baglanti.Close(); // bağlantı kapat
            MusteriGetir();

        }

        private void BiletAl_Load(object sender, EventArgs e) // bilet al
        {
            MusteriGetir(); // fonksiyonu çağır
        }

        private void btnSil_Click(object sender, EventArgs e) // btnSil
        {
            baglanti.Open(); // bağlantı aç
            komut = new SqlCommand("Delete from satılan_bilet where BiletId = '" + txtBiletId.Text + "'", baglanti);
            komut.ExecuteNonQuery(); // işlemi onaylıyorum
            baglanti.Close(); // bağlantı kapat
            MusteriGetir(); // fonksiyonu çağır
        }

        private void btnGuncelle_Click(object sender, EventArgs e) // btnGuncelle güncelleme işlemi yapılır
        {
            baglanti.Open(); // bağlantı aç
            komut = new SqlCommand("UPDATE satılan_bilet SET ad = '" + txtAd.Text + "' , soyad = '" + txtSoyad.Text + "', telefon_no = '" + txtTelefon.Text + "' , cinsiyet = '" + groupBox3.Text + "' , nereden = '" + cmbNereden.Text + "' , nereye = '" + cmbNereye.Text + "' , havayolu = '" + cmbHavayolu.Text + "' where BiletId = '" + txtBiletId.Text + "'", baglanti); // ad, soyad, telefon no, cinsiyet, nereden, nereye ve havayolu bilgilerini BiletId ye göre güncelle
            komut.ExecuteNonQuery(); // işlemi onaylıyorum
            baglanti.Close(); // bağlantı kapat
            MusteriGetir(); // fonksiyonu çağır
        }

        private void cmbHavayolu_SelectedIndexChanged(object sender, EventArgs e) // cmbHavayolu
        {
            switch (cmbHavayolu.Text)
            {
                case "THY":KoltukDoldur(12,true); // THY koltuğu 12 sıralı 
                        break; // kır
                case "Pegasus":KoltukDoldur(12,true); // Pegasus koltuğu 12 sıralı
                    break; // kır
                case "AnadoluJet":KoltukDoldur(12,true); // AnadoluJet koltuğu 12 sıralı
                    break; // kır
                default:
                    break; // kır
            }
            void KoltukDoldur(int sira,bool arkaBesliMi) // koltuk doldur sıra int tipi false ve truler da bool değişkeni 
            {
            yavaslat: // yavaslat değiskenini tanımladım arka koltukları düzeltmek için
                foreach (Control ctrl in this.Controls) // kontrolü çağırıyorum
                {
                    if (ctrl is Button) // ctrl button ise
                    {
                        Button btn = ctrl as Button;

                        if (btn.Text == "Kaydet") // Kaydet e tıklanırsa
                        {
                            continue; // devam et
                        }
                        else // tıklanmaz ise
                        {
                            this.Controls.Remove(ctrl); // sil
                            goto yavaslat; // yavaslat değişkenine git
                        }
                    }
                }

                int koltukNo = 1; // 1 den başla
                for(int i = 0; i < sira; i++) // sıralar tanımlanır
                {
                    for(int j= 0; j < 5; j++) // j ler koltukların sağa doğru ilerlemesi ilerlemesini gösterir
                    {
                        if (arkaBesliMi==true) // arka beşli ise
                        {
                            if(i!=sira-1 &&j==2) // j 2 olduğunda veya -1 sira olduğunda orta kısmı sil zaten sira -1 olmayacağı için direk devam edecek
                            {
                                continue; // devam et
                            }
                            else // değilse 
                            {
                                if (j==2) // j 2 ise
                                {
                                    continue; // devam et
                                }
                            }
                        }
                        Button koltuk=new Button(); // koltuk butonuna oluşturulur
                        koltuk.Height=koltuk.Width=40; // koltuk yüksekliği ve genişliği 40 olacaktır
                        koltuk.Top=30 + (i*45); // koltuğun üstten uzaklığı 30 pikselden sonra başlat
                        koltuk.Left = 5 + (j * 45); // koltuğun soldan uzaklığı 5 pikselden sonra başlat
                        koltuk.Text=koltukNo.ToString(); // koltukNo yu yazdır
                        koltukNo++; // birer birer arttır
                        koltuk.ContextMenuStrip = contextMenuStrip1; // rezerve işlemi için contextmenustrip kullanıyorum
                        koltuk.MouseDown += koltuk_MouseDown;
                        this.Controls.Add(koltuk); // kontrolleri ekle
                    }
                }
            }
        }
        Button tiklanan;
        void koltuk_MouseDown(object sender, MouseEventArgs e)
        {
            tiklanan = sender as Button;
            koltukNo2 = tiklanan.Text;
        }

        private void rezerveEtToolStripMenuItem_Click(object sender, EventArgs e) // rezerve et
        {
            if (cmbHavayolu.SelectedIndex == -1 || cmbNereden.SelectedIndex == -1 || cmbNereye.SelectedIndex == -1 || txtAd.Text==""|| txtSoyad.Text==""||txtTelefon.Text=="") // değerler -1 ve boş olmayacakları için
            {
                MessageBox.Show("Lütfen Gerekli Alanları Doldurunuz!"); // mesajı yazdır
                return; // döndür
            }

            if (rdbErkek.Checked)
            {
                cinsiyetdb = "Erkek"; // cinsiyet erkek ise
                tiklanan.BackColor = Color.Aqua; // aqua boya
            }
            if (rdbKadın.Checked)
            {
                cinsiyetdb = "Kadın"; // cinsiyet kadın ise
                tiklanan.BackColor = Color.Pink; // pembe boya
            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void btnCıkıs_Click(object sender, EventArgs e) // btnCıkıs
        {
            this.Hide(); // sakla
            AnaSayfa asf = new AnaSayfa(); // çıkış butonuna basılınca AnaSayfa ya at
            asf.ShowDialog(); // AnaSayfa yı göster
        }

        private void btnTemizle_Click(object sender, EventArgs e) // btnTemizle
        {
            txtBiletId.Text = ""; // BiletId alanını temizle
            txtAd.Text = ""; // Ad alanını temizle
            txtSoyad.Text = ""; // Soyad alanını temizle
            txtTelefon.Text = ""; // Telefon alanını temizle
            cmbNereden.Text = ""; // Nereden alanını temizle
            cmbNereye.Text = ""; // Nereye alanını temizle
            dtpTarih.Text = ""; // Tarih alanını temizle
            txtFiyat.Text = ""; // Fiyat alanını temizle
            txtTCNO.Text = ""; // TCNO alanını temizle
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtTCNO_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
