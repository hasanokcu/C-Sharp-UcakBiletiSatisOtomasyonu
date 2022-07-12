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
    public partial class Giriş : Form 
    {
        public Giriş() // açık ulaşılabilir giriş sınıfı
        {
            InitializeComponent(); // kontrollerin özellikleri değiştirilir
        }
        static public int ID; // ıd static başka yerlerden ulaşılabilsin diye

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) // label2
        {
            Kullanıcı_Kayıt kullanıcıkayıt = new Kullanıcı_Kayıt(); // label2 tıklanınca kullanıcıkayıt sayfasına at
            kullanıcıkayıt.ShowDialog(); // kullanıcı kayıt sayfasını göster
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) // label1
        {
            Şifremi_Unuttum şifre = new Şifremi_Unuttum(); // label 1 tıklanınca şifremi unuttum sayfasına at
            şifre.ShowDialog(); // şifremi unuttum sayfasını göster
        }
        Kullanıcı_Formu k=new Kullanıcı_Formu(); // kullanıcı formu classına k ismini verdim
        Yönetici_Formu y = new Yönetici_Formu(); // yönetici formu classına y ismini verdim
        internal static object id;

        private void button1_Click(object sender, EventArgs e) // button1
        {
            k.kullanıcı(txtKullanıcıAdı,txtŞifre); // kullanıcı adı ve şifreyi textbox lara çağırıyorum
            if (string.IsNullOrEmpty(txtKullanıcıAdı.Text.Trim())) // string boş ise
            {
                errorProvider1.SetError(txtKullanıcıAdı, "Kullanıcı Adı Boş Geçilemez"); // validasyon için error provider
                return; // döndür
            }
            else // değilse
            {
                errorProvider1.SetError(txtKullanıcıAdı, string.Empty); // validasyon için error provider
            }
            if (string.IsNullOrEmpty(txtŞifre.Text.Trim())) // string boş ise
            {
                errorProvider2.SetError(txtŞifre, "Şifre Boş Geçilemez"); // validasyon için error provider
                return; // döndür
            }
            else // değilse
            {
                errorProvider2.SetError(txtŞifre, string.Empty); // validasyon için error provider
            }
            y.yonetici(txtKullanıcıAdı, txtŞifre); // yönetici adı kullanıcı adı ve şifresini textbox lara çağırıyorum

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtKullanıcıAdı_TextChanged(object sender, EventArgs e)
        {

        }

        private void Giriş_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            }

        private void txtŞifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }

        
    }

