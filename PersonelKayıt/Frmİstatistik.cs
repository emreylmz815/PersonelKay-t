﻿using System;
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
    public partial class Frmİstatistik : Form
    {
        public Frmİstatistik()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=PC-0540\\MS_SQL_SERVER;Initial Catalog=PersonelVeriTabani;Integrated Security=True");

        private void Frmİstatistik_Load(object sender, EventArgs e)
        {
            // Toplam Personel Sayısını hesaplamak için kullanılan formul
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select count(*) from Personel", baglanti);
            SqlDataReader dr1=komut1.ExecuteReader();
            while(dr1.Read())
            {
                LblToplamPersonel.Text = dr1[0].ToString();
                Console.WriteLine(LblToplamPersonel);
            }
            baglanti.Close();

            // evli personel sayısını hesaplamak için kullanılan formul

            baglanti.Open();

            SqlCommand komut2 = new SqlCommand("select count(*) from Personel where Perdurum=1",baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                LblEvliPersonel.Text = dr2[0].ToString();
            }
            baglanti.Close();

            //Bekar personel sayısını hesaplamak için kullanılan formul

            baglanti.Open();

            SqlCommand komut3 = new SqlCommand("select count(*) from Personel where Perdurum=0", baglanti);
            SqlDataReader dr3= komut3.ExecuteReader();

            while (dr3.Read())
            {
                LblBekarPersonel.Text = dr3[0].ToString();
            }
            baglanti.Close();

            //Toplam maaş formulu
            baglanti.Open();

            SqlCommand komut4 = new SqlCommand("select sum(PerMaas) from Personel", baglanti); 

            SqlDataReader dr4=komut4.ExecuteReader();
            while (dr4.Read())
            {
                LblToplamMaas.Text = dr4[0].ToString();
            }
            baglanti.Close();

            //Ortalama maaş formulü
            baglanti.Open ();

            SqlCommand komut5 = new SqlCommand("select avg(PerMaas) from Personel", baglanti);
            SqlDataReader dr5=komut5.ExecuteReader();
            while (dr5.Read())
            {
                LblOrtalamaMaas.Text = dr5[0].ToString();   

            }


            baglanti.Close ();
            // Şehir sayısı
            baglanti.Open() ;
            SqlCommand komut6 = new SqlCommand("select count(distinct(PerSehir)) from Personel", baglanti);
            SqlDataReader dr6=komut6.ExecuteReader();
            while (dr6.Read())
            {
                LblSehirSayısı.Text = dr6[0].ToString();  
            }

            baglanti.Close() ; 
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void LblToplamPersonel_Click(object sender, EventArgs e)
        {

        }
    }
}
