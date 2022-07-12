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
    public partial class YöneticiPaneli : Form
    {
        public YöneticiPaneli() // açık ulaşılabilir yönetici paneli
        {
            InitializeComponent(); // kontrollerin özellikleri değiştirilir
        }

        private void YöneticiPaneli_Load(object sender, EventArgs e)
        {

        }

        private void btnGelenMesajlar_Click(object sender, EventArgs e)
        {
            mesajlar msj = new mesajlar(); // mesajlar butonuna tıklanınca mesajlar sayfasına atar
            msj.Show(); // mesajlar sayfasını gösterir
            this.Hide(); // sakla
        }

    }
}
