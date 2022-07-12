using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UcakBiletiSatisOtomasyonu
{
    class Veritabani
    {
        SqlConnection baglanti = new SqlConnection("Data Source=NIRVANA;Initial Catalog=UcakBiletiSatisDB; Integrated Security = True"); // sql bağlantısı
    }
}

