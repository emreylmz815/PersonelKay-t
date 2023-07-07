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

namespace PersonelKayıt
{
    public partial class FrmGrafik : Form
    {
        public FrmGrafik()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=PC-0540\\MS_SQL_SERVER;Initial Catalog=PersonelVeriTabani;Integrated Security=True");

        
        private void FrmGrafik_load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutg1 = new SqlCommand("Select PerMeslek,Avg(Permaas) from Personel ", baglanti);
            SqlDataReader dr1 = komutg1.ExecuteReader();
            while (dr1.Read())
            {
                chart2.Series["Sehirler"].Points.AddXY(dr1[0], dr1[1]);
            }

            baglanti.Close();
        }
    }
}
