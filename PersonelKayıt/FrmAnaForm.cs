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
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti= new SqlConnection("Data Source=PC-0540\\MS_SQL_SERVER;Initial Catalog=PersonelVeriTabani;Integrated Security=True");
        

        void temizle()
        {
            TxtID.Text = "";
            TxtAd.Text = "";
            TxtSoyad.Text = "";
            TxtMeslek.Text = "";
            MskMaas.Text = "";
            CmbSehir.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'personelVeriTabaniDataSet.Personel' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
          //  this.personelTableAdapter.Fill(this.personelVeriTabaniDataSet.Personel);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            this.personelTableAdapter.Fill(this.personelVeriTabaniDataSet.Personel);
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Personel (PerAd,PerSoyad,PerSehir,PerMaas,PerMeslek,PerDurum) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2",TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", CmbSehir.Text);
            komut.Parameters.AddWithValue("@p4", MskMaas.Text);
            komut.Parameters.AddWithValue("@p5", TxtMeslek.Text);
            komut.Parameters.AddWithValue("@p6", label8.Text);
            komut.ExecuteNonQuery();
            
            
            baglanti.Close();
            MessageBox.Show("Personel başarıyla eklendi!");
        }

       

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                label8.Text = "True";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                label8.Text = "False";
            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            CmbSehir.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            MskMaas.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            label8.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            TxtMeslek.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();

        }

        private void label8_TextChanged(object sender, EventArgs e)
        {
            if (label8.Text == "True")
            {
                radioButton1.Checked = true;

            }else if(label8.Text== "False")
            {
                radioButton2.Checked = true;
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutsil=new SqlCommand("Delete from Personel Where PerId=@k1",baglanti);
            komutsil.Parameters.Add("@k1",TxtID.Text);
            komutsil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("kayıt Silindi");
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutguncelle = new SqlCommand("Update Personel Set PerAd=@a1,PerSoyad=@a2,PerSehir=@a3,PerMaas=@a4, PerDurum=@a5,PerMeslek=@a6 where PerId=@a7", baglanti);
            komutguncelle.Parameters.AddWithValue("@a1", TxtAd.Text);
            komutguncelle.Parameters.AddWithValue("@a2",TxtSoyad.Text);
            komutguncelle.Parameters.AddWithValue("@a3",CmbSehir.Text);
            komutguncelle.Parameters.AddWithValue("@a4",MskMaas.Text);
            komutguncelle.Parameters.AddWithValue("@a5",label8.Text);
            komutguncelle.Parameters.AddWithValue("@a6", TxtMeslek.Text);
            komutguncelle.Parameters.AddWithValue("@a7", TxtID.Text);
            komutguncelle.ExecuteNonQuery();

            baglanti.Close();
            MessageBox.Show("Güncellendi!");
        }

        private void BtnIstatistik_Click(object sender, EventArgs e)
        {
            Frmİstatistik fr =new Frmİstatistik();
            fr.Show();
        }

        private void BtnGrafik_Click(object sender, EventArgs e)
        {
            FrmGrafik frg=new FrmGrafik();
            frg.Show();
        }
    }
}
