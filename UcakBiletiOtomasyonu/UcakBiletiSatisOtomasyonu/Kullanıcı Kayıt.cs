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
    public partial class Kullanıcı_Kayıt : Form
    {
        public Kullanıcı_Kayıt() // açık ulaşılabilir kullanıcı kayıt sınıfı
        {
            InitializeComponent(); // kontrollerin özellikleri değiştirilir
        }
        Kullanıcı_Formu k = new Kullanıcı_Formu(); // kullanıcı formu classına k ismini verdim
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        

        private void btnEkle_Click(object sender, EventArgs e) // btnEkle 
        {
            k.yenikullanıcı(AdSoyadtxt,KullanıcıAdıtxt,Şifretxt,ŞifreTekrartxt,Sorutxt,Cevaptxt,groupBox2); // yeni kullanıcı metodum ile bilgileri textboxlara çağırıyorum
            if (string.IsNullOrEmpty(AdSoyadtxt.Text.Trim())) // string boş ise
            {
                errorProvider1.SetError(AdSoyadtxt, "Bu alan boş geçilemez"); // validasyon için errorProvider kullanıyorum
                return; // döndür
            }
            else // değilse
            {
                errorProvider1.SetError(AdSoyadtxt, string.Empty); // validasyon için errorProvider kullanıyorum
            }
            if (string.IsNullOrEmpty(KullanıcıAdıtxt.Text.Trim())) // string boş ise
            {
                errorProvider2.SetError(KullanıcıAdıtxt, "Bu alan boş geçilemez"); // validasyon için errorProvider kullanıyorum
                return; // döndür
            }
            else // değilse
            {
                errorProvider2.SetError(KullanıcıAdıtxt, string.Empty); // validasyon için errorProvider kullanıyorum
            }
            if (string.IsNullOrEmpty(Şifretxt.Text.Trim())) // string boş ise
            {
                errorProvider3.SetError(Şifretxt, "Bu alan boş geçilemez"); // validasyon için errorProvider kullanıyorum
                return; // döndür
            }
            else // değilse 
            {
                errorProvider3.SetError(Şifretxt, string.Empty); // validasyon için errorProvider kullanıyorum
            }
            if (string.IsNullOrEmpty(ŞifreTekrartxt.Text.Trim())) // string boş ise
            {
                errorProvider4.SetError(ŞifreTekrartxt, "Bu alan boş geçilemez"); // validasyon için errorProvider kullanıyorum
                return; // döndür
            }
            else // değilse 
            {
                errorProvider4.SetError(ŞifreTekrartxt, string.Empty); // validasyon için errorProvider kullanıyorum
            }
            if (string.IsNullOrEmpty(Sorutxt.Text.Trim())) // string boş ise
            {
                errorProvider5.SetError(Sorutxt, "Bu alan boş geçilemez"); // validasyon için errorProvider kullanıyorum
                return; // döndür
            }
            else // değilse
            {
                errorProvider5.SetError(Sorutxt, string.Empty); // validasyon için errorProvider kullanıyorum
            }
            if (string.IsNullOrEmpty(Cevaptxt.Text.Trim())) // string boş ise
            {
                errorProvider6.SetError(Cevaptxt, "Bu alan boş geçilemez"); // validasyon için errorProvider kullanıyorum
                return; // döndür
            }
            else // değilse
            {
                errorProvider6.SetError(Cevaptxt, string.Empty); // validasyon için errorProvider kullanıyorum
            }
        }

        private void Kullanıcı_Kayıt_Load(object sender, EventArgs e)
        {

        }

        private void AdSoyadtxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
