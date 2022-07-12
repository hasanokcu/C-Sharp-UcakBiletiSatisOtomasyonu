using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UcakBiletiSatisOtomasyonu
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa() // açık ulaşılabilir AnaSayfa sınıfı
        {
            InitializeComponent(); // kontrollerin özellikleri değiştirilir
        }

        private void buttonBiletAl_Click(object sender, EventArgs e) // buttonBiletAl
        {
            BiletAl biletAl = new BiletAl(); // biletal formuna git
            biletAl.ShowDialog(); // biletal formunu göster
        }

        private void buttonBiletlerim_Click(object sender, EventArgs e) // buttonBiletlerim
        {
            BiletListele biletlerim = new BiletListele(); // bilet listele formuna git
            biletlerim.ShowDialog(); // bilet listele formunu göster
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {

        }

        private void btnSoruSor_Click(object sender, EventArgs e) // btnSoruSor
        {
            Soru_Sor sorusor = new Soru_Sor(); // SoruSor butonuna tıklanınca
            sorusor.ShowDialog(); // Soru Sor sayfasına at
        }

        private void btnMail_Click(object sender, EventArgs e) // btnMail
        {
            mail mail = new mail(); // mail butonuna tıklanınca
            mail.ShowDialog(); // mail sayfasına at
        }

        private void buttonSoruSor_Click(object sender, EventArgs e) // buttonSoruSor
        {
            Soru_Sor sorusor = new Soru_Sor(); // SoruSor butonuna tıklanınca
            sorusor.ShowDialog(); // Soru Sor sayfasına at
        }

        private void buttonMail_Click(object sender, EventArgs e) // buttonMail
        {
            mail mail = new mail(); // mail butonuna tıklanınca
            mail.ShowDialog(); // mail sayfasına at
        }
    }
}
